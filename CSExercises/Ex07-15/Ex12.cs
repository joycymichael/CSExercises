using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            
            int d3;
            Console.WriteLine("\n\t\t\tABC TAXI COMPANY BILL");
            Console.Write("\n\tEnter The Distance : ");
            double d = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("distane=" + d);
            double fare = 2.40 + (d * 0.4);
          
            double d1 = Math.Round(fare, 2);

            //double someDouble = 12323.2;
            //int someInt = (int)someDouble;
            int d2 = Convert.ToInt32(d1 * 100);
            
            if (d2 % 10 >= 5)
            {
                d3 = ((d2 / 10) + 1) * 10;
            }
            else
            {
                 d3 = (d2 / 10) * 10;
            }
            double d4 = Convert.ToDouble(d3);
            //Console.WriteLine("distane=" + d4);
            int dc = Convert.ToInt32(d4 / 10);
            double d5 = d4 / 100;
            Console.WriteLine("\n\tRounded fareprice ={0:0.00}" , d5);
            Console.WriteLine("\n\tFare price = {0:0.00}", fare);
            Console.ReadLine();
            
           
            
        }
    }
}
