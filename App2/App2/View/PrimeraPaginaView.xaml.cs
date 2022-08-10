using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        Dictionary<string, string[]> CountryInfoDictionary = new Dictionary<string, string[]>();
        public PrimeraPaginaView()
        {
            InitializeComponent();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(PrimeraPaginaView)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("App2.CountryInfoInJson.json");
            var streamReader = new StreamReader(stream).ReadToEnd();       
            
            List<CountryInfoClassModel> DeserializeInfoList = JsonConvert.DeserializeObject< List<CountryInfoClassModel>>(streamReader);
            foreach (var info in DeserializeInfoList)
            {
                CountryInfoDictionary.Add(info.nombre, info.provincias);
            }
            Picker_Country.ItemsSource = CountryInfoDictionary.Keys.ToList();
        }

        private void Picker_Country_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           Picker_Provincia.ItemsSource = CountryInfoDictionary[Picker_Country.SelectedItem.ToString()].ToList();
        }
    }
}