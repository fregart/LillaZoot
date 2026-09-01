using System;
using System.Collections.Generic;
using System.Text;

namespace LillaZoot
{
    abstract class Animal
    {
        public string Name { get; set; }

        // Constructor
        public Animal(string name)
        {
            Name = name;      
        }

        // Abstract method
        public abstract void MakeSound();

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

    }
}
