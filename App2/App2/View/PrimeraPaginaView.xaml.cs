using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;
using App2.Models;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimeraPaginaView : ContentPage
    {
        XmlNodeList CountryNodeList, ProvinciasNodeList, ProvinciaNodeList; 
        public PrimeraPaginaView()
        {
            InitializeComponent();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(PrimeraPaginaView)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("App2.InformacionEnJson.json");
            InformacionDePaisesClassModel Informacion;
            string ReadData;
            using (var streamReader = new StreamReader(stream))
            {
                ReadData = streamReader.ReadToEnd();
            }
             Informacion = JsonConvert.DeserializeObject<InformacionDePaisesClassModel>(ReadData);

            name.Text = Informacion.PaisesInfo.ToString();
            //List<string> countryNameDataList = new List<string>();
            foreach (var info in Informacion.PaisesInfo)
            {
             //   countryNameDataList.Add(country.Attributes["label"].Value);
            }
      //      Picker_Country.ItemsSource = countryNameDataList;
        }

        private void Picker_Country_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //XmlElement CountryElements = (XmlElement)CountryNodeList[Picker_Country.SelectedIndex];
            //ProvinciasNodeList = CountryElements.GetElementsByTagName("Provincias");
            //XmlElement ProvinciasElements = (XmlElement)ProvinciasNodeList[0];
            //ProvinciaNodeList = ProvinciasElements.GetElementsByTagName("provincia");

            //List<string> ProvinciaNameDataList = new List<string>();
            //foreach (XmlNode provincia in ProvinciaNodeList)
            //{
            //    ProvinciaNameDataList.Add(provincia.InnerText);
            //}
            //Picker_Provincia.ItemsSource = ProvinciaNameDataList;
        }
    }
}