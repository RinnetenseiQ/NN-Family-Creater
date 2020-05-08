using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    public class NetworkRandomParams
    {
        public readonly float[] trainConstSpeedRange;
        public readonly string datasetPath;
        public readonly string networkName;
        public readonly int networkOutputNumb;
        public readonly List<string> optimizers;
        public readonly List<string> loss_functions;
        public readonly int epochs;
        public readonly int batchSize;

        public NetworkRandomParams(float[] trainConstSpeedRange, string datasetPath, 
                                   string networkName, List<string> optimizers,
                                   List<string> loss_functions, int epochs,
                                   int batchSize)
        {
            this.trainConstSpeedRange = trainConstSpeedRange;
            this.datasetPath = datasetPath;
            this.networkName = networkName;
            this.optimizers = optimizers;
            this.loss_functions = loss_functions;
            this.epochs = epochs;
            this.batchSize = batchSize;
            networkOutputNumb = Support.GetOutputNumb(datasetPath);
        }
    }
}
