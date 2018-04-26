using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Scoreplat
{
    public class listenscore
    {
        //Id, InsertDT, PaperNo, QuestionNo, StuNo, filepath, Score1, Score2, Score3, Score4, Statu, Operator, OperatorDT, batchno, batchdesc, sign

        public int Id { get; set; }

        public DateTime InsertDT { get; set; }

        public string PaperNo { get; set; }

        public string QuestionNo { get; set; }

        public string encodeno { get; set; }

        public string filename { get; set; }

        public float Score1 { get; set; }

        public float Score2 { get; set; }

        public float Score3 { get; set; }

        public float Score4 { get; set; }

        public string Statu { get; set; }

        public string Operator { get; set; }

        public DateTime OperatorDT { get; set; }

        public int batchno { get; set; }

        public string batchdesc { get; set; }

        public string sign { get; set; }
    }
}
