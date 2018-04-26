namespace AI_Scoreplat
{
    partial class databaseoper
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
            this.btninit = new System.Windows.Forms.Button();
            this.btnreduction = new System.Windows.Forms.Button();
            this.btnbackups = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbuse = new System.Windows.Forms.CheckBox();
            this.btntestconn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txthost = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 705);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // btninit
            // 
            this.btninit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btninit.Location = new System.Drawing.Point(24, 34);
            this.btninit.Name = "btninit";
            this.btninit.Size = new System.Drawing.Size(158, 43);
            this.btninit.TabIndex = 9;
            this.btninit.Text = "数据库初始化";
            this.btninit.UseVisualStyleBackColor = true;
            this.btninit.Click += new System.EventHandler(this.btninit_Click);
            // 
            // btnreduction
            // 
            this.btnreduction.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnreduction.Location = new System.Drawing.Point(576, 362);
            this.btnreduction.Name = "btnreduction";
            this.btnreduction.Size = new System.Drawing.Size(138, 43);
            this.btnreduction.TabIndex = 8;
            this.btnreduction.Text = "数据库还原";
            this.btnreduction.UseVisualStyleBackColor = true;
            this.btnreduction.Click += new System.EventHandler(this.btnreduction_Click);
            // 
            // btnbackups
            // 
            this.btnbackups.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnbackups.Location = new System.Drawing.Point(393, 362);
            this.btnbackups.Name = "btnbackups";
            this.btnbackups.Size = new System.Drawing.Size(138, 43);
            this.btnbackups.TabIndex = 7;
            this.btnbackups.Text = "数据库备份";
            this.btnbackups.UseVisualStyleBackColor = true;
            this.btnbackups.Click += new System.EventHandler(this.btnbackups_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(772, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 713);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出信息";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(210, 689);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtdatabase);
            this.groupBox3.Controls.Add(this.txtpwd);
            this.groupBox3.Controls.Add(this.txtuser);
            this.groupBox3.Controls.Add(this.txthost);
            this.groupBox3.Controls.Add(this.btnreduction);
            this.groupBox3.Controls.Add(this.btnbackups);
            this.groupBox3.Controls.Add(this.btntestconn);
            this.groupBox3.Controls.Add(this.cbuse);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(7, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(740, 440);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(32, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "密码：";
            // 
            // cbuse
            // 
            this.cbuse.AutoSize = true;
            this.cbuse.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbuse.Location = new System.Drawing.Point(234, 368);
            this.cbuse.Name = "cbuse";
            this.cbuse.Size = new System.Drawing.Size(114, 31);
            this.cbuse.TabIndex = 6;
            this.cbuse.Text = "使用参数";
            this.cbuse.UseVisualStyleBackColor = true;
            // 
            // btntestconn
            // 
            this.btntestconn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btntestconn.Location = new System.Drawing.Point(576, 289);
            this.btntestconn.Name = "btntestconn";
            this.btntestconn.Size = new System.Drawing.Size(138, 39);
            this.btntestconn.TabIndex = 5;
            this.btntestconn.Text = "测试连接";
            this.btntestconn.UseVisualStyleBackColor = true;
            this.btntestconn.Click += new System.EventHandler(this.btntestconn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btninit);
            this.groupBox4.Location = new System.Drawing.Point(7, 471);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(740, 234);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // txthost
            // 
            this.txthost.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txthost.Location = new System.Drawing.Point(168, 33);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(491, 30);
            this.txthost.TabIndex = 1;
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtuser.Location = new System.Drawing.Point(168, 96);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(491, 30);
            this.txtuser.TabIndex = 2;
            // 
            // txtpwd
            // 
            this.txtpwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtpwd.Location = new System.Drawing.Point(168, 166);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(491, 30);
            this.txtpwd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(32, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "数据库名称：";
            // 
            // txtdatabase
            // 
            this.txtdatabase.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtdatabase.Location = new System.Drawing.Point(168, 225);
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.PasswordChar = '*';
            this.txtdatabase.Size = new System.Drawing.Size(491, 30);
            this.txtdatabase.TabIndex = 4;
            // 
            // databaseoper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 730);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "databaseoper";
            this.Text = "数据库操作";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnbackups;
        private System.Windows.Forms.Button btninit;
        private System.Windows.Forms.Button btnreduction;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbuse;
        private System.Windows.Forms.Button btntestconn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txthost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdatabase;
    }
}