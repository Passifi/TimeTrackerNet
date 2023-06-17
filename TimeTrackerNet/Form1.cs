using Microsoft.EntityFrameworkCore;
using ScottPlot;
using System.Security;
using TimeTrackerNet.Models;

namespace TimeTrackerNet
{
    public partial class MainWindow : Form
    {
        List<string> skillNames;
        ProgressTrackerContext progressTrackerContext;
        public MainWindow()
        {
            skillNames = new List<string> {"Coding","Chess","Photoshop", "Animation", "Drawing", "Illustrator", "Japanese", "Chinese", "Electronics", "Soccer", "ZoneTwoCardio", "ResistanceTraining", "Spanish", "Philosophy", "Go", "GameDev", "Composing", "Singing", "Guitar", "Piano", "YouTubeChannel", "Blender", "Berufsschule", "AI", "AudioProgramming" };


            progressTrackerContext = new ProgressTrackerContext();
           
           
            InitializeComponent();
            dateSelection.Value = DateTime.Now;
            skillSelection_dropdown.Items.AddRange(skillNames.ToArray());
           

            plot.Refresh();
        }

        private void category_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UpdatePlot(string skillName)
        {
            var data = progressTrackerContext.TimeTracking.Where(s => s.Skill == skillName).Select(s=>new {s.Date ,s.duration}).GroupBy(s=>s.Date);
            List<double> years = new();
            List<double> durations = new();

            foreach(var d in data)
            {
                
                years.Add((double)d.Key.Value.ToOADate());
                durations.Add((double)d.Select(d=>d.duration).Sum());

            }
            plot.Reset();
            plot.Plot.AddScatter(years.ToArray(),durations.ToArray());
            plot.Plot.XAxis.DateTimeFormat(true);
            plot.Plot.XLabel("Date");
            plot.Plot.YLabel("Minutes Spent");
            plot.Plot.SetAxisLimits(yMin: 0);
            plot.Refresh();

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            var newData = new TimeTracking { Category = category_txt.Text, Skill = skillSelection_dropdown.Text, duration = Convert.ToInt32(duration_txt.Text), Date = dateSelection.Value };
            progressTrackerContext.TimeTracking.Add(newData);
            progressTrackerContext.SaveChanges();
            category_txt.Text = "";
            duration_txt.Text = "";

            
        }

        private void UpdateGraph(object sender, EventArgs e)
        {
            UpdatePlot(skillSelection_dropdown.Text);
        }
    }
}