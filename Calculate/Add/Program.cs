using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation C=new Calculation ();
            Console.WriteLine("请输入第一个数：");
            C.Number1 = Convert.ToInt32(Console .ReadLine ());
            Console.WriteLine("请输入运算符号：");
            string x = Convert.ToString(Console.ReadLine());
            Console.WriteLine("请输入第二个数：");
            C.Number2 = Convert.ToInt32(Console.ReadLine());
            C.operation(x);
            if(C.Equals (C.Number1 ,C.Number2 ))
                Console.WriteLine("两数相同");
            else
                Console.WriteLine("两数不同");
        }
    }
}
