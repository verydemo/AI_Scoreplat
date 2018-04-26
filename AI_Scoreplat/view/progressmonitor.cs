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
    public partial class progressmonitor : Form
    {
        public progressmonitor()
        {
            InitializeComponent();
        }

        private void progressmonitor_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.r4.Click +=R4_Click;


            refreshdata();

            timer1.Interval = 120000;
            timer1.Start();
            timer1.Tick += Timer1_Tick;      
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            refreshdata();
        }

        private void R4_Click(object sender, EventArgs e)
        {
            machinelist ml1 = new machinelist();
            ml1.Show();
        }

        private void refreshdata()
        {

            #region 试卷文本
            Task.Factory.StartNew(() => {
                ///试卷总数
                string sqlp1 = string.Format("SELECT count(*) FROM AI_paper");
                int p1 = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqlp1));
                this.p1.Text = p1.ToString();

                ///试卷文本已完成数
                string sqlp2 = string.Format("SELECT count(*) FROM AI_paper WHERE status<>'0'");
                int p2 = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqlp2));
                this.p2.Text = p2.ToString();
                ///试卷文本未完成数
                string sqlp3 = string.Format("SELECT count(*) FROM AI_paper WHERE status='0'");
                int p3 = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqlp3));
                this.p3.Text = p3.ToString();
            });
            #endregion

            #region 语言模型

            Task.Factory.StartNew(() =>
            {
                ///语言模型总数
                string sqly1 = string.Format("SELECT count(*) FROM AI_paper");
                int y1 = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqly1));
                this.y1.Text = y1.ToString();

                ///语言模型已完成数
                string sqly2 = string.Format("SELECT count(*) FROM AI_paper WHERE status='2'");
                int y2 = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqly2));
                this.y2.Text = y2.ToString();

                ///语言模型未完成数
                string sqly3 = string.Format("SELECT count(*) FROM AI_paper WHERE status<>'2'");
                int y3 = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqly3));
                this.y3.Text = y3.ToString();
            });
            #endregion

            #region 入库
            Task.Factory.StartNew(() =>
            {
                ///入库zip数
                string sqlr1 = string.Format("SELECT count(*) FROM AI_file");
                int r1 = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqlr1));
                this.r1.Text = r1.ToString();
                ///入库package数
                string sqlr2 = string.Format("SELECT count(*) FROM AI_package");
                int r2 = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqlr2));
                this.r2.Text = r2.ToString();
                ///入库task数
                string sqlr3 = string.Format("SELECT count(*) FROM AI_task");
                int r3 = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqlr3));
                this.r3.Text = r3.ToString();

                ///机器数
                string sqlr4 = string.Format("SELECT count(t.counts) FROM (SELECT count(worker) counts FROM AI_package WHERE worker IS not null GROUP BY worker ) t");
                int r4 = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqlr4));
                this.r4.Text = r4.ToString();
            });
            #endregion

            #region 评分package
            Task.Factory.StartNew(() =>
            {
                ///评分package总数
                string sqlpp1 = string.Format("SELECT count(*) FROM AI_package");
                int pp1 = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqlpp1));
                this.pp1.Text = pp1.ToString();
                ///评分package已完成数
                string sqlpp2 = string.Format("SELECT count(*) FROM AI_package WHERE status=9");
                int pp2 = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqlpp2));
                this.pp2.Text = pp2.ToString();
                ///评分package未取数
                string sqlpp3 = string.Format("SELECT count(*) FROM AI_package WHERE status=0");
                int pp3 = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqlpp3));
                this.pp3.Text = pp3.ToString();
                ///评分package正在进行数
                string sqlpp4 = string.Format("SELECT count(*) FROM AI_package WHERE status=1");
                int pp4 = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqlpp4));
                this.pp4.Text = pp4.ToString();
            });
            #endregion

            #region 评分
            ///评分-已出分
            Task.Factory.StartNew(() =>
            {
                string sqlps1 = string.Format("select count(t.counts) FROM (SELECT count(filename) counts FROM AI_score GROUP BY filename) t");
                int ps1 = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqlps1));
                this.ps1.Text = ps1.ToString();
            });
            #endregion



        }
    }
}
