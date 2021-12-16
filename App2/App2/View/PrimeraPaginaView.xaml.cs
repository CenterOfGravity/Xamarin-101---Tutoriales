using System.IO;
using System.Reflection;
using System.Xml;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimeraPaginaView : ContentPage
    {
        XmlDocument xmlinfodataloaded = new XmlDocument();
        public PrimeraPaginaView()
        {
            InitializeComponent();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(PrimeraPaginaView)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("App2.InfomacionEnXml.xml");
            xmlinfodataloaded.Load(stream);
            lbl_RawXmlData.Text = xmlinfodataloaded.InnerXml;
        }


    }
}