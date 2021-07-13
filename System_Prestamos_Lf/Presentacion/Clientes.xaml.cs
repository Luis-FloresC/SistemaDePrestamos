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
using System.Data;

namespace System_Prestamos_Lf.Presentacion
{
    
    /// <summary>
    /// Lógica de interacción para Clientes.xaml
    /// </summary>
    public partial class Clientes : UserControl
    {
        private DataTable DataTableClientes = new DataTable();
        private Dominio.Clientes ClssClientes = new Dominio.Clientes();
        public Clientes()
        {
            InitializeComponent();
            MostrarDatosDataGridProveedores();
        }

        /// <summary>
        /// Metodo para Cargar los datos en el DatagridView
        /// </summary>
        private void MostrarDatosDataGridProveedores()
        {
            DataTableClientes.Clear();
            DataTableClientes = ClssClientes.DatagridClientes();
            DataGridClientes.ItemsSource = DataTableClientes.DefaultView;
            var TotalRows = DataGridClientes.Items.Count;
            txtTotal.Text = "Total: " + TotalRows;
        }
        private void DataGridClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
