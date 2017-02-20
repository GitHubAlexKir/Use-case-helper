using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    class Line
    {
        public int LineID;
        public int CaseID;
        public int ActorID;
        public int x1;
        public int y1;
        public int x2;
        public int y2;

        public Line(int LineID,int CaseID,int ActorID)
        {
            this.LineID = LineID;
            this.ActorID = ActorID;
            this.CaseID = CaseID;
        }
    }
}
