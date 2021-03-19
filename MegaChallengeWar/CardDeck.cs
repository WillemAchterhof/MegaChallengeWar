using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
	public static class CardDeck
	{
		public static List<string> CreateDeck()
		{
			
			List<string> PlayCards = new List<string>();
			
			List<string> CardColor = new List<string>();
			CardColor.Add("Clubs");
			CardColor.Add("Diamonds");
			CardColor.Add("Hearts");
			CardColor.Add("Spades");

			List<string> CardValue = new List<string>();
			for (int count = 1; count <= 9; count++)
			{
				CardValue.Add(count.ToString());
			}
			CardValue.Add("Ace");
			CardValue.Add("Jack");
			CardValue.Add("Queen");
			CardValue.Add("King");

			foreach (string cardColor in CardColor)
			{
				foreach (string cardValue in CardValue)
				{
					PlayCards.Add(string.Format($"{cardValue} of {cardColor}"));
				}
			}

			return PlayCards;
		}
	}
}