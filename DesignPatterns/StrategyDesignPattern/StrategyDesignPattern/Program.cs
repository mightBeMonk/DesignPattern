// See https://aka.ms/new-console-template for more information

Vehicle vehicle = new SportyVehicle();
var drive = vehicle.Drive();
Console.WriteLine(drive);
Console.ReadLine();


interface IDriveStrategy
{
    string Drive();
}

class NormalDrive : IDriveStrategy
{
    public string Drive()
    {
        return $"Normal Drive";
    }
}

class SpecialDrive : IDriveStrategy
{
    public string Drive()
    {
        return $"Special Drive";
    }
}

class Vehicle
{
    private readonly IDriveStrategy _driveStrategy;
    public Vehicle(IDriveStrategy driveStrategy)
    {
        _driveStrategy = driveStrategy;
    }
    public string Drive()
    {
        return _driveStrategy.Drive();
    }
}

class SportyVehicle : Vehicle
{
    public SportyVehicle() : base(new SpecialDrive())
    {
    }
}

class NormalVehicle : Vehicle
{
    public NormalVehicle() : base(new NormalDrive())
    {
    }
}