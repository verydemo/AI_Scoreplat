namespace AI_Scoreplat
{
    partial class drdc
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnfyrep = new System.Windows.Forms.Button();
            this.btnfydoc = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnkgf = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btndrdbgl = new System.Windows.Forms.Button();
            this.btnexportdingbiao = new System.Windows.Forms.Button();
            this.btndcdbf = new System.Windows.Forms.Button();
            this.btndrdbf = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnexportpaper = new System.Windows.Forms.Button();
            this.btnimportitemcode = new System.Windows.Forms.Button();
            this.btnimportpapercode = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnqc = new System.Windows.Forms.Button();
            this.btndrscore = new System.Windows.Forms.Button();
            this.btndctzf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1324, 1024);
            this.splitContainer1.SplitterDistance = 907;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 1024);
            this.panel1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.btnfyrep);
            this.groupBox6.Controls.Add(this.btnfydoc);
            this.groupBox6.Location = new System.Drawing.Point(3, 482);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(900, 111);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "发音字典";
            // 
            // btnfyrep
            // 
            this.btnfyrep.Location = new System.Drawing.Point(250, 45);
            this.btnfyrep.Name = "btnfyrep";
            this.btnfyrep.Size = new System.Drawing.Size(162, 45);
            this.btnfyrep.TabIndex = 0;
            this.btnfyrep.Text = "导入替换规则";
            this.btnfyrep.UseVisualStyleBackColor = true;
            this.btnfyrep.Click += new System.EventHandler(this.btnfyrep_Click);
            // 
            // btnfydoc
            // 
            this.btnfydoc.Location = new System.Drawing.Point(38, 45);
            this.btnfydoc.Name = "btnfydoc";
            this.btnfydoc.Size = new System.Drawing.Size(162, 45);
            this.btnfydoc.TabIndex = 0;
            this.btnfydoc.Text = "导出doc文本";
            this.btnfydoc.UseVisualStyleBackColor = true;
            this.btnfydoc.Click += new System.EventHandler(this.btnfydoc_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnkgf);
            this.groupBox5.Location = new System.Drawing.Point(3, 365);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(900, 111);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "客观分";
            // 
            // btnkgf
            // 
            this.btnkgf.Location = new System.Drawing.Point(38, 42);
            this.btnkgf.Name = "btnkgf";
            this.btnkgf.Size = new System.Drawing.Size(162, 45);
            this.btnkgf.TabIndex = 0;
            this.btnkgf.Text = "导入客观分";
            this.btnkgf.UseVisualStyleBackColor = true;
            this.btnkgf.Click += new System.EventHandler(this.btnkgf_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btndrdbgl);
            this.groupBox4.Controls.Add(this.btnexportdingbiao);
            this.groupBox4.Controls.Add(this.btndcdbf);
            this.groupBox4.Controls.Add(this.btndrdbf);
            this.groupBox4.Location = new System.Drawing.Point(4, 248);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(900, 111);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "定标分";
            // 
            // btndrdbgl
            // 
            this.btndrdbgl.Location = new System.Drawing.Point(462, 38);
            this.btndrdbgl.Name = "btndrdbgl";
            this.btndrdbgl.Size = new System.Drawing.Size(162, 45);
            this.btndrdbgl.TabIndex = 2;
            this.btndrdbgl.Text = "导入定标(过滤)";
            this.btndrdbgl.UseVisualStyleBackColor = true;
            this.btndrdbgl.Click += new System.EventHandler(this.btndrdbgl_Click);
            // 
            // btnexportdingbiao
            // 
            this.btnexportdingbiao.Location = new System.Drawing.Point(249, 38);
            this.btnexportdingbiao.Name = "btnexportdingbiao";
            this.btnexportdingbiao.Size = new System.Drawing.Size(162, 45);
            this.btnexportdingbiao.TabIndex = 1;
            this.btnexportdingbiao.Text = "导出定标(过滤)";
            this.btnexportdingbiao.UseVisualStyleBackColor = true;
            this.btnexportdingbiao.Click += new System.EventHandler(this.btnexportdingbiao_Click);
            // 
            // btndcdbf
            // 
            this.btndcdbf.Location = new System.Drawing.Point(679, 38);
            this.btndcdbf.Name = "btndcdbf";
            this.btndcdbf.Size = new System.Drawing.Size(162, 45);
            this.btndcdbf.TabIndex = 0;
            this.btndcdbf.Text = "导出定标分";
            this.btndcdbf.UseVisualStyleBackColor = true;
            this.btndcdbf.Click += new System.EventHandler(this.btndcdbf_Click);
            // 
            // btndrdbf
            // 
            this.btndrdbf.Location = new System.Drawing.Point(38, 38);
            this.btndrdbf.Name = "btndrdbf";
            this.btndrdbf.Size = new System.Drawing.Size(162, 45);
            this.btndrdbf.TabIndex = 0;
            this.btndrdbf.Text = "导入定标分";
            this.btndrdbf.UseVisualStyleBackColor = true;
            this.btndrdbf.Click += new System.EventHandler(this.btndrdbf_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnexportpaper);
            this.groupBox3.Controls.Add(this.btnimportitemcode);
            this.groupBox3.Controls.Add(this.btnimportpapercode);
            this.groupBox3.Location = new System.Drawing.Point(3, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(901, 111);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "试卷题目";
            // 
            // btnexportpaper
            // 
            this.btnexportpaper.Location = new System.Drawing.Point(463, 39);
            this.btnexportpaper.Name = "btnexportpaper";
            this.btnexportpaper.Size = new System.Drawing.Size(162, 45);
            this.btnexportpaper.TabIndex = 1;
            this.btnexportpaper.Text = "导出试卷结构";
            this.btnexportpaper.UseVisualStyleBackColor = true;
            this.btnexportpaper.Click += new System.EventHandler(this.btnexportpaper_Click);
            // 
            // btnimportitemcode
            // 
            this.btnimportitemcode.Location = new System.Drawing.Point(250, 39);
            this.btnimportitemcode.Name = "btnimportitemcode";
            this.btnimportitemcode.Size = new System.Drawing.Size(162, 45);
            this.btnimportitemcode.TabIndex = 0;
            this.btnimportitemcode.Text = "导入题目代码";
            this.btnimportitemcode.UseVisualStyleBackColor = true;
            this.btnimportitemcode.Click += new System.EventHandler(this.btnimportitemcode_Click);
            // 
            // btnimportpapercode
            // 
            this.btnimportpapercode.Location = new System.Drawing.Point(38, 39);
            this.btnimportpapercode.Name = "btnimportpapercode";
            this.btnimportpapercode.Size = new System.Drawing.Size(162, 45);
            this.btnimportpapercode.TabIndex = 0;
            this.btnimportpapercode.Text = "导入试卷代码";
            this.btnimportpapercode.UseVisualStyleBackColor = true;
            this.btnimportpapercode.Click += new System.EventHandler(this.btnimportpapercode_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnqc);
            this.groupBox2.Controls.Add(this.btndrscore);
            this.groupBox2.Controls.Add(this.btndctzf);
            this.groupBox2.Location = new System.Drawing.Point(4, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 111);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分数";
            // 
            // btnqc
            // 
            this.btnqc.Location = new System.Drawing.Point(38, 38);
            this.btnqc.Name = "btnqc";
            this.btnqc.Size = new System.Drawing.Size(162, 45);
            this.btnqc.TabIndex = 2;
            this.btnqc.Text = "去重";
            this.btnqc.UseVisualStyleBackColor = true;
            this.btnqc.Click += new System.EventHandler(this.btnqc_Click);
            // 
            // btndrscore
            // 
            this.btndrscore.Location = new System.Drawing.Point(462, 38);
            this.btndrscore.Name = "btndrscore";
            this.btndrscore.Size = new System.Drawing.Size(162, 45);
            this.btndrscore.TabIndex = 1;
            this.btndrscore.Text = "导入分数";
            this.btndrscore.UseVisualStyleBackColor = true;
            this.btndrscore.Click += new System.EventHandler(this.btndrscore_Click);
            // 
            // btndctzf
            // 
            this.btndctzf.Location = new System.Drawing.Point(250, 38);
            this.btndctzf.Name = "btndctzf";
            this.btndctzf.Size = new System.Drawing.Size(162, 45);
            this.btndctzf.TabIndex = 0;
            this.btndctzf.Text = "导出特征分";
            this.btndctzf.UseVisualStyleBackColor = true;
            this.btndctzf.Click += new System.EventHandler(this.btndctzf_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 1024);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(407, 995);
            this.textBox1.TabIndex = 0;
            // 
            // drdc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 1024);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "drdc";
            this.Text = "导入导出";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.drdc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btndctzf;
        private System.Windows.Forms.Button btndrscore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnimportitemcode;
        private System.Windows.Forms.Button btnimportpapercode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btndcdbf;
        private System.Windows.Forms.Button btndrdbf;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnkgf;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnfydoc;
        private System.Windows.Forms.Button btnfyrep;
        private System.Windows.Forms.Button btnqc;
        private System.Windows.Forms.Button btnexportpaper;
        private System.Windows.Forms.Button btnexportdingbiao;
        private System.Windows.Forms.Button btndrdbgl;
    }
}