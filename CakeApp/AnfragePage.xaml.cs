using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CakeApp
{
	public partial class AnfragePage : ContentPage
	{
		private Anfrage anfrage;

		public AnfragePage()
		{
			InitializeComponent();
		}

		public AnfragePage(Anfrage _anfrage)
		{
			InitializeComponent();
			anfrage = _anfrage;
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			string s = "mailto:" + "tinaallst@gmx.de" + "?subject=Anfrage&body=testi%20test%0AAnzahl:" + anfrage.sAnzahl
						+ "%0ATyp:" + anfrage.Art;
			//string ss = "mailto:tinaallst@gmx.de?subject=Anfrage Torte";
			Uri uri = new Uri(s);
			Device.OpenUri(uri);
		}
	}
}
