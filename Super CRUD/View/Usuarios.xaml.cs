using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

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
            cargarDatos();
        }
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConectionDb"].ConnectionString);
        void cargarDatos()
        {
            conexion.Open();
            SqlCommand command = new SqlCommand("SELECT IdUsuarios, Nombres, Apellido, Dni, Telefono, Email, FechaDeNacimineto,NombreDelCargo FROM Usuarios INNER JOIN Cargo ON Usuarios.Cargo = Cargo.IdCargo ORDER BY IdUsuarios ASC ", conexion);


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            GridDatos.ItemsSource = data.DefaultView;
            conexion.Close();
        }
        private void CrearUsuario(object sender, RoutedEventArgs e)
        {
            CrudUsuarios VentanaDeUsuarios = new CrudUsuarios();
            FrameUsuarios.Content = VentanaDeUsuarios;
        }
    }
}
