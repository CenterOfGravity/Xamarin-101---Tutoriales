using System.Collections.Generic;
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
        XmlNodeList CountryNodeList, ProvinciasNodeList, ProvinciaNodeList; 
        public PrimeraPaginaView()
        {
            InitializeComponent();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(PrimeraPaginaView)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("App2.InfomacionEnXml.xml");
            xmlinfodataloaded.Load(stream);
            CountryNodeList = xmlinfodataloaded.GetElementsByTagName("País");

            List<string> countryNameDataList = new List<string>();
            foreach (XmlNode country in CountryNodeList)
            {
                countryNameDataList.Add(country.Attributes["label"].Value);
            }
            Picker_Country.ItemsSource = countryNameDataList;
        }

        private void Picker_Country_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            XmlElement CountryElements = (XmlElement)CountryNodeList[Picker_Country.SelectedIndex];
            ProvinciasNodeList = CountryElements.GetElementsByTagName("Provincias");
            XmlElement ProvinciasElements = (XmlElement)ProvinciasNodeList[0];
            ProvinciaNodeList = ProvinciasElements.GetElementsByTagName("provincia");

            List<string> ProvinciaNameDataList = new List<string>();
            foreach (XmlNode provincia in ProvinciaNodeList)
            {
                ProvinciaNameDataList.Add(provincia.InnerText);
            }
            Picker_Provincia.ItemsSource = ProvinciaNameDataList;
        }
    }
}