using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int secnumb = r.Next(1, 11),count=0;
            int g;
            do
            {
                Console.Write("\n\tEnter (1-10) guess :");
                g=Convert.ToInt32(Console.ReadLine());
                if (g == secnumb)
                {
                    Console.WriteLine("You Got It!!!");
                }
                else
                {
                    count = count + 1;
                    Console.WriteLine("try again");
                }
            } while (g != secnumb);
            if (count <= 2)
                Console.WriteLine("You are a viizard!!!");
            Console.ReadLine();
        }
    }
}
