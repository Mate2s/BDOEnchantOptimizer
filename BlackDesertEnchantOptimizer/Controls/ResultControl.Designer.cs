namespace BlackDesertEnchantOptimizer
{
    partial class ResultControl
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

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LBestResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.BCalculate = new System.Windows.Forms.Button();
            this.buttonStepByStep = new System.Windows.Forms.Button();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.Failstacks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnchCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BestRepairType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cronestone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurabilityDown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FsCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlackstoneCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostWithoutFs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // LBestResult
            // 
            this.LBestResult.AutoSize = true;
            this.LBestResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBestResult.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBestResult.Location = new System.Drawing.Point(24, 20);
            this.LBestResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBestResult.Name = "LBestResult";
            this.LBestResult.Size = new System.Drawing.Size(83, 17);
            this.LBestResult.TabIndex = 26;
            this.LBestResult.Text = "Best Result: ";
            this.LBestResult.Click += new System.EventHandler(this.LBestResult_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBestResult, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewResult, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 30);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(903, 519);
            this.tableLayoutPanel1.TabIndex = 28;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 3;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.BCalculate, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.buttonStepByStep, 1, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(20, 439);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(863, 50);
            this.tableLayoutPanel12.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(287, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enchant Option";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BCalculate
            // 
            this.BCalculate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BCalculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BCalculate.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BCalculate.FlatAppearance.BorderSize = 0;
            this.BCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCalculate.Font = new System.Drawing.Font("Segoe Print", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BCalculate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BCalculate.Location = new System.Drawing.Point(0, 0);
            this.BCalculate.Margin = new System.Windows.Forms.Padding(0);
            this.BCalculate.Name = "BCalculate";
            this.BCalculate.Size = new System.Drawing.Size(287, 50);
            this.BCalculate.TabIndex = 0;
            this.BCalculate.Text = "Upper enchant";
            this.BCalculate.UseVisualStyleBackColor = false;
            this.BCalculate.Click += new System.EventHandler(this.BCalculate_Click);
            // 
            // buttonStepByStep
            // 
            this.buttonStepByStep.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonStepByStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStepByStep.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonStepByStep.FlatAppearance.BorderSize = 0;
            this.buttonStepByStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStepByStep.Font = new System.Drawing.Font("Segoe Print", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStepByStep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStepByStep.Location = new System.Drawing.Point(574, 0);
            this.buttonStepByStep.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStepByStep.Name = "buttonStepByStep";
            this.buttonStepByStep.Size = new System.Drawing.Size(289, 50);
            this.buttonStepByStep.TabIndex = 1;
            this.buttonStepByStep.Text = "Step by Step";
            this.buttonStepByStep.UseVisualStyleBackColor = false;
            this.buttonStepByStep.Click += new System.EventHandler(this.buttonFsOpt_Click);
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AllowUserToOrderColumns = true;
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.dataGridViewResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Failstacks,
            this.TotalCost,
            this.EnchCount,
            this.BestRepairType,
            this.Cronestone,
            this.DurabilityDown,
            this.FsCost,
            this.BlackstoneCost,
            this.CostWithoutFs});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult.EnableHeadersVisualStyles = false;
            this.dataGridViewResult.Location = new System.Drawing.Point(24, 40);
            this.dataGridViewResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 17);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.Size = new System.Drawing.Size(855, 382);
            this.dataGridViewResult.TabIndex = 29;
            // 
            // Failstacks
            // 
            this.Failstacks.HeaderText = "Failstacks start on";
            this.Failstacks.Name = "Failstacks";
            this.Failstacks.ReadOnly = true;
            // 
            // TotalCost
            // 
            this.TotalCost.HeaderText = "Total cost";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            // 
            // EnchCount
            // 
            this.EnchCount.HeaderText = "Ench count";
            this.EnchCount.Name = "EnchCount";
            this.EnchCount.ReadOnly = true;
            // 
            // BestRepairType
            // 
            this.BestRepairType.HeaderText = "Best repair with";
            this.BestRepairType.Name = "BestRepairType";
            this.BestRepairType.ReadOnly = true;
            // 
            // Cronestone
            // 
            this.Cronestone.HeaderText = "Cronestone used";
            this.Cronestone.Name = "Cronestone";
            this.Cronestone.ReadOnly = true;
            // 
            // DurabilityDown
            // 
            this.DurabilityDown.HeaderText = "Durability down";
            this.DurabilityDown.Name = "DurabilityDown";
            this.DurabilityDown.ReadOnly = true;
            // 
            // FsCost
            // 
            this.FsCost.HeaderText = "Failstack cost";
            this.FsCost.Name = "FsCost";
            this.FsCost.ReadOnly = true;
            // 
            // BlackstoneCost
            // 
            this.BlackstoneCost.HeaderText = "Blackstone cost";
            this.BlackstoneCost.Name = "BlackstoneCost";
            this.BlackstoneCost.ReadOnly = true;
            // 
            // CostWithoutFs
            // 
            this.CostWithoutFs.HeaderText = "Cost without FS";
            this.CostWithoutFs.Name = "CostWithoutFs";
            this.CostWithoutFs.ReadOnly = true;
            // 
            // ResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ResultControl";
            this.Size = new System.Drawing.Size(903, 519);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBestResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        public System.Windows.Forms.Button BCalculate;
        public System.Windows.Forms.Button buttonStepByStep;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Failstacks;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnchCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestRepairType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cronestone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurabilityDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn FsCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlackstoneCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostWithoutFs;
        public System.Windows.Forms.Button button1;
    }
}
