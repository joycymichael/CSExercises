using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("\n\t\t\tCHECKING PRIME ");
            Console.Write("\n\tEnter Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=2;i<n;i++)
            {
           
                if(n%i==0)
                {
                    count = count + 1;
                }

               
            }
            if(count==0)
            {
                Console.WriteLine("\n\t{0} is prime number", n);
            }
            else
            {
                Console.WriteLine("\n\t{0} is not a prime number", n);
            }
            Console.ReadLine();
        }
    }
}
