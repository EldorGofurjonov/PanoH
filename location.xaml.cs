namespace panoh_v2;

public partial class locationMy : ContentPage
{
	public locationMy()
	{
        InitializeComponent();
		show();

	}
	private async void show()
	{
		await Task.Delay(4000);
		await Navigation.PushModalAsync(new chaqiruvnikiritiSH());
	}
}