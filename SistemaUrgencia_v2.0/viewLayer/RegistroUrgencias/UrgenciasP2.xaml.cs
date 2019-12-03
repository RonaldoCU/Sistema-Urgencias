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
    /// Lógica de interacción para UrgenciasP2.xaml
    /// </summary>
    public partial class UrgenciasP2 : Page
    {
        public UrgenciasP2()
        {
            InitializeComponent();
        }

        private void atras1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Urgencias());
        }

        private void Siguiente2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UrgenciasP3());
        }

        private void cancelar2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult rstd = MessageBox.Show("Desea cancelar el resistro", "Urgencias", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (rstd == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
