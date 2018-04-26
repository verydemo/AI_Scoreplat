using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Scoreplat
{
    public class score
    {
        //scoreid, taskid, filename, papercode, stuid, itemno, 
        //gop_lat, gop_raw, wer, gop_lat2, ins, del, words, sub, 
        //rec_words, rec_words_unique, ref_words, ref_words_unique, 
        //keywords_ratio, sim_feat1, sim_feat2, recognisetext,
        //score, needcheck, pcid, validflag

        public int scoreid { get; set; }

        public string filename { get; set; }

        public string papercode { get; set; }

        public string encodeno { get; set; }

        public string itemno { get; set; }

        public float gop_lat { get; set; }

        public float gop_raw { get; set; }

        public float wer { get; set; }

        public float gop_lat2 { get; set; }

        public float ins { get; set; }

        public float del { get; set; }


        public float words { get; set; }

        public float sub { get; set; }
        public float rec_words { get; set; }


        public float rec_words_unique { get; set; }

        public float ref_words { get; set; }


        public float ref_words_unique { get; set; }

        public float keywords_ratio { get; set; }
        public float sim_feat1 { get; set; }

        public float sim_feat2 { get; set; }

        public float scorelast { get; set; }

        public string pcid { get; set; }

    }
}
