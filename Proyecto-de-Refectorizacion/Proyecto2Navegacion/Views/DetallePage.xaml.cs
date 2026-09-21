namespace Proyecto2Navegacion.Views;

[QueryProperty(nameof(Id), "id")]
public partial class DetallePage : ContentPage
{
    private string id = string.Empty;

    public string Id
    {
        get => id;
        set
        {
            id = value;

            // Actualiza el Binding de la interfaz
            // cuando recibe el parámetro
            OnPropertyChanged();
        }
    }

    public DetallePage()
    {
        InitializeComponent();

        // La página utiliza sus propias propiedades como fuente
        // de datos para mostrar el parámetro recibido.
        BindingContext = this;
    }
}