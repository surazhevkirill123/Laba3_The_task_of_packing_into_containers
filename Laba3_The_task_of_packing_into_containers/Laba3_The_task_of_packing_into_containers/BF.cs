using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba3_The_task_of_packing_into_containers
{
    class BF
    {
        public static void BF_DO(List<double> weights, List<List<double>> containers)
        {
            Console.WriteLine("\nBF:");
            int currentContainerIndex = 0;
            List<double> list = new List<double>();
            containers.Add(list);
            double maxSum = 0;

            for (int i = 0; i < weights.Count; i++)
            {
                for (int j = 0; j < containers.Count(); j++)
                {
                    if (weights[i] <= 1 - containers[j].Sum() && containers[j].Sum() > maxSum)
                    {
                        maxSum = containers[j].Sum();
                        currentContainerIndex = j;
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

            int emptyContainers = 0;
            for (int j = 0; j < containers.Count(); j++)
            {               
                if(containers[j].Sum()==0)
                {
                    emptyContainers++;
                }                   
            }
            Console.WriteLine(containers.Count() - emptyContainers);
        }
    }
}
