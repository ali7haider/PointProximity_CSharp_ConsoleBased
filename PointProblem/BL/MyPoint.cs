using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointProblem.BL
{
    class MyPoint
    {
        private int x;
        private int y;
        public MyPoint()
        {
        }
        public MyPoint(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public int getX()
        {
            return x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public int getY()
        {
            return y;
        }
        public void setXY(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        /*public MyPoint getXY()
        {
            return MyPoint;
        }*/
    }
}
