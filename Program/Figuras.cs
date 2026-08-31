using DemoOpenClosePrinciple;

AreaCalculator calculator = new AreaCalculator();

Circle circle1 = new Circle();
circle1.Radius = 2;

Circle circle2 = new Circle();
circle2.Radius = 3;

Circle circle3 = new Circle();
circle3.Radius = 4;


Square square1 = new Square();
square1.Size = 5;

Square square2 = new Square();
square2.Size = 4;

Square square3 = new Square();
square3.Size = 7;

Triangulo triangulo1 = new Triangulo();
triangulo1.Base = 5;
triangulo1.Altura = 2;

Triangulo triangulo2 = new Triangulo();
triangulo2.Base = 4;
triangulo2.Altura = 3;

Triangulo triangulo3= new Triangulo();
triangulo3.Base = 8;
triangulo3.Altura = 8;

Rectangulo rectangulo1 = new Rectangulo();
rectangulo1.Base = 9;
rectangulo1.Altura = 4;

Rectangulo rectangulo2 = new Rectangulo();
rectangulo2.Base = 5;
rectangulo2.Altura = 3;

Rectangulo rectangulo3 = new Rectangulo();
rectangulo3.Base = 6;
rectangulo3.Altura = 6;

Trapecio trapecio1 = new Trapecio();
trapecio1.Base = 7; 
trapecio1.Altura = 3;

Trapecio trapecio2 = new Trapecio();
trapecio2.Base = 8;
trapecio2.Altura = 4;

Trapecio trapecio3 = new Trapecio();
trapecio3.Base = 5;
trapecio3.Altura = 3;





List<Shape> shapes = new List<Shape>();
shapes.Add(circle1);
shapes.Add(circle2);
shapes.Add(circle3);
shapes.Add(square1);
shapes.Add(square2);
shapes.Add(square3);
shapes.Add(triangulo1);
shapes.Add(triangulo2);
shapes.Add(triangulo3);
shapes.Add(rectangulo1);
shapes.Add(rectangulo2);
shapes.Add(rectangulo3);
shapes.Add(trapecio1);
shapes.Add(trapecio2);
shapes.Add(trapecio3);



var resultTotalArea = calculator.TotalArea(shapes);

Console.WriteLine($"El área total es {resultTotalArea}");
