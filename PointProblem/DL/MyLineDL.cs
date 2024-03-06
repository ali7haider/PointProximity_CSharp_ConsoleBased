using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PointProblem.BL;
using PointProblem.UI;

namespace PointProblem.DL
{
    class MyLineDL
    {
        public static MyLine Line = new MyLine();
        public static MyLine AddLine(MyLine line)
        {
            Line = line;
            return Line;
        }
        public static void updateBegin(MyPoint begin)
        {
            Line.setBegin(begin);
        }
        public static void updateEnd(MyPoint End)
        {
            Line.setEnd(End);
        }
        public static MyLine show_Line()
        {
            return Line;
        }
        public static double lengthOfLine(MyLine L)
        {
            double length = Math.Pow((L.getBegin().getX() - L.getBegin().getY()),2) + Math.Pow((L.getEnd().getX() - L.getEnd().getY()),2);
            length = Math.Sqrt(length);
            return length;
        }
        public static double gradientOfLine(MyLine L)
        {
            double gradient = (L.getEnd().getY() - L.getBegin().getY()) / (L.getEnd().getX() - L.getBegin().getX());
            return gradient;
        }
        public static double beginPointFromCoordinates(MyLine L)
        {
            double length = Math.Pow((- L.getBegin().getX()), 2) + Math.Pow((- L.getBegin().getX()), 2);
            length = Math.Sqrt(length);
            return length;
        }
        public static double endPointFromCoordinates(MyLine L)
        {
            double length=Math.Pow((L.getEnd().getX()), 2) + Math.Pow((L.getEnd().getY()), 2);
            length = Math.Sqrt(length);
            return length;
        }
        public static void StoreInFile(MyLine L)
        {
            string path = "lines.txt";
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(L.getBegin().getX() + "," + L.getBegin().getY() + "," + L.getEnd().getX() + "," + L.getEnd().getY());
            file.Flush();
            file.Close();

        }
        public static bool ReadFromFile()
        {
            string path = "lines.txt";
            StreamReader file = new StreamReader(path);
            string record="";
            if(File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                     {
                    string[] splittedRecord = record.Split(',');
                    int x1 = int.Parse(splittedRecord[0]);
                    int y1 = int.Parse(splittedRecord[1]);
                    int x2 = int.Parse(splittedRecord[2]);
                    int y2 = int.Parse(splittedRecord[3]);
                    MyPoint P1 = new MyPoint(x1, y1);
                    MyPoint P2 = new MyPoint(x2, y2);
                    MyLine L = new MyLine(P1, P2);
                    MyLineDL.Line = MyLineDL.AddLine(L);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
