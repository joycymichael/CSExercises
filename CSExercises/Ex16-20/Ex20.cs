using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t PRICE CALCULATER \n");
            Console.Write("\n\tEnter Quantity of TV : ");
            int tv = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tEnter Quantity of dvd : ");
            int dvd = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tEnter Quantity of mp3 : ");
            int mp3 = Convert.ToInt32(Console.ReadLine());
            int total1 = mp3 * 700;
            int total2 = 900 * tv + 500 * dvd;
            if(total2 >10000)
            {
                double discount = total2 * 0.15;
                double pr = total2 - discount + total1;
                Console.Write("\n\tTotal price for this order is  : {0:0.00} ",pr);

            }
            else if (total2 > 5000)
            {
                double discount = total2 * 0.1;
                double pr = total2 - discount + total1;
                Console.Write("\n\tTotal price for this order is  : {0:0.00} ", pr);

            }
            else 
            {
                //double discount = total2 * 0.1;
                double pr = total2 + total1;
                Console.Write("\n\tTotal price for this order is  : {0:0.00} ", pr);
            }

            Console.ReadLine();
        }
    }
}