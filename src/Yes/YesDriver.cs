using System;
using CommandLine;

namespace GamesAndUselessGadgets.Yes
{
    /// <summary>
    /// The class that contains the launcher of yes.
    /// </summary>
    class YesDriver
    {
        public static int YesMain(YesOptions opt)
        {
            Yes yes= new Yes(opt.Content, opt.RepeatTimes);
            yes.Start();
            return 0;
        }
    }
}