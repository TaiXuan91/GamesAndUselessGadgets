using System;

namespace GamesAndUselessGadgets.Game2048
{
    enum Direction1d{
        fromHead,
        fromTail
    }

    enum Direction2d{
        up,
        down,
        left,
        right
    }

    class Game2048{
        // game board
        private uint[,] board;

        /// <summary>
        /// Create a 2048 game
        /// </summary>
        /// <param><c>sideLength</c> the side length of board.</param>
        public Game2048(uint sideLength=4){
            // create board
            sideLength = (sideLength is 0)? 4:(uint)sideLength;
            board = new uint[sideLength, sideLength];
            // 
        }

        /// <summary>
        /// Check one column for movement.
        /// </summary>
        /// <param><c>column</c> is the column to work with.</param>
        /// <param><c>dir</c> is direction of moving.</param>
        public void MoveOneColumn(uint[] column, Direction1d dir){
            // move
            // check and merge
            // move again
        }

    }
}