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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("0.") + "°C";
            minLabel.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("0.") + "°C";
            maxLabel.Text = Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.") + "°C";
            humidLabel.Text = Form1.days[0].humidity + "%";
            pressureLabel.Text = Form1.days[0].pressure + " hPa";
            conditionLabel.Text = Form1.days[0].condition;
            dateLabel.Text = DateTime.Now.ToString("dd-MM-yy");
            date2Label.Text = "Today";
            timeLabel.Text  = DateTime.Now.ToString("hh:mm:ss"); 

            switch (Form1.days[0].icon)
            {
                case "800":
                    //put in sunny icon
                    this.BackColor = Color.SlateBlue;
                    label1.BackgroundImage = Properties.Resources.sunni;
                   break;
                    //overcast icons
                case "801":
                    this.BackColor = Color.SlateGray;
                    label1.BackgroundImage = Properties.Resources.cloudi;
                    break;
                case "802":
                    this.BackColor = Color.SlateGray;
                    label1.BackgroundImage = Properties.Resources.cloudi;
                    break;
                case "803":
                    this.BackColor = Color.SlateGray;
                    label1.BackgroundImage = Properties.Resources.cloudi;
                    break;
                case "804":
                    this.BackColor = Color.SlateGray;
                    label1.BackgroundImage = Properties.Resources.cloudi;
                    break;
                    //rainy icons
                case "300":
                    this.BackColor = Color.DarkCyan;
                    label1.BackgroundImage = Properties.Resources.raini;
                    break;
                case "301":
                    this.BackColor = Color.DarkCyan;
                    label1.BackgroundImage = Properties.Resources.raini;
                    break;
                case "302":
                    this.BackColor = Color.DarkCyan;
                    label1.BackgroundImage = Properties.Resources.raini;
                    break;
                case "310":
                    this.BackColor = Color.DarkCyan;
                    label1.BackgroundImage = Properties.Resources.raini;
                    break;
                case "311":
                    this.BackColor = Color.DarkCyan;
                    label1.BackgroundImage = Properties.Resources.raini;
                    break;
                case "312":
                    this.BackColor = Color.DarkCyan;
                    label1.BackgroundImage = Properties.Resources.raini;
                    break;
                case "313":
                    this.BackColor = Color.DarkCyan;
                    label1.BackgroundImage = Properties.Resources.raini;
                    break;
                case "314":
                    this.BackColor = Color.DarkCyan;
                    label1.BackgroundImage = Properties.Resources.raini;
                    break;
                case "321":
                    this.BackColor = Color.DarkCyan;
                    label1.BackgroundImage = Properties.Resources.raini;
                    break;


            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
