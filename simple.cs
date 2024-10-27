using System;
using System.Collections.Generic;

public interface IVisitor
{
    void Visit(Book book);
    void Visit(Fruit fruit);
}

public class PriceVisitor : IVisitor
{
    public void Visit(Book book)
    {
        Console.WriteLine($"Book price: {book.Price * 0.9} (10% discount)");
    }

    public void Visit(Fruit fruit)
    {
        Console.WriteLine($"Fruit price: {fruit.Price * 0.95} (5% discount)");
    }
}

public interface IElement
{
    void Accept(IVisitor visitor);
}

public class Book : IElement
{
    public double Price { get; set; }

    public Book(double price)
    {
        Price = price;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class Fruit : IElement
{
    public double Price { get; set; }

    public Fruit(double price)
    {
        Price = price;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class ShoppingCart
{
    private List<IElement> elements = new List<IElement>();

    public void AddElement(IElement element)
    {
        elements.Add(element);
    }

    public void ApplyVisitor(IVisitor visitor)
    {
        foreach (var element in elements)
        {
            element.Accept(visitor);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var cart = new ShoppingCart();
        cart.AddElement(new Book(30));
        cart.AddElement(new Fruit(15));

        var priceVisitor = new PriceVisitor();
        cart.ApplyVisitor(priceVisitor);
    }
}
