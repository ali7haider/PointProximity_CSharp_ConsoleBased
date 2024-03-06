using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointProblem.DL;

namespace PointProblem.BL
{
    class MyLine
    {
        private MyPoint Begin;
        private MyPoint End;
        public MyLine(MyPoint Begin, MyPoint End)
        {
            this.Begin = Begin;
            this.End = End;
        }
        public MyLine()
        {

        }
        public void setBegin(MyPoint Begin)
        {
            this.Begin = Begin;
        }
        public MyPoint getBegin()
        {
            return Begin;
        }
        public void setEnd(MyPoint End)
        {
            this.End = End;
        }

         public MyPoint getEnd()
        {
            return End;
        }
        
    }
}
