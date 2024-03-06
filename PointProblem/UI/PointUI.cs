using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointProblem.BL;
using PointProblem.DL;

namespace PointProblem.UI
{
    class PointUI
    {
        
       
        public static MyPoint updateBegin()
        {
            Console.Write("Enter Begin Point x1 : ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Begin Point y1 : ");
            int y1 = int.Parse(Console.ReadLine());
            MyPoint p1 = new MyPoint(x1, y1);
            MenuUI.clearScreen();
            return p1;
        }
        public static MyPoint updateEnd()
        {
            Console.Write("Enter End Point x2 : ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Enter End Point y2 : ");
            int y2 = int.Parse(Console.ReadLine());
            MyPoint p1 = new MyPoint(x2, y2);
            MenuUI.clearScreen();
            return p1;
        }
        public static void printUpdatePoint()
        {

        }
        public static void printEndPoint()
        {

        }

    }
}
