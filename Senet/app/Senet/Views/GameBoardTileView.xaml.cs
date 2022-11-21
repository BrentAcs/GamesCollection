namespace Senet.Views;

public partial class GameBoardTileView : ContentView
{
	public GameBoardTileView()
	{
		InitializeComponent();
	}

   public string TileIndex
   {
      get => IndexLabel.Text;
      set
      {
         IndexLabel.Text = value;
         OnPropertyChanged();
      }
   }
   
   public string Caption
   {
      get => CaptionLabel.Text;
      set
      {
         CaptionLabel.Text = value;
         OnPropertyChanged();
      }
   }
   
}
