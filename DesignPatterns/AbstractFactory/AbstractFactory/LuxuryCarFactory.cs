using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class LuxuryCarFactory : ICarFactory
    {
        public ICar GetCar(Cars cars)
        {
            switch (cars)
            {
                case Cars.BMW:
                    return new Bmw();
                case Cars.Mercedes:
                    return new Mercedes();
                default:
                    return null;
            }
        }
    }
}
