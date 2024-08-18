namespace panoh_v2;

public partial class chaqiruvnikiritiSH : FlyoutPage
{
	public chaqiruvnikiritiSH()
	{
		InitializeComponent();
	}

    private async void saqlash_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new boshoynA());
    }
}