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
    public partial class examadd : Form
    {
        public examadd()
        {
            InitializeComponent();
        }

        public delegate void refresh();
        public event refresh Refreshexam;


        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() != "")
            {
                string name = this.textBox1.Text.Trim();
                string desc = this.textBox2.Text.Trim();
                string sqlstr = string.Format("INSERT INTO AI_exam (name, `desc`) VALUES ('{0}', '{1}')",name,desc);
                try
                {
                    MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr);
                    Refreshexam();
                    MessageBox.Show("添加成功!!!");
                }
                catch (Exception)
                {
                    MessageBox.Show("添加失败!!!");
                }
               
            }
            else {

                MessageBox.Show("名称不能为空!!!");
                return;
            }
        }
    }
}
