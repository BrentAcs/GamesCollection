namespace Senet.Models;

public class GameBoard : BindableObject
{
   private const int TileCount = 30;

   private GameBoardTile[] _tiles = new GameBoardTile[ TileCount ];

   public GameBoardTile this[int index]
   {
      get => GetTile(index);
      set => SetTile(index, value);
   }

   public GameBoardTile GetTile(int index) => _tiles[ index ];
   public void SetTile(int index, GameBoardTile tile) => _tiles[ index ] = tile;
}

public class GameBoardTile : BindableObject
{
   public int Index { get; private set; }
}
