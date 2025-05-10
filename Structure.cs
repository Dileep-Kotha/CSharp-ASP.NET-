using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    //struct student
    //{
    //    public int rno;
    //    public string name;
    //    public int age;
    //    public student(int rno,string name,int age)
    //    {
    //        this.rno = rno;
    //        this.name=name;
    //        this.age = age;
           
    //    }
    //    public void display()
    //    {
    //        Console.WriteLine($"rno is {rno} name is {name} age is {age}");
    //    }
    //}
    
     struct student{
        public int rno;
        public string name;
        public void show()
        {
        Console.WriteLine($" rno is {rno} name is {name}");
        }
    }
     
    internal class Program
    {
        static void Main(string[] args)
        {
            //student s = new student(28,"dileep",22);
            //s.display();
            //Another Method
            student s;
            s.rno = 28;
            s.name = "Dileep";
            s.show();
           
        }
    }
}
