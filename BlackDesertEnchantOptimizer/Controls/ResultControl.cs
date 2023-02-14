using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDOEnchantOptimizerLib;

namespace BlackDesertEnchantOptimizer
{
    public partial class ResultControl : UserControl
    {
        private FormMain mainForm;
        private double bestRowCost;
        private Item currentEnchItem;
        private EnchRow bestRoww;

        public ResultControl(FormMain mainform)
        {
            mainForm = mainform;
            InitializeComponent();
            typeof(DataGridView).InvokeMember(
                "DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null,
                dataGridViewResult,
                new object[] { true });
        }

        public void ReportEnch(string best, string total)
        {
            LBestResult.Text = best;         
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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

        internal void ReportEnch(EnchRow[] enchTable, EnchRow bestRow,int enchItemLvl,Item enchItem)
        {
            dataGridViewResult.Rows.Clear();
            var lvl = enchItem.ItemType == ItemType.Accessory
                ? GetEnumDescription((AccessoryLvl)(enchItemLvl + 1))
                : GetEnumDescription((ArmorOrWeaponLvl)(enchItemLvl + 1));

            double CostEnchPlusCurrentItem = enchItem.Price + bestRow.TotalCost;
            bestRowCost = bestRow.TotalCost;
            currentEnchItem = enchItem;
            bestRoww= bestRow;

            if (enchItem.ItemType==ItemType.Accessory)
            {
                LBestResult.Text =
                string.Format(
                    "For enchant to lvl {0} you need:\n" +
                    "* {2:0,0} silvers ({6:0,0}, mp: {7:0,0})\n " +
                    "*do {1} failstacks (use Failstack Table/Step by step)\n" +
                    "*start ench your item at {1} failstacks\n*Try it {3:0,0.00} \n" +
                    "*Repair with {4}\n" +
                    "*Cronestone used: {5}\n\r",
                    lvl, bestRow.Failstack, bestRow.TotalCost, bestRow.CountOfTry, bestRow.RepairType,
                    bestRow.Cronestone, CostEnchPlusCurrentItem, CostEnchPlusCurrentItem/0.845);
            }
            else
            {
                LBestResult.Text =
                string.Format(
                    "For enchant to lvl {0} you need:\n" +
                    "* {2:0,0} silvers\n " +
                    "*do {1} failstacks (use Failstack Table/Step by step)\n" +
                    "*start ench your item at {1} failstacks\n*Try it {3:0,0.00} \n" +
                    "*Repair with {4}\n" +
                    "*Cronestone used: {5}\n\r",
                    lvl, bestRow.Failstack, bestRow.TotalCost, bestRow.CountOfTry, bestRow.RepairType,
                    bestRow.Cronestone);
            }


            for (int failstacks = mainForm.Optimizer.FailstackStart; failstacks < mainForm.Optimizer.FailstackEnd; failstacks++)
            {
                string totalcost = $"{enchTable[failstacks].TotalCost:0,0.00}";
                string countoftry = $"{enchTable[failstacks].CountOfTry}";
                string durabilitydown = $"{enchTable[failstacks].DurabilityDown:0,0.00}";
                string fscost = $"{enchTable[failstacks].FsCost:0,0.00}";
                string bscost = $"{enchTable[failstacks].BlackstoneCost:0,0.00}";
                string totalcostwithoutfs = $"{enchTable[failstacks].TotalCostWithoutFs:0,0.00}";

                dataGridViewResult.Rows.Add(enchTable[failstacks].Failstack,
                    totalcost,
                    countoftry,
                    enchTable[failstacks].RepairType,
                    enchTable[failstacks].Cronestone,
                    durabilitydown,
                    fscost,
                    bscost,
                    totalcostwithoutfs);
            }
            dataGridViewResult.ClearSelection();
            dataGridViewResult.Rows[bestRow.Failstack].Selected = true;
            dataGridViewResult.FirstDisplayedScrollingRowIndex = dataGridViewResult.SelectedRows[0].Index;

        }        

        private void BCalculate_Click(object sender, EventArgs e)
        {                   
            mainForm.SetUpperEnch(currentEnchItem.Price + Convert.ToDouble(dataGridViewResult.SelectedCells[1].Value.ToString()));          
            mainForm.ShowEnch();
            /*
            mainForm.CalculateFs();
            mainForm.ShowFsTable();*/
        }

        private void buttonFsOpt_Click(object sender, EventArgs e)
        {
            mainForm.ShowStepByStep();
        }

        private void LBestResult_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.ShowEnch();
        }
    }
}
