
namespace panoh_v2;

public partial class viboR : FlyoutPage
{
	public viboR()
	{
		InitializeComponent();
	}

    

    private async void Foydalanuvchi_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Myaccount());
    }

    private async void Xizmatkorsatuvchi_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new RegistratsiyaMchj());
    }
}