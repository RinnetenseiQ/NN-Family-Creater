﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    public class ConvLayer
    {
        public int activationIndex;
        Random random;

        public int[] slidingWindow;
        public bool squareSlidingWindow;

        public bool dropoutExist;
        public bool maxPullingExist;
        public int dropoutRate;

        public int filters;


        public ConvLayer(ConvRandomParams crp, Random random, int filters)
        {
            this.random = random;
            this.filters = filters;
            slidingWindow = new int[2];

            dropoutExist = random.Next(100) < 10 ? true : false;
            maxPullingExist = random.Next(100) < 10 ? true : false;
            if (dropoutExist) dropoutRate = random.Next(10, crp.convDropRange);
            else dropoutRate = 0;

            activationIndex = random.Next(crp.convActIndexesRange);

            squareSlidingWindow = random.Next(100) <= 20 ? true : false;
            if (squareSlidingWindow)
            {
                slidingWindow[0] = random.Next(2, crp.slidingWindowsRange[0]);
                slidingWindow[1] = slidingWindow[0];
            }
            else
            {
                slidingWindow[0] = random.Next(1, crp.slidingWindowsRange[0]);
                if (slidingWindow[0] > 1) slidingWindow[1] = random.Next(1, crp.slidingWindowsRange[1]);
                else slidingWindow[1] = random.Next(2, crp.slidingWindowsRange[1]);
            }
            //Thread.Sleep(1);
        }

        public ConvLayer(ConvLayer cLayerToCopy)
        {
            activationIndex = cLayerToCopy.activationIndex;
            slidingWindow = cLayerToCopy.slidingWindow;
            dropoutExist = cLayerToCopy.dropoutExist;
            dropoutRate = cLayerToCopy.dropoutRate;
            maxPullingExist = cLayerToCopy.maxPullingExist;
        } // копирующий конструктор, хз зачем, но уже написал, не удалять же. Может потом пригодится х)

        public ConvLayer(int activationIndex, int[] slidingWindow, bool dropoutExist, int dropoutRate)
        {
            this.activationIndex = activationIndex;
            this.slidingWindow = slidingWindow;
            this.dropoutExist = dropoutExist;
            this.dropoutRate = dropoutRate;
        } // для создания объекта по описательному

        

        public void MutateWindow(ConvRandomParams crp, int mutateRate)
        {
            int mutateWay = random.Next(100);
            if(mutateWay < 10)
            {
                squareSlidingWindow = !squareSlidingWindow;
                if (squareSlidingWindow)
                {
                    if (slidingWindow[0] > 1) slidingWindow[1] = slidingWindow[0];
                    else slidingWindow[0] = slidingWindow[1];
                }
                else
                {
                    int index = random.Next(2);
                    if (random.Next(100) < mutateRate) slidingWindow[index] = random.Next(2, crp.slidingWindowsRange[index]);
                }
            }
            else
            {
                if (random.Next(100) <= mutateRate) slidingWindow[0] = random.Next(1, crp.slidingWindowsRange[0]);
                if (random.Next(100) <= mutateRate || slidingWindow[0] == 1)
                {
                    if (slidingWindow[0] > 1) slidingWindow[1] = random.Next(1, crp.slidingWindowsRange[1]);
                    else slidingWindow[1] = random.Next(2, crp.slidingWindowsRange[1]);
                }
                this.squareSlidingWindow = slidingWindow[0] == slidingWindow[1]; 
            }

            if (slidingWindow[0] == slidingWindow[1]) squareSlidingWindow = true;
            else squareSlidingWindow = false;
        }

        public void MutateActivation(ConvRandomParams crp, int mutateRate)
        {
            if (random.Next(100) <= mutateRate ? true : false) activationIndex = random.Next(0, crp.convActIndexesRange);
        }

        public void MutateDropout(ConvRandomParams crp, int mutateRate)
        {
            if(random.Next(100) < mutateRate)
            {
                int mutationWay = random.Next(100);
                if (mutationWay < 10) dropoutExist = !dropoutExist;
                else dropoutRate = random.Next(10, crp.convDropRange);
            }
        }
        
        public void MutateMaxPooling(ConvRandomParams crp, int mutateRate)
        {
            if (random.Next(100) < mutateRate) maxPullingExist = !maxPullingExist;
        }
    }

}
