using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimeraPaginaView : ContentPage
    {
        bool EstaElTiempoCorriendo;
        int incremento;
        Stopwatch cronometro = new Stopwatch();
        public PrimeraPaginaView()
        {
            InitializeComponent();
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            EstaElTiempoCorriendo = true;
            incremento = 1;

            cronometro.Restart();
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
                if ((int)cronometro.ElapsedMilliseconds >= 10000)
                {
                    incremento = 100000;
                }
                else if ((int)cronometro.ElapsedMilliseconds >= 5000)
                {
                    incremento = 1000;
                }

                ContadorAutomaticoLabel.Text = (Convert.ToInt64(ContadorAutomaticoLabel.Text) 
                                                                       + incremento).ToString();

              return EstaElTiempoCorriendo;
            });
        }

        private void Button_Released(object sender, EventArgs e)
        {
            EstaElTiempoCorriendo = false;
            cronometro.Stop();
        }
    }
}