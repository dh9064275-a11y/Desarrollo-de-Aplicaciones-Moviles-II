using System.Windows.Input;

namespace Proyecto2Refactorizado.ViewModels;

/// <summary>
/// ViewModel de la página de inicio.
///
/// Centraliza la lógica de navegación que anteriormente
/// se encontraba en InicioPage.xaml.cs.
/// </summary>
public class InicioViewModel
{
    /// <summary>
    /// Comando utilizado para navegar hacia DetallePage.
    /// </summary>
    public ICommand VerDetalleCommand { get; }

    /// <summary>
    /// Constructor del ViewModel.
    /// </summary>
    public InicioViewModel()
    {
        VerDetalleCommand = new Command(async () =>
        {
            // Parámetro que se enviará a DetallePage.
            string id = "1";

            // Validamos que el parámetro exista y no esté vacío.
            if (string.IsNullOrWhiteSpace(id))
            {
                return;
            }

            // Navegamos utilizando una ruta de Shell
            // y enviamos el parámetro mediante URI.
            await Shell.Current.GoToAsync($"DetallePage?id={id}");
        });
    }
}