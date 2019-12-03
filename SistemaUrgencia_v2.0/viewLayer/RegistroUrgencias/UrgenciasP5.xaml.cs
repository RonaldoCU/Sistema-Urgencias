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
    /// Lógica de interacción para UrgenciasP5.xaml
    /// </summary>
    public partial class UrgenciasP5 : Page
    {
        public UrgenciasP5()
        {
            InitializeComponent();
        }

        private void atras4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UrgenciasP4());
        }

        private void cancelar5(object sender, RoutedEventArgs e)
        {
            MessageBoxResult rstd = MessageBox.Show("Desea cancelar el resistro", "Urgencias", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (rstd == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void Guardar(object sender, RoutedEventArgs e)
        {
            MessageBoxResult rstd = MessageBox.Show("Desaguardar estos datos", "Urgencias", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (rstd == MessageBoxResult.Yes)
            {
                MessageBoxResult conf = MessageBox.Show("Datos Guardados", "Urgencias", MessageBoxButton.OK, MessageBoxImage.Question);
                if (conf == MessageBoxResult.OK)
                {
                    NavigationService.Navigate(new Urgencias());
                }
            }
        }
    }
}
