using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {

            
            Console.WriteLine("\n\t\t\t PERFECT NUMBER FROM 1 to 1000 \n\n");
        
            for(int n=1;n<=1000;n++)
            {
                int count = 0;
            for (int i = 1; i < n; i++)
            {

                if (n % i == 0)
                {
                    count = count + i;
                }


            }
            if (count == n)
            {
                Console.Write("\t{0}", n);
            }
          
            }
            Console.ReadLine();
        }
    }
}
