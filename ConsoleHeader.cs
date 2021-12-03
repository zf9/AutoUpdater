using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoUpdate
{
    internal class ConsoleHeader
    {
        public static void C_Exit()
        {
            Environment.Exit(69);
        }

        public static void C_Sleep5()
        {
            Thread.Sleep(5000);
        }

        public static void C_Color()
        {

            Random random = new Random();
            int value = random.Next(1, 5);
            if (value == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            else if (value == 2)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (value == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (value == 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            else if (value == 5)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            UpdateCheck.version();

        }

    }
}
