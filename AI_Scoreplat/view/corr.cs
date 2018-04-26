using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.Statistics;

namespace AI_Scoreplat
{
    public partial class corr : Form
    {
        public corr()
        {
            InitializeComponent();
        }
        delegate void SetdgvCallback();
        private void corr_Load(object sender, EventArgs e)
        {
            dgvcorr.AutoGenerateColumns = false;
            CheckForIllegalCrossThreadCalls = false;


            Task.Factory.StartNew(() =>
            {
                if (this.dgvcorr.InvokeRequired)
                {
                    SetdgvCallback d = new SetdgvCallback(corrdata);
                    this.Invoke(d);
                }
            });
        }


        private void corrdata()
        {
            string sql1 = "SELECT t1.papercode,t1.itemno,t1.pcid,t1.filename,t1.score levelscore, t2.scorelast,t4.fullscore FROM AI_levelscore t1, AI_score t2,AI_listenScore t3, AI_itemdict t4 WHERE t1.filename = t2.filename AND t1.papercode = t3.papercode AND t1.encodeno = t3.encodeno AND t1.pcid = t3.pcid AND t3.sign = '0' AND t3.batchdesc = '定标' and t3.validflag='2' AND t1.itemno = t4.itemno AND t2.validflag='2'";

            //string sql1 = "SELECT t1.papercode,t1.itemno,t1.pcid,t2.filename,t1.score levelscore, t2.score scorelast,t4.fullscore  FROM AI_levelscore t1, totalyzs t2,AI_listenScore t3, AI_itemdict t4 WHERE t1.papercode = t3.papercode AND t1.encodeno = t3.encodeno AND t1.pcid = t3.pcid AND t3.sign = '0'  AND t3.batchdesc = '定标' AND t1.itemno = t4.itemno AND t1.papercode=t2.papercode AND t1.encodeno=t2.encodeno AND t1.itemcode=t2.itemno AND t1.pcid=t2.pcid";

            List<levelscorelast> levelscorelastlist1 = MySqlHelper.GetDataSet(CommandType.Text, sql1).Tables[0].ToModels<levelscorelast>();
            var corrlist = levelscorelastlist1.GroupBy(a => new { a.papercode, a.itemno }).Select(b => (new { papercode = b.First().papercode, itemno = b.First().itemno, corr = Correlation.Pearson(b.Select(b1 => b1.levelscore), b.Select(b2 => b2.scorelast)), per15 = b.Sum(b1 => b1.per15) / b.Count(), per25 = b.Sum(b2 => b2.per25) / b.Count(), per50 = b.Sum(b3 => b3.per50) / b.Count(), count = b.Count() })).ToList();
            var corrlist1= levelscorelastlist1.GroupBy(a => a.itemno).Select(b => (new { papercode = "(总)"+b.First().itemno, itemno = b.First().itemno, corr = Correlation.Pearson(b.Select(b1 => b1.levelscore), b.Select(b2 => b2.scorelast)), per15 = b.Sum(b1 => b1.per15) / b.Count(), per25 = b.Sum(b2 => b2.per25) / b.Count(), per50 = b.Sum(b3 => b3.per50) / b.Count(), count = b.Count() })).ToList();
            corrlist.AddRange(corrlist1);

            dgvcorr.DataSource = corrlist.OrderBy(a =>a.itemno).ThenByDescending(a=>a.count).ToList();

        }


        private void benexcel_Click(object sender, EventArgs e)
        {
            if(CommonHelper.ExportExcel(session.selectexam.name + "相关指标", dgvcorr))
            {
                MessageBox.Show("文件： " + session.selectexam.name + "相关指标" + ".xls 保存成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
