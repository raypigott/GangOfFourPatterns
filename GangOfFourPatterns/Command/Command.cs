using System;

namespace GangOfFourPatterns.Command
{
    public class CommandAction
    {
        public static Action<string> writeline = Console.WriteLine;

        public static Action<string> log = message => writeline("Logging: " + message);

        public static Action<string> save = message => writeline("Saving: " + message);

        public static Action<string> send = message => writeline("Sending: " + message);

        public static Action logHi = () => log("Hi");

        public static Action saveCheers = () => save("Cheers");

        public static Action sendBye = () => send("Bye");
    }
}
