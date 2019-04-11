using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            //TODO-add units
            date1.Text = Form1.days[1].date;
            minLabel.Text = Form1.days[1].tempLow;
            maxLabel.Text = Form1.days[1].tempHigh;
            avg1Label.Text = GetAverage(Form1.days[1].tempHigh, Form1.days[1].tempLow);
            condition1.Text = Form1.days[1].condition;
            precip1.Text = Form1.days[1].precipitation;
            pressure1.Text = Form1.days[1].pressure;
            humid1.Text = Form1.days[1].humidity;
    
            date2.Text = Form1.days[2].date;
            max2Label.Text = Form1.days[2].tempLow;
            max2Label.Text = Form1.days[2].tempHigh;
            avg2.Text = GetAverage(Form1.days[2].tempHigh, Form1.days[2].tempLow);
            condition2.Text = Form1.days[2].condition;
            precip2.Text = Form1.days[2].precipitation;
            pressure2.Text = Form1.days[2].pressure;
            humid2.Text = Form1.days[2].humidity;

            date3.Text = Form1.days[3].date;
            min3.Text = Form1.days[3].tempLow;
            max3.Text = Form1.days[3].tempHigh;
            avg3.Text = GetAverage(Form1.days[3].tempHigh, Form1.days[3].tempLow);
            condition3.Text = Form1.days[3].condition;
            precip3.Text = Form1.days[3].precipitation;
            pressure3.Text = Form1.days[3].pressure;
            humid3.Text = Form1.days[3].humidity;

            switch (Form1.days[1].icon)
            {
                case "800":
                    //put in sunny icon

                    break;
                //overcast icons
                case "801":
                    this.BackColor = Color.SlateGray;
                    break;
                case "802":

                    break;
                case "803":
                    break;
                case "804":

                    break;
                    //TODO - put the rest of te cases in for the rest of the conditions -- thoonder, snow
            }
            switch (Form1.days[2].icon)
            {
                case "800":
                    //put in sunny icon

                    break;
                //overcast icons
                case "801":
                    this.BackColor = Color.SlateGray;
                    break;
                case "802":

                    break;
                case "803":
                    break;
                case "804":

                    break;
                    //TODO - put the rest of te cases in for the rest of the conditions -- thoonder, snow
            }
            switch (Form1.days[3].icon)
            {
                case "800":
                    //put in sunny icon

                    break;
                //overcast icons
                case "801":
                    this.BackColor = Color.SlateGray;
                    break;
                case "802":

                    break;
                case "803":
                    break;
                case "804":

                    break;
                    //TODO - put the rest of te cases in for the rest of the conditions -- thoonder, snow
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        public string GetAverage(string min, string max)
        {
            int avg = 0;
            avg = (Convert.ToInt16(min) / Convert.ToInt16(max)) / 2;

            return Convert.ToString(avg);
        }
    }
}
