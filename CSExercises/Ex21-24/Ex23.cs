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
                    Console.WriteLine("\n\tYou Got It!!!");
                }
                else
                {
                    count = count + 1;
                    Console.WriteLine("\n\ttry again");
                }
            } while (g != secnumb);
            if (count <= 2)
                Console.WriteLine("\n\t\t\tYou are a viizard!!!");
            else if (count <= 6)
                Console.WriteLine("\n\t\t\tYou are a good guess!!!");
            else
            Console.WriteLine("\n\t\t\tYou are lousy!!!");

            Console.ReadLine();
        }
    }
}
