using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            
            int[,] mark = new int[12, 4]
            {
	            {56,84,68,29},
	            {94,73,31,89},
                {41,63,36,90},
                {99,9,18,17},
                {62,3,65,75},
                {40,96,53,23},
                {81,15,27,30},
                {21,70,100,22},
                {88,50,13,12},
                {48,54,52,78},
                {64,71,67,25},
                {16,93,46,72}

	         }; 
            int totalsum = 0;
            Console.WriteLine("\n\t\t\tSTUDENT MARK LIST\n");
            Console.WriteLine("\t\t\t-----------------\n");
            Console.WriteLine("\t\tSUB1\tSUB2\tSUB3\tSUB4\tTOTAL\tAVERAGE\tSTAND.DEV");
            for (int i = 0; i < 12; i++)
            {
                Console.Write("\n\n student{0}", i+1);
                int total = 0, sum=0 ;
                double sd = 0,v1 = 0;
                for (int j = 0; j < 4; j++)
                {
                    totalsum = totalsum + mark[i, j];
                    total = total + mark[i, j];
                    sum = sum + (mark[i, j] * mark[i, j]);
                    v1 = Convert.ToDouble(sum / 4);
                    sd = Math.Sqrt(v1);
                    Console.Write("\t{0}", mark[i, j]);

                }
                Console.Write("\t{0}\t{1}\t{2:0.000}", total,total/4,sd);
            }
            
            Console.Write("\n\nSUB_AVERAGE");
            double[] subave=new double[4];
            for (int j = 0; j < 4; j++)
            {
                int subtotal = 0;
                for (int i = 0; i < 12; i++)
                {
                    subtotal = subtotal + mark[i, j];
                  
                }

                subave[j] = Convert.ToDouble(subtotal / 12);
                Console.Write("\t{0}", subave[j]);
            }
            Console.Write("\n\nSTD.DV\t");
            for (int j = 0; j < 4;j++ )
            {
                double subsum1 = 0;
                double stdv1=0;
                for(int i=0;i<12;i++)
                {
                    double temp = Convert.ToDouble(mark[i, j]);
                    subsum1 = subsum1 + ((temp - subave[j]) * (temp - subave[j]));

                }
                stdv1 = Convert.ToDouble(Math.Sqrt(subsum1 / 12));

                Console.Write("\t{0:0.000}",stdv1);
                
            }
            Console.WriteLine("\n-------------------------------------------------------------");
                Console.WriteLine("\n\n\t\tOverall Average mark is {0}", totalsum / (12 * 4));
              
                Console.ReadLine();
            
        }
    }
}
