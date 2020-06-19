using System;
using System.Collections.Generic;

namespace NN_Family_Creater
{
    public class ConvolutionalChromosome
    {
        public readonly GeneticProgramm _gp;
        Random random;

        public string name;
        public int indexNumber;

        public float trainConstSpeed;
        public string optimizer;
        public string loss_function;

        public double adaptiveSpeedRatio;
        public int speedAlgorithmIndex;

        public ConvStructure convPart;
        public DenseStructure densePart;

        public NetworkRandomParams nrp;
        public ConvRandomParams crp;
        public DenseRandomParams drp;

        public float assessment;

        public float accuracy;
        public int paramsCount;

        public ConvolutionalChromosome(GeneticProgramm gp, Random random)
        {
            _gp = gp;
            this.random = random;
            nrp = gp._nrp;
            crp = gp._crp;
            drp = gp._drp;
            convPart = new ConvStructure(crp, random);
            densePart = new DenseStructure(nrp, drp, random);
            if (nrp.notRandomSpeed) trainConstSpeed = nrp.trainConstSpeedRange[0];
            else trainConstSpeed = Convert.ToSingle(random.Next((int)(nrp.trainConstSpeedRange[0] * 1000), (int)(nrp.trainConstSpeedRange[1] * 1000))) / 1000;
            optimizer = nrp.optimizers[random.Next(nrp.optimizers.Count)];
            loss_function = nrp.loss_functions[random.Next(nrp.loss_functions.Count)];
        }

  
        public ConvolutionalChromosome(ConvolutionalNetwork cNet, ConvRandomParams crp, DenseRandomParams drp)
        {
            this.crp = crp;
            this.drp = drp;
            //добавить рандомные параметры 
            convPart = new ConvStructure(cNet.slidingWindows, cNet.convActivationIndexes, cNet.filters, cNet.convDropoutIndexes, cNet.convDropoutRates);
            densePart = new DenseStructure(cNet.denseActivationIndexes, cNet.neurons, cNet.denseDropoutIndexes, cNet.denseDropoutRates);
        } // конструктор для создания хромосомы из полей описательного класса ConvolutionalNetwork для последующего использования в генетических алгоритмах (например, для поиска лучшего варианта чем текущий)
        
        public void MutateConvolutional(ConvRandomParams crp, int mutateRate)
        {
            if(random.Next(100) < mutateRate)
            {
                if(random.Next(100) < 5)
                {
                    convPart = new ConvStructure(crp, random);
                }
                else
                {
                    convPart.MutateLayersNumb(crp, mutateRate);
                    convPart.MutateActivation(crp, mutateRate);
                    convPart.MutateWindows(crp, mutateRate);
                }
            }
        }

      
        public void MutateDense(DenseRandomParams drp, int mutateRate)
        {
            if(random.Next(100) < mutateRate)
            {
                if (random.Next(100) < 5)
                {
                    densePart = new DenseStructure(nrp, drp, random);
                }
                else
                {
                    densePart.MutateLayersNumb(drp, mutateRate);
                    densePart.MutateActivation(drp, mutateRate);
                    densePart.MutateNeurons(drp, mutateRate);
                    densePart.MutateDropouts(drp, mutateRate);
                }
            }
        }


        public void UpdateAssessmentParam()
        {
            // TO DO
            // assessment = convPart.convLayers.Count*8 + densePart.denseLayer.Count*8 + densePart.denseLayer[0].neurons/8;
            //assessment = random.Next(100);

            //accuracy = new Random().Next(100);
            accuracy = random.Next(100);
          
            paramsCount = random.Next(20, 10000);
            //paramsCount = new Random().Next(20, 10000);
        }

    }
    class ChromosomeComparer : IComparer<ConvolutionalChromosome>
    {
        public float MemoryCoef { get; set; }
        public float AccuracyCoef { get; set; }
        public ChromosomeComparer(float memoryCoef, float accuracyCoef)
        {
            MemoryCoef = memoryCoef;
            AccuracyCoef = accuracyCoef;
        }
        public int Compare(ConvolutionalChromosome a, ConvolutionalChromosome b)
        {
            // TO DO assessment rules

            if ((b.paramsCount - a.paramsCount > 0) && (b.accuracy - a.accuracy < 0)) return 1;
            if ((b.paramsCount - a.paramsCount < 0) && (b.accuracy - a.accuracy > 0)) return -1;
            if ((b.paramsCount - a.paramsCount == 0) && (b.accuracy - a.accuracy == 0)) return 0;
            if ((b.paramsCount - MemoryCoef * a.paramsCount > 0) && (b.accuracy - AccuracyCoef * a.accuracy > 0)) return 1;
            if ((b.paramsCount - MemoryCoef * a.paramsCount < 0) && (b.accuracy - AccuracyCoef * a.accuracy < 0)) return -1;
            return 0; //

            //return b.assessment - a.assessment;
        }
    }

    class ChromosomeComparer3 : IComparer<ConvolutionalChromosome>
    {
        public float a;
        public float b;

        public ChromosomeComparer3(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public int Compare(ConvolutionalChromosome x, ConvolutionalChromosome y)
        {
            float result = (a * (x.accuracy - y.accuracy) - (b * (x.paramsCount - y.paramsCount)));
            if (result < 0) return -1;
            if (result > 0) return 1;
            return 0;
            
        }
    }

    class ChromosomeComparer4 : IComparer<ConvolutionalChromosome>
    {
        public int percent;

        public ChromosomeComparer4(int percent)
        {
            this.percent = percent;
        }
        public int Compare(ConvolutionalChromosome x, ConvolutionalChromosome y)
        {
            float paramPercent;
            float thresholdValue;
            if (x.accuracy != y.accuracy) thresholdValue = Math.Abs(percent * 100 * (x.accuracy - y.accuracy));
            else thresholdValue = percent;

            if (x.accuracy == y.accuracy)
            {
                if (x.paramsCount < y.paramsCount) return -1;
                if (x.paramsCount == y.paramsCount) return 0;
                return 1;
            }

            if (x.accuracy > y.accuracy)
            {
                paramPercent = (float)x.paramsCount / y.paramsCount;
                if (paramPercent < 1) return -1; //не уверен насчет возвращаемых значений
                paramPercent -= 1;
                paramPercent *= 100;
                if (paramPercent < thresholdValue) return -1;
                if (paramPercent == thresholdValue) return 0;
                return 1;


            }

            if(x.accuracy < y.accuracy)
            {
                paramPercent = (float) y.paramsCount / x.paramsCount;
                if (paramPercent < 1) return 1;
                paramPercent -= 1;
                paramPercent *= 100;
                if (paramPercent < thresholdValue) return 1;
                if (paramPercent == thresholdValue) return 0;
                return -1;

            }

            return 0;
        }
    }

    class ChromosomeComparer2 : IComparer<ConvolutionalChromosome>
    {
        
        public int Compare(ConvolutionalChromosome x, ConvolutionalChromosome y)
        {
            if (x.assessment - y.assessment > 0) return -1;
            if (x.assessment - y.assessment < 0) return 1;
            return 0; // переделать!!!!
        }
    }
}
