// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Square square = new Square(2);
Console.WriteLine(square);
square.SideLength = 10;
Console.WriteLine(square);
square.SayHello();

Console.WriteLine();
Rectangle rectangle = new Rectangle(2, 4);
Console.WriteLine(rectangle);
rectangle.SayHello();
Console.WriteLine();

Rectangle rectangleWithEqualSides = new Rectangle(2);
Console.WriteLine(rectangleWithEqualSides);
Console.WriteLine();

Circle circle = new Circle(5);
Console.WriteLine(circle);
circle.SayHello();