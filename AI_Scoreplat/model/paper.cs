using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Scoreplat
{
    public class paper
    {
        //paperid, examid, name, `desc`
        //paperid, examid, name, papercode, `desc`, status, lm_postfix
        public int paperid { get; set; }

        public int examid { get; set; }

        public string name { get; set; }

        public string papercode { get; set; }
        public string desc { get; set; }
        public string status { get; set; }
        public string lm_postfix { get; set; }
    }
}
