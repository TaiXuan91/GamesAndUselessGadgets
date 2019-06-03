using System;

namespace GamesAndUselessGadgets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void yesMain(string[] args)
        {
            /// <summary>反正这是一段注释和咯噢噢噢噢nhaoesuhaoeu
            /// </summary>
            string content = "yes";
            if(args.Length>0)
                content = args[0];
            while(true)
                Console.WriteLine(content);
        }
    }
}
