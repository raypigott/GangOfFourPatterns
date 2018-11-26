namespace GangOfFourPatterns.Interpreter
{
    public class Add : IExpression
    {
        private readonly IExpression left;
        private readonly IExpression right;

        public Add(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public int Interpret()
        {
            return left.Interpret() + right.Interpret();
        }
    }
}