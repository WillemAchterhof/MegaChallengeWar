using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
	public static class Battle
	{
		public static string Go(Player playerOne, Player playerTwo)
		{
			string _result = string.Empty;

			_result += "<h2>Battle Begin</h2>";

			for (int counter = 1; counter < 30; counter++)
			{
				playerOne.DrawnCard = playerOne.Hand.ElementAt(0);
				playerTwo.DrawnCard = playerTwo.Hand.ElementAt(0);

				_result += BattleCards(playerOne.DrawnCard, playerTwo.DrawnCard);
			}

			_result += string.Format($"");

			return _result;
		}

		private static string BattleCards(string cardOne, string cardTwo)
		{
			string _result = string.Empty;
			
			_result += string.Format($"Battle Cards: {cardOne} versus  {cardTwo}" +
				$"<br />Bounty..." +
				$"<br />{cardOne}<br />{cardTwo}<br /><br />");


			return _result;
		}
	}
}