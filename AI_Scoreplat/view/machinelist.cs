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
    public partial class machinelist : Form
    {
        public machinelist()
        {
            InitializeComponent();
        }

        private void machinelist_Load(object sender, EventArgs e)
        {
            dgvmachine.Font = new Font("微软雅黑", 14);
            string sqlstr1 = string.Format("select * from AI_package");
            List<package> packagelist = MySqlHelper.GetDataSet(CommandType.Text, sqlstr1).Tables[0].ToModels<package>();
            var blist =(from a in packagelist
                        group a by a.worker into g
                        select new { lastupdate =(DateTime.Now- g.Max(b => b.lastupdate)).Minutes, totalcount = g.Sum(c => c.taskcount), machinename = g.First().worker, packcount = g.Count(), lycount=(g.Where(d=>d.status==1)).Count(),wccount=(g.Where(f=>f.status==9)).Count() }).ToList();
           dgvmachine.DataSource = blist;

            timer1.Interval = 60000;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string sqlstr1 = string.Format("select * from AI_package");
            List<package> packagelist = MySqlHelper.GetDataSet(CommandType.Text, sqlstr1).Tables[0].ToModels<package>();
            var blist = (from a in packagelist
                         group a by a.worker into g
                         select new { lastupdate = (DateTime.Now - g.Max(b => b.lastupdate)).Minutes, totalcount = g.Sum(c => c.taskcount), machinename = g.First().worker, packcount = g.Count(), lycount = (g.Where(d => d.status == 1)).Count(), wccount = (g.Where(f => f.status == 9)).Count() }).ToList();
            dgvmachine.DataSource = blist;
        }
    }
}
