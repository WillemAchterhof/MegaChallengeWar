using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
	public static class Display
	{
		public static string DealCards()
		{
			return "<h2>Dealing cards... </h2>";
		}
		public static string CardDealt(Player player, string _card)
		{
			return string.Format($"{player.Name} is dealt the {_card}<br />");
		}
		public static string BattleBegin()
		{
			return "<h2>Battle Begin</h2>";
		}
		public static string BattleCards(Player playerOne, Player playerTwo)
		{
			return string.Format($"Battle Cards: {playerOne.BatleCard} versus  {playerTwo.BatleCard}<br />");
		}
		public static string Bounty(List<string> bounty)
		{
			string _result = "Bounty...<br />"; 
			foreach (string _card in bounty)
			{
				_result += string.Format($"{_card}<br />");
			}
			return _result;
		}
		public static string PlayerHand(string name, string card)
		{
			return string.Format($"{name} - {card}<br />");
		}
		public static string War()
		{
			return "********WAR**********<br />";
		}
		public static string Winner(Player playerOne, Player playerTwo)
		{
			string _winner = string.Empty;
			if (playerOne.Won)
			{
				_winner = playerOne.Name;
			}
			else { _winner = playerTwo.Name; }
			return string.Format($"<br />Winner: {_winner}!<br /><br />");
		}
	}
}