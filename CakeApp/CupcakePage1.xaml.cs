
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CakeApp
{
	public partial class CupcakePage1 : ContentPage
	{
		public CupcakePage1()
		{
			InitializeComponent();
			ToolbarItems.Add(new ToolbarItem("Filter", "filter.png", async () => {   var page = new ContentPage(); var result = await page.DisplayAlert("Title", "Message", "Accept", "Cancel"); }));

		}

		async void ButtonNextCupcake_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new AnfragePage());

		}
	}
}
