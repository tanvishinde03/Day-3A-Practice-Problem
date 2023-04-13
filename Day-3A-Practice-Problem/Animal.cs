using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day_3A_Practice_Problem
{
    public class Animal
    {
        // Class member (field)
        public string Name;

        // Class method
        public void Eat()
        {
            Console.WriteLine(Name + " is eating.");
        }
    }

    // Define a derived class called "Dog" that inherits from "Animal"
    class Pug : Animal
    {
        // Class method
        public void Bark()
        {
            Console.WriteLine(Name + " is barking.");
        }
    }
}

