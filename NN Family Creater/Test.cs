using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    class Test
    {
       
        public float accuracy;
        public int paramsCount;
        public float assessment;

        public Test(Random random)
        {
            
            accuracy = (float) random.Next(100) / 100;
            paramsCount = random.Next(4000, 200000000);
        }

        public static void UpdateAssses(List<Test> list)
        {
            float minParamsCount = list[0].paramsCount; //локальная переменная для хранения минимальной памяти

            for (int i = 1; i < list.Count; i++)
            {
                if (minParamsCount != 0)
                {
                    if (list[i].paramsCount < minParamsCount && list[i].paramsCount != 0) minParamsCount = list[i].paramsCount; // цикл поиска минимума
                }

            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].accuracy == 0 || list[i].paramsCount == 0) list[i].assessment = 0;
                else list[i].assessment = list[i].accuracy + list[i].accuracy * (minParamsCount / list[i].paramsCount); // цикл расчета оценки
            }
        }
    }

    

    class TestComparer : IComparer<Test>
    {
        public int percent;

        public TestComparer(int percent)
        {
            this.percent = percent;
        }
        public int Compare(Test x, Test y)
        {
            float paramPercent;
            float thresholdValue;
            if (x.accuracy != y.accuracy) thresholdValue = Math.Abs(percent * 100 * (x.accuracy - y.accuracy));
            else thresholdValue = percent;

            if (x.accuracy == y.accuracy)
            {
                if (x.paramsCount < y.paramsCount) return -1;
                if (x.paramsCount == y.paramsCount) return 0;
                return 1;
            }

            if (x.accuracy > y.accuracy)
            {
                paramPercent = (float)x.paramsCount / y.paramsCount;
                if (paramPercent < 1) return -1; //не уверен насчет возвращаемых значений
                paramPercent -= 1;
                paramPercent *= 100;
                if (paramPercent < thresholdValue) return -1;
                if (paramPercent == thresholdValue) return 0;
                return 1;


            }

            if (x.accuracy < y.accuracy)
            {
                paramPercent = (float)y.paramsCount / x.paramsCount;
                if (paramPercent < 1) return 1;
                paramPercent -= 1;
                paramPercent *= 100;
                if (paramPercent < thresholdValue) return 1;
                if (paramPercent == thresholdValue) return 0;
                return -1;

            }

            return 0;
        }

 
    }
}
