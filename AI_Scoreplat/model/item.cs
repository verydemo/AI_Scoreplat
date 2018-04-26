using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Scoreplat
{
    public class item
    {
        //itemid, examid, paperid, itemtype, modeltext, answertext
        //itemid, examid, paperid, papercode, papername, fullscore, itemtype, itemno, itemcode, itemtext, modeltext, answertext, modellog
        public int itemid { get; set; }
        public int examid { get; set; }
        public int paperid { get; set; }
        public string papercode { get; set; }
        public string papername { get; set; }
        public float fullscore { get; set; }
        public string itemno { get; set; }
        public string itemcode { get; set; }      
        public string itemtype { get; set; }
        public string modeltext { get; set; }
        public string answertext { get; set; }
        public string itemtext { get; set; }
        public float modellog { get; set; }
    }
}
