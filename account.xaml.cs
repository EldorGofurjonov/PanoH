
namespace panoh_v2;

public partial class Myaccount : FlyoutPage
{
	public Myaccount()
	{
		InitializeComponent();
        
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync( new Mainpage());
    }

    private async void oferta_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Oferta());
    }
}