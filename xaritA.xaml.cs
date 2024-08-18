namespace panoh_v2;

public partial class xaritA : ContentPage
{
	public xaritA()
	{
		InitializeComponent();
        showw();
	}
    private async void showw()
    {
        await Task.Delay(3000);
        await Navigation.PushModalAsync(new locationMy2());
    }
}