namespace GangOfFourPatterns.Visitor
{
    public interface Element
    {
        T accept<T>(Visitor<T> visitor);
    }
}
