using System.Drawing;
using Console = Colorful.Console;

namespace _0xDocWorker
{
    class Utils
    {
        public static void PrintLogo()
        {
            const string line = " ▒█████  ▒██   ██▒▓█████▄  ▒█████   ▄████▄   █     █░ ▒█████   ██▀███   ██ ▄█▀▓█████  ██▀███  \r\n" +
                                "▒██▒  ██▒▒▒ █ █ ▒░▒██▀ ██▌▒██▒  ██▒▒██▀ ▀█  ▓█░ █ ░█░▒██▒  ██▒▓██ ▒ ██▒ ██▄█▒ ▓█   ▀ ▓██ ▒ ██▒\r\n" +
                                "▒██░  ██▒░░  █   ░░██   █▌▒██░  ██▒▒▓█    ▄ ▒█░ █ ░█ ▒██░  ██▒▓██ ░▄█ ▒▓███▄░ ▒███   ▓██ ░▄█ ▒\r\n" +
                                "▒██   ██░ ░ █ █ ▒ ░▓█▄   ▌▒██   ██░▒▓▓▄ ▄██▒░█░ █ ░█ ▒██   ██░▒██▀▀█▄  ▓██ █▄ ▒▓█  ▄ ▒██▀▀█▄  \r\n" +
                                "░ ████▓▒░▒██▒ ▒██▒░▒████▓ ░ ████▓▒░▒ ▓███▀ ░░░██▒██▓ ░ ████▓▒░░██▓ ▒██▒▒██▒ █▄░▒████▒░██▓ ▒██▒\r\n" +
                                "░ ▒░▒░▒░ ▒▒ ░ ░▓ ░ ▒▒▓  ▒ ░ ▒░▒░▒░ ░ ░▒ ▒  ░░ ▓░▒ ▒  ░ ▒░▒░▒░ ░ ▒▓ ░▒▓░▒ ▒▒ ▓▒░░ ▒░ ░░ ▒▓ ░▒▓░\r\n" +
                                "  ░ ▒ ▒░ ░░   ░▒ ░ ░ ▒  ▒   ░ ▒ ▒░   ░  ▒     ▒ ░ ░    ░ ▒ ▒░   ░▒ ░ ▒░░ ░▒ ▒░ ░ ░  ░  ░▒ ░ ▒░\r\n" +
                                "░ ░ ░ ▒   ░    ░   ░ ░  ░ ░ ░ ░ ▒  ░          ░   ░  ░ ░ ░ ▒    ░░   ░ ░ ░░ ░    ░     ░░   ░ \r\n" +
                                "    ░ ░   ░    ░     ░        ░ ░  ░ ░          ░        ░ ░     ░     ░  ░      ░  ░   ░     \r\n" +
                                "                   ░               ░                                                          ";

            Console.WriteWithGradient(line, Color.Yellow, Color.Fuchsia, 14);
        }

        public static void Exit()
        {
            Console.Clear();
            const string line = "  ▄████  ▒█████   ▒█████  ▓█████▄  ▄▄▄▄ ▓██   ██▓▓█████  ▐██▌ \r\n" +
                                " ██▒ ▀█▒▒██▒  ██▒▒██▒  ██▒▒██▀ ██▌▓█████▄▒██  ██▒▓█   ▀  ▐██▌ \r\n" +
                                "▒██░▄▄▄░▒██░  ██▒▒██░  ██▒░██   █▌▒██▒ ▄██▒██ ██░▒███    ▐██▌ \r\n" +
                                "░▓█  ██▓▒██   ██░▒██   ██░░▓█▄   ▌▒██░█▀  ░ ▐██▓░▒▓█  ▄  ▓██▒ \r\n" +
                                "░▒▓███▀▒░ ████▓▒░░ ████▓▒░░▒████▓ ░▓█  ▀█▓░ ██▒▓░░▒████▒ ▒▄▄  \r\n" +
                                " ░▒   ▒ ░ ▒░▒░▒░ ░ ▒░▒░▒░  ▒▒▓  ▒ ░▒▓███▀▒ ██▒▒▒ ░░ ▒░ ░ ░▀▀▒ \r\n" +
                                "  ░   ░   ░ ▒ ▒░   ░ ▒ ▒░  ░ ▒  ▒ ▒░▒   ░▓██ ░▒░  ░ ░  ░ ░  ░ \r\n" +
                                "░ ░   ░ ░ ░ ░ ▒  ░ ░ ░ ▒   ░ ░  ░  ░    ░▒ ▒ ░░     ░       ░ \r\n" +
                                "      ░     ░ ░      ░ ░     ░     ░     ░ ░        ░  ░ ░    \r\n" +
                                "                           ░            ░░ ░                  ";

            Console.WriteWithGradient(line, Color.Fuchsia, Color.Yellow, 14);
            Environment.Exit(0);
        }

        public static IEnumerable<string> FindAllFiles(string path)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(path);
            while (queue.Count > 0)
            {
                path = queue.Dequeue();
                try
                {
                    foreach (string subDir in Directory.GetDirectories(path))
                    {
                        queue.Enqueue(subDir);
                    }
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
                string[] files = null;
                try
                {
                    files = Directory.GetFiles(path);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
                if (files != null)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        yield return files[i];
                    }
                }
            }
        }
    }
}
