using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
	public class Player
	{
		public string Name { get; set; }
		public string BatleCard { get; set; }
		public List<string> Hand { get;  set; }
		public bool Won { get; set; }

		public string PlayerHand()
		{
			string _playerHand = string.Empty;

			foreach (string card in this.Hand)
			{
				_playerHand += Display.PlayerHand(this.Name, card);
			}
			return _playerHand;
		}
	}
}
