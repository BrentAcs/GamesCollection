using Microsoft.Maui.Controls.Compatibility;
using Senet.ViewModels;
using Senet.Views;

namespace Senet;

public partial class MainPage : ContentPage
{
   private readonly GameBoardViewModel _boardViewModel;

   public MainPage(GameBoardViewModel boardViewModel)
   {
      _boardViewModel = boardViewModel;
      InitializeComponent();
   }

   protected override void OnAppearing()
   {
      base.OnAppearing();

      foreach (var tile in _boardViewModel.Tiles)
      {
         // var label = new Label
         // {
         //    BindingContext = tile,
         //    BackgroundColor = tile.BackgroundColor,
         //    TextColor = Colors.Black
         // };
         // label.SetBinding(Label.TextProperty, "Index");
         //
         // var image = new Image
         // {
         //    HeightRequest = 32,
         //    WidthRequest = 32,
         //    Source = ImageSource.FromFile("dotnet_bot.png"),
         //    ZIndex = 1
         // };
         //
         // var content = new HorizontalStackLayout()
         // {
         //    Padding = 4,
         //    //Content = label
         // };
         // content.Children.Add(label);
         // content.Children.Add(image);
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
