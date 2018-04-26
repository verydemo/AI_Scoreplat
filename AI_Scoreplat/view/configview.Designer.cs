namespace AI_Scoreplat
{
    partial class configview
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
            this.nudpaperitemcount = new System.Windows.Forms.NumericUpDown();
            this.txtlm_other = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcommondir = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudpaperitemcount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.nudpaperitemcount);
            this.groupBox1.Controls.Add(this.txtcommondir);
            this.groupBox1.Controls.Add(this.txtlm_other);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 566);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // nudpaperitemcount
            // 
            this.nudpaperitemcount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudpaperitemcount.Location = new System.Drawing.Point(295, 54);
            this.nudpaperitemcount.Name = "nudpaperitemcount";
            this.nudpaperitemcount.Size = new System.Drawing.Size(120, 30);
            this.nudpaperitemcount.TabIndex = 1;
            // 
            // txtlm_other
            // 
            this.txtlm_other.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtlm_other.Location = new System.Drawing.Point(295, 111);
            this.txtlm_other.Name = "txtlm_other";
            this.txtlm_other.Size = new System.Drawing.Size(378, 34);
            this.txtlm_other.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(68, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "总语言模型名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(68, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "每张试卷音频数量：";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsave.Location = new System.Drawing.Point(647, 496);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(109, 40);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "保存";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(68, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "公共文件夹：";
            // 
            // txtcommondir
            // 
            this.txtcommondir.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtcommondir.Location = new System.Drawing.Point(295, 166);
            this.txtcommondir.Name = "txtcommondir";
            this.txtcommondir.Size = new System.Drawing.Size(378, 34);
            this.txtcommondir.TabIndex = 2;
            // 
            // configview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 566);
            this.Controls.Add(this.groupBox1);
            this.Name = "configview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参数配置";
            this.Load += new System.EventHandler(this.configview_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudpaperitemcount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlm_other;
        private System.Windows.Forms.NumericUpDown nudpaperitemcount;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcommondir;
    }
}