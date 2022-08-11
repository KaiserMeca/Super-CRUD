using System.Windows;
using System.Windows.Controls;

namespace Super_CRUD.View
{
    /// <summary>
    /// Lógica de interacción para CrudUsuarios.xaml
    /// </summary>
    public partial class CrudUsuarios : Page
    {
        public CrudUsuarios()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Content = new Usuarios();
        }
    }
}
