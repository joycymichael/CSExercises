using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            int f=1,f1=1;
            Console.WriteLine("\n\t\tFACTORIAL CALCULATER");
            Console.Write("\n\tEnter number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                f = f*i;
            }
            for (int i = n; i >= 1; i--)
            {
                f1 = f1 * i;
            }
            Console.WriteLine("\n\tFactorial of {0} is {1}  <---Using increment ",n,f);
            Console.WriteLine("\n\tFactorial of {0} is {1}  <---Using deccrement ", n, f1);
            Console.ReadLine();

        }
    }
}
