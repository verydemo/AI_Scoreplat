namespace AI_Scoreplat
{
    partial class main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiconfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmicorr = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmidatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbmx = new System.Windows.Forms.ToolStripButton();
            this.tsbpc = new System.Windows.Forms.ToolStripButton();
            this.tsbjk = new System.Windows.Forms.ToolStripButton();
            this.tsbdrdc = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncheck = new System.Windows.Forms.Button();
            this.btnfinish = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvexam = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.输出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmicf = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmifinallyscore = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexam)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.输出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiconfig,
            this.tsmicorr,
            this.tsmidatabase});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // tsmiconfig
            // 
            this.tsmiconfig.Name = "tsmiconfig";
            this.tsmiconfig.Size = new System.Drawing.Size(181, 26);
            this.tsmiconfig.Text = "系统配置";
            this.tsmiconfig.Click += new System.EventHandler(this.tsmiconfig_Click);
            // 
            // tsmicorr
            // 
            this.tsmicorr.Name = "tsmicorr";
            this.tsmicorr.Size = new System.Drawing.Size(181, 26);
            this.tsmicorr.Text = "相关系数";
            this.tsmicorr.Click += new System.EventHandler(this.tsmicorr_Click);
            // 
            // tsmidatabase
            // 
            this.tsmidatabase.Name = "tsmidatabase";
            this.tsmidatabase.Size = new System.Drawing.Size(181, 26);
            this.tsmidatabase.Text = "数据库";
            this.tsmidatabase.Click += new System.EventHandler(this.tsmidatabase_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbmx,
            this.tsbpc,
            this.tsbjk,
            this.tsbdrdc});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1065, 98);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbmx
            // 
            this.tsbmx.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbmx.Image = ((System.Drawing.Image)(resources.GetObject("tsbmx.Image")));
            this.tsbmx.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbmx.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbmx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbmx.Name = "tsbmx";
            this.tsbmx.Size = new System.Drawing.Size(96, 95);
            this.tsbmx.Text = "语言模型";
            this.tsbmx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbmx.Click += new System.EventHandler(this.tsbmx_Click);
            // 
            // tsbpc
            // 
            this.tsbpc.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbpc.Image = ((System.Drawing.Image)(resources.GetObject("tsbpc.Image")));
            this.tsbpc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbpc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbpc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbpc.Name = "tsbpc";
            this.tsbpc.Size = new System.Drawing.Size(96, 95);
            this.tsbpc.Text = "数据批次";
            this.tsbpc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbpc.Click += new System.EventHandler(this.tsbpc_Click);
            // 
            // tsbjk
            // 
            this.tsbjk.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbjk.Image = ((System.Drawing.Image)(resources.GetObject("tsbjk.Image")));
            this.tsbjk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbjk.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbjk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbjk.Name = "tsbjk";
            this.tsbjk.Size = new System.Drawing.Size(96, 95);
            this.tsbjk.Text = "进度监控";
            this.tsbjk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbjk.Click += new System.EventHandler(this.tsbjk_Click);
            // 
            // tsbdrdc
            // 
            this.tsbdrdc.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbdrdc.Image = ((System.Drawing.Image)(resources.GetObject("tsbdrdc.Image")));
            this.tsbdrdc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbdrdc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbdrdc.Name = "tsbdrdc";
            this.tsbdrdc.Size = new System.Drawing.Size(96, 95);
            this.tsbdrdc.Text = "导入导出";
            this.tsbdrdc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbdrdc.Click += new System.EventHandler(this.tsbdrdc_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btncheck);
            this.panel1.Controls.Add(this.btnfinish);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.btndel);
            this.panel1.Location = new System.Drawing.Point(3, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 37);
            this.panel1.TabIndex = 2;
            // 
            // btncheck
            // 
            this.btncheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncheck.Location = new System.Drawing.Point(975, 8);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(75, 26);
            this.btncheck.TabIndex = 2;
            this.btncheck.Text = "核查";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // btnfinish
            // 
            this.btnfinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfinish.Location = new System.Drawing.Point(878, 8);
            this.btnfinish.Name = "btnfinish";
            this.btnfinish.Size = new System.Drawing.Size(75, 26);
            this.btnfinish.TabIndex = 1;
            this.btnfinish.Text = "完成";
            this.btnfinish.UseVisualStyleBackColor = true;
            this.btnfinish.Click += new System.EventHandler(this.btnfinish_Click);
            // 
            // btnedit
            // 
            this.btnedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnedit.Location = new System.Drawing.Point(787, 8);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 26);
            this.btnedit.TabIndex = 0;
            this.btnedit.Text = "修改";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadd.Location = new System.Drawing.Point(615, 8);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(69, 26);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "增加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndel
            // 
            this.btndel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndel.Location = new System.Drawing.Point(698, 8);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 26);
            this.btndel.TabIndex = 0;
            this.btndel.Text = "删除";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvexam);
            this.groupBox1.Location = new System.Drawing.Point(0, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1065, 509);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "考试列表";
            // 
            // dgvexam
            // 
            this.dgvexam.AllowUserToAddRows = false;
            this.dgvexam.AllowUserToDeleteRows = false;
            this.dgvexam.AllowUserToResizeColumns = false;
            this.dgvexam.AllowUserToResizeRows = false;
            this.dgvexam.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvexam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvexam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.desc,
            this.examid,
            this.status});
            this.dgvexam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvexam.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvexam.Location = new System.Drawing.Point(3, 21);
            this.dgvexam.Name = "dgvexam";
            this.dgvexam.ReadOnly = true;
            this.dgvexam.RowHeadersVisible = false;
            this.dgvexam.RowTemplate.Height = 27;
            this.dgvexam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvexam.Size = new System.Drawing.Size(1059, 485);
            this.dgvexam.TabIndex = 0;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 300;
            // 
            // desc
            // 
            this.desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desc.DataPropertyName = "desc";
            this.desc.HeaderText = "描述";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // examid
            // 
            this.examid.DataPropertyName = "examid";
            this.examid.HeaderText = "examid";
            this.examid.Name = "examid";
            this.examid.ReadOnly = true;
            this.examid.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "状态";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // 输出ToolStripMenuItem
            // 
            this.输出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmicf,
            this.tsmifinallyscore});
            this.输出ToolStripMenuItem.Name = "输出ToolStripMenuItem";
            this.输出ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.输出ToolStripMenuItem.Text = "输出";
            // 
            // tsmicf
            // 
            this.tsmicf.Name = "tsmicf";
            this.tsmicf.Size = new System.Drawing.Size(181, 26);
            this.tsmicf.Text = "分数核查";
            this.tsmicf.Click += new System.EventHandler(this.tsmicf_Click);
            // 
            // tsmifinallyscore
            // 
            this.tsmifinallyscore.Name = "tsmifinallyscore";
            this.tsmifinallyscore.Size = new System.Drawing.Size(181, 26);
            this.tsmifinallyscore.Text = "最终出分";
            this.tsmifinallyscore.Click += new System.EventHandler(this.tsmifinallyscore_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 701);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "评分系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvexam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbmx;
        private System.Windows.Forms.ToolStripButton tsbpc;
        private System.Windows.Forms.ToolStripButton tsbjk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.DataGridView dgvexam;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn examid;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button btnfinish;
        private System.Windows.Forms.ToolStripButton tsbdrdc;
        private System.Windows.Forms.ToolStripMenuItem tsmiconfig;
        private System.Windows.Forms.ToolStripMenuItem tsmicorr;
        private System.Windows.Forms.ToolStripMenuItem tsmidatabase;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.ToolStripMenuItem 输出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmicf;
        private System.Windows.Forms.ToolStripMenuItem tsmifinallyscore;
    }
}

