using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Scoreplat
{
    public partial class drdc : Form
    {
        public drdc()
        {
            InitializeComponent();
        }

        private void btndctzf_Click(object sender, EventArgs e)
        {
            string sqlstr = string.Format("SELECT * FROM AI_score WHERE validflag='2'");
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "查询出有效记录..."));
            DataSet dataset = MySqlHelper.GetDataSet(CommandType.Text, sqlstr);
            List < AIscore > a1= dataset.Tables[0].ToModels<AIscore>();            

            List<AIscore> a2 = new List<AIscore>();
            List<string> sqllist = new List<string>();
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "开始导出特征分..."));
            if (File.Exists("特征分.txt"))
            {
                File.Delete("特征分.txt");
            }
            StreamWriter sw = File.AppendText("特征分.txt");
            Task t1= Task.Factory.StartNew(()=> {
                string context1 = "scoreid\tpapercode\titemno\tgop_lat\tgop_raw\twer\tgop_lat2\tins\tdel\twords\tsub\trec_words\trec_words_unique\tref_words\tref_words_unique\tkeywords_ratio\tsim_feat1\tsim_feat2\r\n";
                sw.Write(context1);
                List<int> scoreidlist = new List<int>();
                foreach (var f in a1)
                {     
                    string context = f.scoreid + "\t" + f.papercode + "\t" + f.itemno + "\t" + f.gop_lat + "\t" + f.gop_raw + "\t" + f.wer + "\t" + f.gop_lat2 + "\t" + f.ins + "\t" + f.del + "\t" + f.words + "\t" + f.sub + "\t" + f.rec_words + "\t" + f.rec_words_unique + "\t" + f.ref_words + "\t" + f.ref_words_unique + "\t" + f.keywords_ratio + "\t" + f.sim_feat1 + "\t" + f.sim_feat2 + "\r\n";
                    sw.Write(context);
                }
                sw.Close();
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导出特征分成功!!!"));
            }); 
      
        }

        private void btndrscore_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            List<string> sqllist = new List<string>();
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导入分数..."));

                Task t1 = Task.Factory.StartNew(() => {
                string[] aList = File.ReadAllLines(ofd1.FileName, Encoding.UTF8);
                    var lista= aList.ToList();
                    lista.RemoveAt(0);
                    aList= lista.ToArray();
                string sqlstr = "";
                int num = 0;
                foreach (var a in aList)
                {
                    num++;
                    string[] a1 = a.Split('\t');
                    try
                    {
                        if (num == 1)
                        {
                            string sql = string.Format("UPDATE AI_score SET score={0},scorelast={0} WHERE scoreid={1}", Convert.ToSingle(a1[1].Trim()), Convert.ToInt32(a1[0].Trim()));
                            sqlstr = sql;
                            //sqllist.Add(sql);
                        }
                        else {
                            string sql = string.Format("UPDATE AI_score SET score={0},scorelast={0} WHERE scoreid={1}", Convert.ToSingle(a1[1].Trim()), Convert.ToInt32(a1[0].Trim()));
                            sqlstr = sqlstr + ";" + sql;
                            if (num % 50 == 0)
                            {
                                sqllist.Add(sqlstr);
                                sqlstr = "";
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                sqllist.Add(sqlstr);
                string sqlupdate = "UPDATE AI_score t1,AI_itemdict t2 SET t1.scorelast=t2.fullscore WHERE t1.itemno=t2.itemno AND t1.scorelast>t2.fullscore;UPDATE AI_score SET scorelast=0 WHERE scorelast<0";
                sqllist.Add(sqlupdate);
                MySqlHelper.ExecuteSqlTran(sqllist,textBox1, "导入分数");
                });
                Task.WaitAll(t1);
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导入分数成功!!!"));
            }
        }

        private void btnimportpapercode_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            List<string> sqllist = new List<string>();
            int examid = session.selectexam.examid;
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导入试卷代号..."));
                Task t1 = Task.Factory.StartNew(()=> {
                    string[] aList = File.ReadAllLines(ofd1.FileName, Encoding.UTF8);
                    string sqlorigin = "TRUNCATE TABLE AI_paperdict;";
                    sqllist.Add(sqlorigin);
                    foreach (var a in aList)
                    {
                        string[] a1 = a.Split('\t');
                        try
                        {
                            string sql = string.Format("INSERT INTO AI_paperdict (paperno, papercode, lm_postfix,paperdesc) VALUES ('{0}','{1}','{2}','{3}')", a1[0].Trim(), a1[1].Trim(), a1[2].Trim(), a1[3].Trim());
                            string sql1 = string.Format("INSERT INTO AI_paper (papercode,lm_postfix,name,`desc`,status,examid) VALUES ('{0}','{1}','{2}','{2}','0',{3})", a1[1].Trim(), a1[2].Trim(), a1[3].Trim(), examid);
                            sqllist.Add(sql);
                            sqllist.Add(sql1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    MySqlHelper.ExecuteSqlTran(sqllist);


                });
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导入试卷代号成功!!!"));

            }

        }

        private void btnimportitemcode_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            List<string> sqllist = new List<string>();
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导入题目代号..."));
                Task t1 = Task.Factory.StartNew(()=> {
                    string[] aList = File.ReadAllLines(ofd1.FileName, Encoding.UTF8);

                    string sqlorigin = "TRUNCATE TABLE AI_itemdict;";
                    sqllist.Add(sqlorigin);
                    foreach (var a in aList)
                    {
                        string[] a1 = a.Split('\t');
                        try
                        {
                            string sql = string.Format("INSERT INTO AI_itemdict(itemno,itemcode,itemtype,itemdesc,fullscore) VALUES ('{0}','{1}','{2}','{3}','{4}')", a1[0].Trim(), a1[1].Trim(), a1[2].Trim(),a1[3].Trim(),a1[4].Trim());
                            sqllist.Add(sql);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    MySqlHelper.ExecuteSqlTran(sqllist);
                });
                
                Task.WaitAll(t1);
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导入题目代号成功!!!"));

            }
        }

        private void btndrdbf_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            List<string> sqllist = new List<string>();
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导入定标分..."));
                Task t1=Task.Factory.StartNew(()=> {
                    string[] aList = File.ReadAllLines(ofd1.FileName, Encoding.UTF8);
                    string sqlorigin = "TRUNCATE TABLE AI_levelscore;";
                    sqllist.Add(sqlorigin);
                    foreach (var a in aList)
                    {
                        string[] a1 = a.Split(',');
                        try
                        {

                            string sql = string.Format("INSERT INTO AI_levelscore(papercode,encodeno,itemno,score,pcid) VALUES ('{0}','{1}','{2}',{3},'{4}')", a1[0].Trim(), a1[1].Trim(), a1[2].Trim(), Convert.ToSingle(a1[3].Trim()), a1[4].Trim());
                            sqllist.Add(sql);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    MySqlHelper.ExecuteSqlTran(sqllist);
                });
                Task.WaitAll(t1);
                import_listenscore();
                MySqlHelper.ExecuteScalar(CommandType.Text, "UPDATE AI_levelscore t1,AI_score t2 SET t1.scoreid=t2.scoreid WHERE t1.filename=t2.filename AND t2.validflag='2';UPDATE AI_listenScore t1,AI_score t2 SET t1.scoreid=t2.scoreid WHERE t1.filename=t2.filename AND t2.validflag='2' AND t1.batchdesc='定标'");
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导入定标分成功!!!"));
            }
        }

        private void btndcdbf_Click(object sender, EventArgs e)
        {
            string sqlstr2 = string.Format("SELECT * FROM AI_score WHERE validflag='2'");
            List <score> scorelist = MySqlHelper.GetDataSet(CommandType.Text, sqlstr2).Tables[0].ToModels<score>();
            var scorelistd=scorelist.ToDictionary(d => string.Format(d.filename), d => d);

            string sqlstr3 = string.Format("SELECT t2.* FROM AI_listenScore t1,AI_levelscore t2 WHERE t1.sign='0' AND t1.batchdesc='定标' AND t1.papercode=t2.papercode AND t1.encodeno=t2.encodeno AND t1.pcid=t2.pcid");
            List<levelscore> levelscorelist = MySqlHelper.GetDataSet(CommandType.Text,sqlstr3).Tables[0].ToModels<levelscore>();
            textBox1.AppendText(string.Format("{0} 数量：{1}\r\n", DateTime.Now, "开始导出..."));
            if (File.Exists("定标分.txt"))
            {
                File.Delete("定标分.txt");
            }
            StreamWriter sw = File.AppendText("定标分.txt");
            string sw1 = "scoreid\tlevelScore\tpapercode\titemno\tdel\tgop_lat\tgop_lat2\tgop_raw\tins\tkeywords_ratio\trec_words\trec_words_unique\tref_words\tref_words_unique\twer\tsim_feat1\tsim_feat2\tsub\twords\r\n";
            sw.Write(sw1);
            int num = 0;

            levelscorelist.ForEach(a => {
                try
                {
                    num++;
                    if (num % 1000 == 0) { textBox1.AppendText(string.Format("{0} 数量：{1}\r\n", DateTime.Now, num)); }
                    textBox1.Invalidate();
                    if (scorelistd.ContainsKey(a.filename))
                    {
                        score s1 = scorelistd[a.filename];
                        string astr = s1.scoreid + "\t" + a.score + "\t" + s1.papercode + "\t" + s1.itemno + "\t" + s1.del + "\t" + s1.gop_lat + "\t" + s1.gop_lat2 + "\t" + s1.gop_raw + "\t" + s1.ins + "\t" + s1.keywords_ratio + "\t" + s1.rec_words + "\t" + s1.rec_words_unique + "\t" + s1.ref_words + "\t" + s1.ref_words_unique + "\t" + s1.wer + "\t" + s1.sim_feat1 + "\t" + s1.sim_feat2 + "\t" + s1.sub + "\t" + s1.words + "\r\n";
                        sw.Write(astr);

                    }
                    else {
                        string str =DateTime.Now+"\t"+ a.filename + "\t" + a.levelid + "\t" + a.encodeno +"在AI_score找不到对应题的分"+ "\r\n\r\n";
                        File.AppendAllText("定标分_log.txt", str);
                    }         
                }
                catch (Exception ex)
                {
                    string str = DateTime.Now + "\t" + a.filename + "\t" + a.levelid + "\t" + a.encodeno +ex.Message+ "\r\n\r\n";
                    File.AppendAllText("定标分_log.txt", str);
                }
            });

            sw.Close();
            textBox1.AppendText(string.Format("{0} 数量：{1}\r\n", DateTime.Now, "完成!!!"));
        }
            

        private void btndcdbft_Click(object sender, EventArgs e)
        {
            List<task> tasklist2 = new List<task>();
            List<levelscore> tasklist5 = new List<levelscore>();
            Dictionary<string, List<task>> taskdict=new Dictionary<string, List<task>>();
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导出定标分..."));
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "定标分去重,对应路径..."));
            List<task> tasklist1 = new List<task>();
            List<levelscore> tasklist3 = new List<levelscore>();
            List<levelscore> tasklist4 = new List<levelscore>();
            List<Task> tlist = new List<Task>();
            Dictionary<string, task> tasklist1ad = new Dictionary<string, task>();
            Dictionary<string, levelscore> tasklist3ad = new Dictionary<string, levelscore>();
            Task t1 = Task.Factory.StartNew(()=> {
                string sqlstr1 = string.Format("SELECT * FROM AI_task");
                tasklist1 = MySqlHelper.GetDataSet(CommandType.Text, sqlstr1).Tables[0].ToModels<task>();
                var tasklist1a= tasklist1.GroupBy(a => new { a.papercode, a.encodeno, a.pcid }).Where(b => b.Count() == 1).SelectMany(c=>c).ToList();
                tasklist1ad = tasklist1a.ToDictionary(d=>string.Format("{0}\t{1}\t{2}",d.papercode,d.encodeno,d.pcid),d=>d);
            });
            tlist.Add(t1);
            Task t2 = Task.Factory.StartNew(() => {
                string sqlstr2 = string.Format("SELECT * FROM AI_levelscore");
                tasklist3 = MySqlHelper.GetDataSet(CommandType.Text, sqlstr2).Tables[0].ToModels<levelscore>();
                var tasklist3a = tasklist3.GroupBy(a => new { a.papercode, a.encodeno, a.itemno, a.pcid }).Where(b => b.Count() == 1).SelectMany(c => c).ToList();
                tasklist3ad = tasklist3a.ToDictionary(d => string.Format("{0}\t{1}\t{2}\t\n{3}", d.papercode, d.encodeno, d.pcid,d.itemno), d => d);
            });
            tlist.Add(t2);
            Task.WaitAll(tlist.ToArray());
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "定标分去重成功!!!"));
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导出定标分到\"导入定标分(听).txt\"..."));

            List<string> sqllist = new List<string>();
            if (File.Exists("导入定标分(听).txt"))
            {
                File.Delete("导入定标分(听).txt");
            }
            List<itemdict> itemdictlist = MySqlHelper.GetDataSet(CommandType.Text, "SELECT * FROM AI_itemdict").Tables[0].ToModels<itemdict>();
            foreach (var a in tasklist3ad)
            {
                string a1key = a.Key.Replace("\t\n" + a.Value.itemno,"");
                if (tasklist1ad.ContainsKey(a1key))
                {
                    string itemcode = itemdictlist.Where(i => i.itemno == a.Value.itemno).First().itemcode;
                    string itemtype = itemdictlist.Where(i => i.itemno == a.Value.itemno).First().itemtype;
                    a.Value.filename= tasklist1ad[a1key].filepath+"/"+ itemcode;
                    string sqlstr = string.Format("UPDATE AI_levelscore set filename = '{0}' WHERE levelid={1}", a.Value.filename, a.Value.levelid);
                    sqllist.Add(sqlstr);
                    if (itemtype == "read")
                    {
                        string sqlstr1 = string.Format("INSERT INTO AI_listenScore(papercode, itemno, encodeno, filename, Score1, Statu, batchno, batchdesc,itemcode,pcid) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}','{8}','{9}')", a.Value.papercode, a.Value.itemno, a.Value.encodeno, a.Value.filename, a.Value.score, '0', 1, "定标", itemcode,a.Value.pcid);
                        sqllist.Add(sqlstr1);
                    }                   
                }
            }
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "正在更新数据库.."));
            MySqlHelper.ExecuteSqlTran(sqllist);
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "定标分成功导入至听表!!!"));




        }

        private void drdc_Load(object sender, EventArgs e)
        {

        }

        private void btnkgf_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            List<string> sqllist = new List<string>();
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "开始导入客观分..."));
                string[] aList = File.ReadAllLines(ofd1.FileName, Encoding.UTF8);
                string sqlorigin = "TRUNCATE TABLE AI_kgf;";
                sqllist.Add(sqlorigin);
                string sqlstr = "";
                int num = 0;
                try
                {
                    foreach (var a in aList)
                    {
                        num++;
                        var aarray = a.Split(',');
                        string sql = string.Format("INSERT INTO AI_kgf (encodeno,papercode, score,pcid) VALUES ('{0}','{1}',{2},'{3}')", aarray[0].Trim(), aarray[1].Trim(), Convert.ToSingle(aarray[3].Trim()), aarray[2].Trim());
                        sqlstr = sqlstr + ";" + sql;
                        if (num % 50 == 0)
                        {
                            sqllist.Add(sqlstr);
                            sqlstr = "";
                        }
                    }
                    sqllist.Add(sqlstr);
                    MySqlHelper.ExecuteSqlTran(sqllist, textBox1, "导入客观分");
                    textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导入客观分成功!!!"));
                }
                catch (Exception ex)
                {
                    textBox1.AppendText(ex.Message);
                }
            }
            
           
        }

        private void btnfydoc_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd1 = new SaveFileDialog();
            sfd1.FileName = session.selectexam.name+"_alldoc.txt";
            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw1 = File.AppendText(sfd1.FileName);
                List<doc> doclist = MySqlHelper.GetDataSetnew("SELECT modeltxt FROM AI_doc").Tables[0].ToModels<doc>();
                int num = 0;
                doclist.ForEach(a => {
                    num++;
                    if (num == 1)
                    {
                        sw1.Write(a.modeltxt.Trim());
                    }
                    else {
                        sw1.Write(" "+a.modeltxt.Trim());
                    }
                });
                sw1.Close();
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导出doc文本成功!!!"));
            }
        }

        private void btnfyrep_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                if (!ofd1.FileName.Contains("_alldoc_replace"))
                {
                    textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "选择文件错误!!!"));
                    return;
                }
                else {
                    int wordcount = 0;
                    foreach (var wordstr in File.ReadAllLines(ofd1.FileName))
                    {
                        wordcount++;
                        var  word= wordstr.Split('\t');
                        replacetxt(" " + word[0].Trim() + " ", " " + word[1].Trim() + " ");
                    }
                    textBox1.AppendText(string.Format("{0} {1}{2}\r\n", DateTime.Now, wordcount,"个单词被替换!!!"));
                }
            }
        }



        private void replacetxt(string s1, string s2)
        {
            if (s1.Trim() != "")
            {
                Regex re1 = new Regex("[^a-zA-Z' ]");
                if (re1.Matches(s1.Trim(), 0).Count > 0 || re1.Matches(s2.Trim(), 0).Count > 0)
                {
                    textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "文本包含非法字符，需联系后台工程师!!!"));
                    return;
                }
                string sqlstr = "SELECT * FROM AI_doc";
                List<doc> doclist = MySqlHelper.GetDataSet(CommandType.Text, sqlstr).Tables[0].ToModels<doc>();
                List<string> sqlstrlist = new List<string>();
                doclist.ForEach(a =>
                {
                    if (a.tmptxt.ToUpper().Contains(s1.ToUpper()) || a.modeltxt.ToUpper().Contains(s1.Trim().ToUpper()))
                    {
                        a.tmptxt = Regex.Replace(a.tmptxt, s1.Trim(), s2.Trim(), RegexOptions.IgnoreCase);
                        a.modeltxt = Regex.Replace(a.modeltxt, s1.Trim(), s2.Trim(), RegexOptions.IgnoreCase);
                        a.modeltxt = regextxt(a.modeltxt);
                        string sql = string.Format("UPDATE AI_doc SET modeltxt='{0}',tmptxt='{1}' WHERE docid={2}", a.modeltxt.Replace("'", @"\'"), a.tmptxt.Replace("'", @"\'"), a.docid);
                        sqlstrlist.Add(sql);
                    }
                });
                MySqlHelper.ExecuteSqlTran(sqlstrlist);
            }
        }
        private string regextxt(string tmptxt)
        {
            Regex re1 = new Regex("[^a-zA-Z']");
            Regex re2 = new Regex(@"\s+");
            tmptxt = re1.Replace(tmptxt, " ");
            tmptxt = re2.Replace(tmptxt, " ").Trim();
            return tmptxt;
        }

        private void btnqc_Click(object sender, EventArgs e)
        {
            string sqlstr = string.Format("SELECT * FROM AI_score");
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "开始对比出有效记录..."));
            DataSet dataset = MySqlHelper.GetDataSet(CommandType.Text, sqlstr);
            List<AIscore> AIscorelist = dataset.Tables[0].ToModels<AIscore>();
           //查询出无效记录
            var a11 = AIscorelist.ToLookup(a => new { a.encodeno, a.papercode, a.pcid }, b => b).SelectMany(a => a.Where(b => b.filenamenum != a.Max(c => c.filenamenum)).Select(d => d));
            MySqlHelper.ExecuteScalar(CommandType.Text, "UPDATE AI_score SET validflag='2'");
            string scorestr = "0";
            int num = 0;
            List<string> sqllist = new List<string>();
            if (a11.Count() < 1)
            {
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "没有需要去重的!!!"));
                return;
            }
            else {
                foreach (var f in a11)
                {
                    num++;
                    scorestr = scorestr + "," + f.scoreid;
                    if (num % 1000 == 0)
                    {
                        string sql = string.Format("UPDATE AI_score SET validflag=1 WHERE scoreid in ({0})", scorestr);
                        sqllist.Add(sql);
                        scorestr = "0";
                    }
                }
                string sql1 = string.Format("UPDATE AI_score SET validflag=1 WHERE scoreid in ({0})", scorestr);
                sqllist.Add(sql1);
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "正在更新数据库..."));
                MySqlHelper.ExecuteSqlTran(sqllist, textBox1, "更新validflag值");
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "写入数据库完成!!!"));
            }
            
        }

        private void btnexportpaper_Click(object sender, EventArgs e)
        {
            string sqlstr = "SELECT * FROM AI_itemdict";
            List<itemdict> itemdicts = MySqlHelper.GetDataSetnew(sqlstr).Tables[0].ToModels<itemdict>();
            StreamWriter sw = File.AppendText("itemdict_export.txt");
            sw.WriteLine("itemno\titemcode\titemtype\tfullscore");
            itemdicts.ForEach(a=> {
                sw.WriteLine(a.itemno+'\t'+a.itemcode+'\t'+a.itemtype+'\t'+a.fullscore);
            });
            sw.Close();
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导出试卷结构成功!!!"));
        }

        private void btnexportdingbiao_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(string.Format("{0} 数量：{1}\r\n", DateTime.Now, "查询相应定标数据..."));
            string sqlstr2 = string.Format("SELECT * FROM AI_score WHERE validflag='2'");
            List <score> scorelist = MySqlHelper.GetDataSet(CommandType.Text, sqlstr2).Tables[0].ToModels<score>();
            var scorelistd=scorelist.ToDictionary(d => string.Format(d.filename), d => d);

            //string sqlstr3 = string.Format("SELECT t2.* FROM AI_listenScore t1,AI_levelscore t2 WHERE t1.batchdesc='定标' AND t1.papercode=t2.papercode AND t1.encodeno=t2.encodeno AND t1.pcid=t2.pcid");
            //List<levelscore> levelscorelist = MySqlHelper.GetDataSet(CommandType.Text,sqlstr3).Tables[0].ToModels<levelscore>();
            string sqlstr3 = string.Format("SELECT * FROM AI_listenScore WHERE batchdesc='定标'");
            List<listenscore> listenscores = MySqlHelper.GetDataSetnew(sqlstr3).Tables[0].ToModels<listenscore>();
            textBox1.AppendText(string.Format("{0} 数量：{1}\r\n", DateTime.Now, "开始导出..."));
            if (File.Exists("定标分_需过滤.txt"))
            {
                File.Delete("定标分_需过滤.txt");
            }
            StreamWriter sw = File.AppendText("定标分_需过滤.txt");
            string sw1 = "scoreid\tlevelScore\tpapercode\titemno\tdel\tgop_lat\tgop_lat2\tgop_raw\tins\tkeywords_ratio\trec_words\trec_words_unique\tref_words\tref_words_unique\twer\tsim_feat1\tsim_feat2\tsub\twords\r\n";
            sw.Write(sw1);
            int num = 0;

            listenscores.ForEach(a => {
                try
                {
                    num++;
                    if (num % 1000 == 0) { textBox1.AppendText(string.Format("{0} 数量：{1}\r\n", DateTime.Now, num)); }
                    textBox1.Invalidate();
                    if (scorelistd.ContainsKey(a.filename))
                    {
                        score s1 = scorelistd[a.filename];
                        string astr = s1.scoreid + "\t" + a.Score1 + "\t" + s1.papercode + "\t" + s1.itemno + "\t" + s1.del + "\t" + s1.gop_lat + "\t" + s1.gop_lat2 + "\t" + s1.gop_raw + "\t" + s1.ins + "\t" + s1.keywords_ratio + "\t" + s1.rec_words + "\t" + s1.rec_words_unique + "\t" + s1.ref_words + "\t" + s1.ref_words_unique + "\t" + s1.wer + "\t" + s1.sim_feat1 + "\t" + s1.sim_feat2 + "\t" + s1.sub + "\t" + s1.words + "\r\n";
                        sw.Write(astr);

                    }
                    else {
                        string str =DateTime.Now+"\t"+ a.filename + "\t" + a.Id + "\t" + a.encodeno +"在AI_score找不到对应题的分"+ "\r\n\r\n";
                        File.AppendAllText("定标分_log.txt", str);
                    }

                   
                }
                catch (Exception ex)
                {
                    string str = DateTime.Now + "\t" + a.filename + "\t" + a.Id + "\t" + a.encodeno +ex.Message+ "\r\n\r\n";
                    File.AppendAllText("定标分_log.txt", str);
                }
            });

            sw.Close();
            textBox1.AppendText(string.Format("{0} 数量：{1}\r\n", DateTime.Now, "完成!!!"));
        }



        #region 将数据插入到listenscore
        private void import_listenscore()
        {
            List<task> tasklist2 = new List<task>();
            List<levelscore> tasklist5 = new List<levelscore>();
            Dictionary<string, List<task>> taskdict = new Dictionary<string, List<task>>();
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导出定标分..."));
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "定标分去重,对应路径..."));
            List<task> tasklist1 = new List<task>();
            List<levelscore> tasklist3 = new List<levelscore>();
            List<levelscore> tasklist4 = new List<levelscore>();
            List<Task> tlist = new List<Task>();
            Dictionary<string, task> tasklist1ad = new Dictionary<string, task>();
            Dictionary<string, levelscore> tasklist3ad = new Dictionary<string, levelscore>();
            Task t1 = Task.Factory.StartNew(() =>
            {
                string sqlstr1 = string.Format("SELECT * FROM AI_task");
                tasklist1 = MySqlHelper.GetDataSet(CommandType.Text, sqlstr1).Tables[0].ToModels<task>();
                var tasklist1a = tasklist1.GroupBy(a => new { a.papercode, a.encodeno, a.pcid }).Where(b => b.Count() == 1).SelectMany(c => c).ToList();
                tasklist1ad = tasklist1a.ToDictionary(d => string.Format("{0}\t{1}\t{2}", d.papercode, d.encodeno, d.pcid), d => d);
            });
            tlist.Add(t1);
            Task t2 = Task.Factory.StartNew(() =>
            {
                string sqlstr2 = string.Format("SELECT * FROM AI_levelscore");
                tasklist3 = MySqlHelper.GetDataSet(CommandType.Text, sqlstr2).Tables[0].ToModels<levelscore>();
                var tasklist3a = tasklist3.GroupBy(a => new { a.papercode, a.encodeno, a.itemno, a.pcid }).Where(b => b.Count() == 1).SelectMany(c => c).ToList();
                tasklist3ad = tasklist3a.ToDictionary(d => string.Format("{0}\t{1}\t{2}\t\n{3}", d.papercode, d.encodeno, d.pcid, d.itemno), d => d);
            });
            tlist.Add(t2);
            Task.WaitAll(tlist.ToArray());
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "定标分去重成功!!!"));
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "导出定标分到\"导入定标分(听).txt\"..."));

            List<string> sqllist = new List<string>();
            if (File.Exists("导入定标分(听).txt"))
            {
                File.Delete("导入定标分(听).txt");
            }
            List<itemdict> itemdictlist = MySqlHelper.GetDataSet(CommandType.Text, "SELECT * FROM AI_itemdict").Tables[0].ToModels<itemdict>();
            foreach (var a in tasklist3ad)
            {
                string a1key = a.Key.Replace("\t\n" + a.Value.itemno, "");
                if (tasklist1ad.ContainsKey(a1key))
                {
                    string itemcode = itemdictlist.Where(i => i.itemno == a.Value.itemno).First().itemcode;
                    string itemtype = itemdictlist.Where(i => i.itemno == a.Value.itemno).First().itemtype;
                    a.Value.filename = tasklist1ad[a1key].filepath + "/" + itemcode;
                    string sqlstr = string.Format("UPDATE AI_levelscore set filename = '{0}',valided='2' WHERE levelid={1}", a.Value.filename, a.Value.levelid);
                    sqllist.Add(sqlstr);
                    if (itemtype == "read")
                    {
                        string sqlstr1 = string.Format("INSERT INTO AI_listenScore(papercode, itemno, encodeno, filename, Score1, Statu, batchno, batchdesc,itemcode,pcid) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}','{8}','{9}')", a.Value.papercode, a.Value.itemno, a.Value.encodeno, a.Value.filename, a.Value.score, '0', 1, "定标", itemcode, a.Value.pcid);
                        sqllist.Add(sqlstr1);
                    }
                }
            }
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "正在更新数据库.."));
            MySqlHelper.ExecuteSqlTran(sqllist);
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "定标分成功导入至听表!!!"));
        }

        #endregion

        private void btndrdbgl_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "定标分(过滤)导入中..."));
                string scoreids=File.ReadAllText(ofd1.FileName).Replace("scoreid\r\n","");
                scoreids = scoreids.Replace("\r\n", ",");
                string sqlstr = string.Format("UPDATE AI_listenScore SET validflag='2' WHERE scoreid IN ({0})", scoreids);
                MySqlHelper.ExecuteNonQuery(CommandType.Text,sqlstr);
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "定标分(过滤)导入完成!!!"));
            }
        }
    }
}
