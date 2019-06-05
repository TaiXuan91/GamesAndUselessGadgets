using System;
using CommandLine;

namespace GamesAndUselessGadgets
{
    /// <summary>
    /// Used to save content of parsed command line.
    /// </summary>
    [Verb("yes", HelpText = "Just repeat a string until interrupted.")]
    class YesOptions
    {
        [Value(0,HelpText = "The string should be repeated content.")]
        public string Content { get; set; }

        [Option('t', "times", Required = false, HelpText = "Times of repetition.")]
        public uint? RepeatTimes { get; set; }

    }
}