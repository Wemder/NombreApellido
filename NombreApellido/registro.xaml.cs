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
    public partial class registro : ContentPage
    {
        public registro(string usuario, string contrasena)
        {
            InitializeComponent();
            lblUsuarario.Text = "El usuarios es " + usuario + "La contraseña es " + contrasena;
        }

        private void btnInformacion_Clicked(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            double nota2 = Convert.ToDouble(txtPago.Text);
            double valor = (((3000 - nota2) / 5) + 10);

            Resultado.Text = valor.ToString();


            if (valor >= 3000)
            {
                DisplayAlert("Mensaje de alerta", "Tu nombre es" + nombre + "\n Tu Apellido" + apellido + "" + valor, "Cerrar");
            }
            else
            {
                DisplayAlert("Mensaje de alerta", "Tu nombre es" + nombre + "tu Apellido" + apellido + " " + valor, "Cerrar");

            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("alerta", "elentos guardados con exito", "Cerrar");
            await Navigation.PushModalAsync(new Resumen(txtNombre.Text, lblUsuarario.Text, txtPago.Text));

        }
    }
}