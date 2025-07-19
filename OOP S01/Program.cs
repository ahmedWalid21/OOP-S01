using System.ComponentModel;
using System.Drawing;

namespace OOP_S01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Console.Write("enter X for Point 1: ");
            //double x1 = double.Parse(Console.ReadLine());

            //Console.Write("enter Y for Point 1: ");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.Write("enter X for Point 2: ");
            //double x2 = double.Parse(Console.ReadLine());

            //Console.Write("enter Y for Point 2: ");
            //double y2 = double.Parse(Console.ReadLine());

            //Point p1 = new Point(x1, y1);
            //Point p2 = new Point(x2, y2);


            //double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            //Console.WriteLine($"Distance = {distance}"); 
            #endregion

            Person[] p = new Person[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter name : ");
                p[i].Name = Console.ReadLine();

                Console.Write("Enter age : ");
                p[i].Age = int.Parse(Console.ReadLine());

                
            }
            int oldest = 0;
            for(int i=0;i<3; i++)
            {
                if (p[i].Age > p[oldest].Age)
                {
                    oldest = i;
                }
            }
            Console.WriteLine($"\nThe oldest person is: {p[oldest].Name}, Age: {p[oldest].Age}");


        }
    }
}
