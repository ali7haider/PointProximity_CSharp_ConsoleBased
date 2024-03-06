using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointProblem.BL;
using PointProblem.DL;

namespace PointProblem.UI
{
    class LineUI
    {
        public static MyLine addLine()
        {
            Console.Write("Enter Begin Point X1 : ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Begin Point Y1 : ");
            int y1 = int.Parse(Console.ReadLine());
            MyPoint p1 = new MyPoint(x1, y1);
            Console.Write("Enter End Point X2 : ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Enter End Point Y2 : ");
            int y2 = int.Parse(Console.ReadLine());
            MyPoint p2 = new MyPoint(x2, y2);
            MyLine L = new MyLine(p1, p2);
            MenuUI.clearScreen();
            return L;
        }
        public static void print_update(MyLine Line)
        {
            Console.WriteLine("Begin-X1\t\tBegin-Y1\t\tEnd-X2\t\tEnd-Y2");
            Console.WriteLine(Line.getBegin().getX() + "\t\t\t" + Line.getBegin().getY() + "\t\t\t" + Line.getEnd().getX() + "\t\t" + Line.getEnd().getY()); 
            MenuUI.clearScreen();
        }
    }
}
