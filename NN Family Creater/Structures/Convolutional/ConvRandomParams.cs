using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    public class ConvRandomParams
    {
        // Convolutional part params
        public readonly int convLayersNumbRange;
        public readonly int firstConvPowFilters;
        public readonly int convActIndexesRange;
        public readonly List<string> convActivations;
        public readonly int[] slidingWindowsRange;
        public readonly bool convDropoutExist;
        public readonly int convDropRange;

        public ConvRandomParams(int convLayersNumbRange, 
                                int firstConvFiltersRange, 
                                int convActIndexesRange,
                                List<string> convActivations, 
                                int[] slidingWindowsRange,
                                bool convDropoutExist,
                                int convDropRange)
        {
            this.convLayersNumbRange = convLayersNumbRange;
            this.firstConvPowFilters = firstConvFiltersRange;
            this.convActIndexesRange = convActIndexesRange;
            this.convActivations = convActivations;
            this.slidingWindowsRange = slidingWindowsRange;
            this.convDropoutExist = convDropoutExist;
            this.convDropRange = convDropRange;
            
        }    }
}
