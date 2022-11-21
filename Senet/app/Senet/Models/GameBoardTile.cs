namespace Senet.Models;

public class GameBoardTile : BindableObject
{
   private readonly int _index;
   private string _name = string.Empty;

   public int GridX => Index % 10;
   public int GridY => Index / 10;

   public int Index
   {
      get => _index;
      init
      {
         _index = value;
         _name = $"Tile :{_index}";
         OnPropertyChanged();
         OnPropertyChanged(nameof(Name));
      }
   }

   public string Name
   {
      get => _name;
      set
      {
         _name = value;
         OnPropertyChanged();
      }
   }
   
   public Color BackgroundColor => Index % 2 == 0 ? Colors.LightYellow : Colors.SandyBrown;
   public string Caption => GetCaption(_index);

   private string GetCaption(int index)
   {
      switch (index)
      {
         case 14: return "House"; 
         case 25: return "Happiness";
         case 26: return "Water";
         default: return string.Empty;
      }
   }
}
