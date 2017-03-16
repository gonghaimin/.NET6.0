using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class NULL_条件运算符
    {
        /*如果对象为NULL，则不进行后面的获取成员的运算，直接返回NULL*/
        static void Main(string[] args)
        {
            //普通的委托调用
            Func<int> func = () => 0;
            if (func != null)
            {
                func();
            }
            //简化调用
            func?.Invoke();

            var ss = new string[] { "Foo", "" };
            string aa = "测试";
            aa = aa?.ToString();
            var first = ss?[1].ToString();
            var length0 = ss[0]?.Length; // 结果为3
            var length1 = ss[1]?.Length; // 结果为null
            var lengths = ss.Select(s => s?.Length ?? 0); //结果为[3, 0] 
            Console.Read();
        }
    }
}
