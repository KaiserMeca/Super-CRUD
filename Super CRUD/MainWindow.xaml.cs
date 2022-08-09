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

namespace Super_CRUD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        #region Botones Principales
        private void ToggleButton_Mostrar(object sender, RoutedEventArgs e)
        {
            GridContenidoMenu.Opacity = 0.9;
        }

        private void ToggleButton_Ocultar(object sender, RoutedEventArgs e)
        {
            GridContenidoMenu.Opacity = 1;
        }

        private void PreviewMouseLefButtonDown_GridContenidoMenu(object sender, MouseButtonEventArgs e)
        {
            BtnMostrarMenu.IsChecked = false; 
        }

        private void Minimizar(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CerrarApp(object sender, RoutedEventArgs e)
        {
            Close();
        }
        #endregion
    }
}
