using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    class Chromosome
    {
        Random random;

        public string name;

        public double trainConstSpeed;
        public double adaptiveSpeedRatio;
        public int speedAlgorithmIndex;

        public ConvStructure convPart;
        public DenseStructure densePart;

        public float assessment;

        public float accuracy;
        public float memory;

        private readonly int convLayersNumbRange;
        private readonly int denseLayersNumbRange;
        private readonly int firstConvNeuronsRange;
        private readonly int firstDenseNeuronsRange;
        private readonly int convActIndexesRange;
        private readonly int denseActIndexesRange;
        private readonly int[] slidingWindowsRange;
        private readonly int dropoutRangeRate;

        public Chromosome(int convLayersNumbRange, int denseLayersNumbRange,
                          int firstConvNeuronsRange, int firstDenseNeuronsRange,
                          int convActIndexesRange, int denseActIndexesRange,
                          int[] slidingWindowsRange, int dropoutRangeRate)
        {
            random = new Random();

            
            this.convLayersNumbRange = convLayersNumbRange;
            this.denseLayersNumbRange = denseLayersNumbRange;
            this.firstConvNeuronsRange = firstConvNeuronsRange;
            this.firstDenseNeuronsRange = firstDenseNeuronsRange;
            this.convActIndexesRange = convActIndexesRange;
            this.denseActIndexesRange = denseActIndexesRange;
            this.slidingWindowsRange = slidingWindowsRange;
            this.dropoutRangeRate = dropoutRangeRate;
            convPart = new ConvStructure(convLayersNumbRange, slidingWindowsRange, convActIndexesRange, firstConvNeuronsRange, dropoutRangeRate);
            densePart = new DenseStructure(denseLayersNumbRange, denseActIndexesRange, firstDenseNeuronsRange, dropoutRangeRate);
        }

        public Chromosome(Chromosome chrToCopy)
        {

        }

        public void MutateConvolutional(int mutateRate)
        {
            if(random.Next(100) < mutateRate)
            {
                if(random.Next(100) < 5)
                {
                    convPart = new ConvStructure(convLayersNumbRange, slidingWindowsRange, convActIndexesRange, firstConvNeuronsRange, dropoutRangeRate);
                }
                else
                {
                    convPart.MutateLayersNumb(convLayersNumbRange, mutateRate, dropoutRangeRate, slidingWindowsRange, convActIndexesRange);
                    convPart.MutateActivation(mutateRate, convActIndexesRange);
                    convPart.MutateWindows(mutateRate, slidingWindowsRange);
                    
                }
            }
        }

        public void MutateDense(int mutateRate, int dropoutRateRange)
        {
            if(random.Next(100) < mutateRate)
            {
                if (random.Next(100) < 5)
                {
                    densePart = new DenseStructure(denseLayersNumbRange, denseActIndexesRange, firstDenseNeuronsRange, dropoutRangeRate);
                }
                else
                {
                    densePart.MutateLayersNumb(denseLayersNumbRange, mutateRate, denseActIndexesRange, dropoutRangeRate);
                    densePart.MutateActivation(mutateRate, denseActIndexesRange);
                    densePart.MutateNeurons(mutateRate);
                    densePart.MutateDropouts(mutateRate, dropoutRateRange);
                }
            }
        }

        public void UpdateAssessmentParam()
        {
            // TO DO
            // assessment = convPart.convLayers.Count*8 + densePart.denseLayer.Count*8 + densePart.denseLayer[0].neurons/8;
            //assessment = random.Next(100);

            accuracy = random.Next(100);
            memory = random.Next(20, 1000);
        }

    }
    class ChromosomeComparer : IComparer<Chromosome>
    {
        public float MemoryCoef { get; set; }
        public float AccuracyCoef { get; set; }
        public ChromosomeComparer(float memoryCoef, float accuracyCoef)
        {
            MemoryCoef = memoryCoef;
            AccuracyCoef = accuracyCoef;
        }
        public int Compare(Chromosome a, Chromosome b)
        {
            // TO DO assessment rules

            if ((b.memory - a.memory > 0) && (b.accuracy - a.accuracy < 0)) return 1;
            else if ((b.memory - a.memory < 0) && (b.accuracy - a.accuracy > 0)) return -1;
            else if ((b.memory - a.memory == 0) && (b.accuracy - a.accuracy == 0)) return 0;
            else if ((b.memory - MemoryCoef * a.memory > 0) && (b.accuracy - AccuracyCoef * a.accuracy > 0)) return 1;
            else if ((b.memory - MemoryCoef * a.memory < 0) && (b.accuracy - AccuracyCoef * a.accuracy < 0)) return -1;
            else return 0; //

            //return b.assessment - a.assessment;
        }
    }

    class ChromosomeComparer2 : IComparer<Chromosome>
    {
        
        public int Compare(Chromosome x, Chromosome y)
        {
            if (x.assessment - y.assessment > 0) return -1;
            else if (x.assessment - y.assessment < 0) return 1;
            else return 0; // переделать!!!!
        }
    }
}
