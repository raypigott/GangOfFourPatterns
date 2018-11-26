using System;
using System.Collections.Generic;

namespace GangOfFourPatterns.Interpreter
{
    public class FunctionalExpressionInterpreter
    {
        public readonly Dictionary<string, Func<int, int, int>> operators = new Dictionary<string, Func<int, int, int>>();

        public FunctionalExpressionInterpreter()
        {
            operators.Add("+", (a, b) => a + b);
            operators.Add("-", (a, b) => a - b);
            operators.Add("*", (a, b) => a * b);
        }

        public int Evaluate(string expression)
        {
            var stack = new Stack<int>();
            foreach (var value in expression.Split(' '))
            {
                var op = GetOperator(value);
                if (op != null)
                {
                    var right = stack.Pop();
                    var left = stack.Pop();
                    stack.Push(op(left, right));
                }
                else
                {
                    stack.Push(Convert.ToInt32(value));
                }
            }
            return stack.Pop();
        }

        private Func<int, int, int> GetOperator(string key)
        {
            Func<int, int, int> func;
            operators.TryGetValue(key, out func);
            return func;
        }
    }
}
