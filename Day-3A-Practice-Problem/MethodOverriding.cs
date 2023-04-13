using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3A_Practice_Problem
{
    public class MethodOverriding
    {
            public virtual void Speak()
            {
                Console.WriteLine("I am an animal.");
            }
        }

        public class Dog : MethodOverriding
        {
            public override void Speak()
            {
                Console.WriteLine("Woof!");
            }
        }

        public class Cat : MethodOverriding
        {
            public override void Speak()
            {
                Console.WriteLine("Meow!");
            }
        }
    }

