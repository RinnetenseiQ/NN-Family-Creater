using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    public class DenseRandomParams
    {
        // Dense
        public readonly int denseLayersNumbRange;
        public readonly int firstDenseNeuronsRange;
        private readonly int outputNumb;
        public readonly int denseActIndexesRange;
        public readonly List<string> denseActivations;
        public readonly bool denseDropoutExist;
        public readonly int denseDropRange;

        public DenseRandomParams(int denseLayersNumbRange,
                                 int firstDenseNeuronsRange,
                                 int outputNumb,
                                 int denseActIndexesRange,
                                 List<string> denseActivations,
                                 bool denseDropoutExist,
                                 int denseDropRange)
        {
            this.denseLayersNumbRange = denseLayersNumbRange;
            this.firstDenseNeuronsRange = firstDenseNeuronsRange;
            this.outputNumb = outputNumb;
            this.denseActIndexesRange = denseActIndexesRange;
            this.denseActivations = denseActivations;
            this.denseDropoutExist = denseDropoutExist;
            this.denseDropRange = denseDropRange;

        }
    }
}
