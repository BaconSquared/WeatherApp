using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;

namespace WeatherLibrary
{
    public class RestClient
    {
        public string urlParameters { get; set; }

        private const string URL = "http://api.openweathermap.org/data/2.5/weather";
        //private string urlParameters = "?city=Chicago,IL&key={d2c76b397d434982aa94ea9182d5dd66}";

        public RestClient()
        {
            urlParameters = "";
        }

        public string MakeRequest()
        {
            WebClient client = new WebClient();
            Stream data = client.OpenRead(URL);

            StreamReader reader = new StreamReader(data);

            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();

            return s;
        }

    }
}
