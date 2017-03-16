using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class 内插字符串
    {
        static void Main1(string[] args)
        {
            var age = 5;
            var name = "Fanguzai";
            /*用“$”前缀实现（变量直接写到大括号内)*/
            Console.WriteLine($"Hello, {name}");
            var s1 = $"hello, {name}";
            IFormattable s2 = $"Hello, {name}{age}";
            FormattableString s3 = $"Hello, {name}";
            string s5 = $"{DateTime.Now:yyyy-MM-dd}";
            Console.WriteLine(s5);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            /*这是以前的写法*/
            string s4 = string.Format("{0},{1}", name, age);
            Console.WriteLine(s4);
            Console.Read();

        }
      
    }

}
