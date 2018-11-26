using System;

namespace GangOfFourPatterns.ChainOfResponsibility
{
    public class TextFileParser : AbstractFileParser
    {
        public override string Parse(File file)
        {
            if (file.Type == Type.Text) return "Text file: " + file.Content;

            if (nextFileParser != null) return nextFileParser.Parse(file);

            throw new SystemException();
        }
    }
}