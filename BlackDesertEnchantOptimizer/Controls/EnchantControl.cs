using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDOEnchantOptimizerLib;

namespace BlackDesertEnchantOptimizer
{
    public partial class EnchantControl : UserControl
    {
        private FormMain mainForm;

        public EnchantControl(FormMain f)
        {
            mainForm = f;
            InitializeComponent();
            setCustomAppearance();

            SetData();

            memoryFragmentPriceChange();
            blackstonePriceChange();
            
            itemPriceChange();
            itemCostLvlDownChange();
            croneStoneChange();
            TypeChange();
            GradeChange();
            SetColors();
            ChangeColor();
            Cronestone_CheckedChanged();
            comboBoxItemLvl.SelectedIndex = 15;
            itemLvlChange();
        }

        private void SetData()
        {
            mainForm.Optimizer.MemoryFragment_price = Convert.ToInt32(TBMemoryFragment_price.Text);
            mainForm.Optimizer.BlackStone_price = Convert.ToInt32(TBBlackStone_price.Text);
            mainForm.Optimizer.Item = new Item(Convert.ToDouble(TBItem_price.Text), Convert.ToInt32(0), Grade.Green, ItemType.Armor);
            //comboBoxItemLvl.Select(0,15);
        }

        private void setCustomAppearance()
        {
            RBArmor.Appearance = Appearance.Button;
            RBAccessory.Appearance = Appearance.Button;
            RBWeapon.Appearance = Appearance.Button;
            RBBlue.Appearance = Appearance.Button;
            RBGreen.Appearance = Appearance.Button;
            RBYellow.Appearance = Appearance.Button;
            RBOrange.Appearance = Appearance.Button;
            CBCronestone.Appearance = Appearance.Button;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangeColor()
        {
            RBAccessory.BackColor = System.Drawing.ColorTranslator.FromHtml("#404348");
            RBArmor.BackColor = System.Drawing.ColorTranslator.FromHtml("#404348");
            RBWeapon.BackColor = System.Drawing.ColorTranslator.FromHtml("#404348");
            RBBlue.BackColor = System.Drawing.ColorTranslator.FromHtml("#404348");
            RBGreen.BackColor = System.Drawing.ColorTranslator.FromHtml("#404348");
            RBYellow.BackColor = System.Drawing.ColorTranslator.FromHtml("#404348");
            RBOrange.BackColor = System.Drawing.ColorTranslator.FromHtml("#404348");
            CBCronestone.BackColor = System.Drawing.ColorTranslator.FromHtml("#404348");
        }

        private void SetColors()
        {
            RBAccessory.FlatAppearance.CheckedBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            RBArmor.FlatAppearance.CheckedBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            RBWeapon.FlatAppearance.CheckedBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            RBBlue.FlatAppearance.CheckedBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            RBGreen.FlatAppearance.CheckedBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            RBYellow.FlatAppearance.CheckedBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            RBOrange.FlatAppearance.CheckedBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            CBCronestone.FlatAppearance.CheckedBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");

            RBAccessory.FlatAppearance.MouseOverBackColor= System.Drawing.ColorTranslator.FromHtml("#111111");
            RBArmor.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#111111");
            RBWeapon.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#111111");
            RBBlue.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#111111");
            RBGreen.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#111111");
            RBYellow.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#111111");
            RBOrange.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#111111");
            CBCronestone.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#111111");

            RBAccessory.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            RBArmor.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            RBWeapon.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            RBBlue.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            RBGreen.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            RBYellow.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            RBOrange.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            CBCronestone.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            /*
            TBBlackStone_price.BackColor = System.Drawing.ColorTranslator.FromHtml("#696E75");
            TBCroneStone.BackColor = System.Drawing.ColorTranslator.FromHtml("#696E75");
            TBItemCostLvlDown.BackColor = System.Drawing.ColorTranslator.FromHtml("#696E75");
            TBItem_lvl.BackColor = System.Drawing.ColorTranslator.FromHtml("#696E75");
            TBItem_price.BackColor = System.Drawing.ColorTranslator.FromHtml("#696E75");
            TBMemoryFragment_price.BackColor = System.Drawing.ColorTranslator.FromHtml("#696E75");*/
        }
        
        private void TypeChange()
        {
            if (RBArmor.Checked)
            {
                mainForm.Optimizer.Item.ItemType = ItemType.Armor;
                labelItemPriceLvl0.Text = "Item price lvl+0";
                labelBlackstonePrice.Text = "Black stone price";
                labelItemPriceLvlDown.Visible = false;
                TBItemCostLvlDown.Visible = false;
                labelMemoryFragmentPrice.Visible = true;
                TBMemoryFragment_price.Visible = true;

                comboBoxItemLvl.DisplayMember = "Description";
                comboBoxItemLvl.ValueMember = "Value";
                comboBoxItemLvl.DataSource = Enum.GetValues(typeof(ArmorOrWeaponLvl)).Cast<ArmorOrWeaponLvl>().Where(lvl=>lvl!= ArmorOrWeaponLvl.plus20)
                    .Select(value => new
                    {
                        (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                            typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                        value
                    })
                    .OrderBy(item => item.value)
                    .ToList();
            }

            if (RBWeapon.Checked)
            {
                mainForm.Optimizer.Item.ItemType = ItemType.Weapon;
                labelItemPriceLvl0.Text = "Item price lvl+0";
                labelBlackstonePrice.Text = "Black stone price";
                labelItemPriceLvlDown.Visible = false;
                TBItemCostLvlDown.Visible = false;
                labelMemoryFragmentPrice.Visible = true;
                TBMemoryFragment_price.Visible = true;

                comboBoxItemLvl.DisplayMember = "Description";
                comboBoxItemLvl.ValueMember = "Value";
                comboBoxItemLvl.DataSource = Enum.GetValues(typeof(ArmorOrWeaponLvl)).Cast<ArmorOrWeaponLvl>().Where(lvl => lvl != ArmorOrWeaponLvl.plus20)
                    .Select(value => new
                    {
                        (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                            typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                        value
                    })
                    .OrderBy(item => item.value)
                    .ToList();
            }

            if (RBAccessory.Checked)
            {
                mainForm.Optimizer.Item.ItemType = ItemType.Accessory;
                labelItemPriceLvl0.Text = "Current item price";
                labelBlackstonePrice.Text = "Accessory lvl+0";
                TBCroneStone.Text = "999999999";
                CBCronestone.Checked = true;
                labelItemPriceLvlDown.Visible = true;
                TBItemCostLvlDown.Visible = true;
                labelMemoryFragmentPrice.Visible = false;
                TBMemoryFragment_price.Visible = false;

                comboBoxItemLvl.DisplayMember = "Description";
                comboBoxItemLvl.ValueMember = "Value";
                comboBoxItemLvl.DataSource = Enum.GetValues(typeof(AccessoryLvl)).Cast<AccessoryLvl>().Where(lvl => lvl != AccessoryLvl.plus5)
                    .Select(value => new
                    {
                        (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                            typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                        value
                    })
                    .OrderBy(item => item.value)
                    .ToList();
            }                
        }

        private void GradeChange()
        {
            if (RBBlue.Checked)
                mainForm.Optimizer.Item.Grade = Grade.Blue;
            if (RBGreen.Checked)
                mainForm.Optimizer.Item.Grade = Grade.Green;
            if (RBYellow.Checked)
                mainForm.Optimizer.Item.Grade = Grade.Yellow;
            if (RBOrange.Checked)
                mainForm.Optimizer.Item.Grade = Grade.Orange;
        }
        
        private void RBWeapon_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColor();
            TypeChange();
        }        

        private void RBAccessory_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColor();
            TypeChange();
        }

        private void RBArmor_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColor();
            TypeChange();
        }
        private void croneStoneChange()
        {
            mainForm.Optimizer.CroneStoneCounter = Convert.ToInt32(TBCroneStone.Text);
        }

        private void BCalculate_Click(object sender, EventArgs e)
        {
            mainForm.Calculate();
            mainForm.ShowResult();
        }
       
        private void TBItemCostLvlDown_TextChanged(object sender, EventArgs e)
        {
            try
            {
                itemCostLvlDownChange();
                ((TextBox)sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Something is wrong, fill everything with +numbers and try it again.");
                ((TextBox)sender).BackColor = Color.Red;
            }
        }

        private void itemCostLvlDownChange()
        {
            mainForm.Optimizer.ItemCostLvlDown = Convert.ToDouble(TBItemCostLvlDown.Text);
        }

        private void CBCronestone_CheckedChanged(object sender, EventArgs e)
        {
            Cronestone_CheckedChanged();
        }

        private void Cronestone_CheckedChanged()
        {
            if (CBCronestone.Checked)
            {
                mainForm.Optimizer.CroneStoneEnch = true;
                LCroneStone.Visible = true;
                TBCroneStone.Visible = true;
            }
            else
            {
                mainForm.Optimizer.CroneStoneEnch = false;
                LCroneStone.Visible = false;
                TBCroneStone.Visible = false;
            }
        }

        private void RBBlue_CheckedChanged(object sender, EventArgs e)
        {
            GradeChange();
        }

        private void RBGreen_CheckedChanged(object sender, EventArgs e)
        {
            GradeChange();
        }

        private void RBOrange_CheckedChanged(object sender, EventArgs e)
        {
            GradeChange();
        }

        private void RBOrange_CheckedChanged_1(object sender, EventArgs e)
        {
            GradeChange();
        }
        private void TBItem_price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                itemPriceChange();
                ((TextBox) sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Something is wrong, fill everything with +numbers and try it again.");
                ((TextBox) sender).BackColor = Color.Red;
                
            }
        }
        private void itemPriceChange()
        {
                mainForm.Optimizer.Item.Price = Convert.ToDouble(TBItem_price.Text);
        }
     
        private void itemLvlChange()
        {
            //mainForm.item.Lvl = Convert.ToInt32(TBItem_lvl.Text);

            if (mainForm.Optimizer.Item.ItemType == ItemType.Accessory)
            {
                AccessoryLvl accessoryLvl;
                Enum.TryParse<AccessoryLvl>(comboBoxItemLvl.SelectedValue.ToString(), out accessoryLvl);
                mainForm.Optimizer.Item.Lvl = (int) accessoryLvl;

            }
            else
            {
                ArmorOrWeaponLvl armorlvl;
                Enum.TryParse<ArmorOrWeaponLvl>(comboBoxItemLvl.SelectedValue.ToString(), out armorlvl);
                mainForm.Optimizer.Item.Lvl = (int)armorlvl;
            }
        }

        private void TBBlackStone_price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                blackstonePriceChange();
                ((TextBox)sender).BackColor = System.Drawing.ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Something is wrong, fill everything with +numbers and try it again.");
                ((TextBox)sender).BackColor = Color.Red;
               
            }
        }

        private void blackstonePriceChange()
        {
            mainForm.Optimizer.BlackStone_price = Convert.ToInt32(TBBlackStone_price.Text);
        }

        private void TBMemoryFragment_price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                memoryFragmentPriceChange();
                ((TextBox)sender).BackColor = System.Drawing.ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Something is wrong, fill everything with +numbers and try it again.");
                ((TextBox) sender).BackColor = Color.Red;
               
            }
        }

        private void memoryFragmentPriceChange()
        {
            mainForm.Optimizer.MemoryFragment_price = Convert.ToInt32(TBMemoryFragment_price.Text);
        }

        private void TBCroneStone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                croneStoneChange();
                ((TextBox)sender).BackColor = System.Drawing.ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Something is wrong, fill everything with +numbers and try it again.");
                ((TextBox)sender).BackColor = Color.Red;
                
            }
        }

        private void buttonFsOpt_Click(object sender, EventArgs e)
        {
            mainForm.ShowFsOption();
        }

        private void comboBoxItemLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemLvlChange();
        }

        public void ItemlvlUp(double price)
        {

            if (RBAccessory.Checked)
            {
                if (comboBoxItemLvl.SelectedIndex < 4)
                {
                    TBItem_price.Text = price.ToString();
                    comboBoxItemLvl.SelectedIndex++;
                    itemLvlChange();
                }
            }
            else
            {
                if (comboBoxItemLvl.SelectedIndex < 19)
                {                   
                    comboBoxItemLvl.SelectedIndex++;
                    itemLvlChange();
                }
            }
        }
    }
}
