using System;

// Visitor Interface
public interface IAnimalVisitor
{
    void Visit(Dog dog);
    void Visit(Cat cat);
}

// Concrete Visitor
public class SoundVisitor : IAnimalVisitor
{
    public void Visit(Dog dog)
    {
        Console.WriteLine("Dog says: Woof!");
    }

    public void Visit(Cat cat)
    {
        Console.WriteLine("Cat says: Meow!");
    }
}

// Element Interface
public interface IAnimal
{
    void Accept(IAnimalVisitor visitor);
}

// Concrete Elements
public class Dog : IAnimal
{
    public void Accept(IAnimalVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class Cat : IAnimal
{
    public void Accept(IAnimalVisitor visitor)
    {
        visitor.Visit(this);
    }
}

// Client Code
class Program
{
    static void Main(string[] args)
    {
        IAnimal dog = new Dog();
        IAnimal cat = new Cat();
        IAnimalVisitor soundVisitor = new SoundVisitor();

        dog.Accept(soundVisitor); // Output: Dog says: Woof!
        cat.Accept(soundVisitor); // Output: Cat says: Meow!
    }
}
