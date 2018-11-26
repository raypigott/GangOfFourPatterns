using FluentAssertions;
using GangOfFourPatterns.Strategy;
using NUnit.Framework;

namespace GangOfFourPatterns.Tests.StrategyTests
{
    [TestFixture]
    public class StrategyTests
    {
        [Test]
        public void PublishText_WithNoFormatting()
        {
            var response = TextEditor.PublishText("DEBUG - I'm here", TextUtil.AcceptAll, TextUtil.NoFormatting);
            response.Should().Be("DEBUG - I'm here");
        }

        [Test]
        public void PublishText_WithFormattingError()
        {
            var response = TextEditor.PublishText("ERROR - something bad happened", TextUtil.AcceptErrors, TextUtil.FormatError);
            response.Should().Be("ERROR - SOMETHING BAD HAPPENED");
        }

        [Test]
        public void PublishText_ToLowerCase()
        {
            var response = TextEditor.PublishText("DEBUG - I'm here", TextUtil.UnderTwenty, TextUtil.ToLowerCase);
            response.Should().Be("debug - i'm here");
        }
    }
}