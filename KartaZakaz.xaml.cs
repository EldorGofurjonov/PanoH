namespace panoh_v2;

public partial class KartaZakaz : FlyoutPage
{
	public KartaZakaz()
	{
		InitializeComponent();
        show();
	}
    private async void show()
    {
        await Task.Delay(4000);
        await Navigation.PushModalAsync(new zakazTushdi());
    }
}