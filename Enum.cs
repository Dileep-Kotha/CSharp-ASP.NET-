using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    enum days
    {
        monday,
        tuesday,wednesday,thursday,friday,saturday,sunday
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            days today =days.friday;
            Console.WriteLine(today);//default it is string
            Console.WriteLine((int)today);//converted to integer value
        }
    }
}
