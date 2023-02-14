using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDOEnchantOptimizerLib
{
    public class EnchRow
    {
        private int failstack;
        private double totalCost;
        private double totalCostWithoutFS;
        private double countOfTry;
        private double durabilityDown;
        private string repairType;
        private double fsCost;
        private double blackstoneCost;
        private bool cronestone;

        public EnchRow()
        {
            this.failstack = 0;
            this.totalCost = 0;
            totalCostWithoutFS = 0;
            countOfTry = 0;
            this.durabilityDown = 0;
            this.fsCost = 0;
            this.blackstoneCost = 0;
            this.cronestone = false;
            repairType = "";
        }

        public EnchRow(int failstack, double totalCost, double totalCostWithoutFs, double countOfTry, double durabilityDown, double fsCost, double blackstoneCost, bool cronestone,string repairtype)
        {
            this.failstack = failstack;
            this.totalCost = totalCost;
            totalCostWithoutFS = totalCostWithoutFs;
            this.countOfTry = countOfTry;
            this.durabilityDown = durabilityDown;
            this.fsCost = fsCost;
            this.blackstoneCost = blackstoneCost;
            this.cronestone = cronestone;
            repairType = repairtype;
        }

        public string RepairType
        {
            get { return repairType; }
            set { repairType = value; }
        }

        public int Failstack
        {
            get { return failstack; }
            set { failstack = value; }
        }

        public double TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public double TotalCostWithoutFs
        {
            get { return totalCostWithoutFS; }
            set { totalCostWithoutFS = value; }
        }

        public double CountOfTry
        {
            get { return countOfTry; }
            set { countOfTry = value; }
        }

        public double DurabilityDown
        {
            get { return durabilityDown; }
            set { durabilityDown = value; }
        }

        public double FsCost
        {
            get { return fsCost; }
            set { fsCost = value; }
        }

        public double BlackstoneCost
        {
            get { return blackstoneCost; }
            set { blackstoneCost = value; }
        }

        public bool Cronestone
        {
            get { return cronestone; }
            set { cronestone = value; }
        }

        /*
        sb.Append("\r\n" + "Failstacks: " + failstacks + " | total cost: " + totalcost +
                                          " | cost without fs: " + (totalcost - failstackscost) + " | numberOfTryToSuccess: " +
                                          numberOfTryToSuccess + " | durabilitydown: " + durabilitydown.ToString() +
                                          " | failstackcost: " + failstackscost.ToString() +
                                          " | BlackstoneCostToSuccess: " + BlackstoneCostToSuccess + output);*/
    }
}
