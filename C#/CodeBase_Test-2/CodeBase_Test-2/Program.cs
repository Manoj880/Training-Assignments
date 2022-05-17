using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase_Test_2
{
    delegate int calculator(int num1, int num2);
    class calculator1
    {
     

        public static int Addnum(int num1, int num2)
        {
            
            return num1 + num2;
        }
        public static int Multiplynum(int num1, int num2)
        {
            
            return num1 * num2;
        }
        public static int Subtractnum(int num1, int num2)
        {
           
            return num1 - num2;
        }
        
        static void Main(string[] args)
        {
            calculator cal1 = new calculator(Addnum);
            int sum = cal1.Invoke(10,20);
            Console.WriteLine("sum = {0}",sum);
            calculator cal2 = new calculator(Subtractnum);
            int sub = cal2.Invoke(15,30);
            Console.WriteLine("Prod = {0}", sub);
            calculator cal3 = new calculator(Multiplynum);
            int prod = cal3.Invoke(8,9);
            Console.WriteLine("prod = {0}", prod);

            Console.Read();
        }
    }
}
