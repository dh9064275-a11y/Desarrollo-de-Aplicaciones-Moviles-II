namespace Proyecto2Refactorizado;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registro de la ruta de la página secundaria.
        // Esta ruta permitirá navegar hacia DetallePage
        // sin convertirla en una pestaña principal.
        Routing.RegisterRoute("DetallePage", typeof(Views.DetallePage));
    }
}