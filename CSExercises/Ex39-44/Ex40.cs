using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\t\tSquare Root");
            Console.Write("Enter number : ");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\tsquare root of {0} is {1}", n, SQT(n));
            Console.ReadLine();
            
        }

        public static double SQT(int y)
        {
            double sq;
            sq=Math.Sqrt(y);
            return sq;
        }
    }
}
