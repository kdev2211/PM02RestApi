using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using static PM02RestApi.Countries;
using PM02RestApi;

namespace PM02RestApi
{
    
    
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Cpicker.Items.Add("AMERICA");
            Cpicker.Items.Add("AFRICA");
            Cpicker.Items.Add("EUROPA");
            Cpicker.Items.Add("ASIA");
            Cpicker.Items.Add("OCEANIA");

        
           
        }
        CountriesREst itemPais = new CountriesREst();





        private async void itemSlct(object sender, EventArgs e)
        {


            var name = Cpicker.Items[Cpicker.SelectedIndex];
            var value = (String)name;

            switch(value)
            {
                case "AMERICA":

                    var url = "https://restcountries.eu/rest/v2/region/americas";
                    using (HttpClient cliente = new HttpClient())
                    {


                        var Respuesta = await cliente.GetAsync(url);

                 

                        if (Respuesta.IsSuccessStatusCode)
                        {
                            var json = Respuesta.Content.ReadAsStringAsync().Result;
                    

                            var Paises = JsonConvert.DeserializeObject<List<CountriesREst>>(json);
                            ListViewPaises.ItemsSource = Paises;
                        }




                    }

                    break;

                case "AFRICA":

                    var url2 = "https://restcountries.eu/rest/v2/region/africa";
                    using (HttpClient cliente = new HttpClient())
                    {


                        var Respuesta = await cliente.GetAsync(url2);

                        if (Respuesta.IsSuccessStatusCode)
                        {
                            var json = Respuesta.Content.ReadAsStringAsync().Result;
               

                            var Paises = JsonConvert.DeserializeObject<List<CountriesREst>>(json);
                            ListViewPaises.ItemsSource = Paises;
                        }




                    }
                    break;

                case "EUROPA":

                    var url3 = "https://restcountries.eu/rest/v2/region/europe";
                    using (HttpClient cliente = new HttpClient())
                    {


                        var Respuesta = await cliente.GetAsync(url3);

                        if (Respuesta.IsSuccessStatusCode)
                        {
                            var json = Respuesta.Content.ReadAsStringAsync().Result;
        

                            var Paises = JsonConvert.DeserializeObject<List<CountriesREst>>(json);
                            ListViewPaises.ItemsSource = Paises;
                        }




                    }
                    break;

                case "ASIA":

                    var url4 = "https://restcountries.eu/rest/v2/region/asia";
                    using (HttpClient cliente = new HttpClient())
                    {


                        var Respuesta = await cliente.GetAsync(url4);

                        if (Respuesta.IsSuccessStatusCode)
                        {
                            var json = Respuesta.Content.ReadAsStringAsync().Result;
                

                            var Paises = JsonConvert.DeserializeObject<List<CountriesREst>>(json);
                            ListViewPaises.ItemsSource = Paises;
                        }




                    }
                    break;


                case "OCEANIA":

                    var url5 = "https://restcountries.eu/rest/v2/region/oceania";
                    using (HttpClient cliente = new HttpClient())
                    {


                        var Respuesta = await cliente.GetAsync(url5);

                        if (Respuesta.IsSuccessStatusCode)
                        {
                            var json = Respuesta.Content.ReadAsStringAsync().Result;
                 

                            var Paises = JsonConvert.DeserializeObject<List<CountriesREst>>(json);

                            ListViewPaises.ItemsSource = Paises;
                        }




                    }
                    break;
                default:
                    Console.WriteLine("You did not select a valid option.");
                    break;
            }
        }


        private async void ListaPaises_ItemTapped(object sender, ItemTappedEventArgs e)
        {


            itemPais = (CountriesREst)e.Item;


            String flagPais = itemPais.flag;
            String nombrePais = itemPais.name;
            String capitalPais = itemPais.capital;
            IList<Double> latlngPais = itemPais.latlng;
            int poblacionPais = itemPais.population;
            String regionPais = itemPais.region;
            IList<String> codigoPais = itemPais.callingCodes;
            await Navigation.PushAsync(new CountryPage(flagPais, nombrePais, capitalPais, latlngPais, poblacionPais, regionPais, codigoPais));

        }
    }
}
