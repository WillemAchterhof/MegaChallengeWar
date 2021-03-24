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
		public static string BattleCards(List<string> bounty)
		{
			return string.Format($"Battle Cards: {bounty.ElementAt(0)} versus  {bounty.ElementAt(1)}" +
			$"<br />Bounty..." +
			$"<br />{bounty.ElementAt(0)}<br />{bounty.ElementAt(1)}<br /><br />");
		}
		public static string PlayerHand(string name, string card)
		{
			return string.Format($"{name} - {card}<br />");
		}
	}
}