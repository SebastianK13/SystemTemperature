using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SystemTemperature.Service
{
    class CpuUsage
    {
        List<List<double>> CoresAVG;
        List<double> Core1AVG;
        List<double> Core2AVG;
        List<double> Core3AVG;
        List<double> Core4AVG;
        List<double> Core5AVG;
        List<double> Core6AVG;
        int coreIndex;
        double currentUsage;
        public List<double> minUsage;
        public List<double> maxUsage;
        //public double minUsageC1=0;
        //public double maxUsageC1=0;
        //public double minUsageC2=0;
        //public double maxUsageC2=0;
        //public double minUsageC3=0;
        //public double maxUsageC3=0;
        //public double minUsageC4=0;
        //public double maxUsageC4=0;
        //public double minUsageC5=0;
        //public double maxUsageC5=0;
        //public double minUsageC6=0;
        //public double maxUsageC6=0;

        public CpuUsage()
        {
            Core1AVG = new List<double>();
            Core2AVG = new List<double>();
            Core3AVG = new List<double>();
            Core4AVG = new List<double>();
            Core5AVG = new List<double>();
            Core6AVG = new List<double>();
            CoresAVG = new List<List<double>> { 
                Core1AVG,
                Core2AVG,
                Core3AVG,
                Core4AVG,
                Core5AVG,
                Core6AVG,
            };
            minUsage = new List<double> {0,0,0,0,0,0};
            maxUsage = new List<double> { 0, 0, 0, 0, 0, 0 };
        }
        public double AvgUsagePerCore(int core, double usage)
        {
            coreIndex = core;
            currentUsage = usage;
            var avgUsage = Math.Round(UpdateLists().Average(),1);
            UpdateListOfLists();
            UpdateMinMaxUsage();

            return avgUsage;
        }
        private List<double> UpdateLists()
        {
            switch (coreIndex)
            {
                case 1:
                    Core1AVG.Add(currentUsage);
                    return Core1AVG;
                case 2:
                    Core2AVG.Add(currentUsage);
                    return Core2AVG;
                case 3:
                    Core3AVG.Add(currentUsage);
                    return Core3AVG;
                case 4:
                    Core4AVG.Add(currentUsage);
                    return Core4AVG;
                case 5:
                    Core5AVG.Add(currentUsage);
                    return Core5AVG;
                case 6:
                    Core6AVG.Add(currentUsage);
                    return Core6AVG;
                default:
                    return null;
            }
        }
        private void UpdateListOfLists()
        {
            CoresAVG[0] = Core1AVG;
            CoresAVG[1] = Core2AVG;
            CoresAVG[2] = Core3AVG;
            CoresAVG[3] = Core4AVG;
            CoresAVG[4] = Core5AVG;
            CoresAVG[5] = Core6AVG;
        }
        private void UpdateMinMaxUsage()
        {
            if(currentUsage > 0)
            {
                if (minUsage[coreIndex-1] == 0 && maxUsage[coreIndex-1] == 0)
                {
                    minUsage[coreIndex-1] = Math.Round(currentUsage,1);
                    maxUsage[coreIndex-1] = Math.Round(currentUsage, 1);
                }
                else if (minUsage[coreIndex-1] > currentUsage)
                {
                    minUsage[coreIndex-1] = Math.Round(currentUsage, 1);
                }
                else if (maxUsage[coreIndex-1] < currentUsage)
                {
                    maxUsage[coreIndex-1] = Math.Round(currentUsage, 1);
                }
            }
        }
    }
}
