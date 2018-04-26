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
    public partial class questionitemadd : Form
    {

        private paper paper1 = new paper();
        public questionitemadd(paper currentpaper)
        {
            InitializeComponent();
            paper1 = currentpaper;
            this.Text = this.Text + "  " + paper1.name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox2.Text.Trim() != "")
            {
                int examid = session.selectexam.examid;
                string itemtype = this.comboBox2.Text.Trim();
                string itemno = this.comboBox3.Text.Trim();
                string itemcode = this.comboBox1.Text.Trim();
                string itemtext =this.txtitem.Text.Trim().Replace("'", @"\'");
                string answertext = this.txtanswer.Text.Trim().Replace("'", @"\'");
                string modeltext = this.txtmodel.Text.Trim().Replace("'", @"\'");
                //string modeltext = this.txtmodel.Text.Trim();
                float fullscore =Convert.ToInt32( nudfullscore.Value);

                string sqlstr = string.Format("INSERT INTO AI_item(examid, paperid, itemtype, itemno, itemcode, itemtext, answertext, modeltext,papercode,papername,fullscore) VALUES({0},{1},'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", session.selectexam.examid, paper1.paperid, itemtype, itemno, itemcode, itemtext, answertext, modeltext,paper1.papercode,paper1.name, fullscore);
                try
                {
                    MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr);                    
                    MessageBox.Show("添加成功!!!");
                    cleartxt();
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

        private void questionitemadd_Load(object sender, EventArgs e)
        {
            string sqlstr1 = "SELECT * FROM AI_itemdict";
            DataSet dataset1 = MySqlHelper.GetDataSet(CommandType.Text, sqlstr1);
            var data1= dataset1.Tables[0];

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

            var a = (DataRowView)comboBox3.SelectedItem;
            nudfullscore.Value = Convert.ToDecimal(a["fullscore"]);
            txtanswer.KeyDown += txt_result_KeyDown;
            txtitem.KeyDown += txt_result_KeyDown;
            txtmodel.KeyDown += txt_result_KeyDown;
            comboBox3.SelectedValueChanged += ComboBox3_SelectedValueChanged;

        }

        private void ComboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            var a = (DataRowView)comboBox3.SelectedItem;
            nudfullscore.Value = Convert.ToDecimal(a["fullscore"]);
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


        private void txt_result_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }



        private void cleartxt()
        {
            nudfullscore.Value = 0;
            txtanswer.Text = "";
            txtitem.Text = "";
            txtmodel.Text = "";
        }


    }
}
