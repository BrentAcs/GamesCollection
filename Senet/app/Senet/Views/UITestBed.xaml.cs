namespace Senet.Views;

public partial class UITestBed : ContentPage
{
	public UITestBed()
	{
		InitializeComponent();
	}

   private void TapGestureRecognizer_OnTapped(object sender, TappedEventArgs e)
   {
      CollapseLabel.Text = (CollapseLabel.Text == "[+]") ? "[-]" : "[+]";
   }
}
