using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeWar
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void okButton_Click(object sender, EventArgs e)
		{
			string result = string.Empty;
			CardDeck playCards = new CardDeck();

			List<string> PlayingCards = playCards.PlayCards;
			foreach (string playCard in PlayingCards)
			{
				result += string.Format($"{playCard}<br/>");
			}

			resultLabel.Text = result;
		}
	}
}
