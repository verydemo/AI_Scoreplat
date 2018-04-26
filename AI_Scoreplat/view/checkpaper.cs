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
    public partial class checkpaper : Form
    {
        public checkpaper()
        {
            InitializeComponent();
        }

        List<paper> paperlist = new List<paper>();
        private void checkpaper_Load(object sender, EventArgs e)
        {
            paperlist = MySqlHelper.GetDataSet(CommandType.Text, "SELECT * FROM AI_paper").Tables[0].ToModels<paper>();
            cbopaper.DataSource = paperlist;
            cbopaper.DisplayMember = "name";
            cbopaper.ValueMember = "paperid";
            cbopaper.SelectedValueChanged += Cbopaper_SelectedValueChanged;

            initview();

        }

        private void Cbopaper_SelectedValueChanged(object sender, EventArgs e)
        {
            initview();
        }

        List<doc> doclist = new List<doc>();
        List<item> itemlist = new List<item>();
        private void initview()
        {
            string sqldoc = string.Format("SELECT * FROM AI_doc WHERE paperid={0}",cbopaper.SelectedValue);
             doclist = MySqlHelper.GetDataSet(CommandType.Text, sqldoc).Tables[0].ToModels<doc>();
            cbodoc.DataSource = doclist.OrderBy(a=>a.docname).ToList();
            cbodoc.DisplayMember = "docname";
            cbodoc.ValueMember = "docid";
            cbodoc.SelectedValueChanged += Cbodoc_SelectedValueChanged;
            if (doclist.Count() > 0)
            {
                txtdoc.Text = doclist.Where(a => a.docid == Convert.ToInt32(cbodoc.SelectedValue)).ToList().First().orgintxt;
            }
           

            string sqlitem = string.Format("SELECT * FROM AI_item WHERE paperid={0}", cbopaper.SelectedValue);
             itemlist = MySqlHelper.GetDataSet(CommandType.Text, sqlitem).Tables[0].ToModels<item>();
            cboitem.DataSource = itemlist.OrderBy(a=>a.itemno).ToList();
            cboitem.DisplayMember = "itemno";
            cboitem.ValueMember = "itemid";
            cboitem.SelectedValueChanged += Cboitem_SelectedValueChanged;
            if(itemlist.Count>0)
            {
                txtitem.Text = itemlist.Where(a => a.itemid == Convert.ToInt32(cboitem.SelectedValue)).ToList().First().modeltext;
            }

        }

        private void Cboitem_SelectedValueChanged(object sender, EventArgs e)
        {
            if (itemlist.Count > 0)
            {
                txtitem.Text = itemlist.Where(a => a.itemid == Convert.ToInt32(cboitem.SelectedValue)).ToList().First().modeltext;
            }
        }

        private void Cbodoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (doclist.Count() > 0)
            {
                txtdoc.Text = doclist.Where(a => a.docid == Convert.ToInt32(cbodoc.SelectedValue)).ToList().First().orgintxt;
            }
        }

        private void btnnextitem_Click(object sender, EventArgs e)
        {
            if (itemlist.Count > 0)
            {
                if (cboitem.SelectedIndex+1 < itemlist.Count)
                {
                    cboitem.SelectedIndex = cboitem.SelectedIndex + 1;
                }
                else
                {
                    cboitem.SelectedIndex = 0;
                }
            }
        }

        private void btnnextpaper_Click(object sender, EventArgs e)
        {
            if (paperlist.Count > 0)
            {
                if (cbopaper.SelectedIndex + 1 < paperlist.Count)
                {
                    cbopaper.SelectedIndex = cbopaper.SelectedIndex + 1;
                }
                else
                {
                    cbopaper.SelectedIndex = 0;
                }
            }
        }

        private void btnnextdoc_Click(object sender, EventArgs e)
        {
            if (doclist.Count > 0)
            {
                if (cbodoc.SelectedIndex + 1 < doclist.Count)
                {
                    cbodoc.SelectedIndex = cbodoc.SelectedIndex + 1;
                }
                else
                {
                    cbodoc.SelectedIndex = 0;
                }
            }
        }


    }
}
