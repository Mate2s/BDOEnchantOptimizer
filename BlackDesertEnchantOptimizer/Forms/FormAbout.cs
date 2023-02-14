using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackDesertEnchantOptimizer
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            label1.Text = "Developed by Mate2s";
            label2.Text = "If you want contact me: ";
            textBox1.Text = "owner@mate2s.online";
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo("BlackDesertEnchantOptimizer.exe");
            string version = fvi.FileVersion;
            label3.Text = "Version B"+ version + "\n© 2022 Mate2s (M.K.)";
        }
    }
}
