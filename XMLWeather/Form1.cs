using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            
            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                Day d = new Day();
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");
                reader.ReadToFollowing("temperature");
                d.dayTemp = reader.GetAttribute("day");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");
                reader.ReadToFollowing("humidity");
                d.humidity = reader.GetAttribute("value");
                reader.ReadToFollowing("pressure");
                d.pressure = reader.GetAttribute("value");
                reader.ReadToFollowing("precipitation");
                d.precipitation = reader.GetAttribute("mode");
                reader.ReadToFollowing("weather");
                d.condition = reader.GetAttribute("value");
                d.icon = reader.GetAttribute("number");
                reader.ReadToFollowing("lastupdate");
                d.currentTime = reader.GetAttribute("value");

                
                    days.Add(d);
                
            }
            
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");
            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");
            reader.ReadToFollowing("humidity");
            days[0].humidity = reader.GetAttribute("value");
            reader.ReadToFollowing("pressure");
            days[0].pressure = reader.GetAttribute("value");
            reader.ReadToFollowing("precipitation");
            days[0].precipitation = reader.GetAttribute("mode");
            reader.ReadToFollowing("weather");
            days[0].condition = reader.GetAttribute("value");
            days[0].icon = reader.GetAttribute("number");
            reader.ReadToFollowing("lastupdate");
            days[0].currentTime = reader.GetAttribute("value");

        }


    }
}
