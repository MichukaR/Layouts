using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Views;

public partial class FlexLayout : ContentPage
{
    public FlexLayout()
    {
        InitializeComponent();
    }
    private void BotonRegresar_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new StackLayout());
    }
}