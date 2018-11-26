using System.Threading.Tasks;
using GangOfFourPatterns.Command;
using NUnit.Framework;

namespace GangOfFourPatterns.Tests.CommandTests
{
    [TestFixture]
    class CommandTests
    {
        [Test]
        public void DisplaysTheCommandsToTheConsole()
        {
            Parallel.Invoke(CommandAction.logHi, CommandAction.saveCheers, CommandAction.sendBye);
        }
    }
}