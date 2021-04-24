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
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility

            if (Tg_Btn.IsChecked == true)
            {
                tt_home.Visibility = Visibility.Collapsed;
                ttClientes.Visibility = Visibility.Collapsed;
                ttPrestamos.Visibility = Visibility.Collapsed;
                ttPagos.Visibility = Visibility.Collapsed;
                ttEmpleados.Visibility = Visibility.Collapsed;
                tt_settings.Visibility = Visibility.Collapsed;
                tt_signout.Visibility = Visibility.Collapsed;
                ttReportes.Visibility = Visibility.Collapsed;
            }
            else
            {
                ttEmpleados.Visibility = Visibility.Visible;
                ttReportes.Visibility = Visibility.Visible;
                tt_home.Visibility = Visibility.Visible;
                ttClientes.Visibility = Visibility.Visible;
                ttPrestamos.Visibility = Visibility.Visible;
                ttPagos.Visibility = Visibility.Visible;
                tt_settings.Visibility = Visibility.Visible;
                tt_signout.Visibility = Visibility.Visible;
            }
        }

        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 1;
        }

        private void Tg_Btn_Checked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 0.3;
        }

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = LV.SelectedIndex;
            switch (index)
            {
                case 0:
                    
                    break;
                case 1:
                    BG.Children.Clear();
                    BG.Children.Add(new Clientes());
                    break;
                default:
                    break;
            }
        }

    }
}
