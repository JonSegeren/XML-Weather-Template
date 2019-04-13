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
      
       
            date1.Text = Form1.days[0].date;
            minLabel.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("0.") + "°C";
            maxLabel.Text = Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.") + "°C";
            avg1Label.Text = Convert.ToDouble(Form1.days[0].dayTemp).ToString("0.") + "°C";
            condition1.Text = Form1.days[0].condition;
            precip1.Text = Form1.days[0].precipitation;
            humid1.Text = Form1.days[0].humidity + "%" ;
    

            ///these days have an out of index error, can't appear to fix it
            ///
            date2.Text = Form1.days[1].date;
            max2Label.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("0.") + "°C";
            max2Label.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("0.") + "°C";
            avg1Label.Text = Convert.ToDouble(Form1.days[1].dayTemp).ToString("0.") + "°C";
            condition2.Text = Form1.days[1].condition;
            precip2.Text = Form1.days[1].precipitation;
            humid2.Text = Form1.days[1].humidity + "%";

            date3.Text = Form1.days[2].date;
            min3.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("0.") + "°C";
            max3.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("0.") + "°C";
            avg1Label.Text = Convert.ToDouble(Form1.days[2].dayTemp).ToString("0.") + "°C";
            condition3.Text = Form1.days[2].condition;
            precip3.Text = Form1.days[2].precipitation;
            humid3.Text = Form1.days[2].humidity + "%";

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


   
    }
}
