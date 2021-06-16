using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3_The_task_of_packing_into_containers
{
    class ZapolnitelListov
    {
        public static int elementsCount = 10000;
        public static void ZapolnitelListov_DO(List<double> weights)
        {
            Random rnd = new Random();
            for (int i = 0; i < elementsCount; i++)
            {
                weights.Add(rnd.NextDouble());
            }
        }
    }
}
