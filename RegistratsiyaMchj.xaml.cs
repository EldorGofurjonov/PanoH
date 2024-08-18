namespace panoh_v2;

public partial class RegistratsiyaMchj : FlyoutPage
{
	public RegistratsiyaMchj()
	{
		InitializeComponent();
	}

    private async void oferta_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Oferta());
    }

    private async void SingUpButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new KartaZakaz());
    }
}