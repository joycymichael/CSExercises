using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("\n\t\t\t PRIME NUMBERS FROM 5 to 100000 \n\n");
           // Console.Write("\n\tEnter Number : ");
            //int n = Convert.ToInt32(Console.ReadLine());
            for (int n = 5; n <= 10000; n++)
            {
                int count = 0;

                for (int i = 2; i < n; i++)
                {

                    if (n % i == 0)
                    {
                        count = count + 1;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("\t{0} ", n);
                }
               
            }
            Console.ReadLine();
        }
    }
}
