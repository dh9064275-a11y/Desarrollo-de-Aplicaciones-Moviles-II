namespace Proyecto2Refactorizado.Views;

/// <summary>
/// Página secundaria que muestra el detalle recibido
/// mediante un parámetro de navegación de Shell.
///
/// Implementa IQueryAttributable para recibir y validar
/// los parámetros enviados mediante la URI.
/// </summary>
public partial class DetallePage : ContentPage, IQueryAttributable
{
    private string id = string.Empty;

    /// <summary>
    /// Identificador recibido mediante la navegación.
    /// </summary>
    public string Id
    {
        get => id;
        set
        {
            id = value;

            // Actualiza la interfaz cuando cambia el valor.
            OnPropertyChanged();
        }
    }

    public DetallePage()
    {
        InitializeComponent();

        // La propia página será la fuente de datos
        // para mostrar el parámetro recibido.
        BindingContext = this;
    }

    /// <summary>
    /// Recibe los parámetros enviados por Shell.
    /// </summary>
    /// <param name="query">
    /// Diccionario con los parámetros enviados mediante la URI.
    /// </param>
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        // Comprobamos que exista el parámetro "id".
        if (!query.TryGetValue("id", out object? value))
        {
            Id = "ID no recibido";
            return;
        }

        // Convertimos el valor recibido a texto.
        string nuevoId = value?.ToString() ?? string.Empty;

        // Validamos que el ID no esté vacío.
        if (string.IsNullOrWhiteSpace(nuevoId))
        {
            Id = "ID inválido";
            return;
        }

        // Guardamos el ID recibido.
        Id = nuevoId;
    }
}