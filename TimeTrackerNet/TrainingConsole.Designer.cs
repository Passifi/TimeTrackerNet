namespace TimeTrackerNet
{
    partial class TrainingConsole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.distance_txt = new System.Windows.Forms.TextBox();
            this.exercise_lbl = new System.Windows.Forms.Label();
            this.duration_lbl = new System.Windows.Forms.Label();
            this.distance_lbl = new System.Windows.Forms.Label();
            this.heartrate_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.weather_lbl = new System.Windows.Forms.Label();
            this.comment_lbl = new System.Windows.Forms.Label();
            this.duration_txt = new System.Windows.Forms.TextBox();
            this.exercise_txt = new System.Windows.Forms.TextBox();
            this.avgheartrate_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.weather_txt = new System.Windows.Forms.TextBox();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.comment_txt = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(574, 152);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(733, 346);
            this.formsPlot1.TabIndex = 1;
            // 
            // distance_txt
            // 
            this.distance_txt.Location = new System.Drawing.Point(28, 140);
            this.distance_txt.Name = "distance_txt";
            this.distance_txt.Size = new System.Drawing.Size(222, 23);
            this.distance_txt.TabIndex = 0;
            // 
            // exercise_lbl
            // 
            this.exercise_lbl.AutoSize = true;
            this.exercise_lbl.Location = new System.Drawing.Point(28, 34);
            this.exercise_lbl.Name = "exercise_lbl";
            this.exercise_lbl.Size = new System.Drawing.Size(49, 15);
            this.exercise_lbl.TabIndex = 1;
            this.exercise_lbl.Text = "Exercise";
            // 
            // duration_lbl
            // 
            this.duration_lbl.AutoSize = true;
            this.duration_lbl.Location = new System.Drawing.Point(28, 78);
            this.duration_lbl.Name = "duration_lbl";
            this.duration_lbl.Size = new System.Drawing.Size(53, 15);
            this.duration_lbl.TabIndex = 2;
            this.duration_lbl.Text = "Duration";
            // 
            // distance_lbl
            // 
            this.distance_lbl.AutoSize = true;
            this.distance_lbl.Location = new System.Drawing.Point(29, 122);
            this.distance_lbl.Name = "distance_lbl";
            this.distance_lbl.Size = new System.Drawing.Size(52, 15);
            this.distance_lbl.TabIndex = 3;
            this.distance_lbl.Text = "Distance";
            // 
            // heartrate_lbl
            // 
            this.heartrate_lbl.AutoSize = true;
            this.heartrate_lbl.Location = new System.Drawing.Point(28, 166);
            this.heartrate_lbl.Name = "heartrate_lbl";
            this.heartrate_lbl.Size = new System.Drawing.Size(102, 15);
            this.heartrate_lbl.TabIndex = 4;
            this.heartrate_lbl.Text = "Average Heartrate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date";
            // 
            // weather_lbl
            // 
            this.weather_lbl.AutoSize = true;
            this.weather_lbl.Location = new System.Drawing.Point(28, 254);
            this.weather_lbl.Name = "weather_lbl";
            this.weather_lbl.Size = new System.Drawing.Size(51, 15);
            this.weather_lbl.TabIndex = 6;
            this.weather_lbl.Text = "Weather";
            this.weather_lbl.Click += new System.EventHandler(this.weather_lbl_Click);
            // 
            // comment_lbl
            // 
            this.comment_lbl.AutoSize = true;
            this.comment_lbl.Location = new System.Drawing.Point(28, 298);
            this.comment_lbl.Name = "comment_lbl";
            this.comment_lbl.Size = new System.Drawing.Size(66, 15);
            this.comment_lbl.TabIndex = 7;
            this.comment_lbl.Text = "Comments";
            // 
            // duration_txt
            // 
            this.duration_txt.Location = new System.Drawing.Point(29, 96);
            this.duration_txt.Name = "duration_txt";
            this.duration_txt.Size = new System.Drawing.Size(222, 23);
            this.duration_txt.TabIndex = 8;
            // 
            // exercise_txt
            // 
            this.exercise_txt.Location = new System.Drawing.Point(29, 52);
            this.exercise_txt.Name = "exercise_txt";
            this.exercise_txt.Size = new System.Drawing.Size(222, 23);
            this.exercise_txt.TabIndex = 9;
            // 
            // avgheartrate_txt
            // 
            this.avgheartrate_txt.Location = new System.Drawing.Point(28, 184);
            this.avgheartrate_txt.Name = "avgheartrate_txt";
            this.avgheartrate_txt.Size = new System.Drawing.Size(222, 23);
            this.avgheartrate_txt.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.save_btn);
            this.panel1.Controls.Add(this.comment_txt);
            this.panel1.Controls.Add(this.date_picker);
            this.panel1.Controls.Add(this.weather_txt);
            this.panel1.Controls.Add(this.avgheartrate_txt);
            this.panel1.Controls.Add(this.exercise_txt);
            this.panel1.Controls.Add(this.duration_txt);
            this.panel1.Controls.Add(this.comment_lbl);
            this.panel1.Controls.Add(this.weather_lbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.heartrate_lbl);
            this.panel1.Controls.Add(this.distance_lbl);
            this.panel1.Controls.Add(this.duration_lbl);
            this.panel1.Controls.Add(this.exercise_lbl);
            this.panel1.Controls.Add(this.distance_txt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 474);
            this.panel1.TabIndex = 0;
            // 
            // weather_txt
            // 
            this.weather_txt.Location = new System.Drawing.Point(28, 272);
            this.weather_txt.Name = "weather_txt";
            this.weather_txt.Size = new System.Drawing.Size(222, 23);
            this.weather_txt.TabIndex = 11;
            // 
            // date_picker
            // 
            this.date_picker.Location = new System.Drawing.Point(28, 228);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(222, 23);
            this.date_picker.TabIndex = 12;
            // 
            // comment_txt
            // 
            this.comment_txt.Location = new System.Drawing.Point(28, 316);
            this.comment_txt.Multiline = true;
            this.comment_txt.Name = "comment_txt";
            this.comment_txt.Size = new System.Drawing.Size(222, 74);
            this.comment_txt.TabIndex = 13;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(394, 423);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 14;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // TrainingConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 498);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.panel1);
            this.Name = "TrainingConsole";
            this.Text = "Training";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ScottPlot.FormsPlot formsPlot1;
        private TextBox distance_txt;
        private Label exercise_lbl;
        private Label duration_lbl;
        private Label distance_lbl;
        private Label heartrate_lbl;
        private Label label5;
        private Label weather_lbl;
        private Label comment_lbl;
        private TextBox duration_txt;
        private TextBox exercise_txt;
        private TextBox avgheartrate_txt;
        private Panel panel1;
        private TextBox comment_txt;
        private DateTimePicker date_picker;
        private TextBox weather_txt;
        private Button save_btn;
    }
}