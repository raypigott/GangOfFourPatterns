namespace GangOfFourPatterns.ChainOfResponsibility
{
    public interface IFileParser
    {
        string Parse(File file);
        void SetNextParser(IFileParser next);
    }
}