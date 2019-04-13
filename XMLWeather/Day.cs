using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, dayTemp, currentTemp, currentTime, condition, location, tempHigh, tempLow, 
            windSpeed, pressure, precipitation,humidity,icon;

        public Day()
        {
            date = dayTemp = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = pressure = precipitation = humidity = icon = "";
        }
    }
}
