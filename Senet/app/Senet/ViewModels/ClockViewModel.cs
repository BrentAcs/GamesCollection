using CommunityToolkit.Mvvm.ComponentModel;

namespace Senet.ViewModels;

public class ClockViewModel : ObservableObject
{
   public ClockViewModel()
   {
      Task.Run(() =>
      {
         while (true)
         {
            TestFuckingProp = $"Test Fucking Prop - {_tickCount++}";
            Thread.Sleep(1000);
         }
      });
   }


   private int _tickCount = 0;
   private string _testFuckingProp = "Test Fucking Prop"; 
   
   public string TestFuckingProp
   {
      get =>  _testFuckingProp;
      set
      {
         _testFuckingProp = value;
         OnPropertyChanged();
      }
   }

}
