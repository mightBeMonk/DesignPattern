using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    public class Circle : IShape
    {
        public string Draw()
        {
            return "Circle";
        }
    }
}
