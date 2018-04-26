using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Scoreplat
{
    public class levelscore
    {
        //levelid, paperid, stuid, itemno, score, valided

        public int levelid { get; set; }

        public string papercode { get; set; }

        public string encodeno { get; set; }

        public string pcid { get; set; }

        public string itemno { get; set; }

        public double score { get; set; }

        public string valided { get; set; }

        public string filename { get; set; }

        public double scorelast { get; set; }
    }
}
