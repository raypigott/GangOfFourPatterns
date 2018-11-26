namespace GangOfFourPatterns.Visitor
{
    public class Rectangle : Element
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public T accept<T>(Visitor<T> visitor)
        {
            return visitor.visit(this);
        }
    }
}