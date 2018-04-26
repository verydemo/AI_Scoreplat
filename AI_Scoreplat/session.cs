using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Scoreplat
{
    public static class session
    {
        public static exam selectexam { get; set; }

        public static paper selectpaper{ get; set; }

        public static doc selectdoc { get; set; }

        public static item selectitem { get; set; }


        public static string batchdir = "";


        public static void clearsession()
        {
            selectpaper = new paper();
            selectdoc = new doc();
            selectitem = new item();

        }
    }
}
