using App2.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimeraPaginaView : ContentPage
    {
        Dictionary<string, string[]> DictionaryCountryInfo = new Dictionary<string, string[]>();
        public PrimeraPaginaView()
        {
            InitializeComponent();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(PrimeraPaginaView)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("App2.CountryInfoInJson.json");
            var streamReader = new StreamReader(stream).ReadToEnd();
            List<CountryInfoClassModel>  DeserializeInfoList = JsonConvert.DeserializeObject<List<CountryInfoClassModel>>(streamReader);

            foreach(var info in DeserializeInfoList)
            {
                DictionaryCountryInfo.Add(info.nombre, info.provincias);
            }
            Picker_Country.ItemsSource = DictionaryCountryInfo.Keys.ToList();

        }

        private void Picker_Country_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Picker_Provincia.ItemsSource = DictionaryCountryInfo[Picker_Country.SelectedItem.ToString()].ToList();
        }
    }
}