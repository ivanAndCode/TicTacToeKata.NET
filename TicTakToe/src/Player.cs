using System;

namespace TicTakToe
{
    public static class Player
    {
        private static int playerNumber = 1;
        
        public static int GetCurrentPlayerNumber()
        {
            return playerNumber;
        }
        
        public static void UpdateCurrentPlayerNumber()
        {
            playerNumber = (playerNumber == 1) ? 2 : 1;
        }
       
        public static char GetCurrentPlayerSymbol()
        {
            return GetCurrentPlayerNumber() == 1 ? 'X' : 'O';
        }
    }
}