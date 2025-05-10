using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Delegates
{
    
    internal class Program
    {
        public delegate int Del(int x,int y);
        static void Main(string[] args)
        {
            char choice;
            int x, y;
            int res = 0;
            string str;
            Del d;
            Console.WriteLine("##----CALCULATOR----##");
            do
            {
                Console.WriteLine("enter first number:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter second number:");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the operation:");
                choice = Convert.ToChar(Console.ReadLine());
                switch (choice)
                {
                    case '+':
                            d = new Del(Add);
                            res = d(x, y);
                            Console.WriteLine($"{x}+{y}={res}");
                            break;
                    case '*':
                            d = new Del(mul);
                            res = d(x, y);
                            Console.WriteLine($"{x}*{y}={res}");
                            break;
                    case '/':
                            d = new Del(div);
                            res = d(x, y);
                            Console.WriteLine($"{x}/{y}={res}");
                            break;
                    case '-':
                            d = new Del(sub);
                            res = d(x, y);
                            Console.WriteLine($"{x}-{y}={res}");
                            break;
                    case '%':
                            d = new Del(mod);
                            res = d(x, y);
                            Console.WriteLine($"{x}%{y}={res}");
                            break;
                    default:
                            Console.WriteLine("enter correct option");
                            break;
                }
                Console.WriteLine("enter y to continue:");
                str= Console.ReadLine();
            } while (str.ToLower() == "y");
            
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int mul(int x, int y)
        {
            return x * y;
        }
        public static  int div(int x, int y)
        {
            return x / y;
        }
        public static int mod(int x, int y)
        {
            return x % y;
        }
        public static int sub(int x, int y)
        {
            return x - y;
        }
    }
}
