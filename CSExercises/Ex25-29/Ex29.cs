using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {

            int sum = 0;
            Console.WriteLine("\n\t\t\tCHECKING PERFECT NUMBER ");
            Console.Write("\n\tEnter Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {

                if (n % i == 0)
                {
                    sum = sum + i;
                }


            }
            if (sum == n)
            {
                Console.WriteLine("\n\t{0} is perfect number", n);
            }
            else
            {
                Console.WriteLine("\n\t{0} is not a perfect number", n);
            }
            Console.ReadLine();
        }
    }
}
