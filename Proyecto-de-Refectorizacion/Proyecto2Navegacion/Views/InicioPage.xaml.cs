namespace Proyecto2Navegacion.Views;

public partial class InicioPage : ContentPage
{
    public InicioPage()
    {
        InitializeComponent();
    }

    //await
    // Navegación hacia DetallePage utilizando una ruta de Shell.
    // Se envía el parámetro "id" mediante la URI.
    private async void OnVerDetalleClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("DetallePage?id=1"); 
    }
}
