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
            humid1.Text = Form1.days[1].humidity;
    
            date2.Text = Form1.days[2].date;
            max2Label.Text = Form1.days[2].tempLow;
            max2Label.Text = Form1.days[2].tempHigh;
            avg2.Text = GetAverage(Form1.days[2].tempHigh, Form1.days[2].tempLow);
            condition2.Text = Form1.days[2].condition;
            precip2.Text = Form1.days[2].precipitation;
            humid2.Text = Form1.days[2].humidity;

            date3.Text = Form1.days[3].date;
            min3.Text = Form1.days[3].tempLow;
            max3.Text = Form1.days[3].tempHigh;
            avg3.Text = GetAverage(Form1.days[3].tempHigh, Form1.days[3].tempLow);
            condition3.Text = Form1.days[3].condition;
            precip3.Text = Form1.days[3].precipitation;
            humid3.Text = Form1.days[3].humidity;

            dateLabel.Text = DateTime.Now.ToString("dd-MM-yy");
 
            timeLabel.Text = DateTime.Now.ToString("hh:mm:ss");

            switch (Form1.days[1].icon)
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
            switch (Form1.days[2].icon)
            {
                case "800":
                    //put in sunny icon
                    label2.BackgroundImage = Properties.Resources.sunni;
                    break;
                //overcast icons
                case "801":
                    label2.BackgroundImage = Properties.Resources.cloudi;
                    break;
                case "802":
                    label2.BackgroundImage = Properties.Resources.cloudi;
                    break;
                case "803":
                    label2.BackgroundImage = Properties.Resources.cloudi;
                    break;
                case "804":
                    label2.BackgroundImage = Properties.Resources.cloudi;
                    break;
                case "300":
                    label2.BackgroundImage = Properties.Resources.raini;
                    break;
                case "301":
                    label2.BackgroundImage = Properties.Resources.raini;
                    break;
                case "302":
                    label2.BackgroundImage = Properties.Resources.raini;
                    break;
                case "310":
                    label2.BackgroundImage = Properties.Resources.raini;
                    break;
                case "311":
                    label2.BackgroundImage = Properties.Resources.raini;
                    break;
                case "312":
                    label2.BackgroundImage = Properties.Resources.raini;
                    break;
                case "313":
                    label2.BackgroundImage = Properties.Resources.raini;
                    break;
                case "314":
                    label2.BackgroundImage = Properties.Resources.raini;
                    break;
                case "321":
                    label2.BackgroundImage = Properties.Resources.raini;
                    break;

            }
            switch (Form1.days[3].icon)
            {
                case "800":
                    //put in sunny icon
                    label3.BackgroundImage = Properties.Resources.sunni;
                    break;
                //overcast icons
                case "801":
                    label3.BackgroundImage = Properties.Resources.cloudi;
                    break;
                case "802":
                    label3.BackgroundImage = Properties.Resources.cloudi;
                    break;
                case "803":
                    label3.BackgroundImage = Properties.Resources.cloudi;
                    break;
                case "804":
                    label3.BackgroundImage = Properties.Resources.cloudi;
                    break;
                case "300":
                    label3.BackgroundImage = Properties.Resources.raini;
                    break;
                case "301":
                    label3.BackgroundImage = Properties.Resources.raini;
                    break;
                case "302":
                    label3.BackgroundImage = Properties.Resources.raini;
                    break;
                case "310":
                    label3.BackgroundImage = Properties.Resources.raini;
                    break;
                case "311":
                    label3.BackgroundImage = Properties.Resources.raini;
                    break;
                case "312":
                    label3.BackgroundImage = Properties.Resources.raini;
                    break;
                case "313":
                    label3.BackgroundImage = Properties.Resources.raini;
                    break;
                case "314":
                    label3.BackgroundImage = Properties.Resources.raini;
                    break;
                case "321":
                    label3.BackgroundImage = Properties.Resources.raini;
                    break;

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
