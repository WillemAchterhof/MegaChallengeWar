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
	}
}
