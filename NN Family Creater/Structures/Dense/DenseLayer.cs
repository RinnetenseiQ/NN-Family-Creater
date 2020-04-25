using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    class DenseLayer
    {
        public bool dropoutExist;
        public int dropoutRate;
        Random random;
        public int activationIndex;
        public int neurons;

        public DenseLayer(int activationsIndexesRange, int neurons, int dropoutRateRange)
        {
            random = new Random();
            dropoutExist = random.Next(100) < 10 ? true : false;
            if (dropoutExist) dropoutRate = random.Next(10, dropoutRateRange);
            else dropoutRate = 0;
            activationIndex = random.Next(activationsIndexesRange);
            this.neurons = neurons;
        }

        public DenseLayer(int activationIndex, int neurons, bool dropoutExist, int dropoutRate)
        {
            this.activationIndex = activationIndex;
            this.neurons = neurons;
            this.dropoutExist = dropoutExist;
            this.dropoutRate = dropoutRate;
        } // псевдокопирующий конструктор

        public DenseLayer(DenseRandomParams drp, int neurons)
        {
            random = new Random();
            dropoutExist = random.Next(100) < 10 ? true : false;
            if (dropoutExist) dropoutRate = random.Next(10, drp.denseDropRange);
            else dropoutRate = 0;
            activationIndex = random.Next(drp.denseActIndexesRange);
            this.neurons = neurons;
        }

        public void MutateActivation(DenseRandomParams drp, int mutateRate)
        {
           if(random.Next(100) < mutateRate) activationIndex = random.Next(drp.denseActIndexesRange);
            // поменять переменную sameActivations в другом классе(классе выше)
        }

        

        public void MutateDropout(DenseRandomParams drp, int mutateRate)
        {
            if(random.Next(100) < mutateRate)
            {
                int mutationWay = random.Next(100);
                if (mutationWay < 10)
                {
                    dropoutExist = !dropoutExist;
                    if(dropoutExist) dropoutRate = random.Next(10, drp.denseDropRange);
                }
                else dropoutRate = random.Next(10, drp.denseDropRange);
            }
        }
    }
}
