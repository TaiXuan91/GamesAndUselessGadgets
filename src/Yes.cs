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

        /// <summary>
        /// Create a Yes object. 
        /// </summary>
        public Yes(string str){
            content = str;
        }

        /// <summary>
        /// Create a Yes object without string.
        /// </summary>
        public Yes():this("yes"){}

        /// <summary>
        /// Start repeating.
        /// </summary>
        public void Start(){
            while(true){
                Console.WriteLine(content);
            }
        }
    }
}