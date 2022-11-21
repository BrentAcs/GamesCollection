using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Senet.Collections;

public class ObservableCollectionEx<T> : ObservableCollection<T>
{
   public ObservableCollectionEx()
   {
      
   }
   
   public ObservableCollectionEx(IEnumerable<T> collection) : base(collection)
   {
   }

   public ObservableCollectionEx(List<T> list) : base(list)
   {
   }

   public async Task ReloadDataAsync(Func<IList<T>, Task> innerListAction)
   {
      Items.Clear();

      await innerListAction(Items);

      OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
      OnPropertyChanged(new PropertyChangedEventArgs("Items[]"));
      OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
   }
}
