namespace panoh_v2;

public partial class zakazTushdi : FlyoutPage
{ 
	public  zakazTushdi()
	{
		InitializeComponent();
        show();
	   
	}
    private async void show()
    {
        await Task.Delay(4000);
        await Navigation.PushModalAsync(new marshrutt());
    }


}