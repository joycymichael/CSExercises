
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int d;
            Console.WriteLine("\n\n\t\t LCM and HCF");
            Console.Write("\n\tEnter value of A : ");
            int a = Convert.ToInt16(Console.ReadLine());
            int A=a;
            Console.Write("\n\tEnter value of B : ");
            int b = Convert.ToInt16(Console.ReadLine());
            int B=b;
            do
            {
                if (a > b)
                {
                    d = a - b;
                    a = d;
                }
                else
                {
                    d = b - a;
                    b = d;
                }
            } while (a == b);
            Console.WriteLine("\n\t\tX = " + a);
            int hcf = a;
            int lcm = (A * B) / hcf;
            Console.WriteLine("\n\t\tHCF = " + hcf);
            Console.WriteLine("\n\t\tLCM = " + lcm);
            Console.ReadLine();
            

        }
    }
}
