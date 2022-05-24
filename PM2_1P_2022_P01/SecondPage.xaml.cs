using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2_1P_2022_P01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        public SecondPage(String nombre, String edad) {
            InitializeComponent();
            
            lblNombre.Text = nombre;
            lblEdad.Text = edad;
        }
    }
}