using System;

namespace GangOfFourPatterns.ChainOfResponsibility
{
    public class VideoFileParser : AbstractFileParser
    {
        public override string Parse(File file)
        {
            if (file.Type == Type.Audio) return "Video file: " + file.Content;

            if (nextFileParser != null) return nextFileParser.Parse(file);

            throw new SystemException();
        }
    }
}