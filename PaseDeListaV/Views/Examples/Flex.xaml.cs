namespace PaseDeListaV.Views.Examples;

public partial class Flex : ContentPage
{
	public Flex()
	{
		InitializeComponent();
	}

    async void FlexButtonGrid_Clicked(System.Object sender, System.EventArgs e)
    {
		await Shell.Current.GoToAsync("//GridLayout");
    }
}
