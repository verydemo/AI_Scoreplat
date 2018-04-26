using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AI_Scoreplat
{
    public partial class savedir : Form
    {
        public savedir()
        {
            InitializeComponent();
        }

        private string fbd1SelectedPath = "";
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd1 = new FolderBrowserDialog();
            fbd1.Description = "请选择保存文件夹路径";
            if (fbd1.ShowDialog()== DialogResult.OK)
            {
                fbd1SelectedPath = fbd1.SelectedPath;
                textBox1.Text = fbd1SelectedPath;
            }
        }

        private void savedir_Load(object sender, EventArgs e)
        {
            session.batchdir = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            session.batchdir = fbd1SelectedPath;
            this.DialogResult = DialogResult.OK;
        }
    }
}
