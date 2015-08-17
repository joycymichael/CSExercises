using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double c1;
            Console.WriteLine("\n\t\t\tABC TAXI COMPANY BILL");
            Console.Write("\n\tEnter The Distance : ");
            double d = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("distane=" + d);
            double d1 = Math.Round(d,2);
           
            //double someDouble = 12323.2;
            //int someInt = (int)someDouble;
            int d2 = Convert.ToInt32(d1*100);
            int d3 = ((d2 / 10) + 1) * 10;
            double d4 = Convert.ToDouble(d3);
            //Console.WriteLine("distane=" + d4);
            int dc=Convert.ToInt32(d4/10);
            double d5 = d4 / 100;
           //Console.WriteLine("distane={0:0.00}" , d5);
          
           if(d5>=9)
            {
              c1=2.40+85*0.04+ (dc-90)*0.05;
              Console.WriteLine("\n\t\tcost =${0:0.00}" , c1);

            }
            else 
            {
               if(d5>=0.5)
               {
                   c1=2.40+(d5-0.5)*0.04;
                   Console.WriteLine("\n\t\tcost =${0:0.00}" , c1);
               }
               else
               {
                   Console.WriteLine("\n\t\tcost =$2.40");

               }

            }
           Console.ReadLine();
 
        }
    }
}