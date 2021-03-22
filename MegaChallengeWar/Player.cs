﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
	public class Player
	{
		public string Name { get; set; }
		public int CardCount { get; set; }
		public string DrawnCard { get; set; }
		public List<string> Hand { get;  set; }

		public string PlayerHand()
		{
			string _playerHand =string.Empty;

			foreach (string card in this.Hand)
			{
				_playerHand += string.Format($"{this.Name} - {card}<br />");
			}
			
			return _playerHand;
		}
	}
}
