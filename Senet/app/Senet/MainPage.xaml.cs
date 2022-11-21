using Senet.ViewModels;

namespace Senet;

public partial class MainPage : ContentPage
{
   public MainPage(GameBoardViewModel viewModel)
   {
      InitializeComponent();
      // BindingContext = viewModel;
   }

   protected override void OnAppearing()
   {
      base.OnAppearing();

      if (BindingContext is GameBoardViewModel)
      {
         (BindingContext as GameBoardViewModel)!.InitializeAsync();
      }
   }
}
