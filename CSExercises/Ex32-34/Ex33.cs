using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\t\tDESCENDING ORDER\n\n");

            int[] x;

            x = new int[]{86,35,41,49,89,51,11,71,50,75,25,58,40,14,44,3,63,81,93,79};
           // x = new int[] { 4,2,7,9,1,6};
             for(int i=0;i<x.Length-1;i++)
             {
                 for(int j=i+1;j<x.Length;j++)
                 {
                     if(x[i]>x[j])
                     {
                         int temp = x[i];
                         x[i] = x[j];
                         x[j] = temp;
                     }
                 }
                 Console.Write("\nstep{0}", i + 1);
                 for (int k = x.Length - 1; k >= 0; k--)
                 {
                     Console.Write("\t" + x[k]);
                 }
                 
             }
             Console.WriteLine("\nResult");

             for (int i = x.Length-1; i >=0; i--)
             {
                 Console.Write("\t"+x[i]);
             }

             Console.ReadLine();
        }
    }
}
