using Microsoft.Maui.Controls.Compatibility;
using Senet.ViewModels;
using Senet.Views;

namespace Senet;

public partial class MainPage : ContentPage
{
   private readonly GameBoardViewModel _boardViewModel;

   public MainPage(GameBoardViewModel boardViewModel, ClockViewModel clockViewModel)
   {
      BindingContext = clockViewModel;
      _boardViewModel = boardViewModel;
      InitializeComponent();
   }

   protected override void OnAppearing()
   {
      base.OnAppearing();

      foreach (var tile in _boardViewModel.Tiles)
      {
         var content = new GameBoardTileView
         {
            TileIndex = $"{tile.Index}",
            BackgroundColor = tile.BackgroundColor,
            Caption = tile.Caption
         };

         BoardGrid.Add(content, tile.GridX,tile.GridY );
      }
   }

   private void Button_OnClicked(object sender, EventArgs e)
   {
      _boardViewModel.Tiles[ 1 ].Name = "BIGGER";
   }
}
