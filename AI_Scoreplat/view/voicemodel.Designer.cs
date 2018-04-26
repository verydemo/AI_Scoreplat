namespace AI_Scoreplat
{
    partial class voicemodel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnitemedit = new System.Windows.Forms.Button();
            this.btndelitem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.docdel = new System.Windows.Forms.Button();
            this.docadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.delpaper = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.editpaper = new System.Windows.Forms.Button();
            this.addpaper = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treepaperdoc = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvitem = new System.Windows.Forms.DataGridView();
            this.itemno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeltext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnreplace = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnitemedit);
            this.panel1.Controls.Add(this.btndelitem);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.docdel);
            this.panel1.Controls.Add(this.docadd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.delpaper);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.editpaper);
            this.panel1.Controls.Add(this.addpaper);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 54);
            this.panel1.TabIndex = 0;
            // 
            // btnitemedit
            // 
            this.btnitemedit.Location = new System.Drawing.Point(1163, 14);
            this.btnitemedit.Name = "btnitemedit";
            this.btnitemedit.Size = new System.Drawing.Size(58, 26);
            this.btnitemedit.TabIndex = 13;
            this.btnitemedit.Text = "修改";
            this.btnitemedit.UseVisualStyleBackColor = true;
            this.btnitemedit.Click += new System.EventHandler(this.btnitemedit_Click);
            // 
            // btndelitem
            // 
            this.btndelitem.Location = new System.Drawing.Point(1096, 14);
            this.btndelitem.Name = "btndelitem";
            this.btndelitem.Size = new System.Drawing.Size(61, 26);
            this.btndelitem.TabIndex = 12;
            this.btndelitem.Text = "删除";
            this.btndelitem.UseVisualStyleBackColor = true;
            this.btndelitem.Click += new System.EventHandler(this.btndelitem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(782, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 26);
            this.button3.TabIndex = 11;
            this.button3.Text = "转modeltxt并保存";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1032, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "增加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(989, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "题目";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "保存为中间txt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "文本";
            // 
            // docdel
            // 
            this.docdel.Location = new System.Drawing.Point(484, 14);
            this.docdel.Name = "docdel";
            this.docdel.Size = new System.Drawing.Size(49, 26);
            this.docdel.TabIndex = 3;
            this.docdel.Text = "删除";
            this.docdel.UseVisualStyleBackColor = true;
            this.docdel.Click += new System.EventHandler(this.docdel_Click);
            // 
            // docadd
            // 
            this.docadd.Location = new System.Drawing.Point(419, 14);
            this.docadd.Name = "docadd";
            this.docadd.Size = new System.Drawing.Size(59, 26);
            this.docadd.TabIndex = 5;
            this.docadd.Text = "增加";
            this.docadd.UseVisualStyleBackColor = true;
            this.docadd.Click += new System.EventHandler(this.docadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "doc";
            // 
            // delpaper
            // 
            this.delpaper.Location = new System.Drawing.Point(128, 14);
            this.delpaper.Name = "delpaper";
            this.delpaper.Size = new System.Drawing.Size(49, 26);
            this.delpaper.TabIndex = 1;
            this.delpaper.Text = "删除";
            this.delpaper.UseVisualStyleBackColor = true;
            this.delpaper.Click += new System.EventHandler(this.delpaper_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(238, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 26);
            this.button4.TabIndex = 1;
            this.button4.Text = "完成";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // editpaper
            // 
            this.editpaper.Location = new System.Drawing.Point(183, 14);
            this.editpaper.Name = "editpaper";
            this.editpaper.Size = new System.Drawing.Size(49, 26);
            this.editpaper.TabIndex = 1;
            this.editpaper.Text = "修改";
            this.editpaper.UseVisualStyleBackColor = true;
            this.editpaper.Click += new System.EventHandler(this.editpaper_Click);
            // 
            // addpaper
            // 
            this.addpaper.Location = new System.Drawing.Point(63, 14);
            this.addpaper.Name = "addpaper";
            this.addpaper.Size = new System.Drawing.Size(59, 26);
            this.addpaper.TabIndex = 1;
            this.addpaper.Text = "增加";
            this.addpaper.UseVisualStyleBackColor = true;
            this.addpaper.Click += new System.EventHandler(this.addpaper_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "试卷";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treepaperdoc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 659);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "试卷文档";
            // 
            // treepaperdoc
            // 
            this.treepaperdoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.treepaperdoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treepaperdoc.HideSelection = false;
            this.treepaperdoc.Location = new System.Drawing.Point(3, 21);
            this.treepaperdoc.Name = "treepaperdoc";
            this.treepaperdoc.Size = new System.Drawing.Size(243, 635);
            this.treepaperdoc.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 659);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文本";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(3, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(716, 635);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvitem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 659);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "题目列表";
            // 
            // dgvitem
            // 
            this.dgvitem.AllowUserToAddRows = false;
            this.dgvitem.AllowUserToDeleteRows = false;
            this.dgvitem.AllowUserToResizeColumns = false;
            this.dgvitem.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemno,
            this.itemtype,
            this.modeltext,
            this.itemid});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvitem.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvitem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvitem.Location = new System.Drawing.Point(3, 21);
            this.dgvitem.Name = "dgvitem";
            this.dgvitem.ReadOnly = true;
            this.dgvitem.RowHeadersVisible = false;
            this.dgvitem.RowTemplate.Height = 27;
            this.dgvitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvitem.Size = new System.Drawing.Size(273, 635);
            this.dgvitem.TabIndex = 0;
            // 
            // itemno
            // 
            this.itemno.DataPropertyName = "itemno";
            this.itemno.HeaderText = "题目号";
            this.itemno.Name = "itemno";
            this.itemno.ReadOnly = true;
            // 
            // itemtype
            // 
            this.itemtype.DataPropertyName = "itemtype";
            this.itemtype.HeaderText = "题目类型";
            this.itemtype.Name = "itemtype";
            this.itemtype.ReadOnly = true;
            // 
            // modeltext
            // 
            this.modeltext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modeltext.DataPropertyName = "modeltext";
            this.modeltext.HeaderText = "模型文本";
            this.modeltext.Name = "modeltext";
            this.modeltext.ReadOnly = true;
            // 
            // itemid
            // 
            this.itemid.DataPropertyName = "itemid";
            this.itemid.HeaderText = "itemid";
            this.itemid.Name = "itemid";
            this.itemid.ReadOnly = true;
            this.itemid.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt2);
            this.panel2.Controls.Add(this.txt1);
            this.panel2.Controls.Add(this.btnreplace);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(3, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1258, 42);
            this.panel2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(884, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "→";
            this.label7.Visible = false;
            // 
            // txt2
            // 
            this.txt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt2.Location = new System.Drawing.Point(940, 9);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(193, 25);
            this.txt2.TabIndex = 15;
            this.txt2.Visible = false;
            // 
            // txt1
            // 
            this.txt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt1.Location = new System.Drawing.Point(656, 9);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(209, 25);
            this.txt1.TabIndex = 15;
            this.txt1.Visible = false;
            // 
            // btnreplace
            // 
            this.btnreplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnreplace.Location = new System.Drawing.Point(1152, 10);
            this.btnreplace.Name = "btnreplace";
            this.btnreplace.Size = new System.Drawing.Size(75, 25);
            this.btnreplace.TabIndex = 14;
            this.btnreplace.Text = "替换";
            this.btnreplace.UseVisualStyleBackColor = true;
            this.btnreplace.Visible = false;
            this.btnreplace.Click += new System.EventHandler(this.btnreplace_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(220, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 27);
            this.label6.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(21, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 27);
            this.label5.TabIndex = 12;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(975, 659);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.TabIndex = 7;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(3, 111);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(1258, 659);
            this.splitContainer2.SplitterDistance = 975;
            this.splitContainer2.TabIndex = 8;
            // 
            // voicemodel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 775);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "voicemodel";
            this.Text = "模型制作";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.voicemodel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delpaper;
        private System.Windows.Forms.Button editpaper;
        private System.Windows.Forms.Button addpaper;
        private System.Windows.Forms.Button docdel;
        private System.Windows.Forms.Button docadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treepaperdoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvitem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndelitem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemno;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeltext;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemid;
        private System.Windows.Forms.Button btnitemedit;
        private System.Windows.Forms.Button btnreplace;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label7;
    }
}