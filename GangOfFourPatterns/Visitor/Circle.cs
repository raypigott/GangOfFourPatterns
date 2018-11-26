namespace GangOfFourPatterns.Visitor
{
    public class Circle : Element
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public T accept<T>(Visitor<T> visitor)
        {
            return visitor.visit(this);
        }
    }
}