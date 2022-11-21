using Senet.ViewModels;

namespace Senet;

public partial class MainPage : ContentPage
{
   public MainPage(GameBoardViewModel viewModel)
   {
      BindingContext = viewModel;
      InitializeComponent();
   }
}
