using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num1:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num1:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            float res;

            try
            {
                res = n1 / n2;
                Console.WriteLine(res);
            }
            catch (DivideByZeroException ex)//FileNotFoundException,IOException,OverflowException,IndexOutOfRangeException,FormatException
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("divide by zero exception");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("divide by zero exception");
            }
            finally
            {
                //used for clean up operations like closing connections
                Console.WriteLine("finally executes");
            }



            }
        }
}

