using System;

namespace GamesAndUselessGadgets
{
    /// <summary>
    /// Just repeat a string until interrupted.
    /// The default string is "yes".
    /// </summary>
    class Yes
    {
        /// <summary>
        /// What needs to be repeated.
        /// </summary>
        private string content;

        private bool repeatInfinitely;
        private uint repeatTimes;

        /// <summary>
        /// Create a Yes object.
        /// </summary>
        /// <param><c>str</c> is the string should be repeated content.</param>
        /// <param><c>times</c> is repeat times.</param>
        public Yes(string str = null, uint? times = null)
        {
            content = str is null ? "yes" : str;
            repeatInfinitely = times is null ? (true) : (false);
            repeatTimes = times is null ? 0 : (uint)times;
        }

        /// <summary>
        /// Start repeating.
        /// </summary>
        public void Start()
        {
            while (repeatInfinitely || repeatTimes > 0)
            {
                Console.WriteLine(content);
                repeatTimes = repeatTimes>0?repeatTimes-1:0;
            }
        }
    }
}