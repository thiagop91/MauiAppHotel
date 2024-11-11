namespace MauiAppHotel.Views;

public partial class Galeria : ContentPage
{
	public Galeria()
	{
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}