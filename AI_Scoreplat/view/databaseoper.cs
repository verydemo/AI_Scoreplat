using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AI_Scoreplat
{
    public partial class databaseoper : Form
    {
        public databaseoper()
        {
            InitializeComponent();
        }

        private void btnbackups_Click(object sender, EventArgs e)
        {
            string backupstr = "";
            if (cbuse.Checked)
            {
                string host = txthost.Text.Trim();
                string user = txtuser.Text.Trim();
                string pwd = txtpwd.Text.Trim();
                string database = txtdatabase.Text.Trim();
                if (host == "" && user == "" && pwd == "" && database == "")
                {
                    textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "参数不能为空!!!"));
                    return;
                }
                backupstr = string.Format("mysqldump -h {0} -u {1} -p{2} {3} -e --max_allowed_packet=16777216 --net_buffer_length=16384 >{3}_{4}.sql", host, user, pwd, database, DateTime.Now.ToOADate());
            }
            string Conn = MySqlHelper.Conn;
            Regex re1 = new Regex("=(.*?);");
            var a=re1.Matches(Conn, 0);
            string host1 = a[0].Groups[1].Value;
            string user1= a[1].Groups[1].Value;
            string pwd1 = a[2].Groups[1].Value;
            string database1 = a[4].Groups[1].Value;
            textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "正在备份数据库..."));
            try
            {

                backupstr = string.Format("mysqldump -h {0} -u {1} -p{2} {3} >{3}_{4}.sql", host1, user1, pwd1, database1, DateTime.Now.ToOADate());
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                string strOutput = backupstr;
                p.StandardInput.WriteLine(strOutput);
                p.StandardInput.WriteLine("exit");
                while (p.StandardOutput.EndOfStream)
                {
                    strOutput = p.StandardOutput.ReadLine();
                    Console.WriteLine(strOutput);
                }
                p.WaitForExit();
                p.Close();
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "数据库备份完成!!!"));
            }
            catch (Exception ex)
            {
                textBox1.AppendText(string.Format("{0} {1} {2}\r\n", DateTime.Now, "数据库备份失败!!!",ex.Message));
            }
        }

        private void btninit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认初始化吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                string sqlstr = "TRUNCATE TABLE AI_actlog;TRUNCATE TABLE AI_config;TRUNCATE TABLE AI_doc;TRUNCATE TABLE AI_exam;TRUNCATE TABLE AI_file;TRUNCATE TABLE AI_filelog;TRUNCATE TABLE AI_filerecord;TRUNCATE TABLE AI_item;TRUNCATE TABLE AI_itemdict;TRUNCATE TABLE AI_levelscore;TRUNCATE TABLE AI_listenScore;TRUNCATE TABLE AI_listenUser;TRUNCATE TABLE AI_package;TRUNCATE TABLE AI_paper;TRUNCATE TABLE AI_paperdict;TRUNCATE TABLE AI_score;TRUNCATE TABLE AI_task;TRUNCATE TABLE AI_user;INSERT INTO AI_config (name, value, description) VALUES ('paperitemcount','6', '每张试卷音频数量'),('lm_other', 'allret', '总模型名称'),('commondir', '1', '公共字段')";
                MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr);
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "数据库初始化完成!!!"));
            }
        }

        private void btnreduction_Click(object sender, EventArgs e)
        {

            string sqlstr = "TRUNCATE TABLE AI_actlog;TRUNCATE TABLE AI_config;TRUNCATE TABLE AI_doc;TRUNCATE TABLE AI_exam;TRUNCATE TABLE AI_file;TRUNCATE TABLE AI_filelog;TRUNCATE TABLE AI_filerecord;TRUNCATE TABLE AI_item;TRUNCATE TABLE AI_itemdict;TRUNCATE TABLE AI_levelscore;TRUNCATE TABLE AI_listenScore;TRUNCATE TABLE AI_listenUser;TRUNCATE TABLE AI_package;TRUNCATE TABLE AI_paper;TRUNCATE TABLE AI_paperdict;TRUNCATE TABLE AI_score;TRUNCATE TABLE AI_task;TRUNCATE TABLE AI_user;";
            MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr);
            string backupstr = "";
            OpenFileDialog ofd1 = new OpenFileDialog();
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                string filepath = ofd1.FileName;
                if (cbuse.Checked)
                {
                    string host = txthost.Text.Trim();
                    string user = txtuser.Text.Trim();
                    string pwd = txtpwd.Text.Trim();
                    string database = txtdatabase.Text.Trim();
                    if (host == "" && user == "" && pwd == "" && database == "")
                    {
                        textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "参数不能为空!!!"));
                        return;
                    }
                    backupstr = string.Format("mysql -h {0} -u {1} -p{2} {3}< {4}", host, user, pwd, database, filepath);
                }




                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "正在还原数据库..."));
                try
                {
                    string Conn = MySqlHelper.Conn;
                    Regex re1 = new Regex("=(.*?);");
                    var a = re1.Matches(Conn, 0);
                    string host = a[0].Groups[1].Value;
                    string user = a[1].Groups[1].Value;
                    string pwd = a[2].Groups[1].Value;
                    string database = a[4].Groups[1].Value;
                    backupstr = string.Format("mysql -h {0} -u {1} -p{2} {3}< {4}", host, user, pwd, database, filepath);
                    Process p = new Process();
                    p.StartInfo.FileName = "cmd.exe";
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardInput = true;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();
                    string strOutput = backupstr;
                    p.StandardInput.WriteLine(strOutput);
                    p.StandardInput.WriteLine("exit");
                    while (p.StandardOutput.EndOfStream)
                    {
                        strOutput = p.StandardOutput.ReadLine();
                        Console.WriteLine(strOutput);
                    }
                    p.WaitForExit();
                    p.Close();
                    textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "还原数据库完成!!!"));
                }
                catch (Exception)
                {

                    throw;
                }


            }
        }

        private void btntestconn_Click(object sender, EventArgs e)
        {
            string host = txthost.Text.Trim();
            string user = txtuser.Text.Trim();
            string pwd = txtpwd.Text.Trim();
            string database = txtdatabase.Text.Trim();
            if (host == "" && user == "" && pwd == "" && database == "")
            {
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "参数不能为空!!!"));
                return;
            }

            string conn =string.Format( "server={0};UId={1};PassWord={2};Persist Security Info=True;database={3};Charset=utf8;", host,user,pwd, database);
            if (MySqlHelper.Testconn(conn))
            {
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "连接数据库成功!!!"));
            }
            else {
                textBox1.AppendText(string.Format("{0} {1}\r\n", DateTime.Now, "连接数据库失败!!!"));
            }
        }
    }
}
