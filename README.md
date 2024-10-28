# Visitor Pattern

## Type
**Behavioral Design Pattern**

## Introduction
The Visitor Pattern is a behavioral design pattern that enables you to add further operations to objects without altering their structure. It achieves this by separating the operations (behavior) from the object structure on which they operate. This pattern is particularly useful when you have a stable set of classes and want to define new functionalities independently, adhering to the Open/Closed Principle – classes should be open for extension but closed for modification. By leveraging the Visitor pattern, developers can add new operations to an object structure without modifying the classes involved, thus maintaining system stability and reducing code coupling.

## Key Concepts:
1. Double Dispatch:
The Visitor Pattern relies on double dispatch, allowing the operation to be selected based on both the visitor type and the element type being visited. This ensures the correct operation is applied to each element, despite them being of different types.

2. Decoupling Operations from Object Structure:
By decoupling the operations, the Visitor Pattern centralizes related behaviors in one place, preventing the need for object structure changes every time new functionality is introduced.
## Video Resources
- [Visitor Pattern Explained - Gui Ferreira](https://www.youtube.com/watch?v=yyKrt7zSmv0&ab_channel=GuiFerreira)
- [Visitor Pattern - git-amend](https://www.youtube.com/watch?v=Q2gQs6gIzCM&ab_channel=git-amend)

## Rationale
The Visitor Pattern allows for new functionality to be added to an object structure without altering the structure itself. This is especially beneficial when the object structure is stable but new functionality is frequently added. For example, in a software system with many types of documents, the Visitor Pattern can be used to perform operations like exporting to PDF, DOCX, or CSV formats. By encapsulating each operation within a visitor, the pattern:

Reduces Coupling: The Visitor Pattern centralizes operations, making it easier to maintain and update the functionality independently of the object structure.
Enhances Extensibility: New operations can be introduced without modifying the objects they operate on, keeping the original classes clean and focused on their core functionality.
Adheres to SOLID Principles: The Visitor Pattern follows the Single Responsibility Principle (by separating operations) and Open/Closed Principle (by allowing extension without modification).


## UML Diagram
This diagram demonstrates how the Visitor Design Pattern works by separating the behavior (operations) from the objects themselves. It allows you to define new operations on a set of elements without modifying the elements' classes. Instead, you introduce new visitors that contain the behavior.

### Components:
![Visitor Design Pattern UML](images/uml.png)
- **Visitor Interface**:
    - Declares methods: `visit(Book book)` and `visit(Fruit fruit)`.
    - Defines abstract actions on different element types without modifying their structure.

- **ConcreteVisitor**:
    - Implements `visit(Book book)` and `visit(Fruit fruit)` from the Visitor interface.
    - Contains the actual operations performed on `Book` and `Fruit` objects.

- **Element Interface**:
    - Defines the `accept(Visitor visitor)` method.
    - Allows elements to accept a visitor and enable double-dispatch.

- **Concrete Elements (Book and Fruit)**:
    - Implement the `accept(Visitor visitor)` method.
    - When `accept()` is called, the appropriate `visit` method is invoked on the visitor.

- **ObjectStructure Class**:
    - Manages a collection of elements (`List<Element>`).
    - Iterates over elements and applies the visitor using the `accept()` method.

## Simple Code Example Output (simple.cs)
```Dog says: Woof! Cat says: Meow!```

## Common Usage in the Software Industry
- **Stable Structures with New Operations**: The Visitor pattern is used when object structures remain stable, but new functionality needs to be added over time.
- **Compilers**: Nodes in a syntax tree are visited for operations like code generation and optimization.
- **Document Processing Systems**: Used to apply operations like exporting to different formats (e.g., PDF, DOCX).

## Main Code (main.cs) Output
```Book price: 27.0 (10% discount) Fruit price: 14.25 (5% discount)```


