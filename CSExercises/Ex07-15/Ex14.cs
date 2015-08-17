using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            double s, p;
            Console.WriteLine("\n\t\tArea of Triangle");
            Console.Write("\n\tEnter value of a: ");
           a = Convert.ToInt16(Console.ReadLine());
            Console.Write("\n\tEnter value of b: ");
             b = Convert.ToInt16(Console.ReadLine());
            Console.Write("\n\tEnter value of c: ");
            c = Convert.ToInt16(Console.ReadLine());
            s = (a + b + c) / 2;
            p = s * (s - a) * (s - b) * (s - c);

            try
            {

                double area = Math.Sqrt(p);

                Console.WriteLine("Area of trinagle is {0}", area);
            }
            catch (Exception ex)
            {
                Console.ReadLine();
            }

            Console.ReadLine(); 
        }
    }
}