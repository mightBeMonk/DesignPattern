using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    public class ShapeFactory
    {
        public IShape GetShape(Shapes shape)
        {
            switch (shape)
            {
                case Shapes.Circle:
                    return new Circle();
                case Shapes.Rectangle:
                    return new Rectangle();
                default:
                    return null;
            }
        }
    }
    public enum Shapes
    {
        Circle,
        Rectangle
    }
}
