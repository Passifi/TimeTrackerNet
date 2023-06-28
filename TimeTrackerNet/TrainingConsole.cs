using CodeFirstTrials.Data;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTrackerNet.Models;

namespace TimeTrackerNet
{
    public partial class TrainingConsole : Form
    {
        TrainingContext context;
        public TrainingConsole()
        {
            InitializeComponent();
            context = new TrainingContext();
            CreatePlotData();
        }

        private void CreatePlotData()
        {
            
            List<double> years = new();
            List<List<double>> values = new();
            var data = context.cardios.Select(d => new { d.Date, d.Duration,d.Distance,d.AverageHeartRate }).OrderBy(d => d.Date);

            if (data.Count() == 0)
            {
                MessageBox.Show("No data for this skill!");
                return;
            }
            
            List<double> durations = new();
            List<double> distances = new();
            List<double> avgHearts = new();
            foreach (var d in data)
            {

                years.Add((double)d.Date.ToOADate());
                durations.Add(d.Duration);
                distances.Add(d.Distance);
                avgHearts.Add(d.AverageHeartRate);

            }
            values.Add(durations);
            values.Add(distances);
            values.Add(avgHearts);
            String[] names = new string[] {
                "Duration", "Distance", "Avg. Heartrate"
            };
            plot.Reset();
            Color[] colors = { Color.Brown, Color.BlueViolet, Color.Blue, Color.Red };
            for(int i =0; i < values.Count; i++)
            {
                plot.Plot.AddScatter(years.ToArray(), values[i].ToArray(), colors[i],label:names[i]);
            }
                plot.Plot.XAxis.DateTimeFormat(true);

            plot.Plot.XLabel("Date");
            plot.Plot.YLabel("Length of run");
            plot.Plot.SetAxisLimits(yMin: 0);
            plot.Plot.Legend();
            plot.Refresh();
        }

        private void intervalmin_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void exercise_lbl_Click(object sender, EventArgs e)
        {

        }

        private void weather_lbl_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            double duration, avg, distance;
            bool checkValues = double.TryParse(duration_txt.Text, out duration);
            checkValues &= double.TryParse(avgheartrate_txt.Text, out avg);
            checkValues &= double.TryParse(distance_txt.Text, out distance);

            if(!checkValues)
            {
                MessageBox.Show("Please enter in proper Values in the fields Duration, avg Heart and/ or distance. These have to be floating point numbers!");
                return;
            }
            Cardio cardio = new Cardio
            {
                Exercise = exercise_txt.Text,
                Date = date_picker.Value,
                Duration = duration,
                AverageHeartRate = avg,
                Distance = distance,
                Comments = comment_txt.Text,
                Weather = weather_txt.Text,


            };
            context.cardios.Add(cardio);
            context.SaveChanges();
            exercise_txt.Text = "";
            duration_txt.Text = "";
            distance_txt.Text = "";
            avgheartrate_txt.Text = "";
            comment_txt.Text = "";
            weather_txt.Text = "";

        }
    }
}
