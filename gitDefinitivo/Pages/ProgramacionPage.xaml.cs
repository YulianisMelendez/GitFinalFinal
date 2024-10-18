using System.Collections.ObjectModel;
using gitDefinitivo.Models;

namespace gitDefinitivo.Pages;

public partial class ProgramacionPage : ContentPage
{
    public ObservableCollection<DatosCuriososModels> CuriositiesList { get; set; }

    public ProgramacionPage()
    {
        InitializeComponent();

        CuriositiesList = new ObservableCollection<DatosCuriososModels>
            {
                new DatosCuriososModels
                {
                    Title = "El virus Stuxnet",
                    Description = "Stuxnet fue un virus informático desarrollado para sabotear instalaciones nucleares. Es un claro ejemplo de cómo la programación puede ser usada como arma."
                },
                new DatosCuriososModels
                {
                    Title = "El incidente del Therac-25",
                    Description = "Errores en el software del Therac-25 provocaron radiaciones masivas, causando varias muertes. Un recordatorio de cómo los errores en software pueden tener consecuencias mortales."
                },
               
            };

        BindingContext = this;
    }
}