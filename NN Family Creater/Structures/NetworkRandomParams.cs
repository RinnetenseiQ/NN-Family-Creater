﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    public class NetworkRandomParams
    {
        public readonly bool notRandomSpeed;
        public readonly float[] trainConstSpeedRange;
        public readonly string datasetPath;
        public readonly string _modelPath;
        public readonly string _labelPath;
        public readonly string _plotPath;
        public readonly string networkName;
        public readonly int networkOutputNumb;
        public readonly List<string> optimizers;
        public readonly List<string> loss_functions;
        public readonly int epochs;
        public readonly int batchSize;

        public NetworkRandomParams(bool notRandomSpeed, float[] trainConstSpeedRange, string datasetPath, 
                                   string modelPath, string labelPath, string plotPath,
                                   string networkName, List<string> optimizers,
                                   List<string> loss_functions, int epochs,
                                   int batchSize)
        {
            this.notRandomSpeed = notRandomSpeed;
            this.trainConstSpeedRange = trainConstSpeedRange;
            this.datasetPath = datasetPath;
            _modelPath = modelPath;
            _labelPath = labelPath;
            _plotPath = plotPath;
            this.networkName = networkName;
            this.optimizers = optimizers;
            this.loss_functions = loss_functions;
            this.epochs = epochs;
            this.batchSize = batchSize;
            networkOutputNumb = Support.GetOutputNumb(datasetPath);
        }
    }
}
