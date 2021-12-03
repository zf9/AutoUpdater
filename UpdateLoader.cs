using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdate
{
    internal class UpdateLoader
    {
        public static void Update()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            using (var client = new WebClient())
            {
                Console.WriteLine("\n   Downloading New Loader!");
                client.DownloadFile("http://zf9.one/U/SampleLoader.exe", $@"C:\Users\{Environment.UserName}\Desktop\UpdatedLoader.exe");
                Console.WriteLine("\n   Staring New Loader!");
                Process.Start($@"C:\Users\{Environment.UserName}\Desktop\UpdatedLoader.exe");
                ConsoleHeader.C_Sleep5();
                ConsoleHeader.C_Exit();
            }
        }
    }
}
