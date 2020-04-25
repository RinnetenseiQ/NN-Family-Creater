using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    class DenseStructure
    {
        Random random;
        public int denseLayersNumb;
        public List<DenseLayer> denseLayer;
        public bool sameActivations;

        public DenseStructure(DenseRandomParams drp)
        {
            random = new Random();


            sameActivations = random.Next(100) < 10 ? true : false;
            int abserber = 0;
            if (sameActivations)
            {
                abserber = random.Next(drp.denseActIndexesRange);
            }

            denseLayersNumb = random.Next(1, drp.denseLayersNumbRange);
            denseLayer = new List<DenseLayer>(denseLayersNumb);
            for (int i = 0; i < denseLayer.Capacity; i++)
            {
                int neurons;
                if (i == 0) neurons = random.Next(drp.firstDenseNeuronsRange / 3, drp.firstDenseNeuronsRange);
                else neurons = random.Next(denseLayer[i - 1].neurons / 3, denseLayer[i - 1].neurons);
                denseLayer.Add(new DenseLayer(drp, neurons));

                if (sameActivations)
                {
                    denseLayer[denseLayer.Count - 1].activationIndex = abserber;
                }
            }
        }

        public DenseStructure(List<int> denseActivationIndexes, List<int> neurons, List<int> denseDropoutIndexes, List<int> dropoutRates)
        {
            denseLayer = new List<DenseLayer>();
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
                denseLayer.Add(new DenseLayer(denseActivationIndexes[i], neurons[i], dropoutExist, dropoutRate));
            }
        } // конструктор для инициализации объекта DenseStructure по полям объекта ConvolutionalNetwork
  
        public void MutateLayersNumb(DenseRandomParams drp, int mutateRate)
        {
            //if (random.Next(100) < mutateRate) denseLayersNumb = random.Next(1, denseLayerNumbRange);
            if (random.Next(100) < mutateRate) denseLayersNumb = random.Next(1, drp.denseLayersNumbRange);
            if(denseLayersNumb >= denseLayer.Count)
            {
                denseLayer.Capacity = denseLayersNumb;
                while(denseLayer.Count != denseLayer.Capacity)
                {
                    int neurons = random.Next(denseLayer[denseLayer.Count - 1].neurons / 3, denseLayer[denseLayer.Count - 1].neurons);
                    //denseLayer.Add(new DenseLayer(activationsIndexesRange, neurons, dropoutRateRange));
                    denseLayer.Add(new DenseLayer(drp, neurons));

                    if(sameActivations) denseLayer[denseLayer.Count - 1].activationIndex = denseLayer[0].activationIndex;
                }
            }
            else
            {
                denseLayer.RemoveRange(denseLayersNumb, denseLayer.Capacity - denseLayersNumb);
                denseLayer.Capacity = denseLayersNumb;
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
                        int abserberIndex = random.Next(denseLayer.Count);
                        for(int i = 0; i < denseLayer.Count; i++)
                        {
                            denseLayer[i].activationIndex = denseLayer[abserberIndex].activationIndex;
                        }
                    }
                }
                else
                {
                    for(int i = 0; i < denseLayer.Count; i++)
                    {
                        denseLayer[i].MutateActivation(drp, mutateRate);
                    }
                }
            }
        }
        
        public void MutateNeurons(DenseRandomParams drp, int mutateRate) // проверить
        {
            if(random.Next(100) < mutateRate)
            {
                if(random.Next(100) < 10)
                {
                    for(int i = 0; i < denseLayer.Count; i++)
                    {
                        if (i == 0) denseLayer[0].neurons = random.Next(drp.firstDenseNeuronsRange / 3, drp.firstDenseNeuronsRange);
                        else denseLayer[i].neurons = random.Next(denseLayer[i - 1].neurons / 3, denseLayer[i - 1].neurons);
                    }
                }
                //else
            }
        }
        
        public void MutateDropouts(DenseRandomParams drp, int mutateRate)
        {
            if (random.Next(100) < mutateRate)
            {
                if (random.Next(100) < 10)
                {
                    if(denseLayer[0].dropoutExist) for(int i = 0; i < denseLayer.Count; i++) denseLayer[i].dropoutExist = false;
                    else for(int i = 0; i < denseLayer.Count; i++)
                        {
                            denseLayer[i].dropoutExist = true;
                            denseLayer[i].dropoutRate = random.Next(10, drp.denseDropRange);
                        }
                }
                else for (int i = 0; i < denseLayer.Count; i++) denseLayer[i].MutateDropout(drp, mutateRate);
            }
        }
    }
}
