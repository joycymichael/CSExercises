using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex01
    {
        public static void Main(string[] args)
        {
            string n, name;
            Console.Write("Enter Your Name : ");
            n = Console.ReadLine();
            name = n.ToUpper();
            Console.WriteLine("\n\t\t**GOOD MORNING " + name + "**");
            Console.ReadLine();
        }
    }
}
