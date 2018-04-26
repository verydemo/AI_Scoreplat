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

namespace AI_Scoreplat
{
    public partial class output : Form
    {
        public output()
        {
            InitializeComponent();
        }

        private void output_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            nud1n1.ValueChanged += Nud1n1_ValueChanged;
            nud2n1.ValueChanged += Nud2n1_ValueChanged;
            nud3n1.ValueChanged += Nud3n1_ValueChanged;
            nud3n2.ValueChanged += Nud3n1_ValueChanged;
            nud4n1.ValueChanged += Nud4n1_ValueChanged;
            nud4n2.ValueChanged += Nud4n1_ValueChanged;

            nud5n1.ValueChanged += Nud5n1_ValueChanged;
            nud5n2.ValueChanged += Nud1n1_ValueChanged;

            nud6n1.ValueChanged += Nud6n1_ValueChanged;
            nud6n2.ValueChanged += Nud6n1_ValueChanged;
            refreshcl1();
            refreshcl2();
            refreshcl3();
            refreshcl4();
            refreshcl5();
            refreshcl6();
        }

        private void Nud6n1_ValueChanged(object sender, EventArgs e)
        {
            refreshcl6();
        }

        private void Nud5n1_ValueChanged(object sender, EventArgs e)
        {
            refreshcl5();
        }

        private void Nud4n1_ValueChanged(object sender, EventArgs e)
        {
            refreshcl4();
        }

        private void Nud3n1_ValueChanged(object sender, EventArgs e)
        {
            refreshcl3();
        }

        private void Nud2n1_ValueChanged(object sender, EventArgs e)
        {
            refreshcl2();
        }

        private List<outputr> cl1outputlist = new List<outputr>();
        private List<outputr> cl2outputlist = new List<outputr>();
        private List<outputr> cl3outputlist = new List<outputr>();
        private List<outputr> cl4outputlist = new List<outputr>();
        private List<outputr> cl5outputlist = new List<outputr>();
        private List<outputr> cl6outputlist = new List<outputr>();
        private List<outputr> cl7outputlist = new List<outputr>();

        private void refreshcl1()
        {
            nud1n1.ReadOnly = true;
            lab1.Text = "...";
            Task.Factory.StartNew(() => {
                string sql = string.Format("SELECT count(*) FROM AI_score t1,AI_itemdict t2 WHERE t1.itemno=t2.itemno AND t2.itemtype='read' AND planscore<=t2.fullscore*{0} ORDER BY gop_raw DESC,wer ASC", nud1n1.Value / 100);
                int cl1count = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sql));
                lab1.Text = cl1count.ToString();
                nud1n1.ReadOnly = false;
            });

        }
        private void refreshcl2()
        {
            nud1n1.ReadOnly = true;
            lab2.Text = "...";
           Task.Factory.StartNew(() => {
                string sql = string.Format("SELECT count(*) FROM AI_score t1,AI_itemdict t2 WHERE t1.itemno=t2.itemno AND t2.itemtype='retell' AND t1.planscore<t2.fullscore*{0} ORDER BY gop_lat DESC ", nud2n1.Value / 100);
                int cl2count = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sql));
                lab2.Text = cl2count.ToString();
               nud1n1.ReadOnly = false;
           });            
        }
        private void refreshcl3()
        {
            nud3n1.ReadOnly = true;
            nud3n2.ReadOnly = true;
            lab3.Text = "...";
            Task.Factory.StartNew(() => {
                string sql = string.Format("SELECT count(*) FROM AI_score t1,AI_itemdict t2,(SELECT encodeno,papercode,pcid,sum(planscore) scoresqa,(SELECT sum(fullscore) FROM AI_itemdict WHERE itemtype='QA') fullqascore FROM AI_score t31,AI_itemdict t32 WHERE t31.itemno=t32.itemno AND t32.itemtype='QA' GROUP BY encodeno,papercode,pcid) t3 WHERE t1.papercode=t3.papercode AND t1.encodeno=t3.encodeno AND t1.pcid=t3.pcid AND t1.itemno=t2.itemno AND t2.itemtype='read' AND t1.planscore>t2.fullscore*{0} AND t3.scoresqa<t3.fullqascore*{1}", nud3n1.Value / 100, nud3n2.Value / 100);
                int cl3count = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sql));
                lab3.Text = cl3count.ToString();
                nud3n1.ReadOnly = false;
                nud3n2.ReadOnly = false;
            });
        }

        private void refreshcl4()
        {
            nud4n1.ReadOnly = true;
            nud4n2.ReadOnly = true;
            lab4.Text = "...";
            Task.Factory.StartNew(() => {
                string sql = string.Format("SELECT count(*) FROM  (SELECT encodeno,papercode,pcid,sum(planscore) score_zg FROM AI_score GROUP BY encodeno,papercode,pcid) t1, AI_kgf t2,AI_score t3 WHERE t1.encodeno=t2.encodeno AND t1.papercode=t2.papercode AND t1.pcid=t2.pcid  AND t1.encodeno=t3.encodeno AND t1.papercode=t3.papercode AND t1.pcid=t2.pcid AND t2.score<={0} AND t1.score_zg>{1}", nud4n1.Value , nud4n2.Value );
                int cl4count = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sql));
                lab4.Text = cl4count.ToString();
                nud4n1.ReadOnly = false;
                nud4n2.ReadOnly = false;
            });
        }

        private void refreshcl5()
        {
            nud5n1.ReadOnly = true;
            nud5n2.ReadOnly = true;
            lab5.Text = "...";
            Task.Factory.StartNew(() => {
                string sql = string.Format("SELECT count(*) FROM  (SELECT encodeno,papercode,pcid,sum(planscore) score_zg FROM AI_score GROUP BY encodeno,papercode,pcid) t1, AI_kgf t2,AI_score t3 WHERE t1.encodeno=t2.encodeno AND t1.papercode=t2.papercode AND t1.pcid=t2.pcid  AND t1.encodeno=t3.encodeno AND t1.papercode=t3.papercode AND t1.pcid=t2.pcid AND t2.score>{1} AND t1.score_zg<={0}", nud5n1.Value, nud5n2.Value);
                int cl5count = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sql));
                lab5.Text = cl5count.ToString();
                nud5n1.ReadOnly = false;
                nud5n2.ReadOnly = false;
            });
        }

        private void refreshcl6()
        {
            nud6n1.ReadOnly = true;
            nud6n2.ReadOnly = true;
            lab6.Text = "...";
            Task.Factory.StartNew(() => {
                string sql = string.Format("SELECT count(*) FROM  AI_kgf t1, AI_itemdict t2, AI_score t3, AI_score t4 WHERE t1.papercode=t3.papercode AND t1.encodeno=t3.encodeno AND t1.pcid=t3.pcid AND t3.itemno=t2.itemno AND t2.itemtype='retell' AND t1.score<=15*{0} AND t3.planscore>=t2.fullscore*{1} AND t3.papercode=t4.papercode AND t3.encodeno=t4.encodeno AND t3.pcid=t4.pcid", nud6n1.Value / 100, nud6n2.Value / 100);
                int cl6count = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sql));
                lab6.Text = cl6count.ToString();
                nud6n1.ReadOnly = false;
                nud6n2.ReadOnly = false;
            });
        }

        private void Nud1n1_ValueChanged(object sender, EventArgs e)
        {
            refreshcl1();
        }

        private void btnexport1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT t1.papercode,t1.itemno,t1.pcid,t1.encodeno,replace(t1.itemcode,'ans.mp3','') Itemcode1,t1.filename,t1.scorelast Score1 FROM AI_score t1,AI_itemdict t2 WHERE t1.itemno=t2.itemno AND t2.itemtype='read' AND planscore<=t2.fullscore*{0} ORDER BY gop_raw DESC,wer ASC", nud1n1.Value / 100);
            cl1outputlist = MySqlHelper.GetDataSetnew(sql).Tables[0].ToModels<outputr>();
            exportret(cl1outputlist.Take(Convert.ToInt32( nud1n2.Value)).ToList(), "朗读题复核.txt");
            
        }

        private void btnexport2_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT t1.papercode,t1.itemno,t1.pcid,t1.encodeno,replace(t1.itemcode,'ans.mp3','') Itemcode1,t1.filename,t1.scorelast Score1 FROM AI_score t1,AI_itemdict t2 WHERE t1.itemno=t2.itemno AND t2.itemtype='retell' AND t1.planscore<t2.fullscore*{0} ORDER BY gop_lat DESC", nud1n1.Value / 100);
            cl2outputlist = MySqlHelper.GetDataSetnew(sql).Tables[0].ToModels<outputr>();
            exportret(cl2outputlist.Take(Convert.ToInt32(nud2n2.Value)).ToList(), "简述题复核.txt");

        }

        private void btnexport3_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT t1.papercode,t1.itemno,t1.pcid,t1.encodeno,replace(t1.itemcode,'ans.mp3','') Itemcode1,t1.filename,t1.scorelast Score1 FROM AI_score t1,AI_itemdict t2,(SELECT encodeno,papercode,pcid,sum(planscore) scoresqa,(SELECT sum(fullscore) FROM AI_itemdict WHERE itemtype='QA') fullqascore FROM AI_score t31,AI_itemdict t32 WHERE t31.itemno=t32.itemno AND t32.itemtype='QA' GROUP BY encodeno,papercode,pcid) t3 WHERE t1.papercode=t3.papercode AND t1.encodeno=t3.encodeno AND t1.pcid=t3.pcid AND t1.itemno=t2.itemno AND t2.itemtype='read' AND t1.planscore>t2.fullscore*{0} AND t3.scoresqa<t3.fullqascore*{1}", nud3n1.Value / 100, nud3n2.Value / 100);
            cl3outputlist = MySqlHelper.GetDataSetnew(sql).Tables[0].ToModels<outputr>();
            exportret(cl3outputlist.Take(Convert.ToInt32(nud3n3.Value)).ToList(), "问答题相关性复核.txt");

        }

        private void exportret(List<outputr> outlist,string txtname,string flag="0")
        {
            if (flag == "1")
            {
                int batchno = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, "SELECT max(batchno) FROM AI_listenScore")) + 1;
                DialogResult dr = MessageBox.Show("需要插入到listen表进行音频审核么？", "提示", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    List<string> sqllist = new List<string>();
                    foreach (var a in outlist)
                    {
                        string sql = string.Format("INSERT INTO AI_listenScore(papercode, itemno, encodeno, filename, Score1, Statu, batchno, batchdesc,itemcode,pcid,scoreid,validflag) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}','{8}','{9}',{10},'2')", a.papercode, a.itemno, a.encodeno, a.filename, a.Score1, "0", batchno, txtname.Split('.')[0], a.itemcode, a.pcid, a.scoreid);
                        sqllist.Add(sql);
                    }
                    MySqlHelper.ExecuteSqlTran(sqllist);
                    MessageBox.Show("插入完毕！！！");
                }
            }
            else
            {
                SaveFileDialog sfd1 = new SaveFileDialog();
                sfd1.FileName = txtname;
                if (sfd1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = File.AppendText(sfd1.FileName);
                    string desc = txtname.Split('.')[0];
                    foreach (var a in outlist)
                    {
                        string str = a.papercode + "\t" + a.encodeno + "\t" + a.pcid + "\t" + a.Itemcode1 + "\t" + a.Score1 + "\t" +a.filename+"\t"+desc+ "\r\n";
                        sw.Write(str);
                    }
                    sw.Close();
                    MessageBox.Show("导出成功！！！");
                }
                else
                {
                    MessageBox.Show("导出失败！！！");
                }

            }

        }

        private void btnexpoert4_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT t2.papercode,t2.encodeno,t2.pcid,t3.itemno,replace(t3.itemcode,'ans.mp3','') Itemcode1,t3.filename,t3.scorelast Score1,t3.itemcode,t3.scoreid FROM  (SELECT encodeno,papercode,pcid,sum(planscore) score_zg FROM AI_score GROUP BY encodeno,papercode,pcid) t1, AI_kgf t2,AI_score t3 WHERE t1.encodeno=t2.encodeno AND t1.papercode=t2.papercode AND t1.pcid=t2.pcid  AND t1.encodeno=t3.encodeno AND t1.papercode=t3.papercode AND t1.pcid=t2.pcid AND t2.score<={0} AND t1.score_zg>{1}", nud4n1.Value, nud4n2.Value);
            cl4outputlist = MySqlHelper.GetDataSetnew( sql).Tables[0].ToModels<outputr>();
            exportret(cl4outputlist, "客观0主观有.txt", "1");
        }

        private void btnexport5_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT t2.papercode,t2.encodeno,t2.pcid,t3.itemno,replace(t3.itemcode,'ans.mp3','') Itemcode1,t3.filename,t3.planscore Score1,t3.itemcode,t3.scoreid FROM  (SELECT encodeno,papercode,pcid,sum(planscore) score_zg FROM AI_score GROUP BY encodeno,papercode,pcid) t1, AI_kgf t2,AI_score t3 WHERE t1.encodeno=t2.encodeno AND t1.papercode=t2.papercode AND t1.pcid=t2.pcid  AND t1.encodeno=t3.encodeno AND t1.papercode=t3.papercode AND t1.pcid=t2.pcid AND t2.score>{1} AND t1.score_zg<={0}", nud5n1.Value, nud5n2.Value);
            cl5outputlist = MySqlHelper.GetDataSetnew(sql).Tables[0].ToModels<outputr>();
            exportret(cl5outputlist, "主观0客观有.txt", "1");
        }

        private void btnexport6_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT t4.papercode,t4.itemno,t4.pcid,t4.encodeno,replace(t4.itemcode,'ans.mp3','') Itemcode1 , t4.filename,t4.planscore Score1,t4.itemcode,t4.scoreid FROM  AI_kgf t1, AI_itemdict t2, AI_score t3, AI_score t4 WHERE t1.papercode=t3.papercode AND t1.encodeno=t3.encodeno AND t1.pcid=t3.pcid AND t3.itemno=t2.itemno AND t2.itemtype='retell' AND t1.score<=15*{0} AND t3.planscore>=t2.fullscore*{1} AND t3.papercode=t4.papercode AND t3.encodeno=t4.encodeno AND t3.pcid=t4.pcid", nud6n1.Value/100, nud6n2.Value/100);
            cl6outputlist = MySqlHelper.GetDataSetnew(sql).Tables[0].ToModels<outputr>();
            exportret(cl6outputlist, "客观低简述高.txt", "1");
        }

        private void btnexport7_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT t2.papercode,t2.itemno,t2.pcid,t2.encodeno,replace(t2.itemcode,'ans.mp3','') Itemcode1,t2.filename,t2.scorelast Score1 FROM AI_listenScore t1,AI_score t2 WHERE batchdesc LIKE '主客相关%' AND recheck='1' AND t1.filename=t2.filename");
            cl7outputlist = MySqlHelper.GetDataSetnew(sql).Tables[0].ToModels<outputr>();
            exportret(cl7outputlist, "主观0客观有.txt");
        }
    }
}
