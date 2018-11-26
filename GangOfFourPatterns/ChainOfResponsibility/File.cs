namespace GangOfFourPatterns.ChainOfResponsibility
{
    public class File
    {
        public Type Type { get; private set; }

        public string Content { get; private set; }

        public File(Type type, string content)
        {
            Type = type;
            Content = content;
        }
    }
}
