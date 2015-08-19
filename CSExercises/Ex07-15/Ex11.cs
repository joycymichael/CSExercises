using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
           // double c1;
            Console.WriteLine("\n\t\t\tABC TAXI COMPANY BILL");
            Console.Write("\n\tEnter The Distance : ");
            double d = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("distane=" + d);
            double fare=2.40+(d*0.4);
            Console.WriteLine("Fare price = {0:0.00}",fare);
            Console.ReadLine();
            
           
        }
    }
}
