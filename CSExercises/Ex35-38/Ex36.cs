using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            char[] tr1 = new char[] {' ', '.', '$', '*'};
            Console.WriteLine("\n\t\t\tPALINDROME CHECK\n");
            Console.Write("\tEnter senence :");
            string s = Console.ReadLine().ToUpper().Trim(tr1);
            //string r= s.Trim(tr1);
            //string s2 = s.Trim();
            char[] c = s.ToCharArray();
            char[] d = new char[50];
            int j = s.Length - 1;
            //Console.WriteLine(s);
            for(int i=0;i<s.Length;i++)
            {
                
                d[i] = c[j];
                j--;
            }
          
            string s1 = new string(d);
           //Console.WriteLine("{0}", s1);
            if(s1.CompareTo(s)==0)
            {
                Console.WriteLine("\n\t\t{0} IS PALINDROME",s);
            }
            else
            {
                Console.WriteLine("\n\t\t{0} IS NOT PALINDROME", s);
            }
            Console.ReadLine();

        }
    }
}
