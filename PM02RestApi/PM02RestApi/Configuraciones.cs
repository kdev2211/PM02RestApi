using System;
using System.Collections.Generic;
using System.Text;

namespace PM02RestApi
{
    class Configuraciones
    {
        public const String IDFoursquare = "V1YNV3P2YKPF0D2PIO1XH4XQUMWK3NJ5IUAU2TSPB2MU4I1E";
        public const String SecreteFoursquare = "0RWJS2JTDM45ZUE0YPSRAYWINLGJTX4ZMOS2P1OCQWWHMNGY";
       public  const String apifoursquare = "https://api.foursquare.com/v2/venues/search?ll={0},{1}&client_id={2}&client_secret={3}&v={4}";
    }

    public class Sitios
    {
        public static String getUrl(Double latitud, Double longitud)
        {
            return String.Format(Configuraciones.apifoursquare, latitud, longitud, Configuraciones.IDFoursquare, Configuraciones.SecreteFoursquare, DateTime.Now.ToString("yyyyMMdd"));
        }
    }
}
