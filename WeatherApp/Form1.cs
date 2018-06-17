using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeatherApp : Form
    {
        public WeatherApp()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient();

            client.urlParameters = "?q=" + cityTextBox.Text + "&units=Imperial&APPID=a2c2178747622ea7bca42ae200eb9fc3";

            string response = client.MakeRequest();

            string parsedOutput = JSONParser.Parse(response);

            weatherInfoTextBox.Text += "The current temperature in " + cityTextBox.Text + " is " + parsedOutput + " deg F.";
            weatherInfoTextBox.Text += Environment.NewLine;
        }
    }
}
