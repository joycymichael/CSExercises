using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
      
    public class Ex43
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\t\tHEX VALUE");
           // Console.Write("Enter number : ");
           //int n = Convert.ToInt32(Console.ReadLine());
           // string hexValue = n.ToString("X");
    
           // int decAgain = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);*/
          // Console.WriteLine("hex of {0} is {1} ",n,hexValue);
            Console.WriteLine("\nnumber\tHex using function\thew using built in finstion");
           for (int i = 1; i <= 100; i++)
           {
              // Console.WriteLine("\t{0}");
               string s = i.ToString("X");
               Console.WriteLine("{0}\t\t{1}\t\t{2}", i,Hex(i), s);
           }
          
            Console.ReadLine();
        }
        
        public static string Hex(int j)
        {
            int n=j;
            string s2="";
         do{
               
             int hex1 = n % 16;
             if (hex1 >= 10)
               {
                   int caseSwitch = hex1;
                   switch (caseSwitch)
                   {
                       case 10:
                          s2=s2+"A";
                           break;
                       case 11:
                           s2 = s2 + "B";
                           break;
                       case 12:
                           s2 = s2 + "C";
                           break;
                       case 13:
                           s2 = s2 + "D";
                           break;
                       case 14:
                           s2 = s2 + "E";
                           break;
                       case 15:
                           s2 = s2 + "F";
                           break;
                       default:
                           s2 = "";
                           break;
                   }
               }
               else
               {
                   s2=s2+hex1;
               }
               n = n / 16;

           } while (n > 0);
         char[] cArray = s2.ToCharArray();
         string reverse = String.Empty;
         for (int i = cArray.Length - 1; i > -1; i--)
         {
             reverse += cArray[i];
         }
         return reverse;
             
         
    }

    }
}
