using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Proyecto1_AppsMoviles.Models;

namespace Proyecto1_AppsMoviles.ViewModels
{
    public partial class ProfileViewModel : ObservableObject
    {
        private UserProfile profile;

        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private int age;

        [ObservableProperty]
        private string description;

        [ObservableProperty]
        private string imageUrl;

        [ObservableProperty]
        private string errorMessage;

        public ProfileViewModel()
        {
            profile = new UserProfile
            {
                Name = "David",
                Age = 25,
                Description = "Estudiante de Programación de Sistemas en la UCES.",
                ImageUrl = ""
            };

            name = profile.Name;
            age = profile.Age;
            description = profile.Description;
            imageUrl = profile.ImageUrl;
        }

        [RelayCommand]
        private async Task Guardar()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                ErrorMessage = "El nombre no puede estar vacío.";
                return;
            }

            if (Age <= 0)
            {
                ErrorMessage = "La edad debe ser mayor a cero.";
                return;
            }

            profile.Name = Name;
            profile.Age = Age;
            profile.Description = Description;
            profile.ImageUrl = ImageUrl;

            ErrorMessage = "Perfil guardado correctamente.";

            await Task.Delay(2000);

            ErrorMessage = "";
        }     
    }
}