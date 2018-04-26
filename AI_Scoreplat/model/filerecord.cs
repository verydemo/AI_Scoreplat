using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Scoreplat
{
    public class filerecord
    {
        public int recordid { get; set; }

        public int addcount { get; set; }

        public int updatecount { get; set; }

        public int samecount { get; set; }

        public int totalcount { get; set; }

        public int importno { get; set; }

        public DateTime importtime { get; set; }
    }
}
