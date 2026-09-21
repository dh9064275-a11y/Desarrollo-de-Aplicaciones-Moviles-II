using Proyecto1_AppsMoviles.ViewModels;

namespace Proyecto1_AppsMoviles.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new ProfileViewModel();
        }
    }
}