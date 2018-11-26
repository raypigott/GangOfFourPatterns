using FluentAssertions;
using NUnit.Framework;

namespace GangOfFourPatterns.Tests
{
    [TestFixture]
    public class ClownTests
    {
        [Test]
        public void TEST()
        {
            Clown.shout("send in the clowns").Should().Be("SEND IN THE CLOWNS!");
        }
    }
}
