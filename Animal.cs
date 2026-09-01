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

        class Lion : Animal
        {
            public Lion(string name) : base(name) { }
            public override void MakeSound()
            {
                Console.WriteLine($"{Name} says: Roar!");
            }
        }

        class Elephant : Animal
        {
            public Elephant(string name) : base(name) { }
            public override void MakeSound()
            {
                Console.WriteLine($"{Name} says: Trumpet!");
            }
        }

        class Parrot : Animal
        {
            public Parrot(string name) : base(name) { }
            public override void MakeSound()
            {
                Console.WriteLine($"{Name} says: Squawk!");
            }
        }
    }
}