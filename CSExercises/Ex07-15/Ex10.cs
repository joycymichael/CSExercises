using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            int d1, d2;
            double d;

            Console.Write("\n\t\tDistance between two points");
            Console.Write("\n\tEnter value of x1: ");
            int x1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("\n\tEnter value of y1: ");
            int y1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("\n\tEnter value of x2: ");
            int x2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("\n\tEnter value of y2: ");
            int y2 = Convert.ToInt16(Console.ReadLine());
            d1 = (x2 - x1) * (x2 - x1);
            d2 = (y2 - y1) * (y2 - y1);
            //d=math.sqrt(d1+d2);


            try
            {

                 d = Math.Sqrt(d1 + d2);

                 Console.WriteLine("\n\tDistance is {0}", d);
            }
            catch (Exception ex)
            {
                Console.ReadLine();
            }

            Console.ReadLine();
            
        }
    }
}
