using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class 字典的初始化
    {
        static void Main1(string[] args)
        {
           
            Console.Read();
        }
        public void MyMethod()
        {
            /*以前的写法*/
            Dictionary<string, int> student = new Dictionary<string, int>();
            student.Add("a1", 15);
            student.Add("a2", 14);
            student.Add("a3", 16);
            /*现在的写法*/
            Dictionary<string, int> students = new Dictionary<string, int>()
            {
                ["a1"] = 15,
                ["a2"] = 14,
                ["a3"] = 16
            };
        }

    }
}
