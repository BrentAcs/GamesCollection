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
         _boardTiles[ i ] = new GameBoardTile {Index = i};
      }
   }
}
