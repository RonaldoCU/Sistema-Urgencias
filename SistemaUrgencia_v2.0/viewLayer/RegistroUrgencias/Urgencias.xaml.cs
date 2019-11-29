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
using SistemaUrgencia_v2._0;

namespace SistemaUrgencia_v2._0.viewLayer.RegistroUrgencias
{
    /// <summary>
    /// Lógica de interacción para Urgencias.xaml
    /// </summary>
    public partial class Urgencias : Page
    {
        public Urgencias()
        {
            InitializeComponent();
        }
        private void cancelar1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Desea cancelar el resistro", "Urgencias", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
        }

        private void Siguiente1(object sender, RoutedEventArgs e)
        {
            Main.navegate
        }
    }
}
