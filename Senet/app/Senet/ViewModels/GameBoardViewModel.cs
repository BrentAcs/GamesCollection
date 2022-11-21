using CommunityToolkit.Mvvm.ComponentModel;
using Senet.Collections;
using Senet.Models;

namespace Senet.ViewModels;

public class GameBoardViewModel : ObservableObject
{
   private GameBoard _board = new GameBoard();
   
   public GameBoardViewModel()
   {
   }

   public ObservableCollectionEx<GameBoardTile> Tiles { get; private set; } 

   public async Task InitializeAsync()
   {
      _board.Reset();
      Tiles = new ObservableCollectionEx<GameBoardTile>(_board.Tiles);
   }
}
