using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace AI_Scoreplat
{
    public partial class voicemodel : Form
    {
        public voicemodel()
        {
            InitializeComponent();
        }

        private void addpaper_Click(object sender, EventArgs e)
        {
            paperadd pa = new paperadd();
            pa.Refreshpaper += Pa_refreshpaper;
            pa.Show();
        }

        //刷新tree
        private void Pa_refreshpaper()
        {
            treepaperdoc.BeginUpdate();
            treepaperdoc.Nodes.Clear();

            string sqlstr1 = string.Format("SELECT * FROM AI_paper WHERE examid={0}",session.selectexam.examid);
            DataSet dataset1 = MySqlHelper.GetDataSet(CommandType.Text, sqlstr1);
            List<paper> paperlist = dataset1.Tables[0].ToModels<paper>();

            string sqlstr2 = string.Format("SELECT * FROM AI_doc WHERE examid={0}", session.selectexam.examid);
            DataSet dataset2= MySqlHelper.GetDataSet(CommandType.Text, sqlstr2);
            List<doc> doclist = dataset2.Tables[0].ToModels<doc>();
            foreach (var paper in paperlist)
            {
                TreeNode currentNode = null;
                if (paper == null) continue;
                currentNode = treepaperdoc.Nodes.Add(paper.paperid.ToString(), paper.name);
                currentNode.Tag = paper;
                currentNode.Nodes.Clear();
                foreach (var doc in doclist)
                {
                    TreeNode secondNode = null;
                    if(paper.paperid!=doc.paperid) continue;
                    secondNode = currentNode.Nodes.Add(doc.docid.ToString(), doc.docname);
                    secondNode.Tag = doc;
                }

            }
            treepaperdoc.ExpandAll();
            treepaperdoc.EndUpdate();

        }

        private void voicemodel_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            
            dgvitem.AutoGenerateColumns = false;
            dgvitem.Font = new Font("微软雅黑",14);
            treepaperdoc.MouseDown += new MouseEventHandler(Treepaperdoc_Click);
            Pa_refreshpaper();
            textBox1.KeyDown += txt_result_KeyDown;
            dgvitem.CellClick += dgvitem_CellClick;
            treepaperdoc.DoubleClick += Treepaperdoc_DoubleClick;


            //自已绘制  
            this.treepaperdoc.DrawMode = TreeViewDrawMode.OwnerDrawText;
            this.treepaperdoc.DrawNode += new DrawTreeNodeEventHandler(treeView1_DrawNode);

        }

        //在绘制节点事件中，按自已想的绘制
        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            e.DrawDefault = true; //我这里用默认颜色即可，只需要在TreeView失去焦点时选中节点仍然突显


            //if ((e.State & TreeNodeStates.Selected) != 0)
            //{
            //    //演示为绿底白字
            //    e.Graphics.FillRectangle(Brushes.DarkBlue, e.Node.Bounds);

            //    Font nodeFont = e.Node.NodeFont;
            //    if (nodeFont == null) nodeFont = ((TreeView)sender).Font;
            //    e.Graphics.DrawString(e.Node.Text, nodeFont, Brushes.White, Rectangle.Inflate(e.Bounds, 2, 0));
            //}
            //else
            //{
            //    e.DrawDefault = true;
            //}

            //if ((e.State & TreeNodeStates.Focused) != 0)
            //{
            //    using (Pen focusPen = new Pen(Color.Black))
            //    {
            //        focusPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            //        Rectangle focusBounds = e.Node.Bounds;
            //        focusBounds.Size = new Size(focusBounds.Width - 1,
            //        focusBounds.Height - 1);
            //        e.Graphics.DrawRectangle(focusPen, focusBounds);
            //    }
            //}

        }


        private void Treepaperdoc_DoubleClick(object sender, EventArgs e)
        {
            //Point ClickPoint = new Point(e.X, e.Y);
            TreeNode aNode = treepaperdoc.SelectedNode;
            if (aNode == null)
            {
                return;
            }
            if (aNode.Level < 1)
            {
                return;
            }

            doc doc1 = (doc)aNode.Tag;
            string filepath = doc1.docpath;
            try
            {
                Process p = Process.Start(filepath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("")
            }
           


        }

        private void dgvitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int i = e.RowIndex;
                item item = new item();
                item.itemid = Convert.ToInt32(dgvitem.Rows[i].Cells[3].Value.ToString());
                item.itemno = dgvitem.Rows[i].Cells[0].Value.ToString();
                item.modeltext = dgvitem.Rows[i].Cells[1].Value.ToString(); 
                session.selectitem = MySqlHelper.GetDataSet(CommandType.Text, string.Format("SELECT * FROM AI_item WHERE itemid={0}", item.itemid)).Tables[0].ToModels<item>().First();
            }
        }




        private TreeNode CurrentNode = new TreeNode();
        private void Treepaperdoc_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//判断你点的是不是左键
            {
                Point ClickPoint = new Point(e.X, e.Y);
                CurrentNode = treepaperdoc.GetNodeAt(ClickPoint);
                if (CurrentNode != null)
                {
                    if (CurrentNode.Tag.GetType().ToString() == "AI_Scoreplat.paper")
                    {
                        session.selectpaper = (paper)CurrentNode.Tag;
                        label5.Text = session.selectpaper.name;
                        refreshdgvitem();
                    }
                    else if (CurrentNode.Tag.GetType().ToString() == "AI_Scoreplat.doc")
                    {
                        doc doc1 = (doc)CurrentNode.Tag;
                        session.selectdoc = doc1;
                        textBox1.Text = doc1.tmptxt;
                        string sqlstr = string.Format("SELECT * FROM AI_paper WHERE paperid={0}",doc1.paperid);
                        DataSet dataset = MySqlHelper.GetDataSet(CommandType.Text, sqlstr);
                        paper p1=dataset.Tables[0].ToModels<paper>().First();
                        label6.Text = p1.name+","+doc1.docname;
                    }
                }
                else
                {


                }

            }
                
        }

        private void docadd_Click(object sender, EventArgs e)
        {
            if (session.selectpaper.paperid!=0)
            {
                docadd da = new docadd(session.selectpaper);
                da.Refreshpaper += Pa_refreshpaper;
                da.Show();
            }
            else {
                MessageBox.Show("请选择试卷!!!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() != "")
            {
                string tmptxt = textBox1.Text.Trim().Replace("'", @"\'");
                string sqlstr = string.Format("UPDATE AI_doc SET tmptxt ='{0}' WHERE docid={1}", tmptxt, session.selectdoc.docid);
                try
                {
                    MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr);
                    Pa_refreshpaper();
                    MessageBox.Show("保存成功!!!");
                }
                catch (Exception)
                {
                    MessageBox.Show("保存失败!!!");
                }
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (session.selectpaper != null)
            {
                if (session.selectpaper.paperid != 0)
                {
                    questionitemadd qadd1 = new questionitemadd(session.selectpaper);
                    qadd1.Show();
                }
                
            }
            else
            {
                MessageBox.Show("请选择试卷!!!");
            }
            
        }


        private void docdel_Click(object sender, EventArgs e)
        {
            if (session.selectdoc != null)
            {
                if (session.selectdoc != null)
                {
                    if (MessageBox.Show("确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string sqlstr = string.Format("DELETE FROM AI_doc WHERE docid={0}", session.selectdoc.docid);
                        try
                        {
                            MySqlHelper.ExecuteNonQuery(CommandType.Text, sqlstr);
                            Pa_refreshpaper();
                            MessageBox.Show("删除成功!!!");

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("删除失败!!!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择文档!!!");
            }

        }


        private void refreshdgvitem()
        {
            string sqlstr1 = string.Format("SELECT * FROM AI_item where paperid={0}", session.selectpaper.paperid);
            DataSet dataset1 = MySqlHelper.GetDataSet(CommandType.Text, sqlstr1);
            List<item> itemlist = dataset1.Tables[0].ToModels<item>();
            dgvitem.DataSource = itemlist.OrderBy(a=>a.itemno).ToList();
            dgvitem.ClearSelection();
            session.selectitem = new item();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {

                string tmptxt = textBox1.Text.Trim();
                Regex re1 = new Regex("[^a-zA-Z']");
                Regex re2 = new Regex(@"\s+");
                tmptxt = re1.Replace(tmptxt, " ");
                tmptxt = re2.Replace(tmptxt, " ").Trim();
                string modeltxt = tmptxt.Replace("'", @"\'");

                string sqlstr = string.Format("UPDATE AI_doc SET modeltxt ='{0}' WHERE docid={1}", modeltxt, session.selectdoc.docid);
                try
                {
                    MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr);
                    Pa_refreshpaper();
                    MessageBox.Show("保存成功!!!");
                }
                catch (Exception)
                {
                    MessageBox.Show("保存失败!!!");
                }

            }
        }

        private void delpaper_Click(object sender, EventArgs e)
        {
            if (session.selectpaper != null)
            {
                string sqlstr1 = string.Format("DELETE from AI_paper WHERE paperid={0};DELETE FROM AI_doc WHERE paperid={0};DELETE FROM AI_item WHERE paperid={0};", session.selectpaper.paperid);
                MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr1);
                Pa_refreshpaper();
            }
            else
            {
                MessageBox.Show("请选择试卷!!!");
            }


            
        }

        private void editpaper_Click(object sender, EventArgs e)
        {
            if (session.selectpaper.paperid != 0)
            {
                paperedit pe1 = new paperedit(session.selectpaper.paperid);
                pe1.Refreshpaper += Pa_refreshpaper;
                pe1.ShowDialog();
            }
            else {
                MessageBox.Show("请选择试卷!!!");
            }

        }

        private void txt_result_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void btndelitem_Click(object sender, EventArgs e)
        {
            if (session.selectitem == null)
            {
                MessageBox.Show("选择一个题目！！！");
            }
            else {

                string sqlstr1 = string.Format("DELETE FROM AI_item WHERE itemid={0};", session.selectitem.itemid);
                MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr1);
                refreshdgvitem();

            }


        }

        //试卷状态修改
        private void button4_Click(object sender, EventArgs e)
        {
            if (session.selectpaper != null)
            {
                string sqlstr = string.Format("SELECT count(*) FROM AI_item WHERE paperid={0}", session.selectpaper.paperid);
                int count = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr));
                if (count > 0)
                {
                    string sqlstr1 = string.Format("UPDATE AI_paper SET status='1' WHERE paperid={0};", session.selectpaper.paperid);
                    MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr1);
                    MessageBox.Show("试卷已完成!!!");

                }
                else
                {
                    MessageBox.Show("当前试卷下面没有添加题目不能完成!!!");
                }

            }
            else
            {
                MessageBox.Show("请选择试卷!!!");
            }
           
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //this.splitContainer2.Panel2.Visible = this.checkBox1.Checked;
        }

        private void btnitemedit_Click(object sender, EventArgs e)
        {
            if (session.selectpaper.examid != 0 && session.selectitem.itemid != 0)
            {
                itemedit ie1 = new itemedit(session.selectpaper, session.selectitem);
                ie1.Show();
            }
            else {
                MessageBox.Show("请选择题目!!!");
            }

        }

        private void btnreplace_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Trim() != "")
            {
                Regex re1 = new Regex("[^a-zA-Z' ]");
                if (re1.Matches(txt1.Text.Trim(), 0).Count > 0|| re1.Matches(txt2.Text.Trim(), 0).Count > 0)
                {
                    MessageBox.Show("包含非法字符!!!");
                    if (re1.Matches(txt2.Text.Trim(), 0).Count > 0)
                    {
                        txt2.Focus();
                    }
                    else {
                        txt1.Focus();
                    }
                    return;
                }
                //string sqlstr = string.Format("UPDATE AI_doc SET tmptxt=replace(upper(tmptxt),'{0}','{1}'),modeltxt=replace(upper(modeltxt),'{0}','{1}')", txt1.Text.Trim().Replace("'", @"\'"), txt2.Text.Trim().Replace("'", @"\'"));
                //MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr);


                string sqlstr = "SELECT * FROM AI_doc";
                List<doc> doclist = MySqlHelper.GetDataSet(CommandType.Text, sqlstr).Tables[0].ToModels<doc>();
                List<string> sqlstrlist = new List<string>();
                doclist.ForEach(a =>
                {
                    if (a.tmptxt.ToUpper().Contains(txt1.Text.Trim().ToUpper())|| a.modeltxt.ToUpper().Contains(txt1.Text.Trim().ToUpper()))
                    {
                        a.tmptxt=Regex.Replace(a.tmptxt, txt1.Text.Trim(), txt2.Text.Trim(), RegexOptions.IgnoreCase);
                        a.modeltxt = Regex.Replace(a.modeltxt, txt1.Text.Trim(), txt2.Text.Trim(), RegexOptions.IgnoreCase);
                        a.modeltxt = regextxt(a.modeltxt);
                        string sql = string.Format("UPDATE AI_doc SET modeltxt='{0}',tmptxt='{1}' WHERE docid={2}", a.modeltxt.Replace("'", @"\'"), a.tmptxt.Replace("'", @"\'"), a.docid);
                        sqlstrlist.Add(sql);
                    }                  
                });
                MySqlHelper.ExecuteSqlTran(sqlstrlist);
                Pa_refreshpaper();
                MessageBox.Show("替换成功!!!");
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

    }
}
