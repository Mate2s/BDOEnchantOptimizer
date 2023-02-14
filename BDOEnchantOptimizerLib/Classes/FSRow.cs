using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDOEnchantOptimizerLib
{
    public class FSRow
    {
        private int failstacks;
        private int fsfrom;
        private Item fsItem;
        private double enchCountAtCurrentLvl;
        private double totalFSPrice;

        public FSRow()
        {
            this.failstacks = 0;
            this.fsfrom = 0;
            this.fsItem = new Item();
            this.enchCountAtCurrentLvl = 0;
            totalFSPrice = double.MaxValue;
        }

        public FSRow(int failstacks, int fsfrom, Item fsItem, double enchCountAtCurrentLvl, double totalFsPrice)
        {
            this.failstacks = failstacks;
            this.fsfrom = fsfrom;
            this.fsItem = fsItem;
            this.enchCountAtCurrentLvl = enchCountAtCurrentLvl;
            totalFSPrice = totalFsPrice;
        }

        public int Failstacks
        {
            get { return failstacks; }
            set { failstacks = value; }
        }

        public int Fsfrom
        {
            get { return fsfrom; }
            set { fsfrom = value; }
        }

        public Item FsItem
        {
            get { return fsItem; }
            set { fsItem = value; }
        }

        public double EnchCountAtCurrentLvl
        {
            get { return enchCountAtCurrentLvl; }
            set { enchCountAtCurrentLvl = value; }
        }

        public double TotalFsPrice
        {
            get { return totalFSPrice; }
            set { totalFSPrice = value; }
        }
    }
}
