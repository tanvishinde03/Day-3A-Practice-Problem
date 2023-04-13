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

                Console.WriteLine("\n Plase enter the option");
                Console.WriteLine("Select Option 1");
                Console.WriteLine("Select Option 2");
                Console.WriteLine("Select Option 3");
                Console.WriteLine("Select Option 4");
                Console.WriteLine("Select Option 5");
                Console.WriteLine("Select Option 6");
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
                        Pug pug = new Pug();
                        pug.Eat();
                       pug.Bark();
                        Console.ReadLine();
                        break;

                    case 3:
                        MethodOverLoading obj = new MethodOverLoading();
                        obj.Add(10, 20);
                        obj.Add(10.5f, 20.5f);
                        obj.Add("Tanvi", "Shinde");
                        Console.ReadLine();
                        break;
                    case 4:
                        MethodOverriding animal1 = new MethodOverriding();
                        MethodOverriding animal2 = new Dog();
                        MethodOverriding animal3 = new Cat();
                        animal1.Speak();
                        animal2.Speak();
                        animal3.Speak();
                        Console.ReadLine();
                        break;

                    case 5:
                        BankAccount account = new BankAccount("12345", 1000);
                        account.Deposit(500);
                        account.Withdraw(2000);
                        account.Withdraw(1000);
                        account.DisplayBalance();
                        break;

                        case 6:
                        int a = 10;  // value type
                        int b = a;   // value type
                        a = 20;
                        Console.WriteLine($"a = {a}, b = {b}");
                        ValueTypeAndReferenceType p1 = new ValueTypeAndReferenceType { X = 10, Y = 20 };  // value type
                        ValueTypeAndReferenceType p2 = p1;                           // value type
                        p1.X = 30;
                        Console.WriteLine($"p1.X = {p1.X}, p2.X = {p2.X}");
                        Person person = new Person { Name = "John", Age = 30 };  // reference type
                        Person personobj = person;                               // reference type
                        person.Age = 40;
                        Console.WriteLine($"person1.Age = {person.Age}, person2.Age = {personobj.Age}");
                        Console.ReadLine();
                        break;
                }
            }
            }
            
        }
    }

