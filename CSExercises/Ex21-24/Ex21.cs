using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int a;
            Console.WriteLine("\n\n\t\tLucky number ");
            do
            {
                Console.Write("\n\tEnter number ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a != 88);
            Console.WriteLine("\n\t\t\t\tLucky You....");
            Console.ReadLine();
        }
    }
}
