using System.IO;
using System.Reflection;
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
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(PrimeraPaginaView)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("App2.CountryInfoInJson.json");
            string StreamReader = new StreamReader(stream).ReadToEnd();
            lbl_RawJsonData.Text = StreamReader;

        }
    }
}