using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\t\tOccurance of word");
            Console.Write("Enter string1 : ");
            string s1 = Console.ReadLine();
            Console.Write("Enter string2 : ");
            string s2 = Console.ReadLine();
            Console.WriteLine("Result is " + FindWord(s1, s2));
            Console.ReadLine();
        }
        public static int FindWord(string s1, string s2)
        {
            int result;
            if (s1.ToLower().Contains(s2.ToLower()))
            {

                result =s1.IndexOf(s2);
            }

            else
            {

                result = -1;
            }
            return result;
        }
    }
}
