using System.ComponentModel;
using System.Drawing;

namespace OOP_S01
{
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
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
            #region Q02

            //Person[] p = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Enter name : ");
            //    p[i].Name = Console.ReadLine();

            //    Console.Write("Enter age : ");
            //    p[i].Age = int.Parse(Console.ReadLine());


            //}
            //int oldest = 0;
            //for(int i=0;i<3; i++)
            //{
            //    if (p[i].Age > p[oldest].Age)
            //    {
            //        oldest = i;
            //    }
            //}
            //Console.WriteLine($"\nThe oldest person is: {p[oldest].Name}, Age: {p[oldest].Age}");

            #endregion



            Employeee[] Emp = new Employeee[3];

            Emp[0] = new Employeee(1, "Ahmed", 'M', SecurityLevel.DBA, 15000, new HiringDate(18, 6, 2023));

            Emp[1] = new Employeee(2, "Malak", 'F', SecurityLevel.Guest, 8000, new HiringDate(15, 5, 2024));

            Emp[2] = new Employeee(3, "Omar", 'M', SecurityLevel.Developer, 18000, new HiringDate(12, 7, 2025));

            for(int i=0; i<3; i++)
            {
                Console.WriteLine(Emp[i]);
            }









        }
    }
}
