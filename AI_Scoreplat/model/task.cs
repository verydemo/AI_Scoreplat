using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Scoreplat
{
    public class task
    {
        ///taskid, packageid, filename, msgid, msg, status, papercode, pcid
        ///
        public int taskid { get; set; }

        public int packageid { get; set; }

        public string filepath { get; set; }

        public string msgid { get; set; }

        public string msg { get; set; }

        public string status { get; set; }
        public string papercode { get; set; }

        public string pcid { get; set; }

        public string encodeno { get; set; }

        public string zkzh
        {

            get
            {
                if (filepath == null)
                {
                    return "";

                }
                return filepath.Split('/').Last();
            }
        }
    }
}
