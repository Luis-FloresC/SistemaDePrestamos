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
using System.Windows.Shapes;

namespace System_Prestamos_Lf.Presentacion
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Dominio.Empleados Usuarios = new Dominio.Empleados();
                var ResultadoValidacion = Usuarios.VerificarInicioSesión(txtuser.Text, txtpass.Password);
                if ((ResultadoValidacion == true) && (txtuser.Text == AccesoComun.Cache.CacheUsuario.NOMBRE_USUARIO) && (txtpass.Password == AccesoComun.Cache.CacheUsuario.CONTRASEÑA))
                {
                    PantallaDeCarga loading = new PantallaDeCarga();
                    loading.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecto\nIntente de nuevo", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    txtpass.Password = string.Empty;
                    txtpass.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            { DragMove(); }
            catch (Exception){ }
        }
    }
}
