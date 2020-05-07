using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    public class ConvStructure
    {
        Random random;
        public int convLayersNumb;
        public List<ConvLayer> convLayers;

        public bool sameSlidingWindowsSize;
        public bool sameActivations;
        public bool allSquareSlidingWindows;
        
        public ConvStructure(ConvRandomParams crp, Random random)
        {
            this.random = random;

            sameSlidingWindowsSize = random.Next(100) < 10 ? true : false;      //подредачить шанс
            sameActivations = random.Next(100) < 10 ? true : false;             //подредачить шанс
            allSquareSlidingWindows = random.Next(100) < 10 ? true : false;     //подредачить шанс

            convLayersNumb = random.Next(1, crp.convLayersNumbRange);
            convLayers = new List<ConvLayer>(convLayersNumb);

            int powRandomValue = 0;
            for (int i = 0; i < convLayers.Capacity; i++) 
            {
                if (i == 0) powRandomValue = random.Next(1, crp.firstConvPowFilters + 1);
                else powRandomValue += random.Next(0, 2);
                int filters = (int)Math.Pow(2, powRandomValue);
                convLayers.Add(new ConvLayer(crp, random, filters)); // создаются разные, но в листе получаются одинаковые
            }

            if (sameSlidingWindowsSize) // тут уже одинаковые
            {
                int abserber = random.Next(convLayers.Count);
                for (int i = 0; i < convLayers.Count; i++)
                {
                    convLayers[i].slidingWindow = convLayers[abserber].slidingWindow;
                }
            }

            if (allSquareSlidingWindows)
            {
                for (int i = 0; i < convLayers.Count; i++)
                {
                    if (convLayers[i].slidingWindow[0] > 1) convLayers[i].slidingWindow[1] = convLayers[i].slidingWindow[0];
                    else convLayers[i].slidingWindow[0] = convLayers[i].slidingWindow[1];
                }
            }

            if (sameActivations)
            {
                int sameActivationIndex = random.Next(crp.convActIndexesRange);
                for (int i = 0; i < convLayers.Count; i++)
                {
                    convLayers[i].activationIndex = sameActivationIndex;
                }
            }
        }


        public ConvStructure(List<int[]> slidingWindows, List<int> convActivationIndexes, List<int> filters, List<int> convDropoutIndexes, List<int> dropoutRates)
        {
            convLayers = new List<ConvLayer>();
            convLayersNumb = convActivationIndexes.Count;
            for(int i = 0, counter = 0; i < convLayersNumb; i++)
            {
                bool dropoutExist = false;
                int dropoutRate = 0;
                if(i == convDropoutIndexes[counter])
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
                convLayers.Add(new ConvLayer(convActivationIndexes[i], slidingWindows[i], dropoutExist, dropoutRate));
            }
        } // создание объекта по ConvolutionalNetwork

        public void MutateLayersNumb(ConvRandomParams crp, int mutateRate)
        {
            if (random.Next(100) < mutateRate) convLayersNumb = random.Next(1, crp.convLayersNumbRange);

            if(convLayersNumb >= convLayers.Count)
            {
                convLayers.Capacity = convLayersNumb;
                while(convLayers.Count != convLayers.Capacity) // проверить условие!!
                {
                    int filters = random.Next(crp.firstConvPowFilters, crp.firstConvPowFilters + crp.firstConvPowFilters * convLayers.Count); //переделать!?
                    convLayers.Add(new ConvLayer(crp, random, filters));

                    if (sameSlidingWindowsSize) convLayers[convLayers.Count - 1].slidingWindow = convLayers[0].slidingWindow;
                    if (sameActivations) convLayers[convLayers.Count - 1].activationIndex = convLayers[0].activationIndex;
                    if (allSquareSlidingWindows)
                    {
                        if (convLayers[convLayers.Count - 1].slidingWindow[0] > 1) convLayers[convLayers.Count - 1].slidingWindow[1] = convLayers[convLayers.Count - 1].slidingWindow[0];
                        else convLayers[convLayers.Count - 1].slidingWindow[0] = convLayers[convLayers.Count - 1].slidingWindow[1];
                    }
                }
            }
            else
            {
                convLayers.RemoveRange(convLayersNumb, convLayers.Capacity - convLayersNumb);
                convLayers.Capacity = convLayersNumb;
            }

        }

        public void MutateActivation(ConvRandomParams crp, int mutateRate)
        {
            if (random.Next(100) < mutateRate)
            {
                if (random.Next(100) < 10)
                {
                    sameActivations = !sameActivations;
                    if (sameActivations)
                    {
                        int abserberIndex = random.Next(convLayers.Count);
                        for (int i = 0; i < convLayers.Count; i++)
                        {
                            convLayers[i].activationIndex = convLayers[abserberIndex].activationIndex;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < convLayers.Count; i++)
                    {
                        convLayers[i].MutateActivation(crp, mutateRate);
                    }
                }
            }
        }

        public void MutateWindows(ConvRandomParams crp, int mutateRate)
        {
            if(random.Next(100) < mutateRate)
            {
                for (int i = 0; i < convLayers.Count; i++)
                {
                    if (random.Next(100) < 20)
                    {
                        convLayers[i].slidingWindow[0] = random.Next(1, crp.slidingWindowsRange[0]);
                        if (convLayers[i].slidingWindow[0] > 1) convLayers[i].slidingWindow[1] = random.Next(1, crp.slidingWindowsRange[1]);
                        else convLayers[i].slidingWindow[1] = random.Next(2, crp.slidingWindowsRange[1]);
                    }
                    else convLayers[i].MutateWindow(crp, mutateRate);

                }
            }
        }
    }
}
