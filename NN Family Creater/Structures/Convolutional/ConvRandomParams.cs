using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    class ConvRandomParams
    {
        // Convolutional part params
        public readonly int convLayersNumbRange;
        public readonly int firstConvFiltersRange;
        public readonly int convActIndexesRange;
        public readonly int[] slidingWindowsRange;
        public readonly int convDropRange;

        public ConvRandomParams(int convLayersNumbRange, 
                          int firstConvFiltersRange, 
                          int convActIndexesRange, 
                          int[] slidingWindowsRange, 
                          int convDropRange )
        {
            this.convLayersNumbRange = convLayersNumbRange;
            this.firstConvFiltersRange = firstConvFiltersRange;
            this.convActIndexesRange = convActIndexesRange;
            this.slidingWindowsRange = slidingWindowsRange;
            this.convDropRange = convDropRange;
            
        }    }
}
