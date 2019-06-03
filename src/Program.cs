using System;

namespace GamesAndUselessGadgets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Games And Useless Gadgets!");
            if(args.Length<=0){
                Console.WriteLine("Please tell me what needs to be done.");
                return;
            }
            switch(args[0]){
                case "yes":
                    Yes yes;
                    if(args.Length>1){
                        yes = new Yes(args[1]);
                    }
                    else{
                        yes = new Yes();
                    }
                    yes.Start();
                    break;
            }
        }

    }
}
