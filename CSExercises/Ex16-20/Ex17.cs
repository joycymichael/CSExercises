using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("\n\t\tGREETING\n");
            Console.Write("\n\tPlease Enter your name : ");
            string n = Console.ReadLine();
            string name = n.ToUpper();
            Console.Write("\n\tGender(M/F): ");
            //name = n.ToUpper();
            string g1 = Console.ReadLine();
            string g = g1.ToUpper();
            Console.Write("\n\tPlease Enter Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (g.Equals("M"))
            {
                if(age>=40)
                    Console.WriteLine("\n\t\tGOOD MORNING UNCLE " + name);
                else
                    Console.WriteLine("\n\t\tGOOD MORNING Mr." + name);
            }
            else
            {
                if(age>=40)
                    Console.WriteLine("\n\t\tGOOD MORNING AUNTY " + name);
                else
                    Console.WriteLine("\n\t\tGOOD MORNING Ms." + name);
            }
            

            Console.ReadLine();

        }
    }
}