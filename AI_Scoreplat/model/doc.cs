using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Scoreplat
{
    public class doc
    {
        //docid, examid, paperid, docpath, orgintxt, tmptxt
        //docid, examid, paperid,papercode, papername, docname, docpath, orgintxt, tmptxt, modeltxt
        public int docid { get; set; }

        public int examid { get; set; }

        public int paperid { get; set; }

        public string papercode { get; set; }

        public string papername { get; set; }

        public string docpath { get; set; }

        public string orgintxt { get; set; }

        public string tmptxt { get; set; }

        public string modeltxt { get; set; }
        public string docname { get; set; }
    }
}
