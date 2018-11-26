namespace GangOfFourPatterns.Visitor
{
    public interface Visitor<out T>
    {
        T visit(Square element);
        T visit(Circle element);
        T visit(Rectangle element);
    }
}