using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba3_The_task_of_packing_into_containers
{
    class NF
    {
        public static void NF_DO(List<double> weights, List<List<double>> containers)
        {
            Console.WriteLine("\nNF:");
            int currentContainerIndex = 0;
            List<double> list = new List<double>();
            containers.Add(list);

            for (int i = 0; i < weights.Count; i++)
            {
                if (weights[i] <= 1 - containers[currentContainerIndex].Sum())
                {
                    containers[currentContainerIndex].Add(weights[i]);
                }

                else
                {
                    i--;
                    currentContainerIndex++;
                    List<double> list1 = new List<double>();
                    containers.Add(list1);
                }
            }

            Console.WriteLine(containers.Count());
        }
    }
}
