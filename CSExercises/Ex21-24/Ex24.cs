using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            double N = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(N);
            int n1 = Convert.ToInt32(N);
            Random r = new Random();
            int guess = r.Next(1, n1);
            if(guess*guess==N)
            {
                Console.WriteLine("\nGuess is correct");
            }
            else
            {
                double guess1 = Convert.ToDouble((guess + (N / guess)) / 2);
                Console.WriteLine("Guesss is " + guess1);
            }
            
           // Console.WriteLine("SQUARE ROOT = " + c);
            Console.ReadLine();
        }
    }
}
