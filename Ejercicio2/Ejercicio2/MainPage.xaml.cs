using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btninformacion_Clicked(object sender, EventArgs e)
        {
            var vari = new Model.Variables
            {
                Nombre = txtnombre.Text,
                Apellidos = txtapellidos.Text,
                Edad = Convert.ToInt32(txtedad.Text), 
                Correo= txtcorreo.Text,
                EnviarNombre = txtnombre.Text,
                EnviarApellido = txtapellidos.Text,
                EnviarEdad = Convert.ToInt32(txtedad.Text),
                EnviarCorreo = txtcorreo.Text
            };
            var ma = new Views.Agregar();
            ma.BindingContext = vari;
            await Navigation.PushModalAsync(ma);
        }
    }
}
