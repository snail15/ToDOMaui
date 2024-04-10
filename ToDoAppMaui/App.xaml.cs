using ToDoAppMaui.Views;

namespace ToDoAppMaui;

public partial class App : Application
{
    public App(MainView view)
    {
        InitializeComponent();

        MainPage = new NavigationPage(view);
    }
}
