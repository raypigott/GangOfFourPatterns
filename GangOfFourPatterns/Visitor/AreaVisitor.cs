using System;

namespace GangOfFourPatterns.Visitor
{
    public class AreaVisitor : Visitor<double>
    {
        public double visit(Square element)
        {
            return element.Side * element.Side;
        }

        public double visit(Circle element)
        {
            return Math.PI * element.Radius * element.Radius;
        }

        public double visit(Rectangle element)
        {
            return element.Height * element.Width;
        }
    }
}