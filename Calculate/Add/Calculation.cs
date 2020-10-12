using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add
{
    class Calculation:Solve
    {
        int number1;
        int number2;
        string x;
        string y;
        
        public string X
        {
            get { return x; }
            set { x = value; }
        }
        
        public string Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Number2
        {
            get { return number2; }
            set { number2 = value; }
        }

        public int Number1
        {
            get { return number1; }
            set { number1 = value; }
        }
        
        public override int _Add()  //加
        {
            return number1 + number2;
        }
        public override double add()
        {
            return number1 % number2;
        }
        public override String Add()
        {
            return x + y;
        }
        public override int And()
        {
            return number1 % number2;
        }
        public override int _Reduce()  //减
        {
            return number1 - number2;
        }
        public override String Reduce()
        {
            for (int i = 0; i < Y.Length; i++)
            {
                X = x.Replace(Y[i],' ');
            }
            X = X.Trim();
            return X;
        }
        public override int _Ride()   //乘
        {
            return number1 * number2;
        }
        public override int _Except()   //除
        {
            return number1 / number2;
        }
        public void operation(string x)
        {
            if (x == "+")
                Console.WriteLine("整数和为：" + _Add());
            else if (x == "%")
                Console.WriteLine("取余：" + add());
            else if (x == "&")
                Console.WriteLine("与运算："+And());
            else if (x == "S+")
                Console.WriteLine("字符串连接:" + Add());
            else if (x == "-")
                Console.WriteLine("整数差为：" + _Reduce());
            else if (x == "S-")
                Console.WriteLine("字符串删除:" + Reduce());
            else if (x == "*")
                Console.WriteLine("乘为：" + _Ride());
            else if (x == "/")
                Console.WriteLine("除为：" + _Except());
            else
                Console.WriteLine("符号输入错误！！！");
            
        }
        public bool Equals (int number1,int number2)
        {
            if (number1 == number2)
                return true;
            else
                return false;
        }
    }
}
