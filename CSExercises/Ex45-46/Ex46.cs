using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\t\tRANDOM NUMBER OCCURRENCES\n");
            int[,] n = new int[10, 10]
            {
	            {10,34,90,12,11,9,4,56,84,68},
	            {94,73,31,89,23,34,65,66,77,11},
                {41,63,36,90,7,45,44,66,99,10},
                {99,9,18,17,31,89,23,34,63,36},
                {62,3,65,75,11,87,55,33,9,2},
                {40,96,53,23,24,46,58,11,98,21},
                {81,15,27,30,21,54,87,32,16,54},
                {21,70,100,22,31,45,66,54,23,3},
                {88,50,13,12,31,87,10,65,49,62},
                {48,54,52,78,54,42,12,35,43,15},
               

	         };

            

            Random r = new Random();
            int[] gnum=new int[50];
            int[] gnum_occ = new int[50];
            //int secnumb = r.Next(1, 100),count=0;
            Console.WriteLine("\n\tGenerated_number\tOccurrences");
            for(int i=0;i<50;i++)
            {
                gnum[i] = r.Next(1, 100);
                gnum_occ[i] = 0;
                for(int j=0;j<10;j++)
                {
                    for(int k=0;k<10;k++)
                    {
                        if(gnum[i]==n[j,k])
                        {
                            gnum_occ[i] = gnum_occ[i] + 1;
                        }
                    }
                }
                Console.WriteLine("\n\t\t{0}\t\t{1}", gnum[i], gnum_occ[i]);

            }
           

            Console.ReadLine();
 
            
        }
    }
}
