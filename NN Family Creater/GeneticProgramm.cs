using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    public class GeneticProgramm
    {
        public readonly NetworkRandomParams _nrp;
        public readonly ConvRandomParams _crp;
        public readonly DenseRandomParams _drp;
        public readonly int _genEpochs;
        public readonly int[] _selection;
        public readonly int _populationSize;
        public readonly int _mutateRate;
        public readonly float _accPriority;
        public readonly float _paramPriority;
        public readonly int _assessmentIndex;
        public readonly int _percent;
       

        public GeneticProgramm(NetworkRandomParams nrp, ConvRandomParams crp, DenseRandomParams drp,
                               int genEpochs, int[] selection, int populationSize, int mutateRate, 
                               float accPriority, float paramPriority, int assessmentIndex, int percent)
        {
            _nrp = nrp;
            _crp = crp;
            _drp = drp;
            _genEpochs = genEpochs;
            _selection = selection;
            _populationSize = populationSize;
            _mutateRate = mutateRate;
            _accPriority = accPriority;
            _paramPriority = paramPriority;
            _assessmentIndex = assessmentIndex;
            _percent = percent;
         
        }
    }
}
