namespace GangOfFourPatterns.Interpreter
{
    public class Number : IExpression
    {
        private readonly int n;

        public Number(int n)
        {
            this.n = n;
        }

        public int Interpret()
        {
            return n;
        }
    }
}