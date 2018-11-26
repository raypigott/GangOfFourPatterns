namespace GangOfFourPatterns.Visitor
{
    public class Square : Element
    {
        public double Side { get; }

        public Square(double side)
        {
            Side = side;
        }

        public T accept<T>(Visitor<T> visitor)
        {
            return visitor.visit(this);
        }
    }
}