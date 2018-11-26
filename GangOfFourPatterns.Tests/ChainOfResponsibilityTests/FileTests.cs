using FluentAssertions;
using GangOfFourPatterns.ChainOfResponsibility;
using NUnit.Framework;

namespace GangOfFourPatterns.Tests.ChainOfResponsibilityTests
{
    [TestFixture]
    public class FileTests
    {
        [Test]
        public void TraditionalAudio_Should_BeFound ()
        {
            IFileParser textParser = new TextFileParser();
            IFileParser audioParser = new AudioFileParser();
            IFileParser videoParser = new VideoFileParser();

            textParser.SetNextParser(audioParser);
            audioParser.SetNextParser(videoParser);

            File file = new File(Type.Audio, "Dream Theater - The Astonishing");
            string result = textParser.Parse(file);

            result.Should().Be("Audio file: Dream Theater - The Astonishing");
        }

        [Test]
        public void Audio_Should_BeFound()
        {
            var file = new File(Type.Audio, "Dream Theater - The Astonishing");
            var result = FunctionalParser.Parse(file, FunctionalParser.ParseText, FunctionalParser.ParseAudio, FunctionalParser.ParseVideo);

            result.Should().Be("Audio file: Dream Theater - The Astonishing");
        }

        [Test]
        public void Text_Should_BeFound()
        {
            var file = new File(Type.Text, "This is a text file");
            var result = FunctionalParser.Parse(file, FunctionalParser.ParseText, FunctionalParser.ParseAudio, FunctionalParser.ParseVideo);

            result.Should().Be("Text file: This is a text file");
        }

        [Test]
        public void Video_Should_BeFound()
        {
            var file = new File(Type.Video, "Star Wars - A New Hope");
            var result = FunctionalParser.Parse(file, FunctionalParser.ParseText, FunctionalParser.ParseAudio, FunctionalParser.ParseVideo);

            result.Should().Be("Video file: Star Wars - A New Hope");
        }
    }
}