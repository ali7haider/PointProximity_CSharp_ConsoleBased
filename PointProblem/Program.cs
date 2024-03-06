using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointProblem.BL;
using PointProblem.DL;
using PointProblem.UI;

namespace PointProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            if(MyLineDL.ReadFromFile())
            {
                Console.WriteLine("Read data Succesfully");
            }
            while (true)
            {
                string opt = MenuUI.menu();
                if (opt == "1")
                {
                    MyLine L = LineUI.addLine();
                    MyLineDL.Line = MyLineDL.AddLine(L);

                    
                }
                else if (opt == "2")
                {
                    MyPoint P = PointUI.updateBegin();
                    MyLineDL.updateBegin(P);

                }
                else if (opt == "3")
                {
                    MyPoint P = PointUI.updateEnd();
                    MyLineDL.updateEnd(P);
                }
                else if (opt == "4")
                {
                    MyLine L= MyLineDL.show_Line();
                    LineUI.print_update(L);
                }
                else if (opt == "5")
                {
                    MyLine L = MyLineDL.Line;
                    Console.WriteLine("End Point X2 : " + L.getEnd().getX() );
                    Console.WriteLine("End Point Y2 :" + L.getEnd().getY());
                    MenuUI.clearScreen();
                }
                else if (opt == "6")
                {
                    MyLine L = MyLineDL.Line;
                    double len = MyLineDL.lengthOfLine(L);
                    Console.WriteLine("Length of Line Is : " + len);
                    MenuUI.clearScreen();

                }
                else if (opt == "7")
                {
                    MyLine L = MyLineDL.Line;
                    double gra = MyLineDL.gradientOfLine(L);
                    Console.WriteLine("Gradient of Line Is : " + gra);
                    MenuUI.clearScreen();

                }
                else if (opt == "8")
                {
                    MyLine L = MyLineDL.Line;
                    double beginCoord = MyLineDL.beginPointFromCoordinates(L);
                    Console.WriteLine("Distance of Begin Point from zero Coordinates : " + beginCoord);
                    MenuUI.clearScreen();

                }
                else if (opt == "9")
                {

                    MyLine L = MyLineDL.Line;
                    double endCoord = MyLineDL.endPointFromCoordinates(L);
                    Console.WriteLine("Distance of End Point from zero Coordinates  : " + endCoord);
                    MenuUI.clearScreen();
                }
                else if (opt == "10")
                {
                    MyLine L = MyLineDL.Line;
                    MyLineDL.StoreInFile(L);
                    break;

                }
                else
                {
                    Console.WriteLine("Wrong Input......");
                    MenuUI.clearScreen();
                }
            }
        }
    }
    }
