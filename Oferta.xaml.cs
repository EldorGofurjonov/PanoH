
namespace panoh_v2;

public partial class Oferta : ContentPage
{
	public Oferta()
	{
		InitializeComponent();
	}

    private async void close_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }
}