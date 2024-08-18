
namespace panoh_v2;

public partial class marshrutt : ContentPage
{
    public marshrutt()
    {
        InitializeComponent();
        showw();
    }

    private async void showw()
    {
        await Task.Delay(3000);
        await Navigation.PushModalAsync(new locationMy());
    }
}