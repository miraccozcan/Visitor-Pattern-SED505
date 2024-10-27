using System;
using System.Collections.Generic;

// Visitor Interface
public interface IVisitor
{
    void Visit(Book book);
    void Visit(Fruit fruit);
}

// Concrete Visitor
public class DiscountVisitor : IVisitor
{
    public void Visit(Book book)
    {
        double discount = book.Price * 0.10; // 10% discount
        Console.WriteLine($"Book price: {book.Price - discount} (10% discount)");
    }

    public void Visit(Fruit fruit)
    {
        double discount = fruit.Price * 0.05; // 5% discount
        Console.WriteLine($"Fruit price: {fruit.Price - discount} (5% discount)");
    }
}

// Element Interface
public interface IElement
{
    void Accept(IVisitor visitor);
}

// Concrete Elements
public class Book : IElement
{
    public double Price { get; set; }
    public string Title { get; set; }

    public Book(double price, string title)
    {
        Price = price;
        Title = title;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class Fruit : IElement
{
    public double Price { get; set; }
    public string Name { get; set; }

    public Fruit(double price, string name)
    {
        Price = price;
        Name = name;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

// ObjectStructure Class
public class ObjectStructure
{
    private List<IElement> _elements = new List<IElement>();

    public void AddElement(IElement element)
    {
        _elements.Add(element);
    }

    public void ApplyVisitor(IVisitor visitor)
    {
        foreach (var element in _elements)
        {
            element.Accept(visitor);
        }
    }
}

// Client Code
class Program
{
    static void Main(string[] args)
    {
        // Create elements
        var book = new Book(30.0, "C# Programming");
        var fruit = new Fruit(15.0, "Apple");

        // Create visitor
        var discountVisitor = new DiscountVisitor();

        // Create object structure
        var objectStructure = new ObjectStructure();
        objectStructure.AddElement(book);
        objectStructure.AddElement(fruit);

        // Apply visitor to elements
        objectStructure.ApplyVisitor(discountVisitor);
    }
}
