using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CarFactory
    {
        public ICarFactory GetCarFactory(Car car)
        {
            switch (car)
            {
                case Car.Luxury:
                    return new LuxuryCarFactory();
                case Car.Ordinary:
                    return new OrdinaryCarFactory();
                default:
                    return null;
            }
        }
    }
    public enum Car
    {
        Luxury,
        Ordinary
    }
}
