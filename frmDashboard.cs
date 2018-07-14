using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace Prime_Movie_Project
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            int i = 50;
            pieChart1.HoverPushOut = 25;
            pieChart1.InnerRadius = 45;
            pieChart1.LegendLocation = LegendLocation.Bottom;

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    
                   // Title = "Chrome",
                    Values = new ChartValues<double> {8},
                   // PushOut = 15,
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Mozilla",
                    Values = new ChartValues<double> {6},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Opera",
                    Values = new ChartValues<double> {10},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Explorer",
                    Values = new ChartValues<double> {i},
                   DataLabels = true
                }
            };




            pieChart2.HoverPushOut = 25;
            pieChart2.InnerRadius = 60;
            pieChart2.LegendLocation = LegendLocation.Bottom;

            pieChart2.Series = new SeriesCollection
            {
                new PieSeries
                {
                    
                   // Title = "Chrome",
                    Values = new ChartValues<double> {8},
                   // PushOut = 15,
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Hollywood",
                    Values = new ChartValues<double> {6},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Chinese",
                    Values = new ChartValues<double> {10},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Korea",
                    Values = new ChartValues<double> {i},
                   DataLabels = true
                }
            };
        }


        //Line chart




        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
