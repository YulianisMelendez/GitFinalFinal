using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Maui.Controls;

namespace gitDefinitivo;

 public partial class Maestro : ContentPage
{
    public Maestro()
    {
        InitializeComponent();
    }

    public static void NavigationToPage(ContentPage nuevaPagina)
    {
        App.FlyoutPage.Detail.Navigation.PushAsync(nuevaPagina);
    }


    public static void OcultarDetalles()
    {
        App.FlyoutPage.IsPresented = false;
    }



}
