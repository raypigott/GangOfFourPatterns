using System;

namespace GangOfFourPatterns.Template
{
    public class ResourceHandler
    {
        public static void WithResource(Action<Resource> consumer, Action<string> writeline)
        {
            var resource = new Resource(writeline);

            try
            {
                consumer(resource);
            }
            finally
            {
                resource.Dispose();
            }
        }
    }
}