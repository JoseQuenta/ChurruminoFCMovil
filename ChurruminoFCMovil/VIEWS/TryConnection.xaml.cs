using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChurruminoFCMovil.VIEWS
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TryConnection : ContentView
	{
        //Se declara una variable de tipo Conexion.
        private Conexion conexion;
        public TryConnection ()
		{
			InitializeComponent ();
            //Se inicializa la variable conexion con un nuevo objeto de la clase Conexion.
            conexion = new Conexion();
		}

        private void ProbarConexion_Clicked(object sender, EventArgs e)
        {
            //Se abre la conexion.
            conexion.Abrir();
            //Se cierra la conexion.
            conexion.Cerrar();
            //Se muestra un mensaje de conexion exitosa.
            DisplayAlert("Conexion", "Conexion exitosa", "OK");
        }
    }
}