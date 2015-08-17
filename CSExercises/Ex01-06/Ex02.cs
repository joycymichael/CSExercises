using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            
           Console.WriteLine("\n\t\tSQUARE CALCULATER");
           Console.Write("\n\tEnter an Integer Number : ");
           string n=Console.ReadLine();
           int a = Convert.ToInt32(n);
            Console.WriteLine("\n\tAnswer is {0}", a * a);
            Console.ReadLine();
        }
    }
}
