using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic Collections");
            Console.WriteLine("---List---");
            List<string> l = new List<string>();//Generic collection
            l.Add("hi");
            l.Add("kotha");
            l.Add("dileep");
            l.Add("cognizant");
            l.Add("intern");
            List<int> l2 = new List<int>() { 1, 2, 3, 4, 7, 8, 9, 10 };//in one line
            foreach (int i in l2)
            {
                Console.WriteLine(i);
            }
            foreach (string str in l)
            {
                Console.WriteLine(str);
            }
            l2.Reverse();
            Console.WriteLine("After Reversing:");
            foreach (int i in l2)
            {
                Console.WriteLine(i);
            }
            l2.Reverse();


            Console.WriteLine("---Dictionary---");
            Dictionary<int,string> dt=new Dictionary<int,string>();
            dt.Add(100, "hundred");
            dt.Add(101, "hundred-one");

            dt.Add(102, "hundred-two");

            dt.Add(103, "hundred-three");
            if(dt.ContainsKey(103))
            {
                Console.WriteLine("contains 103 key");
            }
            foreach(var d in dt)
            {
                Console.WriteLine("Key is: "+d.Key+" value is:"+d.Value);
            }


            // 3. HashSet<T> (Unique elements)
            Console.WriteLine("\n--- HashSet<T> Example ---");
            HashSet<int> uniqueNumbers = new HashSet<int>();
            uniqueNumbers.Add(1);
            uniqueNumbers.Add(2);
            uniqueNumbers.Add(2); // Duplicate, will not be added
            uniqueNumbers.Add(3);
            Console.WriteLine($"Number of unique numbers: {uniqueNumbers.Count}");
            foreach (int number in uniqueNumbers)
            {
                Console.WriteLine(number); // Output order is not guaranteed
            }
            //Stack<int> s=new Stack<int>();
            //Queue<int> q=new Queue<int>(); same as non generic collections



            Console.WriteLine("Non-Generic Collections");
            Console.WriteLine("---ArrayList---");
            ArrayList al = new ArrayList();//non-generic collection & dynamic size
            al.Add(10);
            al.Add("Kotha");
            al.Add("Dileep");
            al.Add(1228);
            al.Add(10.00);
            foreach (var v in al)//var is used because diff types are stored
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("---Stack(LIFO)---");
            Stack s=new Stack();
            s.Push(10);
            s.Push(20);
            s.Push(50);
            s.Push(60);
            Console.WriteLine("Stack Values are:");
            foreach(int sv in s)
            {
                Console.WriteLine(sv);
            }
            var r=s.Pop();
            Console.WriteLine("After Pop Operation:");
            foreach (int sv in s)
            {
                Console.WriteLine(sv);
            }
            Console.WriteLine($"removed element is :{r}");
            Console.WriteLine($"top element is :{s.Peek()}");


            Console.WriteLine("---Queue(FIFO)---");
            Queue q=new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(50);
            q.Enqueue(60);
            Console.WriteLine("Queue values are:");
            foreach (int qv in q)
            {
                Console.WriteLine(qv);
            }
            Console.WriteLine("After Dequeue:");
            q.Dequeue();
            foreach (int qv in q)
            {
                Console.WriteLine(qv);
            }
            Console.WriteLine($"last element is :{q.Peek()}");









        }
    }
}
