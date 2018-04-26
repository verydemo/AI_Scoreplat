using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Scoreplat
{
    public partial class paperadd : Form
    {
        public paperadd()
        {
            InitializeComponent();
        }
        public delegate void refresh();
        public event refresh Refreshpaper;

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() != "")
            {
                int examid = session.selectexam.examid;
                string name = this.textBox1.Text.Trim();
                string desc = this.textBox2.Text.Trim();
                string papercode = this.comboBox1.Text.Trim();
                string lm_postfix = txtmodelname.Text.Trim();
                string sqlstr = string.Format("INSERT INTO AI_paper (examid, name, `desc`,papercode,lm_postfix,status) VALUES({0}, '{1}','{2}','{3}','{4}','0')", examid, name, desc, papercode,lm_postfix);
                try
                {
                    MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr);
                    Refreshpaper();
                    MessageBox.Show("添加成功!!!");
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("添加失败!!!");
                }

            }
            else
            {
                MessageBox.Show("名称不能为空!!!");
                return;
            }
        }

        private void paperadd_Load(object sender, EventArgs e)
        {
            string sqlstr = "SELECT * FROM AI_paperdict";
            DataSet dataset = MySqlHelper.GetDataSet(CommandType.Text, sqlstr);
            comboBox1.DataSource = dataset.Tables[0];
            comboBox1.DisplayMember = "papercode";
            comboBox1.ValueMember = "id";
            comboBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.comboBox1.Focus();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1.Focus();
            }
        }
    }
}
