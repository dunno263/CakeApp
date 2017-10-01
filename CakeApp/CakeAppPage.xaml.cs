using Xamarin.Forms;

namespace CakeApp
{
	public partial class CakeAppPage : ContentPage
	{


		public CakeAppPage()
		{
			InitializeComponent();
		}

		async void VcHochzeit_Tapped(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new CupcakePage1());
		}

		async void VcKiBu_Tapped(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new CupcakePage1());
		}

		async void VcCupcakes_Tapped(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new CupcakePage1());
		}
	}
}
