using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
	public static class Battle
	{
		private static string _result = string.Empty;
		public static string Go(Player playerOne, Player playerTwo)
		{
			_result += Display.BattleBegin();

			List<string> Bounty = new List<string>();

			int counter = 0;
			while (counter < 40 && playerOne.Hand.Count > 0 && playerTwo.Hand.Count > 0)
			{
				Bounty.Add(playerOne.Hand.ElementAt(0));
				Bounty.Add(playerTwo.Hand.ElementAt(0));

				playerOne.BatleCard = Bounty.ElementAt(0);
				playerTwo.BatleCard = Bounty.ElementAt(1);

				_result += Display.BattleCards(playerOne, playerTwo);
				CheckWinner(playerOne, playerTwo, Bounty);
				
				playerOne.Hand.RemoveAt(0);
				playerTwo.Hand.RemoveAt(0);

				while (!playerOne.Won && !playerTwo.Won)
				{
					int _counter = 6;
					War(playerOne, playerTwo, Bounty);
					_result += Display.War();

					playerOne.BatleCard = Bounty.ElementAt(_counter);
					playerTwo.BatleCard = Bounty.ElementAt(_counter + 1);
					_result += Display.BattleCards(playerOne, playerTwo);
					CheckWinner(playerOne, playerTwo, Bounty);
					_counter += 3;
				}
				
				_result += Display.Bounty(Bounty);
				_result += Display.Winner(playerOne, playerTwo);

				Bounty.Clear();
				playerOne.Won = false;
				playerTwo.Won = false;
				counter++;
			}

			if (playerOne.Hand.Count > playerTwo.Hand.Count)
			{ playerOne.Won = true; }
			else { playerTwo.Won = true; }

			_result += string.Format($"{playerOne.Name}:{playerOne.Hand.Count}" +
				$"</br>{playerTwo.Name}:{playerTwo.Hand.Count}" +
				$"</br>{Display.Winner(playerOne, playerTwo)}");

			return _result;
		}

		private static void CheckWinner(Player playerOne, Player playerTwo, List<string> bounty)
		{
			int _cardValueOne = CardValue(playerOne.BatleCard);
			int _cardValueTwo = CardValue(playerTwo.BatleCard);

			if (_cardValueOne > _cardValueTwo)
			{
				foreach (string _card in bounty)
				{ playerOne.Hand.Add(_card); }
				playerOne.Won = true;
			}
			else if (_cardValueOne < _cardValueTwo)
			{
				foreach (string _card in bounty)
				{ playerTwo.Hand.Add(_card); }
				playerTwo.Won = true;
			}
			return;
		}

		private static void War(Player playerOne, Player playerTwo, List<string> Bounty)
		{
			for (int counter = 0; counter < 3 ; counter++)
			{
			Bounty.Add(playerOne.Hand.ElementAt(0));
			Bounty.Add(playerTwo.Hand.ElementAt(0));

			playerOne.Hand.RemoveAt(0);
			playerTwo.Hand.RemoveAt(0);
			}
		}

		private static int CardValue(string card)
		{
			string _card = card.Substring(0,2).Trim();
			bool parsed = int.TryParse(_card, out int _cardValue);
			if (!parsed)
			{
				if (_card.ToUpper() == "JA") { _cardValue = 11; }
				if (_card.ToUpper() == "QU") { _cardValue = 12; }
				if (_card.ToUpper() == "KI") { _cardValue = 13; }
				if (_card.ToUpper() == "AC") { _cardValue = 14; }
			}

			return _cardValue;
		}
	}
}