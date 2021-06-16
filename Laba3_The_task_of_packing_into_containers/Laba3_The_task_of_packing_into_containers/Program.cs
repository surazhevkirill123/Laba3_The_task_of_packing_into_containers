using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba3_The_task_of_packing_into_containers
{
    class Program
    {
        public static List<double> weightsNF = new List<double>();
        public static List<List<double>> containersNF = new List<List<double>>();

        public static List<double> weightsFF = new List<double>();
        public static List<List<double>> containersFF = new List<List<double>>();

        public static List<double> weightsBF = new List<double>();
        public static List<List<double>> containersBF = new List<List<double>>();

        public static List<double> weightsFFD = new List<double>();
        public static List<List<double>> containersFFD = new List<List<double>>();

        static void Main(string[] args)
        {
            ZapolnitelListov.ZapolnitelListov_DO(weightsNF);
            ZapolnitelListov.ZapolnitelListov_DO(weightsFF);
            ZapolnitelListov.ZapolnitelListov_DO(weightsBF);
            ZapolnitelListov.ZapolnitelListov_DO(weightsFFD);
            NF.NF_DO(weightsNF, containersNF);
            FF.FF_DO(weightsFF, containersFF);
            BF.BF_DO(weightsBF, containersBF);
            FFD.FFD_DO(weightsFFD, containersFFD);
        }

    }
}
