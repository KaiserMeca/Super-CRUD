using Super_CRUD.View;
using System.Windows;
using System.Windows.Input;

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
            GridContenidoMenu.Opacity = 0.7;
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

        private void Usuarios_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Usuarios();
        }
    }
}
