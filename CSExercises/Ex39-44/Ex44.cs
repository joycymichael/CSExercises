using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\t\tFind and replace char in string");
            Console.Write("Enter string1 : ");
            string s1 = Console.ReadLine();
             Console.Write("Enter char1 : ");
            char c1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter char2 : ");
            char c2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("result is {0}",Substitute(s1, c1, c2));
            Console.ReadLine();
        }
        public static string Substitute(string s, char c1, char c2)
        {
           // return s.Replace(s, c1, c2);
            char[] ch=new char[s.Length];
            ch = s.ToCharArray();
            for(int i=0;i<s.Length;i++)
            {
                if(ch[i]==c1)
                {
                    ch[i] = c2;
                }
               
            }
            string s1 = new string(ch);
            return s1;
        }
    }
}
