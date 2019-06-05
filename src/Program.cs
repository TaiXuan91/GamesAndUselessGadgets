using System;
using CommandLine;

namespace GamesAndUselessGadgets
{
    [Verb("yoot", HelpText = "Just repeat a string until interrupted.")]
    class YooOptions
    {
        [Option]
        public string Content { get; set; }
        // [Option('c', "content", Required = false, HelpText = "The string should be repeated content.")]

    }
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Welcome to Games And Useless Gadgets!");
            return CommandLine.Parser.Default.ParseArguments<YesOptions,YooOptions>(args).MapResult(
	            (YesOptions opts) => YesDriver.YesMain(opts),
                (YooOptions opts) => {Console.WriteLine(opts); return 0;},
	            errs => 1);
            // if (args.Length <= 0)
            // {
            //     Console.WriteLine("Please tell me what needs to be done.");
            //     return;
            // }
            // switch (args[0])
            // {
            //     case "yes":
            //         
            //         break;
            // }
        }

    }
}
