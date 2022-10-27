using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NombreApellido
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuiario ,string nombre,  string totalp)
        {
            InitializeComponent();
            lblUsuario.Text = "el nombre del usuario es" + usuiario;
            lblEstudiante.Text = "" + nombre;
            lbltotal.Text = "" + totalp;

        }
    }
}