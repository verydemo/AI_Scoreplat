namespace AI_Scoreplat
{
    partial class itemedit
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
            this.nudfullscore = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudfullscore)).BeginInit();
            this.SuspendLayout();
            // 
            // nudfullscore
            // 
            this.nudfullscore.DecimalPlaces = 1;
            this.nudfullscore.Enabled = false;
            this.nudfullscore.Location = new System.Drawing.Point(473, 74);
            this.nudfullscore.Name = "nudfullscore";
            this.nudfullscore.ReadOnly = true;
            this.nudfullscore.Size = new System.Drawing.Size(120, 25);
            this.nudfullscore.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "分值";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 702);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 37);
            this.button2.TabIndex = 23;
            this.button2.TabStop = false;
            this.button2.Text = "model文本转化";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(131, 24);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(211, 23);
            this.comboBox3.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(131, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(211, 23);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(473, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 23);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.TabStop = false;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(660, 704);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 35);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "确认";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(131, 497);
            this.txtmodel.Multiline = true;
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtmodel.Size = new System.Drawing.Size(625, 180);
            this.txtmodel.TabIndex = 5;
            // 
            // txtanswer
            // 
            this.txtanswer.Location = new System.Drawing.Point(131, 294);
            this.txtanswer.Multiline = true;
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtanswer.Size = new System.Drawing.Size(625, 175);
            this.txtanswer.TabIndex = 4;
            // 
            // txtitem
            // 
            this.txtitem.Location = new System.Drawing.Point(131, 125);
            this.txtitem.Multiline = true;
            this.txtitem.Name = "txtitem";
            this.txtitem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtitem.Size = new System.Drawing.Size(625, 148);
            this.txtitem.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "model文本";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "answer文本";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "题目文本";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "题目类型";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "题号代码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "题号";
            // 
            // itemedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 751);
            this.Controls.Add(this.nudfullscore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.txtanswer);
            this.Controls.Add(this.txtitem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "itemedit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "题目修改";
            this.Load += new System.EventHandler(this.itemedit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudfullscore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudfullscore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}