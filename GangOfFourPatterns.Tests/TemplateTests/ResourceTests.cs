using System;
using GangOfFourPatterns.Template;
using NUnit.Framework;

namespace GangOfFourPatterns.Tests.TemplateTests
{
    [TestFixture]
    public class ResourceTests
    {
        [Test]
        public void RunResourceDisplaysToTheConsoleAndWillOccasionallyFail()
        {
            ResourceHandler.WithResource(resource => resource.UseResource(), Console.WriteLine);

            ResourceHandler.WithResource(resource => resource.EmployResource(), Console.WriteLine);
        }
    }
}