using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDOEnchantOptimizerLib.Tables
{
    public class EnchantTable
    {       
        public Grade Grade;
        public ItemType ItemType;
        public double ChancePerFsConvertionConstant;
        public double ChancePerFsOverSoftcapConvertionConstant;
        public List<EnchantTableRow> enchantTableRows= new List<EnchantTableRow>();
           
        public EnchantTable()
        {
            CalcAllRows();
        }

        public double GetChance(int failstack,int enchLvl)
        {
            if (failstack >= enchantTableRows.Where(x => x.Level == enchLvl).SingleOrDefault().CapFS)
                return enchantTableRows.Where(x => x.Level == enchLvl).SingleOrDefault().CapChance;

            if (failstack > enchantTableRows.Where(x => x.Level == enchLvl).SingleOrDefault().SoftcapFS)
                return enchantTableRows.Where(x => x.Level == enchLvl).SingleOrDefault().StartChance +
                    enchantTableRows.Where(x => x.Level == enchLvl).SingleOrDefault().ChancePerFS * enchantTableRows.Where(x => x.Level == enchLvl).SingleOrDefault().SoftcapFS +
                    enchantTableRows.Where(x => x.Level == enchLvl).SingleOrDefault().ChancePerFSOverSoftcap * (failstack- enchantTableRows.Where(x => x.Level == enchLvl).SingleOrDefault().SoftcapFS);

            return enchantTableRows.Where(x => x.Level == enchLvl).SingleOrDefault().StartChance +
                    enchantTableRows.Where(x => x.Level == enchLvl).SingleOrDefault().ChancePerFS * failstack;
        }

        public void CalcAllRows()
        {
            foreach(var x in enchantTableRows)
            {
                x.CalcFromStartChance(ChancePerFsConvertionConstant, ChancePerFsOverSoftcapConvertionConstant);
            }
        }
    }
}
