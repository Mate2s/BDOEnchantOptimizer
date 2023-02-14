using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using BDOEnchantOptimizerLib;

namespace BlackDesertEnchantOptimizer
{
    public partial class FsTableControl : UserControl
    {
        private FormMain mainForm;
       
        public FsTableControl(FormMain f)
        {
            mainForm = f;
            InitializeComponent();

            typeof(DataGridView).InvokeMember(
                "DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null,
                dataGridViewFs,
                new object[] {true});
        }

        public string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        public void ReportFS(FSRow []FSTable)
        {
            dataGridViewFs.Rows.Clear();
            for (int failstacks = mainForm.Optimizer.FailstackStart + 1; failstacks < mainForm.Optimizer.FailstackEnd; failstacks++)
            {
                string enchcount = $"{FSTable[failstacks].EnchCountAtCurrentLvl:0,0.00}";
                string totalprice = $"{FSTable[failstacks].TotalFsPrice:0,0.00}";
                string itemtype = FSTable[failstacks].FsItem.ItemType == ItemType.Accessory
                    ? (FSTable[failstacks].FsItem.ItemType.ToString() + " " + GetEnumDescription((AccessoryLvl)FSTable[failstacks].FsItem.Lvl))
                    : FSTable[failstacks].FsItem.ItemType.ToString() + " " + GetEnumDescription((ArmorOrWeaponLvl)FSTable[failstacks].FsItem.Lvl);

                dataGridViewFs.Rows.Add(FSTable[failstacks].Failstacks,
                itemtype,
                enchcount,
                totalprice,
                FSTable[failstacks].Fsfrom.ToString());
            }
        }

        private void BCalculate_Click(object sender, EventArgs e)
        {
            mainForm.Calculate();
            mainForm.ShowResult();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
    
}
