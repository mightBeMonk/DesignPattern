using AbstractFactory;

CarFactory carFactory = new CarFactory();
var carName1 = carFactory.GetCarFactory(Car.Ordinary).GetCar(Cars.Baleno).Name();
var carName2 = carFactory.GetCarFactory(Car.Luxury).GetCar(Cars.Mercedes).Name();

Console.WriteLine(carName1);
Console.WriteLine(carName2);

Console.ReadLine();
