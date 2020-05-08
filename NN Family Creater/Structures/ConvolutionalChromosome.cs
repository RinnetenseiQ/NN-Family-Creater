﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    public class ConvolutionalChromosome
    {
        Random random;

        public string name;

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
        public float paramsCount;

        public ConvolutionalChromosome(NetworkRandomParams nrp, ConvRandomParams crp, DenseRandomParams drp, Random random)
        {
            this.random = random;
            this.nrp = nrp;
            this.crp = crp;
            this.drp = drp;
            convPart = new ConvStructure(crp, random);
            densePart = new DenseStructure(drp, random);

            trainConstSpeed = Convert.ToSingle(random.Next((int)(nrp.trainConstSpeedRange[0] * 1000), (int)(nrp.trainConstSpeedRange[1] * 1000))) / 1000;
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
                    densePart = new DenseStructure(drp, random);
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
            else if ((b.paramsCount - a.paramsCount < 0) && (b.accuracy - a.accuracy > 0)) return -1;
            else if ((b.paramsCount - a.paramsCount == 0) && (b.accuracy - a.accuracy == 0)) return 0;
            else if ((b.paramsCount - MemoryCoef * a.paramsCount > 0) && (b.accuracy - AccuracyCoef * a.accuracy > 0)) return 1;
            else if ((b.paramsCount - MemoryCoef * a.paramsCount < 0) && (b.accuracy - AccuracyCoef * a.accuracy < 0)) return -1;
            else return 0; //

            //return b.assessment - a.assessment;
        }
    }

    class ChromosomeComparer2 : IComparer<ConvolutionalChromosome>
    {
        
        public int Compare(ConvolutionalChromosome x, ConvolutionalChromosome y)
        {
            if (x.assessment - y.assessment > 0) return -1;
            else if (x.assessment - y.assessment < 0) return 1;
            else return 0; // переделать!!!!
        }
    }
}
