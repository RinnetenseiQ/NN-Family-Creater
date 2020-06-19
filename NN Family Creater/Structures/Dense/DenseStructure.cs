using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    public class DenseStructure
    {
        public readonly NetworkRandomParams nrp;
        public readonly DenseRandomParams drp;
        public Random random;
        public int denseLayersNumb;
        public List<DenseLayer> denseLayers;
        public bool sameActivations;

        public DenseStructure(NetworkRandomParams nrp, DenseRandomParams drp, Random random)
        {
            this.nrp = nrp;
            this.drp = drp;
            this.random = random;
            
            sameActivations = random.Next(100) < 10 ? true : false;
            int absorber = 0;
            if (sameActivations)
            {
                absorber = random.Next(drp.denseActIndexesRange);
            }

            denseLayersNumb = random.Next(1, drp.denseLayersNumbRange);
            denseLayers = new List<DenseLayer>(denseLayersNumb);

            int powIndex = 0;
            for (int i = 0; i < denseLayers.Capacity; i++)
            {
                int neurons = 0;

                if (i == 0) powIndex = random.Next(Support.GetPow2(nrp.networkOutputNumb), drp.firstDenseNeuronsRange);
                else powIndex += random.Next(0, 2);
                neurons = (int)Math.Pow(2, powIndex);
                denseLayers.Insert(0, new DenseLayer(drp, random, neurons));
  
                if (sameActivations)
                {
                    denseLayers[0].activationIndex = absorber;
                }
            }
        }

        public DenseStructure(List<int> denseActivationIndexes, List<int> neurons, List<int> denseDropoutIndexes, List<int> dropoutRates)
        {
            denseLayers = new List<DenseLayer>();
            denseLayersNumb = denseActivationIndexes.Count;
            for(int i = 0, counter = 0; i < denseLayersNumb; i++)
            {
                bool dropoutExist = false;
                int dropoutRate = 0;
                if(i == denseDropoutIndexes[counter])
                {
                    dropoutExist = true;
                    dropoutRate = dropoutRates[counter];
                    counter++;
                }
                else
                {
                    dropoutExist = false;
                    dropoutRate = 0;
                }
                denseLayers.Add(new DenseLayer(denseActivationIndexes[i], neurons[i], dropoutExist, dropoutRate));
            }
        } // конструктор для инициализации объекта DenseStructure по полям объекта ConvolutionalNetwork
  
        public void MutateLayersNumb(DenseRandomParams drp, int mutateRate)
        {
            if (random.Next(100) < mutateRate) denseLayersNumb = random.Next(1, drp.denseLayersNumbRange);
            if(denseLayersNumb >= denseLayers.Count)
            {
                denseLayers.Capacity = denseLayersNumb;
                int powIndex = Support.GetPow2(denseLayers[denseLayers.Count - 1].neurons);
                while (denseLayers.Count != denseLayers.Capacity)
                {
                    powIndex += random.Next(0, 2);
                    int neurons = (int)Math.Pow(2, powIndex);
                    denseLayers.Insert(0, new DenseLayer(drp, random, neurons));
                    if(sameActivations) denseLayers[0].activationIndex = denseLayers[1].activationIndex;
                }
            }
            else
            {
                denseLayers.RemoveRange(0, denseLayers.Capacity - denseLayersNumb); // перепроверить!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                denseLayers.Capacity = denseLayersNumb;
            }
        }
        
        public void MutateActivation(DenseRandomParams drp, int mutateRate)
        {
            if(random.Next(100) < mutateRate)
            {
                if(random.Next(100) < 10)
                {
                    sameActivations = !sameActivations;
                    if (sameActivations)
                    {
                        int absorberIndex = random.Next(denseLayers.Count);
                        foreach (var t in denseLayers) t.activationIndex = denseLayers[absorberIndex].activationIndex;
                    }
                }
                else foreach (var t in denseLayers) t.MutateActivation(drp, mutateRate);
            }
        }
        
        public void MutateNeurons(DenseRandomParams drp, int mutateRate) // проверить
        {
            if(random.Next(100) < mutateRate)
            {
                int mutateIndex = random.Next(0, denseLayers.Count);
                int powIndex = 0;
                while(mutateIndex != -1)
                {
                    if (mutateIndex != (denseLayers.Count - 1)) powIndex = Support.GetPow2(denseLayers[mutateIndex + 1].neurons);
                    else powIndex = drp.firstDenseNeuronsRange;
                    powIndex += random.Next(0, 2);
                    denseLayers[mutateIndex].neurons = (int)Math.Pow(2, powIndex);
                    mutateIndex--;
                }
            }
        }
        
        public void MutateDropouts(DenseRandomParams drp, int mutateRate)
        {
            if (random.Next(100) < mutateRate)
            {
                if (random.Next(100) < 10)
                {
                    if (denseLayers[0].dropoutExist) foreach (var t in denseLayers)
                    {
                        t.dropoutExist = false;
                        t.dropoutRate = 0;
                    }
                    else foreach (var t in denseLayers)
                    {
                        t.dropoutExist = true;
                        t.dropoutRate = random.Next(10, drp.denseDropRange);
                    }
                }
                else foreach (var t in denseLayers) t.MutateDropout(drp, mutateRate);
            }
        }
    }
}
