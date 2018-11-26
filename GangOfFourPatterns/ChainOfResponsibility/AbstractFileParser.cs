namespace GangOfFourPatterns.ChainOfResponsibility
{
    public abstract class AbstractFileParser : IFileParser
    {
        protected IFileParser nextFileParser;

        public abstract string Parse(File file);

        public void SetNextParser(IFileParser next)
        {
            nextFileParser = next;
        }
    }
}