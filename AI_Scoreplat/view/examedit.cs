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
    public partial class examedit : Form
    {
        public examedit()
        {
            InitializeComponent();
        }
        public delegate void refresh();
        public event refresh Refreshexam;
        private void examedit_Load(object sender, EventArgs e)
        {

                textBox1.Text = session.selectexam.name;
                textBox2.Text = session.selectexam.desc;        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() != "")
            {
                string name = this.textBox1.Text.Trim();
                string desc = this.textBox2.Text.Trim();
                string sqlstr = string.Format("UPDATE AI_exam SET name = '{0}',`desc` ='{1}'  WHERE examid={2}", name, desc,session.selectexam.examid);
                try
                {
                    MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr);
                    Refreshexam();
                    MessageBox.Show("修改成功!!!");
                }
                catch (Exception)
                {
                    MessageBox.Show("修改失败!!!");
                }

            }
            else
            {

                MessageBox.Show("名称不能为空!!!");
                return;
            }
        }
    }
}
