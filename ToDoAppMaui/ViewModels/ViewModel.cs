using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ToDoAppMaui.ViewModels;
[ObservableObject]
public abstract partial class ViewModel
{
    // public event PropertyChangedEventHandler PropertyChanged;
    public INavigation Navigation { get; set; }
    
    // public void RaisePropertyChanged(params string[] propertyNames)
    // {
    //     foreach (var propertyName in propertyNames)
    //     {
    //         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //     }
    // }
    
}
