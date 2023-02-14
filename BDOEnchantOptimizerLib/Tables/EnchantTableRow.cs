using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BDOEnchantOptimizerLib.Tables
{
    public class EnchantTableRow
    {        
        public int Level { get; set; }
        public double StartChance { get; set; }
        public double ChancePerFS { get; set; }
        public int SoftcapFS { get; set; }
        public double SoftcapChance { get; set; }
        public double ChancePerFSOverSoftcap { get; set; }
        public int CapFS { get; set; }
        public double CapChance { get; set; }

        public EnchantTableRow()
        {
            CalcFromStartChance();
        }

        public void CalcFromStartChance(double enchConstant=0.1,double enchConstantOversoftcap=0.02, double softcap = 0.7, double hardcap = 0.9)
        {      
            if(StartChance==1)
            {
                ChancePerFS = 0;
                SoftcapFS = 0;
                SoftcapChance = 1;
                ChancePerFSOverSoftcap = 0;
                CapChance = 1;
                CapFS = 0;
            }
            else
            {                
                    ChancePerFS = StartChance * enchConstant;
                    SoftcapFS = (int)Math.Round((SoftcapChance - StartChance) / ChancePerFS);                    
                    ChancePerFSOverSoftcap = StartChance * enchConstantOversoftcap;                    
                    CapFS = (int)Math.Ceiling((CapChance - SoftcapChance) / ChancePerFSOverSoftcap) + SoftcapFS;
            }            
        }

    }
}
