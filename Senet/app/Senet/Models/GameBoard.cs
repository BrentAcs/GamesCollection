namespace Senet.Models;

public class GameBoard : BindableObject
{
   private const int TileCount = 30;

   private GameBoardTile[] _boardTiles = new GameBoardTile[ TileCount ];

   public GameBoardTile this[int index]
   {
      get => GetTile(index);
      set => SetTile(index, value);
   }

   public IEnumerable<GameBoardTile> BoardTiles => _boardTiles;

   public GameBoardTile GetTile(int index) => _boardTiles[ index ];
   public void SetTile(int index, GameBoardTile tile) => _boardTiles[ index ] = tile;

   public void Reset()
   {
      for (int i = 0; i < TileCount; i++)
      {
         _boardTiles[ i ] = new GameBoardTile {Moniker = i + 1};
      }
   }
}

public class GameBoardTile : BindableObject
{
   private int _moniker;

   public GameBoardTile()
   {
   }

   public int GridX
   {
      get
      {
         var result = (Moniker - 1) % 10;
         System.Diagnostics.Debug.WriteLine($"Moniker: {Moniker}, GridX: {result}");
         return result;
      }
   }

   public int GridY
   {
      get
      {
         var result = (Moniker - 1) / 10;
         System.Diagnostics.Debug.WriteLine($"Moniker: {Moniker}, GridY: {result}");
         return result;
      }
   }

   public int Moniker
   {
      get => _moniker;
      set
      {
         _moniker = value;
         OnPropertyChanged();
      }
   }
}
