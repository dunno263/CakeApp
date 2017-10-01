using Xamarin.Forms;

namespace CakeApp
{
	public partial class CakeAppPage : ContentPage
	{


		public CakeAppPage()
		{
			InitializeComponent();
		}

		void VcHochzeit_Tapped(object sender, System.EventArgs e)
		{
			
		}

		async void VcCupcakes_Tapped(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new CupcakePage1());
		}
	}
}
