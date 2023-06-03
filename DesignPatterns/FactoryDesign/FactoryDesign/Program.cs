using FactoryDesign;

ShapeFactory factory = new ShapeFactory();

var obj = factory.GetShape(Shapes.Circle);

Console.WriteLine($"Object created for :{obj.Draw()}");
Console.ReadLine();