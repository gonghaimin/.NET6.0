using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
namespace ConsoleApp
{
    class usingStatic类型
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hi,Fanguzai!");
            WriteLine("Hi,Fanguzai!");  // 使用了 using static System.Console;
            Read();
        }
        /*使用了 using static System.Math; */
        public static double MyMethod(double x, double angle)
        {
            return Sin(x) + Cos(angle);
        }
    }
}
