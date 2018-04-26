namespace AI_Scoreplat
{
    partial class machinelist
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvmachine = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastupdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lyb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wcb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagecount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmachine)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvmachine);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1117, 720);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dgvmachine
            // 
            this.dgvmachine.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvmachine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmachine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.lastupdate,
            this.totalcount,
            this.lyb,
            this.wcb,
            this.packagecount});
            this.dgvmachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvmachine.Location = new System.Drawing.Point(3, 21);
            this.dgvmachine.Name = "dgvmachine";
            this.dgvmachine.ReadOnly = true;
            this.dgvmachine.RowTemplate.Height = 27;
            this.dgvmachine.Size = new System.Drawing.Size(1111, 696);
            this.dgvmachine.TabIndex = 0;
            // 
            // username
            // 
            this.username.DataPropertyName = "machinename";
            this.username.HeaderText = "机器名";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 200;
            // 
            // lastupdate
            // 
            this.lastupdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastupdate.DataPropertyName = "lastupdate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.lastupdate.DefaultCellStyle = dataGridViewCellStyle6;
            this.lastupdate.HeaderText = "离线时间(分钟)";
            this.lastupdate.Name = "lastupdate";
            this.lastupdate.ReadOnly = true;
            // 
            // totalcount
            // 
            this.totalcount.DataPropertyName = "totalcount";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.totalcount.DefaultCellStyle = dataGridViewCellStyle7;
            this.totalcount.HeaderText = "总数";
            this.totalcount.Name = "totalcount";
            this.totalcount.ReadOnly = true;
            // 
            // lyb
            // 
            this.lyb.DataPropertyName = "lycount";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.lyb.DefaultCellStyle = dataGridViewCellStyle8;
            this.lyb.HeaderText = "领用包";
            this.lyb.Name = "lyb";
            this.lyb.ReadOnly = true;
            // 
            // wcb
            // 
            this.wcb.DataPropertyName = "wccount";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.wcb.DefaultCellStyle = dataGridViewCellStyle9;
            this.wcb.HeaderText = "完成包";
            this.wcb.Name = "wcb";
            this.wcb.ReadOnly = true;
            // 
            // packagecount
            // 
            this.packagecount.DataPropertyName = "packcount";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.packagecount.DefaultCellStyle = dataGridViewCellStyle10;
            this.packagecount.HeaderText = "package数";
            this.packagecount.Name = "packagecount";
            this.packagecount.ReadOnly = true;
            this.packagecount.Width = 150;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // machinelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 720);
            this.Controls.Add(this.groupBox2);
            this.Name = "machinelist";
            this.Text = "机器列表";
            this.Load += new System.EventHandler(this.machinelist_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmachine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvmachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastupdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn lyb;
        private System.Windows.Forms.DataGridViewTextBoxColumn wcb;
        private System.Windows.Forms.DataGridViewTextBoxColumn packagecount;
        private System.Windows.Forms.Timer timer1;
    }
}