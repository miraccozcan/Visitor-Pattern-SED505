# Visitor Pattern

## Type
**Behavioral Design Pattern**

## Introduction
The Visitor pattern is a behavioral design pattern that allows you to define new operations on objects without changing the classes on which it operates. It separates the algorithm from the objects it works on by letting you place these new operations in a visitor object, which means that existing object structures can remain unchanged.

## Video Resources
- [Visitor Pattern Explained - Gui Ferreira](https://www.youtube.com/watch?v=yyKrt7zSmv0&ab_channel=GuiFerreira) (10 minutes)
- [Visitor Pattern - git-amend](https://www.youtube.com/watch?v=Q2gQs6gIzCM&ab_channel=git-amend) (10 minutes)

## Rationale
The main rationale behind the Visitor pattern is to allow for the extension of an object’s behavior without modifying the object itself. This is particularly useful when the object structure is stable, but new functionality needs to be added frequently. Instead of adding many new methods to these objects, which can clutter the class design, the Visitor pattern centralizes the logic in a separate visitor class. This keeps the object model clean and adheres to the open/closed principle, where objects are open for extension but closed for modification.

## UML Design

## Common Usage in the Software Industry
- **Stable Structures with New Operations**: The Visitor pattern is used when object structures remain stable, but new functionality needs to be added over time.
- **Compilers**: Nodes in a syntax tree are visited for operations like code generation and optimization.
- **Document Processing Systems**: Used to apply operations like exporting to different formats (e.g., PDF, DOCX).

