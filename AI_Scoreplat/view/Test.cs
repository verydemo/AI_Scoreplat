using MathNet.Numerics.Statistics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace AI_Scoreplat
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void abc()
        {
            string sql1 = "SELECT t1.papercode,t1.itemno,t1.pcid,t1.filename,t1.score levelscore, t2.scorelast FROM AI_levelscore t1, AI_score t2,AI_listenScore t3, AI_itemdict t4 WHERE t1.filename = t2.filename AND t1.papercode = t3.papercode AND t1.encodeno = t3.encodeno AND t1.pcid = t3.pcid AND t3.sign = '0' AND t3.batchdesc = '定标' AND t1.itemno = t4.itemno AND t4.itemtype != 'QA' AND t2.validflag='2'";
            List<levelscorelast> levelscorelastlist1 = MySqlHelper.GetDataSet(CommandType.Text, sql1).Tables[0].ToModels<levelscorelast>();
            var corrlist = levelscorelastlist1.GroupBy(a => new { a.papercode, a.itemno }).Select(b => (new { papercode = b.First().papercode, itemno = b.First().itemno, corr = Correlation.Pearson(b.Select(b1 => b1.levelscore), b.Select(b2 => b2.scorelast)), count = b.Count() })).ToList();
            var corrlist1 = levelscorelastlist1.GroupBy(a => a.itemno).Select(b => (new { papercode = "(总)" + b.First().itemno, itemno = b.First().itemno, corr = Correlation.Pearson(b.Select(b1 => b1.levelscore), b.Select(b2 => b2.scorelast)), count = b.Count() })).ToList();
            corrlist.AddRange(corrlist1);
            string sql2 = "SELECT t1.papercode,t1.itemno,t1.pcid,t1.filename,t1.score levelscore, t2.scorelast FROM AI_levelscore t1, AI_score t2,AI_listenScore t3, AI_itemdict t4 WHERE t1.filename = t2.filename AND t1.papercode = t3.papercode AND t1.encodeno = t3.encodeno AND t1.pcid = t3.pcid AND t3.sign = '0' AND t3.batchdesc = '定标' AND t1.itemno = t4.itemno AND t4.itemtype = 'QA' AND t2.validflag='2'";
            List<levelscorelast> levelscorelastlist2 = MySqlHelper.GetDataSet(CommandType.Text, sql2).Tables[0].ToModels<levelscorelast>();
            //var jbyzl=levelscorelastlist1.GroupBy(a=>new { a.papercode,a.itemno})
            var yzllist = levelscorelastlist2.GroupBy(a => new { a.papercode, a.itemno }).Select(b => new { papercode = b.First().papercode, itemno = b.First().itemno, per15 = b.Sum(b1 => b1.per15) / b.Count(), per25 = b.Sum(b2 => b2.per25) / b.Count(), per50 = b.Sum(b3 => b3.per50) / b.Count(), count = b.Count() }).ToList();
            var yzllist1 = levelscorelastlist2.GroupBy(a => a.itemno).Select(b => new { papercode = "(总)" + b.First().itemno, itemno = b.First().itemno, per15 = b.Sum(b1 => b1.per15) / b.Count(), per25 = b.Sum(b2 => b2.per25) / b.Count(), per50 = b.Sum(b3 => b3.per50) / b.Count(), count = b.Count() }).ToList();
            yzllist.AddRange(yzllist1);

            var alist = corrlist.GroupBy(a => a.itemno).SelectMany(b => {
                PropertyInfo[] properties = b.First().GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
                List<string> strlist = new List<string>();
                int num = 0;
                foreach (PropertyInfo item in properties)
                {
                    num++;
                    if (num > 2) {
                        strlist.Add(b.First().itemno + " " + item.Name);
                        //Dictionary ad=
                    }
                   
                }
                return strlist;
            });

        }

        private void Test_Load(object sender, EventArgs e)
        {
            abc();
        }




    }
}
