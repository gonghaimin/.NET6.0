using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class nameofs
    {
        /*我们常常在反射或类似的技术中以字符串的形式使用属性的名称，当我们进行重构而修改属性名称的时候，
         * 由于字符串类型的属性得不到编译器检查，现在有了nameof，再也不用担心拼错属性名称了。
 nameof运算符可以作用于变量、函数、类以及名字空间中，用于返回返回其名称*/

        static void Main1(string[] args)
        {
    
            Console.WriteLine(nameof(Func1));
            Console.WriteLine(nameof(System.Threading.Tasks));
            Console.WriteLine(nameof(Main1));
            Console.WriteLine(nameof(F));

            Console.Read();
        }
        private static void Func1(int x) { }
        private string F<T>() => nameof(T);
        private void Func2(string msg) { }
        private void Func(string msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                throw new ArgumentException(nameof(msg));
            }
        }
    }
}
