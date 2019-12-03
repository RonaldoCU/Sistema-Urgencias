using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SistemaUrgencia_v2._0.viewLayer.RegistroUrgencias
{
    /// <summary>
    /// Lógica de interacción para UrgenciasP4.xaml
    /// </summary>
    public partial class UrgenciasP4 : Page
    {
        public UrgenciasP4()
        {
            InitializeComponent();
        }

        private void Atras3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UrgenciasP3());
        }

        private void Siguiente4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UrgenciasP5());
        }

        private void cancelar4(object sender, RoutedEventArgs e)
        {
            MessageBoxResult rstd = MessageBox.Show("Desea cancelar el resistro", "Urgencias", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (rstd == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
