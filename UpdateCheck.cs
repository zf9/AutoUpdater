using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoUpdate
{
    internal class UpdateCheck
    {
        public static void version()
        {
            string html = string.Empty;
            string url = "https://pastebin.com/raw/5LpE3tJ1";
            string C_Version = "1.0";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36";
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            if (html == C_Version)
            {
                LatestVersion.MainStart();
            }
            else
            {
                UpdateLoader.Update();
                ConsoleHeader.C_Sleep5();
                ConsoleHeader.C_Exit();
            }
        }
    }
}
