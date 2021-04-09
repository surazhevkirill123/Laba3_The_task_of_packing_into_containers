using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba3_The_task_of_packing_into_containers
{
    class Program
    {
        public static List<double> weightsNF = new List<double>() { 0.83, 0.53, 0.18, 0.69, 0.71, 0.89, 0.43, 0.81, 0.01, 0.91, 0.12, 0.28, 0.08, 0.68, 0.37, 0.02, 0.6, 0.34, 0.15, 0.64 };
        public static List<List<double>> containersNF = new List<List<double>>();

        public static List<double> weightsFF = new List<double>() { 0.83, 0.53, 0.18, 0.69, 0.71, 0.89, 0.43, 0.81, 0.01, 0.91, 0.12, 0.28, 0.08, 0.68, 0.37, 0.02, 0.6, 0.34, 0.15, 0.64 };
        public static List<List<double>> containersFF = new List<List<double>>();

        public static List<double> weightsBF = new List<double>() { 0.83, 0.53, 0.18, 0.69, 0.71, 0.89, 0.43, 0.81, 0.01, 0.91, 0.12, 0.28, 0.08, 0.68, 0.37, 0.02, 0.6, 0.34, 0.15, 0.64 };
        public static List<List<double>> containersBF = new List<List<double>>();

        public static List<double> weightsFFD = new List<double>() { 0.83, 0.53, 0.18, 0.69, 0.71, 0.89, 0.43, 0.81, 0.01, 0.91, 0.12, 0.28, 0.08, 0.68, 0.37, 0.02, 0.6, 0.34, 0.15, 0.64 };
        public static List<List<double>> containersFFD = new List<List<double>>();

        static void Main(string[] args)
        {
            NF.NF_DO(weightsNF, containersNF);
            FF.FF_DO(weightsFF, containersFF);
            BF.BF_DO(weightsBF, containersBF);
            FFD.FFD_DO(weightsFFD, containersFFD);
        }

    }
}
