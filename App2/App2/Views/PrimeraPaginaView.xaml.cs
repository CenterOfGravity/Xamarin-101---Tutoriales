
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimeraPaginaView : ContentPage
    {
        bool EstaElTiempoCorriendo;
        int incremento;
        public PrimeraPaginaView()
        {
            InitializeComponent();
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            EstaElTiempoCorriendo = true;
            incremento = 1;
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
                ContadorAutomaticoLabel.Text = (Convert.ToInt64(ContadorAutomaticoLabel.Text) + incremento).ToString();
                return EstaElTiempoCorriendo;
            });
        }

        private void Button_Released(object sender, EventArgs e)
        {
            EstaElTiempoCorriendo = false;
        }
    }
}