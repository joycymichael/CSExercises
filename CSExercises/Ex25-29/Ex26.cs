using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\tNO\t\tINVERSE\t\tSQUAREROOT\t\tSQARE");
            Console.WriteLine("\n\t--\t\t-------\t\t----------\t\t-----");
            for (double i = 1; i <= 10; i++)
            {
                double inv = i / 10;
                double s1 = Math.Sqrt(i);
                double s2 = i * i;

                Console.WriteLine("\n\t{0:0.0}\t\t{1:0.000}\t\t{2:0.000}\t\t\t{3:0.0}", i, inv, s1, s2);
            }
            Console.ReadLine();
        }
    }
}
