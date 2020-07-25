using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    class AutonomicParams
    {
        public readonly List<int> callbacksList;
        public readonly string modelPath;
        public readonly string labelPath;
        public readonly string plotPath;
        public readonly string datasetPath;
        public readonly string networkName;
     
        public AutonomicParams(List<int> callbacksList, string modelPath, 
                               string labelPath, string plotPath, string datasetPath, 
                               string networkName)
        {
            this.callbacksList = callbacksList;
            this.modelPath = modelPath;
            this.labelPath = labelPath;
            this.plotPath = plotPath;
            this.datasetPath = datasetPath;
            this.networkName = networkName;
        }
    }
}
