using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping.");
    }
}

// Derived class inheriting from the base class (Single Inheritance)
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an object of the derived class
        Dog myDog = new Dog();

        // Accessing methods from the base class
        myDog.Eat();
        myDog.Sleep();

        // Accessing method from the derived class
        myDog.Bark();
    }
}
