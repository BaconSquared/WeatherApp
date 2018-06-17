using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WeatherApp
{
    public static class JSONParser
    {
        public static string Parse(string input)
        {
            string parsedInput = "";

            JObject joResponse = JObject.Parse(input);
            JObject ojObject = (JObject)joResponse["main"];
            JValue currentTemp = (JValue)ojObject["temp"];
            //Console.WriteLine(currentTemp);

            return Convert.ToString(currentTemp);
        }
    }
}
