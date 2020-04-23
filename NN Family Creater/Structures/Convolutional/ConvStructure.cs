using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    class ConvStructure
    {
        Random random;
        public int convLayersNumb;
        public List<ConvLayer> convLayers;
        private readonly int[] slidingWindowRange;
        public int firstLayerNeuronsNumbRange;

        public bool sameSlidingWindowsSize;
        public bool sameActivations;
        public bool allSquareSlidingWindows;
        public ConvStructure(int convLayerNumbRange, int[] slidingWindowRange,
                             int activationsIndexesRange, int firstLayerNeuronsNumbRange, int dropoutRateRange)
        {
            this.slidingWindowRange = slidingWindowRange;
            this.firstLayerNeuronsNumbRange = firstLayerNeuronsNumbRange;
           
            random = new Random();

            sameSlidingWindowsSize = random.Next(100) < 10 ? true : false;      //подредачить шанс
            sameActivations = random.Next(100) < 10 ? true : false;             //подредачить шанс
            allSquareSlidingWindows = random.Next(100) < 10 ? true : false;     //подредачить шанс

            convLayersNumb = random.Next(1, convLayerNumbRange);
            convLayers = new List<ConvLayer>(convLayersNumb);
            for (int i = 0, adds = 0; i < convLayers.Capacity; i++, adds += 16) // переделать условие выхода ----------- экзепшн!!!!!
            {
                int neurons = random.Next(8, firstLayerNeuronsNumbRange) + adds; // Переделать!!!?
                convLayers.Add(new ConvLayer(slidingWindowRange, activationsIndexesRange, neurons, dropoutRateRange));
            }

            if (sameSlidingWindowsSize)
            {
                int abserber = random.Next(convLayers.Count);
                for(int i = 0; i < convLayers.Count; i++)
                {
                    convLayers[i].slidingWindow = convLayers[abserber].slidingWindow;
                }
            }

            if (allSquareSlidingWindows)
            {
                for(int i = 0; i < convLayers.Count; i++)
                {
                    if (convLayers[i].slidingWindow[0] > 1) convLayers[i].slidingWindow[1] = convLayers[i].slidingWindow[0];
                    else convLayers[i].slidingWindow[0] = convLayers[i].slidingWindow[1];
                }
            }

            if (sameActivations)
            {
                int sameActivationIndex = random.Next(activationsIndexesRange);
                for(int i = 0; i < convLayers.Count; i++)
                {
                    convLayers[i].activationIndex = sameActivationIndex;
                }
            }

            //this.MutateWindows(30, )

            
        }

        public ConvStructure(ConvStructure CSToCopy)
        {
            this.convLayersNumb = CSToCopy.convLayersNumb;
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

        public void MutateLayersNumb(int convLayerNumbRange, int mutateRate, int dropoutRateRange,
                                     int[] slidingWindowRange, int activationsIndexesRange)
        {
            if (random.Next(100) < mutateRate) convLayersNumb = random.Next(1, convLayerNumbRange);

            if(convLayersNumb >= convLayers.Count)
            {
                convLayers.Capacity = convLayersNumb;
                while(convLayers.Count != convLayers.Capacity) // проверить условие!!
                {
                    int neurons = random.Next(firstLayerNeuronsNumbRange, firstLayerNeuronsNumbRange + firstLayerNeuronsNumbRange * convLayers.Count); //переделать!?
                    convLayers.Add(new ConvLayer(slidingWindowRange, activationsIndexesRange, neurons, dropoutRateRange));

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

        public void MutateActivation(int mutateRate, int activationsIndexesRange)
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
                        convLayers[i].MutateActivation(activationsIndexesRange, mutateRate);
                    }
                }
            }
        }

        public void MutateWindows(int mutateRate, int[] slidingWindowRange)
        {
            if(random.Next(100) < mutateRate)
            {
                for (int i = 0; i < convLayers.Count; i++)
                {
                    if (random.Next(100) < 20)
                    {
                        convLayers[i].slidingWindow[0] = random.Next(1, slidingWindowRange[0]);
                        if (convLayers[i].slidingWindow[0] > 1) convLayers[i].slidingWindow[1] = random.Next(1, slidingWindowRange[1]);
                        else convLayers[i].slidingWindow[1] = random.Next(2, slidingWindowRange[1]);
                    }
                    else convLayers[i].MutateWindow(slidingWindowRange, mutateRate);

                }
            }
        }

        

        public void CrossSlidingWindow()
        {

        }
    }
}
