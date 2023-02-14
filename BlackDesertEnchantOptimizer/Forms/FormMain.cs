
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDOEnchantOptimizerLib;
using BDOEnchantOptimizerLib.Tables;

namespace BlackDesertEnchantOptimizer
{
    public partial class FormMain : Form
    {

        public BDOEnchantOptimizer Optimizer = new BDOEnchantOptimizer();   

        private bool moveable = false;
        private Point startmove;
             
        private EnchantControl enchantControl;
        private FsControl fsControl;
        private FsTableControl fsTableControl;
        private ResultControl resultControl;
        private StepByStepControl stepByStepControl;
        private FormAbout formAbout;

        public FormMain()
        {
            InitializeComponent();
            /*  if (!panel1.Controls.Contains(EnchantControl.Instance))
              {
                  panel1.Controls.Add(EnchantControl.Instance);
              }
              */

            enchantControl = new EnchantControl(this);
            fsControl = new FsControl(this);
            fsTableControl = new FsTableControl(this);
            resultControl = new ResultControl(this);
            stepByStepControl = new StepByStepControl(this);

            ShowResult();
            ShowEnch();
            buttonEnchOption.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F");
        }

  

        private void buttonMouseHover(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            s.ForeColor = System.Drawing.Color.LawnGreen;
        }

        private void buttonMouseLeave(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            s.ForeColor = System.Drawing.Color.LimeGreen;
        }

        private void buttonClick(object sender, MouseEventArgs e)
        {
            Button s = (Button)sender;
            if (s.Name == "buttonEnchOption")
                ShowEnch();

            if (s.Name == "buttonFsOption")
                ShowFsOption();

            if (s.Name == "buttonFsTable")
                ShowFsTable();

            if (s.Name == "buttonResult")
                ShowResult();

            if (s.Name == "buttonStepByStep")
                ShowStepByStep();
        }

        private void resetColor()
        {
            buttonEnchOption.BackColor = System.Drawing.ColorTranslator.FromHtml("#23262A");
            buttonFsOption.BackColor = System.Drawing.ColorTranslator.FromHtml("#23262A");
            buttonFsTable.BackColor = System.Drawing.ColorTranslator.FromHtml("#23262A");
            buttonResult.BackColor = System.Drawing.ColorTranslator.FromHtml("#23262A");
            buttonStepByStep.BackColor = System.Drawing.ColorTranslator.FromHtml("#23262A");
        }
        public void SetUpperEnch(double price)
        {
            enchantControl.ItemlvlUp(price);
        }
        public void ShowEnch()
        {
            prepareAndShowControl(enchantControl);
            buttonEnchOption.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F");
        }

        public void ShowFsOption()
        {
            prepareAndShowControl(fsControl);
            buttonFsOption.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F");
        }

        public void ShowFsTable()
        {            
            prepareAndShowControl(fsTableControl);
            buttonFsTable.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F");
        }

        public void ShowResult()
        {

            prepareAndShowControl(resultControl);
            buttonResult.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F");
        }

        public void ShowStepByStep()
        {
            prepareAndShowControl(stepByStepControl);
            buttonStepByStep.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F");
        }

        private void prepareAndShowControl(UserControl control)
        {
            if (!panelCenter.Controls.Contains(control))
            {
                panelCenter.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                control.BringToFront();
            }
            else
            {
                control.BringToFront();
            }
            resetColor();
        }

        private void labelMinimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            moveable = true;
            startmove = new Point(e.X, e.Y);

            startmove = this.PointToClient(Cursor.Position);
            //Panel p = (Panel)sender;
            //Point objectlocation = p.Location;
            // startmove = new Point(objectlocation.X+ startmove.X, startmove.Y+ objectlocation.Y); 
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            moveable = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveable)
            {
                this.Location = new Point(System.Windows.Forms.Cursor.Position.X - startmove.X, System.Windows.Forms.Cursor.Position.Y - startmove.Y);
            }
        }

        private void BCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
            ShowResult();
        }

        public void Calculate()
        {

            try
            {
                Optimizer.Calculate();
                fsTableControl.ReportFS(Optimizer.FSTable);
                resultControl.ReportEnch(Optimizer.ResultBest,"");
                resultControl.ReportEnch(Optimizer.EnchTable, Optimizer.BestRow, Optimizer.EnchItem.Lvl, Optimizer.EnchItem);
                stepByStepControl.SetStepByStep(Optimizer.BestRow, Optimizer.EnchItem.Lvl, Optimizer.EnchItem);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something is wrong, fill everything with +numbers and try it again.");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            formAbout = new FormAbout();
            formAbout.StartPosition = FormStartPosition.CenterParent;
            formAbout.ShowDialog();
        }
    }
}
