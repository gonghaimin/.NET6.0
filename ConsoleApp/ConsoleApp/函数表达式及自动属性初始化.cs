using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class 函数表达式及自动属性初始化
    {
        static void Main1(string[] args)
        {
            Point p = new Point(2, 3);
            Console.WriteLine(p.Distance);
            Console.Read();
        }
        public class Point
        {
            /*初始化属性*/
            public int X { get; set; } = 2;
            public int Y { get; set; } = 3;
            /*这是自动属性初始化属性的写法*/
            public string str { get; set; } = "测试";
            /**/
            public string newstr => $"{str}{Y}";
            /*只读属性*/
            public int Id { get; }
            /*这是以前的写法*/
            public Point(int id)
            {
                str = "默认值";
                Y = 5;
                Id = id;
            }

            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            public double Distances
            {
                get { return Math.Sqrt((X * X) + (Y * Y)); }
            }
            public Point Moves(int dx, int dy)
            {
                return new Point(X + dx, Y + dy);
            }
            /*使用Lambda表达式简化以上过程*/
            public double Distance => Math.Sqrt((X * X) + (Y * Y));

            public Point Move(int dx, int dy) => new Point(X + dx, Y + dy);
        }
    }
}
