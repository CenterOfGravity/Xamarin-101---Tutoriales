
using App2.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace App2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimeraPaginaView : ContentPage
    {
        PrimeraPaginaViewModel primerapaginaviewmodel = new PrimeraPaginaViewModel();

        public PrimeraPaginaView()
        {
            InitializeComponent();
        }

        private void ButtonSumar_Clicked(object sender, EventArgs e)
        {
            ResultadoLabel.Text =  primerapaginaviewmodel.Suma(NumeroA.Text, NumeroB.Text);
            SignoLabel.Text = "+";
        }

        private void ButtonRestar_Clicked(object sender, EventArgs e)
        {
            ResultadoLabel.Text = primerapaginaviewmodel.Resta(NumeroA.Text, NumeroB.Text);
            SignoLabel.Text = "-";
        }
    }
}