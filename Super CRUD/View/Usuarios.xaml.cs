using System.Windows;
using System.Windows.Controls;

namespace Super_CRUD.View
{
    /// <summary>
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : UserControl
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void CrearUsuario(object sender, RoutedEventArgs e)
        {
            CrudUsuarios VentanaDeUsuarios = new CrudUsuarios();
            FrameUsuarios.Content = VentanaDeUsuarios;
        }
    }
}
