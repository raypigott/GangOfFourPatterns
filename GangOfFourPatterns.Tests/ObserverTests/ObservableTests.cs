using System;
using GangOfFourPatterns.Observer;
using NUnit.Framework;

namespace GangOfFourPatterns.Tests.ObserverTests
{
    [TestFixture]
    public class ObservableTests
    {
        [Test]
        public void DisplaysThreeEventsToTheConsole()
        {
            var observable = new Observable();
            observable.Register("1", Console.WriteLine);
            observable.Register("2", Console.WriteLine);
            observable.SendEvent("Hello World!");

            observable.Unregister("1");
            observable.SendEvent("Hello World - Is there anyone out there?");
        }
    }
}
