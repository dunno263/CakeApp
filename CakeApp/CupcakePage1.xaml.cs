
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CakeApp
{
	public partial class CupcakePage1 : ContentPage
	{
		private Anfrage anfrage = new Anfrage();

		public CupcakePage1()
		{
			InitializeComponent();
			anfrage.Art = AnfrageArt.Cupcakes;
		}

		async void ButtonNextCupcake_Clicked(object sender, System.EventArgs e)
		{
			anfrage.sAnzahl = Entry_Anzahl.Text;
			await Navigation.PushAsync(new AnfragePage(anfrage));
		}

		void Handle_Completed(object sender, System.EventArgs e)
		{
			DisplayAlert("Handle_Completed erreicht", "test", "Test");
		}
	}
}
