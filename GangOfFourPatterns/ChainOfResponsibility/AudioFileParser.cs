using System;

namespace GangOfFourPatterns.ChainOfResponsibility
{
    public class AudioFileParser : AbstractFileParser
    {
        public override string Parse(File file)
        {
            if (file.Type == Type.Audio) return "Audio file: " + file.Content;

            if (nextFileParser != null) return nextFileParser.Parse(file);

            throw new SystemException();
        }
    }
}