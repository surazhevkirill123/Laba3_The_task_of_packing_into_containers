using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba3_The_task_of_packing_into_containers
{
    class FFD
    {
        public static void FFD_DO(List<double> weights, List<List<double>> containers)
        {
            Console.WriteLine("\nFFD:");
            weights.Sort();
            weights.Reverse();

            int currentContainerIndex = 0;
            List<double> list = new List<double>();
            containers.Add(list);

            for (int i = 0; i < weights.Count; i++)
            {
                for (int j = 0; j < containers.Count(); j++)
                {
                    if (weights[i] <= 1 - containers[j].Sum())
                    {
                        currentContainerIndex = j;
                        break;
                    }
                }

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

            for (int j = 0; j < containers.Count(); j++)
            {
                for (int k = 0; k < containers[j].Count(); k++)
                {
                    Console.Write(containers[j][k] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
