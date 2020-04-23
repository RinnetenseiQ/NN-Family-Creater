using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    class DenseStructure
    {
        int firstLayerNeuronsNumbRange;
        Random random;

        public int denseLayersNumb;
        public List<DenseLayer> denseLayer;
        

        public bool sameActivations;

        public DenseStructure(int denseLayersNumbRange, int activationsIndexesRange, 
                              int firstLayerNeuronsNumbRange, int dropoutRateRange)
        {
            random = new Random();
            

            sameActivations = random.Next(100) < 10 ? true : false;
            int abserber = 0;
            if (sameActivations)
            {
                abserber = random.Next(activationsIndexesRange);
            } 
            this.firstLayerNeuronsNumbRange = firstLayerNeuronsNumbRange;

            denseLayersNumb = random.Next(1, denseLayersNumbRange);
            denseLayer = new List<DenseLayer>(denseLayersNumb);
            for(int i = 0; i < denseLayer.Capacity; i++)
            {
                int neurons;
                if (i == 0) neurons = random.Next(firstLayerNeuronsNumbRange / 3, firstLayerNeuronsNumbRange);
                else neurons = random.Next(denseLayer[i-1].neurons/3, denseLayer[i-1].neurons);
                denseLayer.Add(new DenseLayer(activationsIndexesRange, neurons, dropoutRateRange));

                if (sameActivations)
                {
                    denseLayer[denseLayer.Count - 1].activationIndex = abserber;
                }
            }

        }

        public void MutateLayersNumb(int denseLayerNumbRange, int mutateRate, int activationsIndexesRange, int dropoutRateRange)
        {
            if (random.Next(100) < mutateRate) denseLayersNumb = random.Next(1, denseLayerNumbRange);
            if(denseLayersNumb >= denseLayer.Count)
            {
                denseLayer.Capacity = denseLayersNumb;
                while(denseLayer.Count != denseLayer.Capacity)
                {
                    int neurons = random.Next(denseLayer[denseLayer.Count - 1].neurons / 3, denseLayer[denseLayer.Count - 1].neurons);
                    denseLayer.Add(new DenseLayer(activationsIndexesRange, neurons, dropoutRateRange));

                    if(sameActivations) denseLayer[denseLayer.Count - 1].activationIndex = denseLayer[0].activationIndex;
                }
            }
            else
            {
                denseLayer.RemoveRange(denseLayersNumb, denseLayer.Capacity - denseLayersNumb);
                denseLayer.Capacity = denseLayersNumb;
            }
        }

        public void MutateActivation(int mutateRate, int activationsIndexesRange)
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
                        denseLayer[i].MutateActivation(activationsIndexesRange, mutateRate);
                    }
                }
            }
        }

        public void MutateNeurons(int mutateRate) // проверить
        {
            if(random.Next(100) < mutateRate)
            {
                if(random.Next(100) < 10)
                {
                    for(int i = 0; i < denseLayer.Count; i++)
                    {
                        if (i == 0) denseLayer[0].neurons = random.Next(firstLayerNeuronsNumbRange / 3, firstLayerNeuronsNumbRange);
                        else denseLayer[i].neurons = random.Next(denseLayer[i - 1].neurons / 3, denseLayer[i - 1].neurons);
                    }
                }
                //else
            }
        }

        public void MutateDropouts(int mutateRate, int dropoutRange)
        {
            if (random.Next(100) < mutateRate)
            {
                if (random.Next(100) < 10)
                {
                    if(denseLayer[0].dropoutExist) for(int i = 0; i < denseLayer.Count; i++) denseLayer[i].dropoutExist = false;
                    else for(int i = 0; i < denseLayer.Count; i++)
                        {
                            denseLayer[i].dropoutExist = true;
                            denseLayer[i].dropoutRate = random.Next(10, dropoutRange);
                        }
                }
                else for (int i = 0; i < denseLayer.Count; i++) denseLayer[i].MutateDropout(dropoutRange, mutateRate);
            }
        }
    }
}
