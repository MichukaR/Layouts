using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Views;

public partial class StackLayout : ContentPage
{
    public StackLayout()
    {
        InitializeComponent();
    }
    
    private void BotonIrFlex_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new StackLayout());
    }
}