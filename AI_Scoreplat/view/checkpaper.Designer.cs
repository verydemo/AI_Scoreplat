namespace AI_Scoreplat
{
    partial class checkpaper
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbodoc = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboitem = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbopaper = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtdoc = new System.Windows.Forms.TextBox();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnextitem = new System.Windows.Forms.Button();
            this.btnnextpaper = new System.Windows.Forms.Button();
            this.btnnextdoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1290, 682);
            this.splitContainer1.SplitterDistance = 622;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtdoc);
            this.groupBox3.Location = new System.Drawing.Point(10, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 570);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文档文本";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnnextdoc);
            this.groupBox1.Controls.Add(this.cbodoc);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "试卷文档";
            // 
            // cbodoc
            // 
            this.cbodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodoc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbodoc.FormattingEnabled = true;
            this.cbodoc.Location = new System.Drawing.Point(19, 36);
            this.cbodoc.Name = "cbodoc";
            this.cbodoc.Size = new System.Drawing.Size(319, 35);
            this.cbodoc.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtitem);
            this.groupBox4.Location = new System.Drawing.Point(9, 109);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(648, 570);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "题目文本";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnnextitem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboitem);
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 90);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "题目";
            // 
            // cboitem
            // 
            this.cboitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboitem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboitem.FormattingEnabled = true;
            this.cboitem.Location = new System.Drawing.Point(147, 36);
            this.cboitem.Name = "cboitem";
            this.cboitem.Size = new System.Drawing.Size(305, 35);
            this.cboitem.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1290, 739);
            this.splitContainer2.SplitterDistance = 53;
            this.splitContainer2.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnnextpaper);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.cbopaper);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1290, 53);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "试卷";
            // 
            // cbopaper
            // 
            this.cbopaper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopaper.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbopaper.FormattingEnabled = true;
            this.cbopaper.Location = new System.Drawing.Point(115, 15);
            this.cbopaper.Name = "cbopaper";
            this.cbopaper.Size = new System.Drawing.Size(235, 35);
            this.cbopaper.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 682);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 682);
            this.panel2.TabIndex = 0;
            // 
            // txtdoc
            // 
            this.txtdoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtdoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtdoc.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtdoc.Location = new System.Drawing.Point(3, 21);
            this.txtdoc.Multiline = true;
            this.txtdoc.Name = "txtdoc";
            this.txtdoc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtdoc.Size = new System.Drawing.Size(599, 546);
            this.txtdoc.TabIndex = 0;
            // 
            // txtitem
            // 
            this.txtitem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtitem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtitem.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtitem.Location = new System.Drawing.Point(3, 21);
            this.txtitem.Multiline = true;
            this.txtitem.Name = "txtitem";
            this.txtitem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtitem.Size = new System.Drawing.Size(642, 546);
            this.txtitem.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "题号";
            // 
            // btnnextitem
            // 
            this.btnnextitem.Location = new System.Drawing.Point(498, 36);
            this.btnnextitem.Name = "btnnextitem";
            this.btnnextitem.Size = new System.Drawing.Size(83, 35);
            this.btnnextitem.TabIndex = 2;
            this.btnnextitem.Text = "下一题";
            this.btnnextitem.UseVisualStyleBackColor = true;
            this.btnnextitem.Click += new System.EventHandler(this.btnnextitem_Click);
            // 
            // btnnextpaper
            // 
            this.btnnextpaper.Location = new System.Drawing.Point(436, 15);
            this.btnnextpaper.Name = "btnnextpaper";
            this.btnnextpaper.Size = new System.Drawing.Size(89, 35);
            this.btnnextpaper.TabIndex = 2;
            this.btnnextpaper.Text = "下一试卷";
            this.btnnextpaper.UseVisualStyleBackColor = true;
            this.btnnextpaper.Click += new System.EventHandler(this.btnnextpaper_Click);
            // 
            // btnnextdoc
            // 
            this.btnnextdoc.Location = new System.Drawing.Point(374, 36);
            this.btnnextdoc.Name = "btnnextdoc";
            this.btnnextdoc.Size = new System.Drawing.Size(89, 35);
            this.btnnextdoc.TabIndex = 2;
            this.btnnextdoc.Text = "下一文档";
            this.btnnextdoc.UseVisualStyleBackColor = true;
            this.btnnextdoc.Click += new System.EventHandler(this.btnnextdoc_Click);
            // 
            // checkpaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 748);
            this.Controls.Add(this.splitContainer2);
            this.Name = "checkpaper";
            this.Text = "核查题目";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.checkpaper_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbopaper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbodoc;
        private System.Windows.Forms.ComboBox cboitem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtdoc;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnextitem;
        private System.Windows.Forms.Button btnnextpaper;
        private System.Windows.Forms.Button btnnextdoc;
    }
}