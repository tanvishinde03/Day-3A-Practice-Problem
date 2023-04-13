using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3A_Practice_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassNObject person1 = new ClassNObject(); // Creating object
           ClassNObject  person2 = new ClassNObject();

            person1.Name = "Tanvi";
            person1.Age = 22;

            person2.Name = "Aarti";
            person2.Age = 22;

            person1.SayHello();
            person2.SayHello();
            Console.ReadLine();
        }
    }
}
