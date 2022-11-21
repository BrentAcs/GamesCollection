using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Senet.Models;

namespace Senet.ViewModels;

public class GameBoardViewModel : ObservableObject
{
   private GameBoard _board = new GameBoard();
   
   public GameBoardViewModel()
   {
      _board.Reset();
      Tiles = new ObservableCollection<GameBoardTile>(_board.BoardTiles);
   }

   public ObservableCollection<GameBoardTile> Tiles { get; private set; } 

   public async Task InitializeAsync()
   {
      _board.Reset();
      Tiles = new ObservableCollection<GameBoardTile>(_board.BoardTiles);
   }
}
