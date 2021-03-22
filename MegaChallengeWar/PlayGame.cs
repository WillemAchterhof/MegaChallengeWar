using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public static class PlayGame
    {
        public static string Game(CardDeck playDeck)
        {
            Random random = new Random();
            string result = string.Empty;


            Player playerOne = new Player();
            Player playerTwo = new Player();
            playerOne.Name = "Willem";
            playerOne.Hand = new List<string>();
            playerTwo.Name = "Mark";
            playerTwo.Hand = new List<string>();

            result = playDeck.DealCards(playerOne, playerTwo);
            result += Battle.Go(playerOne, playerTwo);

            return result; 
        }
	}
}
