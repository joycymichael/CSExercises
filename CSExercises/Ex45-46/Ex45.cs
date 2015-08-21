using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("\n\tCounting coins for given amount");
            Console.Write("\n\tEnter Amount: ");
            double n = Convert.ToDouble(Console.ReadLine());
            int sent = Convert.ToInt32(n * 100);
            if(sent%10>5)
            {
                sent = sent - (sent % 10)  + 10;
            }
            else
            {
                sent = sent - (sent % 10) +5;
            }
         
           // Console.WriteLine("\ndouble n={0}, int n-{1}", n, Convert.ToInt32(n*100));
           Console.WriteLine("\n" + sent);
           if (sent % 100 != 0)
           {
               if (sent % 10 == 5)
               {
                   Console.WriteLine("\t5c");
                   sent = sent - 5;
               }
               do
               {
                   if (sent % 100 >= 50)
                   {
                       Console.WriteLine("\t50c");
                       sent = sent - 50;
                   }
                   else if (sent % 100 < 50 && sent % 100 >= 20)
                   {
                       Console.WriteLine("\t20c");
                       sent = sent - 20;
                   }
                   else
                   {
                       Console.WriteLine("\t10c");
                       sent = sent - 10;
                   }


               } while (sent % 100 > 0);
           }

            Console.WriteLine("\t{0}*100c", sent / 100);
           
            Console.ReadLine();
            
            
        }
    }
}
