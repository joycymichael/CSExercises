using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
     
            int num, r,sum = 0;
            Console.WriteLine("\n\t\t  TO CHECK ARMSTRONG NUMBER ");
            Console.Write("Enter a number : ");
            num = int.Parse(Console.ReadLine());
            for (int i = num; i > 0; i = i / 10)
            {
                r = i % 10;
                sum = sum + r*r*r;
            }
            if (sum == num)
            {
                Console.Write("Entered number is an Armstrong number.");
            }
            else
            Console.Write("Entered number is not an Armstrong number.");
            Console.ReadLine();
      
            
        }
    }
}