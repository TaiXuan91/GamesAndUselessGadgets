using System;

namespace yes
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = "yes";
            if(args.Length>0)
                content = args[0];
            while(true)
                Console.WriteLine(content);
        }
    }
}
