using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace System_Prestamos_Lf.Presentacion
{

    

    /// <summary>
    /// Lógica de interacción para PantallaDeCarga.xaml
    /// </summary>
    public partial class PantallaDeCarga : Window
    {

        private Timer timer;
        private int a = 0;
        private string str;
        private string usuarioActual;
        private int codigoEmpleado;
        Dominio.Empleados Empleados = new Dominio.Empleados();

        public PantallaDeCarga()
        {
            InitializeComponent();
            timer = new Timer(35);
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Start();
            string nombre = AccesoComun.Cache.CacheUsuario.NOMBRE_EMPLEADO;
            string apellido = AccesoComun.Cache.CacheUsuario.APELLIDO_EMPLEADO;
            txtuser.Content = string.Concat(Empleados.Cadena(nombre)," ",Empleados.Cadena(apellido));
        }


        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, (Action)(() => //Invocación de metodo dispatcher 
            {
                if (BAR.Value < 30)
                {
                    a += 1;
                    str = a + " %";
                    lbload.Content = str;
                   
                    BAR.Value += 0.3;
                }
                else
                {

                    timer.Stop();
                    MessageBox.Show("Listo");
                    this.Close();
                }
            }));
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {

               
            }
        }
    }
}
