using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDOEnchantOptimizerLib;

namespace BlackDesertEnchantOptimizer
{
    public partial class FsControl : UserControl
    {
        private FormMain mainForm;
        public FsControl(FormMain mainform)
        {
            mainForm = mainform;
            InitializeComponent();
            CBAccessory.Appearance= Appearance.Button;
            checkBoxArmor.Appearance= Appearance.Button;
            checkBoxValuePack.Appearance=Appearance.Button;
            
            foreach (var accessorygrp in mainForm.Optimizer.AccessoryGroup)
            {
                CBAccGroup.Items.Add(accessorygrp.Name);
            }
            foreach (var armorgrp in mainForm.Optimizer.FSArmorGroup)
            {
                CBFSArmor.Items.Add(armorgrp.Name);
            }
            foreach (var lvl in mainForm.Optimizer.FSArmorLvlGroup)
            {
                CBFSArmorLvl.Items.Add(lvl);
            }

            tbConcentratedBlackstone.Text = 1000000.ToString();
            CBFSArmorLvl.Text = ItemLvl.TET.ToString();
            CBAccGroup.Text = "cheapest30";
            CBFSArmor.Text = "Armor of Hercules";
            CBFSItem_type.Text = "Armor";
            TBFSBlackstone_price.Text = 1.ToString();
            TBFSBlackstone_price.Text = 170000.ToString();
            SetFsItemGrade();
            PermanentFreeStartFSChange();

            SetColor();
            acessoryGroupChange();
            armorGroupChange();
            typeFSChange();
            TbConcentratedBlackstoneChange();
            ValuePackChange();
            CBAccessory.Checked = false;
            checkBoxArmor.Checked = false;
        }

        private void SetFsItemGrade()
        {
            comboBoxFsItemGrade.DisplayMember = "Name";
            comboBoxFsItemGrade.ValueMember = "Value";
            comboBoxFsItemGrade.DataSource = Enum.GetValues(typeof(Grade)).Cast<Grade>()
                .Select(value => value)
                .OrderBy(item => item)
                .ToList();
            comboBoxFsItemGrade.SelectedIndex = 0;
        }

        private void SetColor()
        {
            CBAccessory.FlatAppearance.CheckedBackColor = System.Drawing.ColorTranslator.FromHtml("#36393E");
            checkBoxArmor.FlatAppearance.CheckedBackColor = System.Drawing.ColorTranslator.FromHtml("#36393E");
            checkBoxValuePack.FlatAppearance.CheckedBackColor = System.Drawing.ColorTranslator.FromHtml("#36393E");

            CBAccessory.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#111111");
            checkBoxArmor.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#111111");
            checkBoxValuePack.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#111111");

            CBAccessory.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            checkBoxArmor.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
            checkBoxValuePack.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#1C1C1C");
        }

        //asdasddasasdasdasd
        private void typeFSChange()
        {
            if (CBFSItem_type.Text == "Armor")
                mainForm.Optimizer.FailstackItem.ItemType = ItemType.Armor;
            if (CBFSItem_type.Text == "Weapon")
                mainForm.Optimizer.FailstackItem.ItemType = ItemType.Weapon;
            if (CBFSItem_type.Text == "Accesories")
                mainForm.Optimizer.FailstackItem.ItemType = ItemType.Armor;
        }
        private void acessoryGroupChange()
        {
            var group = (from a in mainForm.Optimizer.AccessoryGroup
                         where a.Name == CBAccGroup.Text
                         select a).FirstOrDefault();

            TBAcc0.Text = Convert.ToString(group.PriceAcessory0);
            TBAccpri.Text = Convert.ToString(group.PriceAcessoryPri);
            TBAccDuo.Text = Convert.ToString(group.PriceAcessoryDuo);
            TBAccTri.Text = Convert.ToString(group.PriceAcessoryTri);
            TBAccTet.Text = Convert.ToString(group.PriceAcessoryTet);
            TBAccPen.Text = Convert.ToString(group.PriceAcessoryPen);
        }

        private void TbConcentratedBlackstoneChange()
        {
            mainForm.Optimizer.BetterBlackstone_price = Convert.ToDouble(tbConcentratedBlackstone.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TbConcentratedBlackstoneChange();
                ((TextBox)sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                NumberException(exception, sender, e);
            }
        }

        private void FsControl_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxArmor_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                mainForm.Optimizer.UseFsItem15plus = true;
                cb.Text = "ON";
                panel3.Visible = true;
            }
            else
            {
                mainForm.Optimizer.UseFsItem15plus = false;
                cb.Text = "OFF";
                panel3.Visible = false;
            }
        }

        private void fSArmorLvlGroupChange()
        {
            var group = (from a in mainForm.Optimizer.FSArmorLvlGroup
                         where a.ToString() == CBFSArmorLvl.Text
                         select a).FirstOrDefault();

            mainForm.Optimizer.FSArmorLvlMax = Convert.ToInt32(group);
        }

        private void armorGroupChange()
        {
            var group = (from a in mainForm.Optimizer.FSArmorGroup
                         where a.Name == CBFSArmor.Text
                         select a).FirstOrDefault();

            TBArmor0.Text = Convert.ToString(group.PriceAcessory0);
            TBArmorPRI.Text = Convert.ToString(group.PriceAcessoryPri);
            TBArmorDUO.Text = Convert.ToString(group.PriceAcessoryDuo);
            TBArmorTRI.Text = Convert.ToString(group.PriceAcessoryTri);
            TBArmorTET.Text = Convert.ToString(group.PriceAcessoryTet);
            TBArmorPEN.Text = Convert.ToString(group.PriceAcessoryPen);
        }        

        private void CBAccessory_CheckedChanged(object sender, EventArgs e)
        {
            if (CBAccessory.Checked)
            {
                mainForm.Optimizer.UseFsAccessory = true;
                CBAccessory.Text = "ON";
                panel2.Visible = true;
            }
            else
            {
                mainForm.Optimizer.UseFsAccessory = false;
                CBAccessory.Text = "OFF";
                panel2.Visible = false;
            }
        }

        private void checkBoxArmor_CheckedChanged_1(object sender, EventArgs e)
        {
            checkBoxArmor_CheckedChanged(sender, e);
        }

        private void CBFSItem_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeFSChange();
        }

        private void TBFSBlackstone_price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mainForm.Optimizer.FSBlackstone_price = Convert.ToDouble(TBFSBlackstone_price.Text);
                ((TextBox)sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                NumberException(exception, sender, e);
            }
        }

        private void CBAccGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            acessoryGroupChange();
        }

        private void TBAcc0_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mainForm.Optimizer.Acessory_price[0] = Convert.ToDouble(TBAcc0.Text);
                ((TextBox)sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                NumberException(exception, sender, e);
            }
        }

        private void TBAccpri_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mainForm.Optimizer.Acessory_price[1] = Convert.ToDouble(TBAccpri.Text);
                ((TextBox)sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                NumberException(exception, sender, e);
            }
        }

        private void TBAccDuo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mainForm.Optimizer.Acessory_price[2] = Convert.ToDouble(TBAccDuo.Text);
                ((TextBox)sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                NumberException(exception, sender, e);
            }
        }

        private void TBAccTri_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mainForm.Optimizer.Acessory_price[3] = Convert.ToDouble(TBAccTri.Text);
                ((TextBox)sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                NumberException(exception, sender, e);
            }
        }

        private void TBAccTet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mainForm.Optimizer.Acessory_price[4] = Convert.ToDouble(TBAccTet.Text);
                ((TextBox)sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                NumberException(exception, sender, e);
            }
        }

        private void TBAccPen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mainForm.Optimizer.Acessory_price[5] = Convert.ToDouble(TBAccPen.Text);
                ((TextBox)sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                NumberException(exception, sender, e);
            }
        }

        private void CBFSArmorLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            fSArmorLvlGroupChange();
        }       

        private void TBArmor0_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mainForm.Optimizer.Armor_price[0] = Convert.ToDouble(TBArmor0.Text);
                ((TextBox)sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                NumberException(exception, sender, e);
            }
        }

        private void TBArmorPRI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mainForm.Optimizer.Armor_price[16] = Convert.ToDouble(TBArmorPRI.Text);
                ((TextBox)sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                NumberException(exception, sender, e);
            }
        }

        private void TBArmorDUO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mainForm.Optimizer.Armor_price[17] = Convert.ToDouble(TBArmorDUO.Text);
                ((TextBox)sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                NumberException(exception, sender, e);
            }
        }

        private void TBArmorTRI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mainForm.Optimizer.Armor_price[18] = Convert.ToDouble(TBArmorTRI.Text);
                ((TextBox)sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                NumberException(exception, sender, e);
            }
        }

        private void TBArmorTET_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mainForm.Optimizer.Armor_price[19] = Convert.ToDouble(TBArmorTET.Text);
                ((TextBox)sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                NumberException(exception, sender, e);
            }
        }

        private void TBArmorPEN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mainForm.Optimizer.Armor_price[20] = Convert.ToDouble(TBArmorPEN.Text);
                ((TextBox)sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                NumberException(exception, sender, e);
            }
        }

        private void NumberException(Exception exception, object sender, EventArgs e)
        {
            Console.WriteLine(exception);
            MessageBox.Show("Something is wrong, fill everything with +numbers and try it again.");
            ((TextBox)sender).BackColor = Color.Red;
        }

        private void CBFSArmor_SelectedIndexChanged(object sender, EventArgs e)
        {
            armorGroupChange();
        }

        private void BCalculate_Click(object sender, EventArgs e)
        {
            mainForm.Calculate();
            mainForm.ShowResult();
        }

        private void buttonFsOpt_Click(object sender, EventArgs e)
        {
            mainForm.Optimizer.CalculateFs();
            mainForm.ShowFsTable();
        }

        private void checkBoxValuePack_CheckedChanged(object sender, EventArgs e)
        {
            ValuePackChange();
        }

        private void ValuePackChange()
        {
            if (checkBoxValuePack.Checked)
            {
                mainForm.Optimizer.ValuePack = true;
                checkBoxValuePack.Text = "Value Pack activated";
            }
            else
            {
                mainForm.Optimizer.ValuePack = false;
                checkBoxValuePack.Text = "Value Pack not activated";
            }
        }

        private void comboBoxFsItemGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grade grade;
            Enum.TryParse<Grade>(comboBoxFsItemGrade.SelectedValue.ToString(), out grade);
            mainForm.Optimizer.FsItem15plus = new Item(mainForm.Optimizer.FsItem15plus.Price, mainForm.Optimizer.FsItem15plus.Lvl, (Grade)grade, mainForm.Optimizer.FsItem15plus.ItemType);            
        }

        private void TBLBPermanentFreeStartFS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PermanentFreeStartFSChange();
                ((TextBox)sender).BackColor = ColorTranslator.FromHtml("#696E75");
            }
            catch (Exception exception)
            {
                NumberException(exception, sender, e);
            }
        }

        private void PermanentFreeStartFSChange()
        {
            mainForm.Optimizer.PermanentFreeStartFS = Convert.ToInt32(TBLBPermanentFreeStartFS.Text.ToString());
        }
    }
}
