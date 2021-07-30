using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
namespace App2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimeraPaginaView : ContentPage
    {
        public PrimeraPaginaView()
        {
            InitializeComponent();
            EntryParaNombre.Text = Preferences.Get("NombreGuardado","");
            EntryParaApellido.Text = Preferences.Get("ApellidoGuardado", "");
            RememberMeSwith.IsToggled = Preferences.Get("RememberMeSwithState", false);
        }

        private void RememberMeSwith_Toggled(object sender, ToggledEventArgs e)
        {
          if(RememberMeSwith.IsToggled == true)
          {
                Preferences.Set("NombreGuardado", EntryParaNombre.Text);
                Preferences.Set("ApellidoGuardado", EntryParaApellido.Text);
                Preferences.Set("RememberMeSwithState", RememberMeSwith.IsToggled);
                RememberMeSwith.ThumbColor = Color.Blue;
                RememberMeSwith.OnColor = Color.SkyBlue;
            }
          else
          {
                Preferences.Remove("NombreGuardado");
                Preferences.Remove("ApellidoGuardado");
                Preferences.Remove("RememberMeSwithState");
                RememberMeSwith.ThumbColor = Color.Gray;
            }
        }
    }
}