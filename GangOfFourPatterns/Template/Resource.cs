using System;

namespace GangOfFourPatterns.Template
{
    /// <summary>
    /// https://www.voxxed.com/2016/05/gang-four-patterns-functional-light-part-2/
    /// </summary>
    public class Resource
    {
        private readonly Action<string> writeline;

        public Resource(Action<string> writeline)
        {
            this.writeline = writeline;
            writeline("Resource created");
        }

        public void UseResource()
        {
            RiskyOperation();
            writeline("Resource used");
        }

        public void EmployResource()
        {
            RiskyOperation();
            writeline("Resource employeed");
        }

        public void Dispose()
        {
            writeline("Resource disposed");
        }

        private static void RiskyOperation()
        {
            if (new Random().Next(10) == 0)
            {
                throw new SystemException();
            }
        }
    }
}
