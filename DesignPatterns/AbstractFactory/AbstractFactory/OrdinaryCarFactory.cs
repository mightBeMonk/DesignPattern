using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class OrdinaryCarFactory : ICarFactory
    {
        public ICar GetCar(Cars cars)
        {
            switch (cars)
            {
                case Cars.Swift:
                    return new Swift();
                case Cars.Baleno:
                    return new Baleno();
                default:
                    return null;
            }
        }
    }
}
