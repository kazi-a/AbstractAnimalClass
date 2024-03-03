using System;

abstract class Animal
{
    // Property
    public abstract string Name { get; set; }

    // Additional properties
    public abstract string Color { get; set; }
    public abstract int Age { get; set; }

    // Methods
    public abstract string Describe();
    public string whatAmI()
    {
        return "I am an animal";
    }

    // Constructors
    public Animal() { }

    public Animal(string name, string color, int age)
    {
        Name = name;
        Color = color;
        Age = age;
    }
}

class Cat : Animal
{
    // Properties
    public override string Name { get; set; }
    public override string Color { get; set; }
    public override int Age { get; set; }

    // Constructor
    public Cat() : base() { }

    public Cat(string name, string color, int age) : base(name, color, age) { }

    // Method Override
    public override string Describe()
    {
        return $"I am a {Color} cat named {Name} and I am {Age} years old.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object using the default constructor
        Animal animal1 = new Cat();
        Console.WriteLine(animal1.Describe());
        Console.WriteLine(animal1.whatAmI());

        Console.WriteLine();

        // Create an object using the parameterized constructor
        Animal animal2 = new Cat("Whiskers", "Gray", 5);
        Console.WriteLine(animal2.Describe());
        Console.WriteLine(animal2.whatAmI());
    }
}
