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
    public partial class paperedit : Form
    {
        paper paper1 = new paper();
        public delegate void refresh();
        public event refresh Refreshpaper;

        public paperedit(int id)
        {

            InitializeComponent();
            paper1 = MySqlHelper.GetDataSet(CommandType.Text,string.Format("SELECT * FROM AI_paper WHERE paperid={0}",id)).Tables[0].ToModels<paper>().First();
        }

        private void paperedit_Load(object sender, EventArgs e)
        {
            string sqlstr = "SELECT * FROM AI_paperdict";
            DataSet dataset = MySqlHelper.GetDataSet(CommandType.Text, sqlstr);
            comboBox1.DataSource = dataset.Tables[0];
            comboBox1.DisplayMember = "papercode";
            comboBox1.ValueMember = "id";
            comboBox1.Text = "";

            textBox1.Text = paper1.name;
            comboBox1.SelectedValue = paper1.paperid;
            comboBox1.Text = paper1.papercode;
            textBox2.Text = paper1.desc;
            txtmodelname.Text = paper1.lm_postfix;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string papercode = comboBox1.Text.Trim();
            string desc = textBox2.Text.Trim();
            string lm_postfix = txtmodelname.Text.Trim();
            string sqlstr = string.Format("UPDATE AI_paper SET name = '{0}',papercode = '{1}',`desc` = '{2}',lm_postfix ='{3}' WHERE paperid={4}", name,papercode, desc, lm_postfix,paper1.paperid);
            try
            {
                MySqlHelper.ExecuteScalar(CommandType.Text,sqlstr);
                MessageBox.Show("更新成功!!!");
                Refreshpaper();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("更新失败!!!");
            }
        }
    }
}
