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
			resultLabel.Text = string.Empty;

			CardDeck PlayDeck = new CardDeck();

			PlayDeck.Create();

            resultLabel.Text = PlayGame.Game(PlayDeck);
        }
	}
}
