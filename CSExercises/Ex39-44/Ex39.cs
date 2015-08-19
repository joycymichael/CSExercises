using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex39
    {
        public static void main(string[] args)
        {
            Console.WriteLine("\n\t\tFACTORIAL");
            Console.Write("Enter number : ");
            long n=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("factorial of {0} is {1}",n,Factorial(n));
            Console.ReadLine();

        }
        public static long Factorial(long n)
        {
            long f=1;
             for (int i = 1; i <= n; i++)
            {
                f = f*i;
            }
            return f;
        }
    }
}
