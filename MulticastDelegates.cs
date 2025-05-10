using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteDelegates
{
    public delegate void Print(string name);
    internal class Program
    {
        public static void display(string x)
        {
            Console.WriteLine("name in display is "+x);
        }
        public void show(string y)
        {
            Console.WriteLine("name in show is " + y);
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            Print del =new Print(p.show);//it should be called with object because it is non-static method
            del += Program.display;//multicast Delegates
            //called using class name because it is static method
            del("dileep");
        }
    }
}
