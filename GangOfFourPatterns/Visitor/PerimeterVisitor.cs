using System;

namespace GangOfFourPatterns.Visitor
{
    public class PerimeterVisitor : Visitor<double>
    {
        public double visit(Square element)
        {
            return 4 * element.Side;
        }

        public double visit(Circle element)
        {
            return 2 * Math.PI * element.Radius;
        }

        public double visit(Rectangle element)
        {
            return (2 * element.Height + 2 * element.Width);
        }
    }
}