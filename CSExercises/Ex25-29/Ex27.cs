using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\tX \t\tY");
            Console.WriteLine("\n\t---------------------");
            for (double i = -5; i <5; i++)
            {
                
                double y = 2*i*i-4*i+3;

                Console.WriteLine("\n\t{0:0.0}\t\t{1:0.0}",i,y);
            }
            Console.WriteLine("\n\t");
            for (double i = -5; i < 5; i++)
            {

                double y = 2 * i * i - 4 * i + 3;
                for (int j = 1; j <= y;j++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
                   
            }
            Console.ReadLine();
            
        }
    }
}
