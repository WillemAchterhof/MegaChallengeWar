using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public static class PlayGame
    {
        public static string Game()
        {
            Random random = new Random();
            string result = string.Empty;

            Player playerOne = new Player();
            Player playerTwo = new Player();
            playerOne.Name = "Willem";
            playerOne.Hand = new List<string>();
            playerTwo.Name = "Mark";
            playerTwo.Hand = new List<string>();


            int _playerOneCount = 0;
            int _playerTwoCount = 0;
            
			while (CardDeck.PlayCards.Count > 0)
			{
                int _cardNumber;
                string card;

				if (_playerOneCount <= _playerTwoCount)
				{
                    _cardNumber = random.Next(CardDeck.PlayCards.Count);
                    _playerOneCount += 1;
                    card = CardDeck.PlayCards.ElementAt(_cardNumber);
                    playerOne.Hand.Add(card);
                    CardDeck.PlayCards.RemoveAt(_cardNumber);
				}
				else
				{
                    _cardNumber = random.Next(CardDeck.PlayCards.Count);
                    _playerTwoCount += 1;
                    card = CardDeck.PlayCards.ElementAt(_cardNumber);
                    playerTwo.Hand.Add(card);
                    CardDeck.PlayCards.RemoveAt(_cardNumber);
				}
			}
			foreach (string card in playerOne.Hand)
			{
                result += string.Format($"{card}<br />");
			}
            result += "<br />";
			foreach (string card in playerTwo.Hand)
			{
                result += string.Format($"{card}<br />");

			}
            return result; 
        }
	}
}
