using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace AI_Scoreplat
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            examadd examadd1 = new examadd();
            examadd1.Refreshexam += refreshexam;        
            examadd1.Show();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (session.selectexam == null)
            {
                MessageBox.Show("请选择一个考试!!!");
            }
            else {
                examedit examedit1 = new examedit();
                examedit1.Refreshexam += refreshexam;
                examedit1.Show();

            }

        }

        private void main_Load(object sender, EventArgs e)
        {
             string Version=Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = this.Text + "  " + Version;

            CheckForIllegalCrossThreadCalls = false;
            //Task.Factory.StartNew(()=>{
                if (MySqlHelper.Testcon())
                {
                    try
                    {
                        dgvexam.AutoGenerateColumns = false;
                        string sqlstr = string.Format("SELECT * FROM AI_exam");
                        DataSet dataset = MySqlHelper.GetDataSet(CommandType.Text, sqlstr);
                        dgvexam.DataSource = dataset.Tables[0];
                        dgvexam.ClearSelection();
                    }
                    catch (Exception)
                    {
                    }
                
                }
                else
                {

                }
                dgvexam.CellClick += Dgvexam_CellClick;

            //});
           

        }

        private void Dgvexam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int i = e.RowIndex;
                exam exam1 = new exam();
                exam1.examid =Convert.ToInt32(dgvexam.Rows[i].Cells[2].Value.ToString());
                exam1.name= dgvexam.Rows[i].Cells[0].Value.ToString();
                exam1.desc = dgvexam.Rows[i].Cells[1].Value.ToString();
                session.clearsession();
                session.selectexam = MySqlHelper.GetDataSet(CommandType.Text,string.Format("SELECT * FROM AI_exam WHERE examid={0}", exam1.examid)).Tables[0].ToModels<exam>().First();
            }
        }

        private void btnrfh_Click(object sender, EventArgs e)
        {
            if (MySqlHelper.Testcon())
            {
                dgvexam.AutoGenerateColumns = false;
                string sqlstr = string.Format("SELECT * FROM AI_exam");
                DataSet dataset = MySqlHelper.GetDataSet(CommandType.Text, sqlstr);
                dgvexam.DataSource = dataset.Tables[0];
                dgvexam.ClearSelection();
            }
            else
            {

            }
        }

        private void tsbmx_Click(object sender, EventArgs e)
        {
            if (session.selectexam!=null)
            {
                voicemodel vm1 = new voicemodel();
                session.clearsession();
                vm1.ShowDialog();


            }
            else {
                MessageBox.Show("请选择一场考试!!!");
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (session.selectexam != null)
            {
                if (MessageBox.Show("确认删除？考试信息都会删除!!!", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sqlstr = string.Format("DELETE FROM AI_exam WHERE examid={0};DELETE FROM AI_paper WHERE examid={0};DELETE FROM AI_doc WHERE examid={0};DELETE FROM AI_item WHERE examid={0}", session.selectexam.examid);
                    try
                    {
                        MySqlHelper.ExecuteNonQuery(CommandType.Text, sqlstr);
                        refreshexam();
                        MessageBox.Show("删除成功!!!");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("删除失败!!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一场考试!!!");
            }


           
        }


        private void refreshexam()
        {

            if (MySqlHelper.Testcon())
            {
                try
                {
                    dgvexam.AutoGenerateColumns = false;
                    string sqlstr = string.Format("SELECT * FROM AI_exam");
                    DataSet dataset = MySqlHelper.GetDataSet(CommandType.Text, sqlstr);
                    dgvexam.DataSource = dataset.Tables[0];
                    dgvexam.ClearSelection();
                }
                catch (Exception)
                {

                }
           
            }

        }

        private void tsbpc_Click(object sender, EventArgs e)
        {
            importbatch ib1 = new importbatch();
            ib1.Show();

        }

        private void btnfinish_Click(object sender, EventArgs e)
        {

            if (session.selectexam == null)
            {
                MessageBox.Show("请选择一个考试!!!");
            }
            else
            {
                string sqlstr = string.Format("SELECT count(*) FROM AI_paper WHERE examid={0} AND status='0'", session.selectexam.examid);
                int count = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr));
                if (count == 0)
                {
                    string sqlstr1 = string.Format("UPDATE AI_exam SET status='1' WHERE examid={0}", session.selectexam.examid);
                    MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr1);
                    refreshexam();
                    MessageBox.Show("考试已完成!!!");
                }
                else
                {
                    MessageBox.Show("当前考试下面有试卷没有完成!!!");
                }

            }
           
        }

        private void tsbdrdc_Click(object sender, EventArgs e)
        {
            if (session.selectexam == null)
            {
                MessageBox.Show("请选择一个考试!!!");
            }
            else
            {
                drdc drdc1 = new drdc();
                drdc1.ShowDialog();
            }
        }

        private void tsbjk_Click(object sender, EventArgs e)
        {
            progressmonitor pm1 = new progressmonitor();
            pm1.ShowDialog();
        }

        private void tsmicorr_Click(object sender, EventArgs e)
        {
            if (session.selectexam != null)
            {
                corr corr1 = new corr();
                corr1.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择一场考试!!!");
            }
          
        }

        private void tsmidatabase_Click(object sender, EventArgs e)
        {
            databaseoper do1 = new databaseoper();
            do1.ShowDialog();
        }

        private void tsmiconfig_Click(object sender, EventArgs e)
        {
            configview cv1 = new configview();
            cv1.ShowDialog();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            if (session.selectexam == null)
            {
                MessageBox.Show("请选择一个考试!!!");
            }
            else
            {
              
                checkpaper cp1 = new checkpaper();
                cp1.ShowDialog();
            }

        }

        private void tsmicf_Click(object sender, EventArgs e)
        {
            output o1 = new output();
            o1.ShowDialog();
        }

        private void tsmifinallyscore_Click(object sender, EventArgs e)
        {
            finallyscore fs1 = new finallyscore();
            fs1.ShowDialog();
        }
    }
}
