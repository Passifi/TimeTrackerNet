using CodeFirstTrials.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using ScottPlot;
using System.Security;
using TimeTrackerNet.Models;

namespace TimeTrackerNet
{
    public partial class MainWindow : Form
    {
        const string neutralTime = "00:00:00";
        TimeSpan passedTime;
        List<string> skillNames;
        ProgressTrackerContext progressTrackerContext;
        TrainingContext trainingContext;
        DateTime currentTime;
        DateTime startTime;
        public MainWindow()
        {
            skillNames = new List<string> {"Coding","Chess","Photoshop", "Animation", "Drawing", "Illustrator", "Japanese", "Chinese", "Electronics", "Soccer", "ZoneTwoCardio", "ResistanceTraining", "Spanish", "Philosophy", "Go", "GameDev", "Composing", "Singing", "Guitar", "Piano", "YouTubeChannel", "Blender", "Berufsschule", "AI", "AudioProgramming" };

            trainingContext = new TrainingContext();
            progressTrackerContext = new ProgressTrackerContext();

            passedTime = DateTime.Now - DateTime.Now;
            InitializeComponent();
            dateSelection.Value = DateTime.Now;
            skillSelection_dropdown.Items.AddRange(skillNames.ToArray());

            timer1.Interval = 100;
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
            if(data.Count() == 0)
            {
                MessageBox.Show("No data for this skill!");
                return;
            }
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
            int durationPared;
            bool tryparse = int.TryParse(duration_txt.Text, out durationPared);
            if (!tryparse) 
            {
                MessageBox.Show("Duration is not a proper integer Value");
                return;
            }
            var newData = new TimeTracking { Category = category_txt.Text, Skill = skillSelection_dropdown.Text, duration = Convert.ToInt32(duration_txt.Text), Date = dateSelection.Value };
            progressTrackerContext.TimeTracking.Add(newData);
            progressTrackerContext.SaveChanges();
            category_txt.Text = "";
            duration_txt.Text = "";
            var totalTime = progressTrackerContext.TimeTracking.Where(p => p.Date.Value.Date == DateTime.Now.Date).Select(p => p.duration);
            if(totalTime.Count() > 0 )
                errorHandler_txt.Text = $"Total amount of skill learning today! {totalTime.ToList().Sum()}";



        }

        private void UpdateGraph(object sender, EventArgs e)
        {
            UpdatePlot(skillSelection_dropdown.Text);
            try
            {
                var total = progressTrackerContext.TimeTracking.Where(el => el.Skill == skillSelection_dropdown.Text).Select(el => el.duration).ToList().Sum();
                errorHandler_txt.Text = $"Lifetime total time spent with this skill: {total} minutes!";
            }
            catch(Exception exception)
            {
                errorHandler_txt.Text = exception.Message;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now;
            TimeSpan timeDelta = currentTime - startTime;
            timeDelta += passedTime;
            int hours = timeDelta.Hours;
            int minutes = timeDelta.Minutes;
            int seconds = timeDelta.Seconds;
            int milliseconds = (int)(timeDelta.Milliseconds / 10.0);
            if(hours > 0)
            {
                timeDisplay_txt.Text = $"{hours.ToString("D2")}:{minutes.ToString("D2")}:{seconds.ToString("D2")}";
            }
            else 
            {
                timeDisplay_txt.Text = $"{minutes.ToString("D2")}:{seconds.ToString("D2")}:{milliseconds.ToString("D2")}";
            }


        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                
                timer1.Start();
                startTime = DateTime.Now;
                play_btn.Text = "Pause";

            }
            else 
            {
                currentTime = DateTime.Now;
                passedTime = currentTime - startTime + passedTime;

                timer1.Stop();
                play_btn.Text = "Continue";
            }
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            currentTime = DateTime.Now;
            passedTime = currentTime - startTime + passedTime;
            int newDuration = (int)passedTime.TotalMinutes;
            duration_txt.Text = Math.Round((double)newDuration).ToString();
            timer1.Stop();
            play_btn.Text = "Play";
            passedTime = DateTime.Now - DateTime.Now;
            timeDisplay_txt.Text = neutralTime;


        }
    }
}