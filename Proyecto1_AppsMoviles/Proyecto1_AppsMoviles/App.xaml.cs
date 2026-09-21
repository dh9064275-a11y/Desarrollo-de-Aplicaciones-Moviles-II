using Microsoft.Extensions.DependencyInjection;
using Proyecto1_AppsMoviles.Views;

namespace Proyecto1_AppsMoviles
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}