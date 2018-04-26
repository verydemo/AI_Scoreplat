using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AI_Scoreplat
{
    public partial class finallyscore : Form
    {
        public finallyscore()
        {
            InitializeComponent();
        }

        private void btnexport1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT t2.papercode paperno,t2.encodeno,t2.pcid,t2.totalscore score,t2.Itemcount,concat(t1.filepath,'.zip') zippath  FROM AI_task t1, (SELECT papercode,encodeno,pcid,count(1) Itemcount,sum(scorelast) totalscore,taskid FROM AI_score WHERE  validflag='2' GROUP BY papercode,encodeno,pcid,taskid) t2 WHERE t1.taskid=t2.taskid";
            List<finallyscore1> alist = MySqlHelper.GetDataSetnew(sql).Tables[0].ToModels<finallyscore1>();
            string sql1 = "SELECT papercode paperno,encodeno,pcid,concat(filepath,'.zip') zippath FROM AI_task WHERE scorecount=0";
            List<finallyscore1> alist1 = MySqlHelper.GetDataSetnew(sql1).Tables[0].ToModels<finallyscore1>();
            alist.AddRange(alist1);
            SaveFileDialog sfd1 = new SaveFileDialog();
            sfd1.FileName = "sumscore.txt";
            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw= File.AppendText(sfd1.FileName);
                alist.ForEach(a => {
                    string str = a.paperno+"\t"+a.encodeno+"\t"+a.pcid+"\t"+Convert.ToSingle(a.score)+"\t"+Convert.ToSingle(a.Itemcount)+"\t"+a.zippath+"\r\n";
                    sw.Write(str);
                });
                sw.Close();
                MessageBox.Show("导出成功!!!");
            }

        }

        private void btnexport2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT t1.papercode paperno,t1.encodeno ,t1.pcid,replace(t1.itemcode,'ans.mp3','') audiopath,t1.scorelast score,concat(t2.filepath,'.zip') zippath FROM AI_score t1,AI_task t2 WHERE t1.taskid=t2.taskid AND t1.validflag='2'";
            List<finallyscore2> alist = MySqlHelper.GetDataSetnew(sql).Tables[0].ToModels<finallyscore2>();
            SaveFileDialog sfd1 = new SaveFileDialog();
            sfd1.FileName = "itemscore.txt";
            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.AppendText(sfd1.FileName);
                alist.ForEach(a => {
                    string str = a.paperno + "\t" + a.encodeno + "\t" + a.pcid + "\t" + a.audiopath + "\t" + a.Score + "\t" + a.zippath + "\t" + "--" + "\r\n";
                    sw.Write(str);
                });
                sw.Close();

                MessageBox.Show("导出成功!!!");
            }
        }

        private void btnexport3_Click(object sender, EventArgs e)
        {
            string sql = "SELECT papercode paperno,encodeno,pcid,concat(filepath,'.zip') zippath FROM AI_task WHERE scorecount=0";
            List<finallyscore3> alist = MySqlHelper.GetDataSetnew(sql).Tables[0].ToModels<finallyscore3>();
            SaveFileDialog sfd1 = new SaveFileDialog();
            sfd1.FileName = "noneaudio.txt";
            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.AppendText(sfd1.FileName);
                alist.ForEach(a => {
                    string str = a.paperno+"\t"+a.encodeno+"\t"+a.pcid+"\t"+a.zippath+"\r\n";
                    sw.Write(str);
                });
                sw.Close();
                MessageBox.Show("导出成功!!!");
            }
        }




    }
}
