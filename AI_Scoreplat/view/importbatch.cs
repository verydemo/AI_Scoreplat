using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace AI_Scoreplat
{
    public partial class importbatch : Form
    {
        public importbatch()
        {
            InitializeComponent();
        }

        private void importbatch_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            dgvrecord.AutoGenerateColumns = false;
            dgvrecord.Columns[6].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm";
            refreshdgv();


        }

        private void refreshdgv() {

            string sqlstr1 = string.Format("SELECT * FROM AI_filerecord");
            dgvrecord.DataSource = MySqlHelper.GetDataSet(CommandType.Text, sqlstr1).Tables[0];
        }

        private string savepath="";
        private void tsbimport_Click(object sender, EventArgs e)
        {

            if (savepath == "")
            {
                MessageBox.Show("请选择保存路径!!!");
                return;
            }
            var commondir = MySqlHelper.ExecuteScalar(CommandType.Text, "SELECT value FROM AI_config WHERE name='commondir'");
            string pubpath;
            if (commondir.IsNullOrEmpty())
            {
                //MessageBox.Show("请先配置公共文件夹");
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "没有配置公共文件夹!"));
                return;
            }
            else {
                pubpath = commondir.ToString();
            }
            
            FolderBrowserDialog fbd1 = new FolderBrowserDialog();
            fbd1.Description = "请选择文件夹路径";
            if (fbd1.ShowDialog() == DialogResult.OK)
            {
                string path = fbd1.SelectedPath;
                string sqlstr = "SELECT count(*) FROM AI_filerecord";
                int batchno = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr)) + 1;
                //int batchno = 2;
                textBox1.AppendText(string.Format("\r\n{0} 第{1}批次\r\n", DateTime.Now, batchno));
                textBox1.AppendText(string.Format("{0} {1}", DateTime.Now, "遍历文件夹获取文件中...\r\n"));
                //生成文件路径保存到logpath并保存到表filelog
                string logpath = "log_" + batchno + "_" + DateTime.Now.ToOADate() + ".txt";
                string para = string.Format("{0} {1}", path, logpath);
                Process p = Process.Start("getzippath", para);
                p.WaitForExit();
                textBox1.AppendText(string.Format("{0} {1}", DateTime.Now, "获取文件路径完毕!\r\n"));
                textBox1.AppendText(string.Format("{0} {1}", DateTime.Now, "将当前批次文件路径插入到数据库中...\r\n"));
                string[] aList = File.ReadAllLines(logpath, Encoding.UTF8);
                List<string> sqlstringlist = new List<string>();
                Task tinsert = Task.Factory.StartNew(()=> {
                    foreach (var a in aList)
                    {
                        string[] b = a.Split('\t');
                        string path1 = b[0].Replace(@"\", "/");
                        string name = b[1];
                        int importno = batchno;
                        string filelasttime = b[2];
                        string size = b[3];
                        string sqlstring = string.Format("INSERT INTO AI_filelog (name, path, filelasttime, size, importno, ftime) VALUES ('{0}','{1}','{2}','{3}','{4}',now())", name, path1, filelasttime, size, importno);

                        sqlstringlist.Add(sqlstring);
                    }
                    MySqlHelper.ExecuteSqlTran(sqlstringlist);
                });
                Task.WaitAll(tinsert);

                textBox1.AppendText(string.Format("{0} {1}", DateTime.Now, "插入完毕!\r\n"));
                textBox1.AppendText(string.Format("{0} {1}", DateTime.Now, "开始与之前数据对比...\r\n"));
                //AI_filelog对比AI_file   
                string sqlstr1 = string.Format("SELECT id,name,path, filelasttime,size,importno FROM AI_filelog WHERE importno={0}", batchno);
                List<file> fileloglist = MySqlHelper.GetDataSet(CommandType.Text, sqlstr1).Tables[0].ToModels<file>();
                string sqlstr2 = string.Format("SELECT id,name,path, filelasttime,size,importno FROM AI_file ");
                List<file> filelist = MySqlHelper.GetDataSet(CommandType.Text, sqlstr2).Tables[0].ToModels<file>();
                List<string> sqlfilelist = new List<string>();
                int total = fileloglist.Count;
                int n1 = 0;
                int n2 = 0;
                int n3 = 0;
               
                List<file> a1list = new List<file>(); //不相同的,add
                List<file> a2list = new List<file>();//路径相同,sizelasttime不同,update
                List<file> a3list = new List<file>();//一模一样,same
                List<Task> t = new List<Task>();

                var fileloglistdic = fileloglist.ToDictionary(d => string.Format("{0}\t{1}\t{2}", d.size, d.filelasttime, methodhelper.splits(d.path, pubpath)[1]), d => d);
                var fileloglistdicd = fileloglistdic.ToDictionary(d=>string.Format("{0}", methodhelper.splits(d.Value.path, pubpath)[1]),d=>d);
                var filelistdic = filelist.ToDictionary(d => string.Format("{0}\t{1}\t{2}", d.size, d.filelasttime, methodhelper.splits(d.path, pubpath)[1]), d => d);
                var filelistdicd = filelistdic.ToDictionary(d => string.Format("{0}", methodhelper.splits(d.Value.path, pubpath)[1]), d => d);

                int num = 0;
                int totalcount=fileloglistdicd.Count();
                foreach (var a in fileloglistdicd)
                {
                    num++;
                    if (num % 10000 == 0)
                    {
                        textBox1.AppendText(string.Format("{0} 数据对比进度{1}/{2}\r\n", DateTime.Now, num, totalcount));
                    }
                    if (filelistdicd.ContainsKey(a.Key))
                    {
                        if (filelistdicd[a.Key].Key== a.Value.Key)
                        {
                            a3list.Add(a.Value.Value);
                        }
                        else {
                            a2list.Add(a.Value.Value);
                        }
                    }
                    else {
                        a1list.Add(a.Value.Value);
                    }
                }
                textBox1.AppendText(string.Format("{0} {1}", DateTime.Now, "数据对比完毕!\r\n"));
                textBox1.AppendText(string.Format("{0} {1}", DateTime.Now, "将差异数据插入数据库...\r\n"));
                n1 = a1list.Count;
                n2 = a2list.Count;
                n3 = a3list.Count;

                Task sqltask1 = Task.Factory.StartNew(() => {
                    foreach (var a1 in a1list)
                    {
                        string sqlfile2 = string.Format("INSERT INTO AI_file (name, path, filelasttime, size, importno, ftime) VALUES ('{0}','{1}','{2}','{3}',{4},now())", a1.name, a1.path.Replace(@"\", "/"), a1.filelasttime, a1.size, a1.importno);
                        sqlfilelist.Add(sqlfile2);
                    }
                    foreach (var a2 in a2list)
                    {
                        string sqlfile1 = string.Format("UPDATE AI_file SET filelasttime = '{0}',size = '{1}',importno = {2},ftime = NOW() WHERE path='{3}'", a2.filelasttime, a2.size, a2.importno, a2.path);
                        sqlfilelist.Add(sqlfile1);
                    }
                    MySqlHelper.ExecuteSqlTran(sqlfilelist);

                    string sqlfilerecord = string.Format("INSERT INTO AI_filerecord (addcount, updatecount, samecount, totalcount, importno, importtime) VALUES ({0},{1},{2},{3},{4},now())", n1, n2, n3, total, batchno);
                    MySqlHelper.ExecuteScalar(CommandType.Text, sqlfilerecord);
                });
                Task.WaitAll(sqltask1);

                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "当前批次数据插入结束!"));
                string info = string.Format("add {0} ,update {1},same {2},total {3}", n1,n2,n3, total);
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, info));

                refreshdgv();

                //copy文件
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "开始copy文件..."));

                Task ta1 = Task.Factory.StartNew(() => {
                    List<string> ta1sqllist = new List<string>();
                    int num1 = 0;
                    foreach (var a1 in a1list)
                    {
                        //string currentpath = System.IO.Directory.GetCurrentDirectory();
                        string currentpath = savepath;
                        num1 = num1 + 1;
                        string patha1 = Path.Combine(currentpath, string.Format("part{0}", batchno), "add");
                        patha1 = patha1 + methodhelper.splits(a1.path, pubpath)[1].Replace("/", "\\");
                        string patha1dir = Path.GetDirectoryName(patha1);

                        if (!Directory.Exists(patha1dir))
                        {
                            Directory.CreateDirectory(patha1dir);
                        }
                        System.IO.File.Copy(a1.path, patha1,true);
                        string ta1sql = string.Format("UPDATE AI_filelog SET outpath='{0}' WHERE path='{1}' AND importno={2}", patha1.Replace(@"\", "/"), a1.path.Replace(@"\", "/"), batchno);
                        ta1sqllist.Add(ta1sql);
                        this.progressBar1.Value = Convert.ToInt32(num1 * 100 / a1list.Count);
                        label3.Text = string.Format("{0}/{1}", num1, a1list.Count);
                        Application.DoEvents();
                    }
                    MySqlHelper.ExecuteSqlTran(ta1sqllist);
                });



                Task ta2 = Task.Factory.StartNew(() => {
                    List<string> ta2sqllist = new List<string>();
                    int num2 = 0;
                    foreach (var a2 in a2list)
                    {
                        num2 = num2 + 1;
                        //string currentpath = System.IO.Directory.GetCurrentDirectory();
                        string currentpath = savepath;
                        string patha2 = Path.Combine(currentpath, string.Format("part{0}", batchno), "update");
                        patha2 = patha2 + methodhelper.splits(a2.path, pubpath)[1].Replace("/", "\\");
                        string patha2dir = Path.GetDirectoryName(patha2);

                        if (!Directory.Exists(patha2dir))
                        {
                            Directory.CreateDirectory(patha2dir);
                        }
                        System.IO.File.Copy(a2.path, patha2,true);
                        string ta2sql= string.Format("UPDATE AI_filelog SET outpath='{0}' WHERE path='{1}' AND importno={2}", patha2.Replace(@"\", "/"), a2.path.Replace(@"\", "/"), batchno);
                        ta2sqllist.Add(ta2sql);

                        this.progressBar2.Value = Convert.ToInt32(num2 * 100 / a2list.Count);
                        label3.Text = string.Format("{0}/{1}", num2, a2list.Count);
                        Application.DoEvents();
                    }

                    MySqlHelper.ExecuteSqlTran(ta2sqllist);
                });

                List<Task> talist = new List<Task>();
                talist.Add(ta1);
                talist.Add(ta2);
                Task.WaitAll(talist.ToArray());
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "copy文件完成!!!"));

            }
            
        }

        private void btnpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd1 = new FolderBrowserDialog();
            if (fbd1.ShowDialog() == DialogResult.OK)
            {
                txtsavepath.Text = fbd1.SelectedPath;
                savepath= fbd1.SelectedPath;
            }
        }
    }
}
