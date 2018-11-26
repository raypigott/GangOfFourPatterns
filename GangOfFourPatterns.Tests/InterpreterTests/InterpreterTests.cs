using FluentAssertions;
using GangOfFourPatterns.Interpreter;
using NUnit.Framework;

namespace GangOfFourPatterns.Tests.InterpreterTests
{
    [TestFixture]
    public class InterpreterTests
    {
        [Test]
        public void Evaluate_GivenAnExpression_ShouldBeCorrect()
        {
            var interpreter = new ExpressionInterpreter();
            interpreter.Evaluate("7 3 - 2 1 + *").Should().Be(12);
        }

        [Test]
        public void FunctionalInterpreter_GivenAnExpression_ShouldBeCorrect()
        {
            var interpreter = new FunctionalExpressionInterpreter();
            interpreter.Evaluate("7 3 - 2 1 + *").Should().Be(12);
        }
    }
}
