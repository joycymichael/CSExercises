using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {

            int x, y;

            Console.WriteLine("TO FIND VALUE of 2x^2-4x+3");
            Console.Write("Enter value of x: ");
            x = Convert.ToInt16(Console.ReadLine());

            try
            {

                y = 2 * x * x - 4 * x + 3;

                Console.WriteLine("Y= {0}", y);
            }
            catch (Exception ex)
            {
                Console.ReadLine();
            }

            Console.ReadLine();
            
        }
    }
}
