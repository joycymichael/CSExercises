using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            double s, i;

            Console.WriteLine("Income calculater");
            Console.Write("Enter salary: ");
             s = Convert.ToInt16(Console.ReadLine());

       
                try
                {
                    i = s + 0.1 * s + 0.03 * s;

                    Console.WriteLine("Total income = {0}", i);
                }
                catch (Exception ex)
                {
                    Console.ReadLine();
                }

                Console.ReadLine();
            
           

        }
    }
}
