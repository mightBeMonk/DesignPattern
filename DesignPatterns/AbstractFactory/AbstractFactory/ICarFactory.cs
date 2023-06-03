namespace AbstractFactory
{
    public interface ICarFactory
    {
        ICar GetCar(Cars cars);
    }
}