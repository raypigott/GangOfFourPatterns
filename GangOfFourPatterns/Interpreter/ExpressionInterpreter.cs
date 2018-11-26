using System;
using System.Collections.Generic;

namespace GangOfFourPatterns.Interpreter
{
    public class ExpressionInterpreter
    {
        public bool IsOperator(string value)
        {
            return value.Equals("+") || value.Equals("-") || value.Equals("*");
        }

        public IExpression GetOperator(string value, IExpression left, IExpression right)
        {
            switch (value)
            {
                case "+":
                    return new Add(left, right);
                case "-":
                    return new Subtract(left, right);
                case "*":
                    return new Multiply(left, right);
            }

            throw new SystemException();
        }

        public int Evaluate(string expression)
        {
            var stack = new Stack<IExpression>();
            foreach (var value in expression.Split(' '))
            {
                if (IsOperator(value))
                {
                    var right = stack.Pop();
                    var left = stack.Pop();
                    stack.Push(GetOperator(value, left, right));
                }
                else
                {
                    var i = new Number(Convert.ToInt32(value));
                    stack.Push(i);
                }
            }
            return stack.Pop().Interpret();
        }
    }
}