namespace BlackDesertEnchantOptimizer
{
    partial class FormMain
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BCalculate = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanelExit = new System.Windows.Forms.TableLayoutPanel();
            this.panelExit = new System.Windows.Forms.Panel();
            this.labelAbout = new System.Windows.Forms.Label();
            this.panelSpace = new System.Windows.Forms.Panel();
            this.panelMinimalize = new System.Windows.Forms.Panel();
            this.labelMinimalize = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.panelSpace2 = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStepByStep = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.buttonResult = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.buttonFsTable = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.buttonFsOption = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.buttonEnchOption = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanelExit.SuspendLayout();
            this.panelExit.SuspendLayout();
            this.panelMinimalize.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BCalculate
            // 
            this.BCalculate.BackColor = System.Drawing.Color.Maroon;
            this.BCalculate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BCalculate.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BCalculate.FlatAppearance.BorderSize = 0;
            this.BCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCalculate.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BCalculate.ForeColor = System.Drawing.Color.LimeGreen;
            this.BCalculate.Location = new System.Drawing.Point(0, 513);
            this.BCalculate.Margin = new System.Windows.Forms.Padding(0);
            this.BCalculate.Name = "BCalculate";
            this.BCalculate.Size = new System.Drawing.Size(233, 50);
            this.BCalculate.TabIndex = 0;
            this.BCalculate.Text = "Calculate";
            this.BCalculate.UseVisualStyleBackColor = false;
            this.BCalculate.Click += new System.EventHandler(this.BCalculate_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tableLayoutPanelExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(233, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(901, 74);
            this.panelTop.TabIndex = 27;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // tableLayoutPanelExit
            // 
            this.tableLayoutPanelExit.AutoSize = true;
            this.tableLayoutPanelExit.ColumnCount = 1;
            this.tableLayoutPanelExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelExit.Controls.Add(this.panelExit, 0, 1);
            this.tableLayoutPanelExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanelExit.Location = new System.Drawing.Point(802, 0);
            this.tableLayoutPanelExit.Name = "tableLayoutPanelExit";
            this.tableLayoutPanelExit.RowCount = 3;
            this.tableLayoutPanelExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelExit.Size = new System.Drawing.Size(99, 74);
            this.tableLayoutPanelExit.TabIndex = 3;
            // 
            // panelExit
            // 
            this.panelExit.AutoSize = true;
            this.panelExit.Controls.Add(this.labelAbout);
            this.panelExit.Controls.Add(this.panelSpace);
            this.panelExit.Controls.Add(this.panelMinimalize);
            this.panelExit.Controls.Add(this.labelExit);
            this.panelExit.Controls.Add(this.panelSpace2);
            this.panelExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExit.Location = new System.Drawing.Point(3, 25);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(93, 24);
            this.panelExit.TabIndex = 0;
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAbout.Location = new System.Drawing.Point(0, 0);
            this.labelAbout.Margin = new System.Windows.Forms.Padding(0);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(19, 20);
            this.labelAbout.TabIndex = 5;
            this.labelAbout.Text = "?";
            this.labelAbout.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelSpace
            // 
            this.panelSpace.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSpace.Location = new System.Drawing.Point(19, 0);
            this.panelSpace.Name = "panelSpace";
            this.panelSpace.Size = new System.Drawing.Size(5, 24);
            this.panelSpace.TabIndex = 9;
            // 
            // panelMinimalize
            // 
            this.panelMinimalize.AutoSize = true;
            this.panelMinimalize.Controls.Add(this.labelMinimalize);
            this.panelMinimalize.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMinimalize.Location = new System.Drawing.Point(24, 0);
            this.panelMinimalize.Margin = new System.Windows.Forms.Padding(0);
            this.panelMinimalize.Name = "panelMinimalize";
            this.panelMinimalize.Size = new System.Drawing.Size(24, 24);
            this.panelMinimalize.TabIndex = 7;
            this.panelMinimalize.Click += new System.EventHandler(this.labelMinimalize_Click);
            // 
            // labelMinimalize
            // 
            this.labelMinimalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinimalize.Location = new System.Drawing.Point(0, -14);
            this.labelMinimalize.Margin = new System.Windows.Forms.Padding(0);
            this.labelMinimalize.Name = "labelMinimalize";
            this.labelMinimalize.Size = new System.Drawing.Size(24, 24);
            this.labelMinimalize.TabIndex = 4;
            this.labelMinimalize.Text = "_";
            this.labelMinimalize.Click += new System.EventHandler(this.labelMinimalize_Click);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExit.Location = new System.Drawing.Point(48, 0);
            this.labelExit.Margin = new System.Windows.Forms.Padding(0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(21, 20);
            this.labelExit.TabIndex = 3;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // panelSpace2
            // 
            this.panelSpace2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSpace2.Location = new System.Drawing.Point(69, 0);
            this.panelSpace2.Name = "panelSpace2";
            this.panelSpace2.Size = new System.Drawing.Size(24, 24);
            this.panelSpace2.TabIndex = 10;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(233, 74);
            this.panelCenter.Margin = new System.Windows.Forms.Padding(0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(901, 519);
            this.panelCenter.TabIndex = 28;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.BCalculate);
            this.panelLeft.Controls.Add(this.flowLayoutPanel1);
            this.panelLeft.Controls.Add(this.panel14);
            this.panelLeft.Controls.Add(this.panel11);
            this.panelLeft.Controls.Add(this.panel10);
            this.panelLeft.Controls.Add(this.panel12);
            this.panelLeft.Controls.Add(this.panelLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(233, 593);
            this.panelLeft.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonStepByStep);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 306);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 58);
            this.panel1.TabIndex = 32;
            // 
            // buttonStepByStep
            // 
            this.buttonStepByStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStepByStep.FlatAppearance.BorderSize = 0;
            this.buttonStepByStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStepByStep.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStepByStep.Location = new System.Drawing.Point(0, 0);
            this.buttonStepByStep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStepByStep.Name = "buttonStepByStep";
            this.buttonStepByStep.Size = new System.Drawing.Size(233, 58);
            this.buttonStepByStep.TabIndex = 0;
            this.buttonStepByStep.Text = "       Step by step";
            this.buttonStepByStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStepByStep.UseVisualStyleBackColor = true;
            this.buttonStepByStep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 563);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(233, 30);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.buttonResult);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 248);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(233, 58);
            this.panel14.TabIndex = 31;
            // 
            // buttonResult
            // 
            this.buttonResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonResult.FlatAppearance.BorderSize = 0;
            this.buttonResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResult.Location = new System.Drawing.Point(0, 0);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(233, 58);
            this.buttonResult.TabIndex = 0;
            this.buttonResult.Text = "       Result";
            this.buttonResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonClick);
            this.buttonResult.MouseLeave += new System.EventHandler(this.buttonMouseLeave);
            this.buttonResult.MouseHover += new System.EventHandler(this.buttonMouseHover);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.buttonFsTable);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 190);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(233, 58);
            this.panel11.TabIndex = 30;
            // 
            // buttonFsTable
            // 
            this.buttonFsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFsTable.FlatAppearance.BorderSize = 0;
            this.buttonFsTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFsTable.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFsTable.Location = new System.Drawing.Point(0, 0);
            this.buttonFsTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFsTable.Name = "buttonFsTable";
            this.buttonFsTable.Size = new System.Drawing.Size(233, 58);
            this.buttonFsTable.TabIndex = 0;
            this.buttonFsTable.Text = "       Failstack Table";
            this.buttonFsTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFsTable.UseVisualStyleBackColor = true;
            this.buttonFsTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonClick);
            this.buttonFsTable.MouseLeave += new System.EventHandler(this.buttonMouseLeave);
            this.buttonFsTable.MouseHover += new System.EventHandler(this.buttonMouseHover);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.buttonFsOption);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 132);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(233, 58);
            this.panel10.TabIndex = 29;
            // 
            // buttonFsOption
            // 
            this.buttonFsOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFsOption.FlatAppearance.BorderSize = 0;
            this.buttonFsOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFsOption.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFsOption.Location = new System.Drawing.Point(0, 0);
            this.buttonFsOption.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFsOption.Name = "buttonFsOption";
            this.buttonFsOption.Size = new System.Drawing.Size(233, 58);
            this.buttonFsOption.TabIndex = 0;
            this.buttonFsOption.Text = "       Failstack option";
            this.buttonFsOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFsOption.UseVisualStyleBackColor = true;
            this.buttonFsOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonClick);
            this.buttonFsOption.MouseLeave += new System.EventHandler(this.buttonMouseLeave);
            this.buttonFsOption.MouseHover += new System.EventHandler(this.buttonMouseHover);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.buttonEnchOption);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 74);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(233, 58);
            this.panel12.TabIndex = 28;
            // 
            // buttonEnchOption
            // 
            this.buttonEnchOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEnchOption.FlatAppearance.BorderSize = 0;
            this.buttonEnchOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnchOption.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEnchOption.Location = new System.Drawing.Point(0, 0);
            this.buttonEnchOption.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEnchOption.Name = "buttonEnchOption";
            this.buttonEnchOption.Size = new System.Drawing.Size(233, 58);
            this.buttonEnchOption.TabIndex = 0;
            this.buttonEnchOption.Text = "       Enchant option";
            this.buttonEnchOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnchOption.UseVisualStyleBackColor = true;
            this.buttonEnchOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonClick);
            this.buttonEnchOption.MouseLeave += new System.EventHandler(this.buttonMouseLeave);
            this.buttonEnchOption.MouseHover += new System.EventHandler(this.buttonMouseHover);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label25);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 74);
            this.panelLogo.TabIndex = 7;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.Color.GreenYellow;
            this.label25.Location = new System.Drawing.Point(0, 0);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(233, 74);
            this.label25.TabIndex = 0;
            this.label25.Text = "BDO Enchant Optimizer";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1134, 593);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.Text = "Black Desert Enchant Optimizer";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tableLayoutPanelExit.ResumeLayout(false);
            this.tableLayoutPanelExit.PerformLayout();
            this.panelExit.ResumeLayout(false);
            this.panelExit.PerformLayout();
            this.panelMinimalize.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Button BCalculate;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button buttonFsOption;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button buttonEnchOption;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button buttonFsTable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStepByStep;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelExit;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label labelMinimalize;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Panel panelMinimalize;
        private System.Windows.Forms.Panel panelSpace;
        private System.Windows.Forms.Panel panelSpace2;
    }
}

