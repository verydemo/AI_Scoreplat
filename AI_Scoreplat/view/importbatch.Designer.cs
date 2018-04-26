namespace AI_Scoreplat
{
    partial class importbatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(importbatch));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbimport = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvrecord = new System.Windows.Forms.DataGridView();
            this.importno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatecount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samecount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtsavepath = new System.Windows.Forms.TextBox();
            this.btnpath = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecord)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbimport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1299, 91);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbimport
            // 
            this.tsbimport.Image = ((System.Drawing.Image)(resources.GetObject("tsbimport.Image")));
            this.tsbimport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbimport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbimport.Name = "tsbimport";
            this.tsbimport.Size = new System.Drawing.Size(73, 88);
            this.tsbimport.Text = "数据导入";
            this.tsbimport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbimport.Click += new System.EventHandler(this.tsbimport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvrecord);
            this.groupBox1.Location = new System.Drawing.Point(0, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 575);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dgvrecord
            // 
            this.dgvrecord.AllowUserToAddRows = false;
            this.dgvrecord.AllowUserToDeleteRows = false;
            this.dgvrecord.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.importno,
            this.recordid,
            this.addcount,
            this.updatecount,
            this.samecount,
            this.totalcount,
            this.ftime});
            this.dgvrecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvrecord.Location = new System.Drawing.Point(3, 21);
            this.dgvrecord.Name = "dgvrecord";
            this.dgvrecord.ReadOnly = true;
            this.dgvrecord.RowHeadersVisible = false;
            this.dgvrecord.RowTemplate.Height = 27;
            this.dgvrecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrecord.Size = new System.Drawing.Size(822, 551);
            this.dgvrecord.TabIndex = 0;
            // 
            // importno
            // 
            this.importno.DataPropertyName = "importno";
            this.importno.HeaderText = "批次";
            this.importno.Name = "importno";
            this.importno.ReadOnly = true;
            this.importno.Width = 120;
            // 
            // recordid
            // 
            this.recordid.DataPropertyName = "recordid";
            this.recordid.HeaderText = "recordid";
            this.recordid.Name = "recordid";
            this.recordid.ReadOnly = true;
            this.recordid.Visible = false;
            // 
            // addcount
            // 
            this.addcount.DataPropertyName = "addcount";
            this.addcount.HeaderText = "增加数量";
            this.addcount.Name = "addcount";
            this.addcount.ReadOnly = true;
            this.addcount.Width = 120;
            // 
            // updatecount
            // 
            this.updatecount.DataPropertyName = "updatecount";
            this.updatecount.HeaderText = "更新数量";
            this.updatecount.Name = "updatecount";
            this.updatecount.ReadOnly = true;
            this.updatecount.Width = 120;
            // 
            // samecount
            // 
            this.samecount.DataPropertyName = "samecount";
            this.samecount.HeaderText = "相同数量";
            this.samecount.Name = "samecount";
            this.samecount.ReadOnly = true;
            this.samecount.Width = 120;
            // 
            // totalcount
            // 
            this.totalcount.DataPropertyName = "totalcount";
            this.totalcount.HeaderText = "总量";
            this.totalcount.Name = "totalcount";
            this.totalcount.ReadOnly = true;
            this.totalcount.Width = 120;
            // 
            // ftime
            // 
            this.ftime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ftime.DataPropertyName = "importtime";
            this.ftime.HeaderText = "插入时间";
            this.ftime.Name = "ftime";
            this.ftime.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(834, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 575);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(3, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(458, 551);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.progressBar2);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(706, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(581, 105);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "进度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(75, 63);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(372, 11);
            this.progressBar2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(75, 25);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(372, 11);
            this.progressBar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "更新：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "增加：";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnpath);
            this.groupBox4.Controls.Add(this.txtsavepath);
            this.groupBox4.Location = new System.Drawing.Point(111, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(589, 105);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "保存路径";
            // 
            // txtsavepath
            // 
            this.txtsavepath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtsavepath.Location = new System.Drawing.Point(7, 42);
            this.txtsavepath.Name = "txtsavepath";
            this.txtsavepath.ReadOnly = true;
            this.txtsavepath.Size = new System.Drawing.Size(502, 34);
            this.txtsavepath.TabIndex = 0;
            // 
            // btnpath
            // 
            this.btnpath.Location = new System.Drawing.Point(516, 42);
            this.btnpath.Name = "btnpath";
            this.btnpath.Size = new System.Drawing.Size(55, 36);
            this.btnpath.TabIndex = 1;
            this.btnpath.Text = "...";
            this.btnpath.UseVisualStyleBackColor = true;
            this.btnpath.Click += new System.EventHandler(this.btnpath_Click);
            // 
            // importbatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 702);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "importbatch";
            this.Text = "批次";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.importbatch_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecord)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbimport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvrecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn importno;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordid;
        private System.Windows.Forms.DataGridViewTextBoxColumn addcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatecount;
        private System.Windows.Forms.DataGridViewTextBoxColumn samecount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ftime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtsavepath;
        private System.Windows.Forms.Button btnpath;
    }
}