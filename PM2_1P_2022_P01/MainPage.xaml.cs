using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM2_1P_2022_P01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(DateTime date)
        {
            InitializeComponent();
        }

        private async void btnMostrar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Aviso", String.Format("Nombre: {0} Edad : {1} Aviso", txtNombre.Text, txtEdad.Text), "OK");
        }

        private async void btnPagina_Clicked(object sender, EventArgs e)
        {
            var empleado = new Models.Empleado {
                nombre = txtNombre.Text,
                edad = txtEdad.Text
            };

            // Enviando datos a otra pantalla con BINDING CONTEXT
            /*var secondPage = new SecondPage();
            secondPage.BindingContext = empleado;
            await Navigation.PushAsync(secondPage);*/
            
            //Enviando datos a otra pantalla mediante el Constructor
            await Navigation.PushAsync(new SecondPage(txtNombre.Text, txtEdad.Text));
        }
    }
}
