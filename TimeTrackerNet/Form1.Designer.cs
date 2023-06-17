﻿namespace TimeTrackerNet
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataEntry_pnl = new System.Windows.Forms.Panel();
            this.save_btn = new System.Windows.Forms.Button();
            this.skillSelection_dropdown = new System.Windows.Forms.ComboBox();
            this.duration_txt = new System.Windows.Forms.TextBox();
            this.category_txt = new System.Windows.Forms.TextBox();
            this.duration_lbl = new System.Windows.Forms.Label();
            this.category_lbl = new System.Windows.Forms.Label();
            this.skill_lbl = new System.Windows.Forms.Label();
            this.errorHandler_txt = new System.Windows.Forms.TextBox();
            this.timeTrackingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progressTrackerContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plot = new ScottPlot.FormsPlot();
            this.button1 = new System.Windows.Forms.Button();
            this.dateSelection = new System.Windows.Forms.DateTimePicker();
            this.dataEntry_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressTrackerContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataEntry_pnl
            // 
            this.dataEntry_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEntry_pnl.Controls.Add(this.dateSelection);
            this.dataEntry_pnl.Controls.Add(this.save_btn);
            this.dataEntry_pnl.Controls.Add(this.skillSelection_dropdown);
            this.dataEntry_pnl.Controls.Add(this.duration_txt);
            this.dataEntry_pnl.Controls.Add(this.category_txt);
            this.dataEntry_pnl.Controls.Add(this.duration_lbl);
            this.dataEntry_pnl.Controls.Add(this.category_lbl);
            this.dataEntry_pnl.Controls.Add(this.skill_lbl);
            this.dataEntry_pnl.Location = new System.Drawing.Point(12, 12);
            this.dataEntry_pnl.Name = "dataEntry_pnl";
            this.dataEntry_pnl.Size = new System.Drawing.Size(268, 178);
            this.dataEntry_pnl.TabIndex = 0;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(178, 131);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // skillSelection_dropdown
            // 
            this.skillSelection_dropdown.FormattingEnabled = true;
            this.skillSelection_dropdown.Location = new System.Drawing.Point(72, 15);
            this.skillSelection_dropdown.Name = "skillSelection_dropdown";
            this.skillSelection_dropdown.Size = new System.Drawing.Size(181, 23);
            this.skillSelection_dropdown.TabIndex = 1;
            // 
            // duration_txt
            // 
            this.duration_txt.Location = new System.Drawing.Point(72, 73);
            this.duration_txt.Name = "duration_txt";
            this.duration_txt.Size = new System.Drawing.Size(181, 23);
            this.duration_txt.TabIndex = 3;
            // 
            // category_txt
            // 
            this.category_txt.Location = new System.Drawing.Point(72, 44);
            this.category_txt.Name = "category_txt";
            this.category_txt.Size = new System.Drawing.Size(181, 23);
            this.category_txt.TabIndex = 2;
            this.category_txt.TextChanged += new System.EventHandler(this.category_txt_TextChanged);
            // 
            // duration_lbl
            // 
            this.duration_lbl.AutoSize = true;
            this.duration_lbl.Location = new System.Drawing.Point(13, 76);
            this.duration_lbl.Name = "duration_lbl";
            this.duration_lbl.Size = new System.Drawing.Size(53, 15);
            this.duration_lbl.TabIndex = 3;
            this.duration_lbl.Text = "Duration";
            // 
            // category_lbl
            // 
            this.category_lbl.AutoSize = true;
            this.category_lbl.Location = new System.Drawing.Point(13, 47);
            this.category_lbl.Name = "category_lbl";
            this.category_lbl.Size = new System.Drawing.Size(55, 15);
            this.category_lbl.TabIndex = 2;
            this.category_lbl.Text = "Category";
            this.category_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // skill_lbl
            // 
            this.skill_lbl.AutoSize = true;
            this.skill_lbl.Location = new System.Drawing.Point(13, 18);
            this.skill_lbl.Name = "skill_lbl";
            this.skill_lbl.Size = new System.Drawing.Size(28, 15);
            this.skill_lbl.TabIndex = 1;
            this.skill_lbl.Text = "Skill";
            // 
            // errorHandler_txt
            // 
            this.errorHandler_txt.Location = new System.Drawing.Point(375, 12);
            this.errorHandler_txt.Multiline = true;
            this.errorHandler_txt.Name = "errorHandler_txt";
            this.errorHandler_txt.Size = new System.Drawing.Size(318, 125);
            this.errorHandler_txt.TabIndex = 5;
            // 
            // plot
            // 
            this.plot.Location = new System.Drawing.Point(287, 143);
            this.plot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(500, 295);
            this.plot.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generate Chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdateGraph);
            // 
            // dateSelection
            // 
            this.dateSelection.Location = new System.Drawing.Point(13, 102);
            this.dateSelection.Name = "dateSelection";
            this.dateSelection.Size = new System.Drawing.Size(240, 23);
            this.dateSelection.TabIndex = 9;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.errorHandler_txt);
            this.Controls.Add(this.dataEntry_pnl);
            this.Name = "MainWindow";
            this.Text = "TimeTracker";
            this.dataEntry_pnl.ResumeLayout(false);
            this.dataEntry_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressTrackerContextBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel dataEntry_pnl;
        private ComboBox skillSelection_dropdown;
        private TextBox duration_txt;
        private TextBox category_txt;
        private Label duration_lbl;
        private Label category_lbl;
        private Label skill_lbl;
        private Button save_btn;
        private TextBox errorHandler_txt;
        private BindingSource timeTrackingBindingSource;
        private BindingSource progressTrackerContextBindingSource;
        private ScottPlot.FormsPlot plot;
        private Button button1;
        private DateTimePicker dateSelection;
    }
}