namespace AI_Scoreplat
{
    partial class corr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvcorr = new System.Windows.Forms.DataGridView();
            this.papercode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correlationdata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.per15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.per25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.benexcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcorr)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvcorr);
            this.groupBox1.Location = new System.Drawing.Point(2, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1102, 621);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "相关指标";
            // 
            // dgvcorr
            // 
            this.dgvcorr.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvcorr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcorr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.papercode,
            this.itemno,
            this.Correlationdata,
            this.per15,
            this.per25,
            this.count});
            this.dgvcorr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcorr.Location = new System.Drawing.Point(3, 21);
            this.dgvcorr.Name = "dgvcorr";
            this.dgvcorr.ReadOnly = true;
            this.dgvcorr.RowHeadersVisible = false;
            this.dgvcorr.RowTemplate.Height = 27;
            this.dgvcorr.Size = new System.Drawing.Size(1096, 597);
            this.dgvcorr.TabIndex = 0;
            // 
            // papercode
            // 
            this.papercode.DataPropertyName = "papercode";
            this.papercode.HeaderText = "试卷号";
            this.papercode.Name = "papercode";
            this.papercode.ReadOnly = true;
            this.papercode.Width = 200;
            // 
            // itemno
            // 
            this.itemno.DataPropertyName = "itemno";
            this.itemno.HeaderText = "题号";
            this.itemno.Name = "itemno";
            this.itemno.ReadOnly = true;
            this.itemno.Width = 200;
            // 
            // Correlationdata
            // 
            this.Correlationdata.DataPropertyName = "corr";
            this.Correlationdata.HeaderText = "相关系数";
            this.Correlationdata.Name = "Correlationdata";
            this.Correlationdata.ReadOnly = true;
            this.Correlationdata.Width = 200;
            // 
            // per15
            // 
            this.per15.DataPropertyName = "per15";
            this.per15.HeaderText = "15%";
            this.per15.Name = "per15";
            this.per15.ReadOnly = true;
            // 
            // per25
            // 
            this.per25.DataPropertyName = "per25";
            this.per25.HeaderText = "25%";
            this.per25.Name = "per25";
            this.per25.ReadOnly = true;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "数量";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.benexcel);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 69);
            this.panel1.TabIndex = 2;
            // 
            // benexcel
            // 
            this.benexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.benexcel.Location = new System.Drawing.Point(949, 13);
            this.benexcel.Name = "benexcel";
            this.benexcel.Size = new System.Drawing.Size(119, 41);
            this.benexcel.TabIndex = 0;
            this.benexcel.Text = "导出excel";
            this.benexcel.UseVisualStyleBackColor = true;
            this.benexcel.Click += new System.EventHandler(this.benexcel_Click);
            // 
            // corr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "corr";
            this.Text = "相关指标";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.corr_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcorr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvcorr;
        private System.Windows.Forms.DataGridViewTextBoxColumn papercode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correlationdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn per15;
        private System.Windows.Forms.DataGridViewTextBoxColumn per25;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button benexcel;
    }
}