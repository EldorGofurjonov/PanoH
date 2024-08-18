
namespace panoh_v2;

public partial class Mainpage : FlyoutPage
{
    public int b = 9;
    public Mainpage()
    {
        InitializeComponent();

    }
    public int k = 1;
    private xaritA fx()
    {
        return new xaritA();
    }
    private async void fy(Slider arg, ValueChangedEventArgs e)
    {
        int a = (int)(e.NewValue);
        if (b + 12 < a)
        {
            arg.Value = 9;
        }
        else
        {
            b = a;
        }

        if (b + 12 >= a && (a > 89) && k == 1)
        {
            k++;
            await Navigation.PushModalAsync(fx());
            await Task.Delay(500);
            arg.Value = 9;

            k = 1;
        }

        if (a < 9)
            arg.Value = 9;
        else if (a > 91)
            arg.Value = 91;

    }
    private void tezyordam_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        fy(tezyordam, e);
    }

    private void otochirish_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        fy(otochirish, e);
    }



    private  void FVV_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        fy(FVV, e);
    }

    private void ichkiishlar_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        fy(ichkiishlar, e);
    }

    private void YPX_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        fy(YPX, e);
    }

    private void Gaz_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        fy(Gaz, e);
    }

    private void Evakuator_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        fy(Evakuator, e);
    }

    
//    eski funksiy
//    int a = (int)(e.NewValue);
//        if (b + 12 < a)
//        {
//            Evakuator.Value = 9;
//        }
//        else
//        {
//            b = a;
//        }
//        if (a < 9)
//    Evakuator.Value = 9;
//else if (a > 91)
//    Evakuator.Value = 91;

//if (b + 12 >= a && (a > 90) && k == 1)
//{
//    k++;
//    await Navigation.PushModalAsync(fx());
//    Evakuator.Value = 91;
//    k = 1;
//}

}