using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointProblem.UI
{
    class MenuUI
    {
        public static void header()
        {
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("                                                        ");
            Console.WriteLine("            Point Calculation                           ");
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("                                                        ");

        }
        static public string menu()
        {
            header();
            Console.WriteLine("[1]-Make a Line");
            Console.WriteLine("[2]-Update a Begin Point");
            Console.WriteLine("[3]-Update a End Point");
            Console.WriteLine("[4]-Show the Update Point");
            Console.WriteLine("[5]-Show the End Point");
            Console.WriteLine("[6]-Get the Length of Line");
            Console.WriteLine("[7]-Get the Gradient of Line");
            Console.WriteLine("[8]-Find the Distance of begin point from zero coordinates");
            Console.WriteLine("[9]-Find the Distance of End point from zero coordinates");
            Console.WriteLine("[10]-Exit");
            Console.Write("Your Option......");
            string op = Console.ReadLine();
            return op;
        }
        public static void clearScreen()
        {
            Console.WriteLine("Press any Key to Continue....");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
