using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("\n\t\tGREETING\n");
            Console.Write("Please Enter your name : ");
            string n = Console.ReadLine();
            string name = n.ToUpper();
            Console.Write("Gender(M/F): ");
            //name = n.ToUpper();
            string g1 = Console.ReadLine();
            string g = g1.ToUpper();

            if(g.Equals("M"))
               Console.WriteLine("GOOD MORNING Mr." + name);
            else
                Console.WriteLine("GOOD MORNING Ms." + name);

            Console.ReadLine();
            
        }
    }
}