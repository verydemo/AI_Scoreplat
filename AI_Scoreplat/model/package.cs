using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Scoreplat
{
    public class package
    {
        //packageid, status, username, taskcount,startdate, lastupdate
        //packageid, status, worker, taskcount, startdate, lastupdate
        public int packageid { get; set; }

        public int status { get; set; }

        public string worker { get; set; }

        public int taskcount { get; set; }

        public DateTime startdate { get; set; }

        public DateTime lastupdate { get; set; }
    }
}
