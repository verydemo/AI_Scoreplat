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
    public partial class configview : Form
    {
        public configview()
        {
            InitializeComponent();
           
        }

        private void configview_Load(object sender, EventArgs e)
        {
            try
            {
                int paperitemcount = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, "SELECT value FROM AI_config WHERE name='paperitemcount'"));
                nudpaperitemcount.Value = paperitemcount;
            }
            catch (Exception)
            {
            }

            try
            {
                string lm_other=MySqlHelper.ExecuteScalar(CommandType.Text, "SELECT value FROM AI_config WHERE name='lm_other'").ToString();
                txtlm_other.Text = lm_other;              
            }
            catch (Exception)
            {

            }
            try
            {
                string commondir = MySqlHelper.ExecuteScalar(CommandType.Text, "SELECT value FROM AI_config WHERE name='commondir'").ToString();
                txtcommondir.Text = commondir;
            }
            catch (Exception)
            {

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string lmother = txtlm_other.Text.Trim();
            string paperitemcount = nudpaperitemcount.Value.ToString();
            string commondir = txtcommondir.Text.Trim();
            try
            {
                //string sqlstr=string.Format("UPDATE AI_config SET value='{0}' WHERE name='paperitemcount';UPDATE AI_config SET value='{1}' WHERE name='lm_other';UPDATE AI_config SET value='{2}' WHERE name='commondir'", paperitemcount, lmother, commondir);
                //MySqlHelper.ExecuteScalar(CommandType.Text, sqlstr);
                //MessageBox.Show("保存成功!!!");
                string sql1 = string.Format("SELECT count(*) FROM AI_config WHERE name='paperitemcount'");
                string sql2;
                if (Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sql1)) <1)
                {
                     sql2 = string.Format("INSERT INTO AI_config (name,value,description) VALUES('paperitemcount', '{0}', '每张试卷音频数量')", nudpaperitemcount.Value);
                }
                else {
                    sql2 = string.Format("UPDATE AI_config SET value='{0}' WHERE name='paperitemcount'",nudpaperitemcount.Value);
                }
                MySqlHelper.ExecuteScalar(CommandType.Text, sql2);

                string sql3 = string.Format("SELECT count(*) FROM AI_config WHERE name='lm_other'");
                string sql4;
                if (Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sql3)) < 1)
                {
                    sql4 = string.Format("INSERT INTO AI_config (name,value,description) VALUES('lm_other', '{0}', '总模型名称')", lmother);
                }
                else
                {
                    sql4 = string.Format("UPDATE AI_config SET value='{0}' WHERE name='lm_other'", lmother);
                }
                MySqlHelper.ExecuteScalar(CommandType.Text, sql4);


                string sql5 = string.Format("SELECT count(*) FROM AI_config WHERE name='commondir'");
                string sql6;
                if (Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, sql5)) < 1)
                {
                    sql6 = string.Format("INSERT INTO AI_config (name,value,description) VALUES('commondir', '{0}', '公共文件夹')", commondir);
                }
                else
                {
                    sql6 = string.Format("UPDATE AI_config SET value='{0}' WHERE name='commondir'", commondir);
                }
                MySqlHelper.ExecuteScalar(CommandType.Text, sql6);

                MessageBox.Show("保存成功!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
