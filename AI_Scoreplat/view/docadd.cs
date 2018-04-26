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

using Microsoft.Office.Interop.Word;

namespace AI_Scoreplat
{
    public partial class docadd : Form
    {
        paper paper1 = new paper();
        public docadd(paper selectpaper)
        {
            InitializeComponent();
            paper1 = selectpaper;
            this.Text = this.Text +"   " + paper1.name;
        }
        public delegate void refresh();
        public event refresh Refreshpaper;
        public string orgintxt;

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd1.FileName;
                textBox2.Text = Path.GetFileName(ofd1.FileName);
            }
            
        }

        #region 读取 word文档 返回内容
        /// <summary>
        /// 读取 word文档 返回内容
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetWordContent(string path)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Type wordType = app.GetType();
            Microsoft.Office.Interop.Word.Document doc = null;
            object unknow = Type.Missing;
            app.Visible = false;
            object file = path;
            doc = app.Documents.Open(ref file,
                ref unknow, ref unknow, ref unknow, ref unknow,
                ref unknow, ref unknow, ref unknow, ref unknow,
                ref unknow, ref unknow, ref unknow, ref unknow,
                ref unknow, ref unknow, ref unknow);
            try
            {
                int count = doc.Paragraphs.Count;
                StringBuilder sb = new StringBuilder();
                for (int i = 1; i <= count; i++)
                {
                    sb.Append(doc.Paragraphs[i].Range.Text.Trim() + "\r\n");
                }
                string temp = sb.ToString();
                return temp;
            }
            catch
            {
                return "";
            }
            finally
            {
                doc.Close(ref unknow, ref unknow, ref unknow);
                wordType.InvokeMember("Quit", System.Reflection.BindingFlags.InvokeMethod, null, app, null);
                doc = null;
                app = null;
                //垃圾回收
                GC.Collect();
                GC.WaitForPendingFinalizers();

            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() != "" && textBox2.Text != "")
            {
                label3.Text = "正在获取word的文本!";
                orgintxt = GetWordContent(textBox1.Text).Replace("'", @"\'");
                label3.Text = "获取word文本完毕!";
                string sqlstr = string.Format("INSERT INTO AI_doc (examid, paperid, docpath,docname,orgintxt,tmptxt,papercode,papername) VALUES ({0}, {1}, '{2}','{3}','{4}','{5}','{6}','{7}')", session.selectexam.examid,session.selectpaper.paperid, @textBox1.Text.Trim().Replace('\\','/'), textBox2.Text.Trim(), @orgintxt.Trim(), @orgintxt.Trim(), paper1.papercode,paper1.name);
                try
                {
                    MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr);
                    Refreshpaper();
                    MessageBox.Show("添加成功!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("添加失败!!!");
                }
            }
            else {
                MessageBox.Show("信息不能为空!!!");
                return;
            }
        }
    }
}
