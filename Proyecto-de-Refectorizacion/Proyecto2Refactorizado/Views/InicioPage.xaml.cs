using Proyecto2Refactorizado.ViewModels;

namespace Proyecto2Refactorizado.Views;

public partial class InicioPage : ContentPage
{
    public InicioPage()
    {
        InitializeComponent();

        // Asigna el ViewModel como fuente de datos de la página.
        // De esta manera, los controles del XAML pueden acceder
        // a los comandos definidos en InicioViewModel.
        BindingContext = new InicioViewModel();
    }
}
