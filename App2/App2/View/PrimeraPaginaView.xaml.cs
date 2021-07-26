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
    public partial class PrimeraPaginaView : ContentPage
    {
        public PrimeraPaginaView()
        {
            InitializeComponent();
        }

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            string nombre = EntryParaNombre.Text;
            string apellido = EntryParaApellido.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new SegundaPaginaView(nombre, apellido));
        }
    }
}