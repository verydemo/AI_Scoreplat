using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AI_Scoreplat
{
    public partial class itemedit : Form
    {

        private paper paper1 = new paper();
        private item item1 = new item();
        public itemedit(paper currentpaper, item currentitem)
        {
            InitializeComponent();

            paper1 = currentpaper;
            this.Text = this.Text + "  " + paper1.name;
            item1 = MySqlHelper.GetDataSet(CommandType.Text,string.Format("SELECT * FROM AI_item WHERE itemid={0}", currentitem.itemid)).Tables[0].ToModels<item>().First();

        }

        private void itemedit_Load(object sender, EventArgs e)
        {

            string sqlstr1 = "SELECT * FROM AI_itemdict";
            DataSet dataset1 = MySqlHelper.GetDataSet(CommandType.Text, sqlstr1);
            var data1 = dataset1.Tables[0];

            comboBox3.DataSource = data1;
            comboBox1.DataSource = data1;
            comboBox1.DisplayMember = "itemcode";
            comboBox1.ValueMember = "id";
            //comboBox1.Text = "";

            comboBox2.DataSource = data1;
            comboBox2.DisplayMember = "itemtype";
            comboBox2.ValueMember = "id";
            //comboBox2.Text = "";

            comboBox3.DisplayMember = "itemno";
            comboBox3.ValueMember = "id";
            //comboBox3.Text = "";

            txtanswer.KeyDown += txt_result_KeyDown;
            txtitem.KeyDown += txt_result_KeyDown;
            txtmodel.KeyDown += txt_result_KeyDown;

            comboBox3.Text = item1.itemno;
            nudfullscore.Value =Convert.ToDecimal( item1.fullscore);
            txtanswer.Text = item1.answertext;
            txtitem.Text = item1.itemtext;
            txtmodel.Text = item1.modeltext;

            comboBox3.SelectedValueChanged += ComboBox3_SelectedValueChanged;

        }

        private void ComboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            var a = (DataRowView)comboBox3.SelectedItem;
            nudfullscore.Value = Convert.ToDecimal(a["fullscore"]);
        }

        private void txt_result_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regex re1 = new Regex("[^a-zA-Z']");
            Regex re2 = new Regex(@"\s+");
            string tmptxt = this.txtmodel.Text;
            tmptxt = re1.Replace(tmptxt, " ");
            tmptxt = re2.Replace(tmptxt, " ").Trim();
            //string modeltxt = tmptxt.Replace("'", @"\'");
            string modeltxt = tmptxt;
            this.txtmodel.Text = modeltxt;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (this.comboBox2.Text.Trim() != "")
            {
                int examid = session.selectexam.examid;
                string itemtype = this.comboBox2.Text.Trim();
                string itemno = this.comboBox3.Text.Trim();
                string itemcode = this.comboBox1.Text.Trim();
                string itemtext = this.txtitem.Text.Trim().Replace("'", @"\'");
                string answertext = this.txtanswer.Text.Trim().Replace("'", @"\'");
                string modeltext = this.txtmodel.Text.Trim().Replace("'", @"\'");
                decimal fullscore = nudfullscore.Value;
                //string modeltext = this.txtmodel.Text.Trim();

                string sqlstr = string.Format("UPDATE AI_item SET examid ={0},paperid ={1},papercode = '{2}',papername ='{3}',fullscore = {4},itemtype ='{5}',itemno = '{6}',itemcode ='{7}',itemtext ='{8}',modeltext = '{9}',answertext = '{10}' where itemid={11}", examid,paper1.paperid,paper1.papercode,paper1.name,fullscore,itemtype,itemno,itemcode, itemtext, modeltext,answertext,item1.itemid);
                try
                {
                    MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr);
                    MessageBox.Show("修改成功!!!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("添加失败!!!");
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
