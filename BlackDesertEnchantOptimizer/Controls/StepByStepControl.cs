using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using BDOEnchantOptimizerLib;

namespace BlackDesertEnchantOptimizer
{
    public partial class StepByStepControl : UserControl
    {
        private FormMain mainForm;
        public StepByStepControl(FormMain mainform)
        {
            mainForm = mainform;
            InitializeComponent();
            CBIntro.Appearance = Appearance.Button;
            CBIntro.Checked = false;
            CBIntro.Checked = true;
            SetColor();
            SetIntro();
            SetStepByStep();
        }


        private void SetColor()
        {
            CBIntro.FlatAppearance.CheckedBackColor = System.Drawing.ColorTranslator.FromHtml("#36393E");
            CBIntro.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#111111");
            CBIntro.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
        }

        private void CBIntroChange()
        {

        }

        private void SetStepByStep()
        {
            
        }

        private void SetIntro()
        {
            LIntro.Text = "At the start you need cheap item +14/+15 and some character with negative karma for degrade your item from +15 to +14." +
                "\nFor degrade item you need: " +
                "\n-login character with negative karma" +
                "\n-equip +15item" +
                "\n-die once or more until item is +14" +
                "\n\nOR\n" +
                "\n-visit priest at church in Heidel / Velia ..." ;
        }

        private void dataGridViewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        internal void SetStepByStep(EnchRow bestRow,int enchItemLvl,Item enchItem)
        {
            var lvl = enchItem.ItemType == ItemType.Accessory
                ? GetEnumDescription((AccessoryLvl)(enchItemLvl + 1))
                : GetEnumDescription((ArmorOrWeaponLvl)(enchItemLvl + 1));

            textBoxStepByStep.Text = "";
            int jump = 1;
            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.Append("Everything is in average so if you will enchant only one item then result can be different(RNG is RNG) but if u will enchant 1000x u will get same results.\r\n");

            sb.Append(string.Format(
                   "\r\nFor enchant to lvl {0} you need:\r\n* {2:0,0} silvers\r\n*do {1} failstacks\r\n*start ench your item at {1} failstacks\r\n*Try it {3:0,0.00} \r\n*Repair with {4}\r\n*Cronestone used: {5}\r\n\r\n",
                   lvl, bestRow.Failstack, bestRow.TotalCost, bestRow.CountOfTry, bestRow.RepairType,
                   bestRow.Cronestone));
            sb.Append("For failstacking use option \"Durable\"(if possible).\r\n");
            sb.Append("Materials what you need for fs:\r\n");

            Item fsitemstart = mainForm.Optimizer.FSTable[1].FsItem;
            Item fsitemm = mainForm.Optimizer.FSTable[1].FsItem;
            var list = new[] { new { item = fsitemstart, counter = 0 } }.ToList();
            int itemsnumber = 1;
            int count = 0;
            List<FSRow> fsrows = new List<FSRow>(); 

            for (int fs = bestRow.Failstack; fs != 0; fs = mainForm.Optimizer.FSTable[fs].Fsfrom)
            {
                fsrows.Add(mainForm.Optimizer.FSTable[fs]);               
            }

            var neco = from fsrow in fsrows
                        group fsrow by fsrow.FsItem.ItemType into g
                        select new { type = g.Key, FSRow = g.ToList() };
            double[] counteraccessories = new double[5];

            for(int i =0;i<5; i++)
            {
                counteraccessories[i] = new double();
                counteraccessories[i] = 0;
            }

            double countbs = 0;
            double countcontbs = 0;
           
            foreach (var type in neco)
            {
                if (type.type == ItemType.Accessory)
                {
                    var groupedbylvl = from fsrow in type.FSRow
                               group fsrow by fsrow.FsItem.Lvl into g
                               select new { type = g.Key, FSRow = g.ToList() };

                    foreach(var rowgroupedbylvl in groupedbylvl)
                    {
                        foreach (var row in rowgroupedbylvl.FSRow)
                        {
                            if (row.FsItem.Lvl == 0)
                            {
                                if (counteraccessories[row.FsItem.Lvl] == 0)                                
                                    counteraccessories[row.FsItem.Lvl] = row.EnchCountAtCurrentLvl * 2;                              
                                else                               
                                    counteraccessories[row.FsItem.Lvl] = row.EnchCountAtCurrentLvl * counteraccessories[row.FsItem.Lvl] + row.EnchCountAtCurrentLvl * 2;        
                            }
                            else
                            {
                                if (counteraccessories[row.FsItem.Lvl] == 0)                               
                                    counteraccessories[row.FsItem.Lvl] = row.EnchCountAtCurrentLvl;                                
                                else                               
                                    counteraccessories[row.FsItem.Lvl] = row.EnchCountAtCurrentLvl * counteraccessories[row.FsItem.Lvl] + row.EnchCountAtCurrentLvl;                               
                                
                                if (counteraccessories[0] == 0)                               
                                    counteraccessories[0] = row.EnchCountAtCurrentLvl;                               
                                else                               
                                    counteraccessories[0] = row.EnchCountAtCurrentLvl * counteraccessories[0] + row.EnchCountAtCurrentLvl;
                            }
                        }
                    }    
                }
                else
                {
                    var groupedbylvl = from fsrow in type.FSRow
                                       group fsrow by fsrow.FsItem.Lvl into g
                                       select new { type = g.Key, FSRow = g.ToList() };

                    foreach (var rowgroupedbylvl in groupedbylvl)
                    {
                        foreach (var row in type.FSRow)
                        {
                            if (row.FsItem.Lvl < 15)
                            {
                                if (countbs == 0)                                
                                    countbs = row.EnchCountAtCurrentLvl;                               
                                else                               
                                    countbs = row.EnchCountAtCurrentLvl * countbs + row.EnchCountAtCurrentLvl;                               
                            }
                            else
                            {
                                if (countcontbs == 0)                               
                                    countcontbs = row.EnchCountAtCurrentLvl;                               
                                else                                
                                    countcontbs = row.EnchCountAtCurrentLvl * countcontbs + row.EnchCountAtCurrentLvl;                                
                            }
                        }
                    }
                }
            }
            
            for (int i = 0; i < 5; i++)
            {
                if (counteraccessories[i] != 0)
                    sb.Append("accessories " + GetEnumDescription((AccessoryLvl)(i)) + ": " + counteraccessories[i] + "\r\n");
            }

            if (countbs != 0)
                sb.Append("blackstone :" + countbs + "\r\n");
            if (countcontbs != 0)
                sb.Append("concentrated lacksotnes :" + countcontbs + "\r\n");

            sb.Append("\r\nHow to do failstaks:\r\n");
            
            for (int fs=1;fs<= bestRow.Failstack;fs=fs+jump)
            {                
                Item fsitem = mainForm.Optimizer.FSTable[fs].FsItem;
                int fromfs= mainForm.Optimizer.FSTable[fs].Fsfrom;
                jump = 1;

                if (fsitem.Lvl>=15)
                    jump = fsitem.Lvl - 13;
                
                if (fsitem.ItemType==ItemType.Accessory)                
                    sb.Append("-from failstacks "+ fromfs+" to " + fs.ToString() + " use accessories lvl "+ GetEnumDescription((AccessoryLvl)(fsitem.Lvl))+ " and lvl+0\r\n");                
                else
                    sb.Append("-from failstacks " + fromfs + " to " + fs.ToString()+" use armor lvl "+ GetEnumDescription((ArmorOrWeaponLvl)(fsitem.Lvl)) + " and blackstone\r\n");
            }     

            textBoxStepByStep.Text = sb.ToString();
        }

        private void CBIntro_CheckedChanged(object sender, EventArgs e)
        {
            if(CBIntro.Checked)
            {
                CBIntro.Text = "Intro +";
                LIntro.Visible = true;
            }
            else
            {
                CBIntro.Text = "Intro -";
                LIntro.Visible = false;
            }
        }

        private void BFailstackOption_Click(object sender, EventArgs e)
        {
            mainForm.ShowFsOption();
        }

        private void buttonFsOptn_Click(object sender, EventArgs e)
        {
            
            mainForm.ShowEnch();
        }
        public string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)            
                return attributes[0].Description;           
            else            
                return value.ToString();            
        }
    }
}
