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
        public readonly int networkOutputNumb;

        public NetworkRandomParams(float[] trainConstSpeedRange, string datasetPath, string networkName)
        {
            this.trainConstSpeedRange = trainConstSpeedRange;
            this.datasetPath = datasetPath;
            networkOutputNumb = Support.GetOutputNumb(datasetPath);
        }
    }
}
