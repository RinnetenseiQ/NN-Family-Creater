using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    class DenseRandomParams
    {
        // Dense
        public readonly int denseLayersNumbRange;
        public readonly int firstDenseNeuronsRange;
        public readonly int denseActIndexesRange;
        public readonly int denseDropRange;

        public DenseRandomParams(int denseLayersNumbRange,
                          int firstDenseNeuronsRange,
                          int denseActIndexesRange,
                          int denseDropRange)
        {
            this.denseLayersNumbRange = denseLayersNumbRange;
            this.firstDenseNeuronsRange = firstDenseNeuronsRange;
            this.denseActIndexesRange = denseActIndexesRange;
            this.denseDropRange = denseDropRange;

        }
    }
}
