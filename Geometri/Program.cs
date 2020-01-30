using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    {
        static double side = 10;
        static double side2 = 5;
        static double side3 = 7;
        static double side4 = 9;
        static double vinkel = 20;
        public static List<Geometri> Geolist = new List<Geometri>();
        static void Main(string[] args)
        {
           
            Menu();
        }
        static void Geo()
        {
            foreach (Geometri geo in Geolist)
            {
                Console.WriteLine(geo.Areal());
                Console.WriteLine(geo.Omkreds());
            }
        }
        static void Menu()
        {
            Geometri o = new Square(side);
            Geometri a = new Square(side);
            Geometri p = new Parallelogram(side, side2, vinkel);
            Geometri t = new Trapez(side, side2, side3, side4);
            Geometri tre = new Trekant(side, side2, side3);
            Geometri tre2 = new Trekant(side, side2, side3);
            Geolist.Add(o);
            Geolist.Add(a);
            Geolist.Add(p);
            Geolist.Add(t);
            Geolist.Add(tre);
            Geolist.Add(tre2);

            while (true)
            {
                Console.WriteLine("Welcome to DoMath");
                Console.WriteLine("Skriv 1 for omkreds på en firkant.");
                Console.WriteLine("Skriv 2 for arealet på en firkant");
                Console.WriteLine("Skriv 3 for arealet på en Parallelogram");
                Console.WriteLine("Skriv 4 for arealet på en Trapez");
                Console.WriteLine("Skriv 5 for arealet på en Rektanglel");
                Console.WriteLine("Skriv 6 for omkreds på en Rektanglel");
                Console.WriteLine("Skriv 7 for at kalde alle udregninger på 1 gang");
                double userinput = Convert.ToInt32(Console.ReadLine());
                switch (userinput)
                {
                    case 1:
                        Console.WriteLine(o.Omkreds());
                        break;
                    case 2:
                        Console.WriteLine(a.Areal());
                        break;
                    case 3:
                        Console.WriteLine(p.Areal());
                       
                        break;
                    case 4:
                        Console.WriteLine(t.Areal());
                        break;
                    case 5:
                        Console.WriteLine(tre.Areal());
                        break;
                    case 6:
                        Console.WriteLine(tre2.Omkreds());
                        break;
                    case 7:
                        Geo();
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
