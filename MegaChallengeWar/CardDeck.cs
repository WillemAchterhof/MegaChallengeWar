using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
	public  class CardDeck
	{
		public List<string> PlayCards = new List<string>();
		private string _result = string.Empty;
        
		public void Create()
		{
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
		}
		
		Random random = new Random();
		public string DealCards(Player playerOne, Player playerTwo)
		{
			 _result = Display.DealCards();
			
			while (this.PlayCards.Count > 0)
			{
				if ( playerOne.Hand.Count == playerTwo.Hand.Count) {
					_result += giveCardto(playerOne); }
				else {
					_result += giveCardto(playerTwo); }
			}
			return _result;
		}

		private string giveCardto(Player player)
		{
			int _cardNumber = random.Next(this.PlayCards.Count);
			string _card = this.PlayCards.ElementAt(_cardNumber);
			
			player.Hand.Add(_card);
			this.PlayCards.RemoveAt(_cardNumber);
			_result = Display.CardDealt(player, _card);
			return _result;
		}
	}
}
