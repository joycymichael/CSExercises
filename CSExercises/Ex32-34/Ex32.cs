using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\t\tSALES INFORMATION");

           int[] sale;
         
           sale=new int[12];
           int sum = 0;
            for(int i=1;i<=12;i++)
            {
                Console.Write("Enter sales for month {0} :",i);
                sale[i - 1] = Convert.ToInt32(Console.ReadLine());
            }
            int max = sale[0], min = sale[0];
            for (int i = 0; i <12; i++)
            {
                if (min > sale[i])
                {
                    //max = sale[i];
                    min = sale[i];
                }
                if(max<sale[i])
                {
                    max = sale[i];
                }
                sum = sum + sale[i];
                
              
            }
            for (int i = 0; i < 12; i++)
            {
                if(sale[i]==min)
                {
                    Console.Write("\n\tmanimum sale month is : {0} ", i+1);
                }
                if(sale[i]==max)
                {
                    Console.Write("\n\tmaximum sale month is : {0} ", i+1);
                }
            }
            double ave = Convert.ToDouble(sum / sale.Length);
            Console.Write("\n\tmaximum sale  is : {0} ", max);
            Console.Write("\n\tminimum sale  is : {0} ", min);
            Console.Write("\n\tAverage sale  is : {0} ", ave);
            Console.ReadLine();
 
        }
    }
}
