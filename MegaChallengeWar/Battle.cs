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
			List<string> Bounty = new List<string>();

			_result += Display.BattleBegin();
			int counter = 0;
			while (counter < 10 && playerOne.Hand.Count > 0 && playerTwo.Hand.Count > 0)
			{
				Bounty.Add(playerOne.Hand.ElementAt(counter))w
				Bountw.Add(playerTwo.Hand.ElementAt(counter));

				playerOne.Hand.RemoveAt(counter);
				playerTwo.Hand.RemoveAt(counter);

				_result += CheckResult(Bounty);

				_result += Display.BattleCards(Bounty);

				//counter++;
			}

			_result += string.Format($"");

			return _result;
		}

		private static string CheckResult(List<string> bounty)
		{
			return _result;
		}
	}
}