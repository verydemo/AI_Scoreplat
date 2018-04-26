using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Scoreplat
{
    public class levelscorelast
    {
        //papercode, itemno, pcid, filename, levelscore, scorelast

        public string papercode { get; set; }

        public string itemno { get; set; }

        public string pcid { get; set; }

        public string filename { get; set; }

        public double levelscore { get; set; }

        public double scorelast { get; set; }

        public double fullscore { get; set; }

        public float per15
        {
            get
            {
                if (Math.Abs(levelscore - scorelast) <= fullscore*0.15)
                {
                    return 1;
                }
                else {
                    return 0;
                }          
            }
        }

        public float per25
        {
            get
            {
                if (Math.Abs(levelscore - scorelast) <= fullscore* 0.25)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public float per50
        {
            get
            {
                if (Math.Abs(levelscore - scorelast) <= fullscore* 0.5)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
