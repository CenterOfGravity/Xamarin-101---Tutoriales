using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegundaPaginaView : ContentPage
    {
        public SegundaPaginaView(string nombre, string apellido)
        {
            
            InitializeComponent();
            LabelDeBienvenida.Text = "Bienvenid@ " + nombre + " " + apellido;
        }


    }
}