using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\t\tMARK GRADING \n");
            Console.Write("\n\tPlease Enter your mark : ");
            int m = Convert.ToInt32(Console.ReadLine());
            if(m>=0 && m<=100)
            {
                if(m<=40)
                    Console.WriteLine("\n\tYou scored {0} marks which os F grade",m);
                else if (m <= 59)
                    Console.WriteLine("\n\tYou scored {0} marks which os C grade", m);
                else if (m <= 79)
                    Console.WriteLine("\n\tYou scored {0} marks which os B grade", m);
                else 
                    Console.WriteLine("\n\tYou scored {0} marks which os A grade", m);


            }
            else
            {
                Console.WriteLine("Error!! //plase Enter between 0 to 100");
            }
            Console.ReadLine();
        }
    }
}