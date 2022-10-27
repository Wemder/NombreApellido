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
    public partial class loguin : ContentPage
    {
        public loguin()
        {
            InitializeComponent();
        }
        int contador = 0;
        int limite = 2;
        private async void btnInicio_Clicked(object sender, EventArgs e)
        {
            if (contador <= limite)
            {

            await Navigation.PushAsync(new registro(txtUsuario.Text, txtContraseña.Text));

           // string usuario = "estudiante2022";
           // string contrasena = "uisrael2022";
           // string tusuario = txtUsuario.Text;
           // string tcontrasena = txtContraseña.Text;

                //if (usuario == tusuario & contrasena == tcontrasena)
            if (this.txtUsuario.Text == "estudiante2022" && this.txtContraseña.Text == "uisrael2022")        
            {
                   
                DisplayAlert("Alerta", "Usuario correcto", "Cerrar");


            }
            else
            {
                DisplayAlert("Alerta", "Usuario no existe", "Cerrar");

            }

            }

        }
    }
}

