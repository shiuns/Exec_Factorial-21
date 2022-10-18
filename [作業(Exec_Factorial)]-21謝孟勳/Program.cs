using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_Exec_Factorial___21謝孟勳
{
    //計算數值的階層
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("您要的階乘數字是: ");
            string input = Console.ReadLine();

            int sum = 1;
            for (int i = 1; i <= Convert.ToInt32(input); i++)
            {
                sum *= i;
            }
            Console.WriteLine();
            Console.WriteLine($" {input} 的階層乘積是 {sum} ");
        }
    }
}
