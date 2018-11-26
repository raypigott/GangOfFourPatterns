namespace GangOfFourPatterns.Interpreter
{
    public class Multiply : IExpression
    {
        private readonly IExpression left;
        private readonly IExpression right;

        public Multiply(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public int Interpret()
        {
            return left.Interpret() * right.Interpret();
        }
    }
}