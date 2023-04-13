using System;
using System.Collections;
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
            bool flag = true;
            while (flag)
            {

                Console.WriteLine(" Plase enter the option");
                Console.WriteLine("Select Option 1");
                Console.WriteLine("Select Option 2");
                Console.WriteLine("Select Option 3");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        ClassNObject person1 = new ClassNObject(); // Creating object
                        ClassNObject person2 = new ClassNObject();

                        person1.Name = "Tanvi";
                        person1.Age = 22;

                        person2.Name = "Aarti";
                        person2.Age = 22;

                        person1.SayHello();
                        person2.SayHello();
                        Console.ReadLine();
                        break;

                    case 2:
                        Dog dog = new Dog();
                        dog.Eat();
                        dog.Bark();
                        Console.ReadLine();
                        break;

                    case 3:
                        MethodOverLoading obj = new MethodOverLoading();
                        obj.Add(10, 20);
                        obj.Add(10.5f, 20.5f);
                        obj.Add("Tanvi", "Shinde");
                        Console.ReadLine();
                        break;
                }
            }
            
        }
    }
}
