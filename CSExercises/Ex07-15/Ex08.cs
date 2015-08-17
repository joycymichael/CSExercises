using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            double c, f;

            Console.WriteLine("\n\t\tCentigrade to Fahrenheit");
            Console.Write("\n\tEnter Centigrade value: ");
             c = Convert.ToInt16(Console.ReadLine());

            try
            {

                f = 1.8 * c + 32;

                Console.WriteLine("\n\tFahrenheit = {0}", f);
            }
            catch (Exception ex)
            {
                Console.ReadLine();
            }

            Console.ReadLine();
            
        }
    }
}
