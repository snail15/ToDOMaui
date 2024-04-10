using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppMaui.ViewModels;

namespace ToDoAppMaui.Views;

public partial class ItemView : ContentPage
{
    public ItemView(ItemViewModel viewModel)
    {
        InitializeComponent();
        viewModel.Navigation = Navigation;
        BindingContext = viewModel;
    }
}

