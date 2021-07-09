using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace PM02RestApi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountryPage : ContentPage
    {
        public CountryPage(String Bandera, String nombre, String capital, IList<double> Latlng, int poblacion, String region, IList<String> codigo)
        {
            InitializeComponent();
            double val1 = Latlng[0];
            double val2 = Latlng[1];

            String cod = codigo[0];

            Pin ubicacion = new Pin();
            ubicacion.Label = nombre;
            ubicacion.Position = new Position(val1, val2);
            mapas.Pins.Add(ubicacion);




            mapas.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(val1, val2), Distance.FromKilometers(2000)));


       
            poblacionPais.Text = poblacion.ToString();

            regionPais.Text = region.ToString();

            capitalPais.Text = capital;
            codigoPais.Text = cod;
        }
    }
}