﻿namespace Daily_Digital_Task_Tracker
{
    partial class DayExpanded
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.CreateEvent_btn = new System.Windows.Forms.Button();
            this.seconds_cmb = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start_btn = new System.Windows.Forms.Button();
            this.mins_cmb = new System.Windows.Forms.ComboBox();
            this.timer_lbl = new System.Windows.Forms.Label();
            this.hours_cmb = new System.Windows.Forms.ComboBox();
            this.task_cmb = new System.Windows.Forms.ComboBox();
            this.date_lbl = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateEvent_btn
            // 
            this.CreateEvent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateEvent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateEvent_btn.Location = new System.Drawing.Point(12, 326);
            this.CreateEvent_btn.Name = "CreateEvent_btn";
            this.CreateEvent_btn.Size = new System.Drawing.Size(345, 118);
            this.CreateEvent_btn.TabIndex = 2;
            this.CreateEvent_btn.Text = "Create";
            this.CreateEvent_btn.UseVisualStyleBackColor = true;
            this.CreateEvent_btn.Click += new System.EventHandler(this.CreateEvent_btn_Click);
            // 
            // seconds_cmb
            // 
            this.seconds_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seconds_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds_cmb.FormattingEnabled = true;
            this.seconds_cmb.Location = new System.Drawing.Point(12, 257);
            this.seconds_cmb.Name = "seconds_cmb";
            this.seconds_cmb.Size = new System.Drawing.Size(345, 37);
            this.seconds_cmb.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start_btn
            // 
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(455, 326);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(333, 118);
            this.start_btn.TabIndex = 7;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // mins_cmb
            // 
            this.mins_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mins_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mins_cmb.FormattingEnabled = true;
            this.mins_cmb.Location = new System.Drawing.Point(12, 193);
            this.mins_cmb.Name = "mins_cmb";
            this.mins_cmb.Size = new System.Drawing.Size(345, 37);
            this.mins_cmb.TabIndex = 10;
            // 
            // timer_lbl
            // 
            this.timer_lbl.AutoSize = true;
            this.timer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_lbl.Location = new System.Drawing.Point(552, 22);
            this.timer_lbl.Name = "timer_lbl";
            this.timer_lbl.Size = new System.Drawing.Size(143, 37);
            this.timer_lbl.TabIndex = 11;
            this.timer_lbl.Text = "00:00:00";
            // 
            // hours_cmb
            // 
            this.hours_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hours_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_cmb.FormattingEnabled = true;
            this.hours_cmb.Location = new System.Drawing.Point(12, 136);
            this.hours_cmb.Name = "hours_cmb";
            this.hours_cmb.Size = new System.Drawing.Size(345, 37);
            this.hours_cmb.TabIndex = 12;
            // 
            // task_cmb
            // 
            this.task_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_cmb.FormattingEnabled = true;
            this.task_cmb.Location = new System.Drawing.Point(12, 72);
            this.task_cmb.Name = "task_cmb";
            this.task_cmb.Size = new System.Drawing.Size(345, 37);
            this.task_cmb.TabIndex = 13;
            this.task_cmb.SelectedIndexChanged += new System.EventHandler(this.task_cmb_SelectedIndexChanged);
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(83, 22);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(179, 37);
            this.date_lbl.TabIndex = 14;
            this.date_lbl.Text = "44/44/4444";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            this.progressBar.ChartAreas.Add(chartArea2);
            this.progressBar.Location = new System.Drawing.Point(455, 45);
            this.progressBar.Name = "progressBar";
            this.progressBar.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Name = "Series1";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            series2.ShadowColor = System.Drawing.Color.Transparent;
            this.progressBar.Series.Add(series2);
            this.progressBar.Size = new System.Drawing.Size(333, 270);
            this.progressBar.TabIndex = 16;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // DayExpanded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timer_lbl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.task_cmb);
            this.Controls.Add(this.hours_cmb);
            this.Controls.Add(this.mins_cmb);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.seconds_cmb);
            this.Controls.Add(this.CreateEvent_btn);
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "DayExpanded";
            this.Text = "DayExpanded";
            this.Load += new System.EventHandler(this.DayExpanded_Load);
            this.Resize += new System.EventHandler(this.DayExpanded_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateEvent_btn;
        private System.Windows.Forms.ComboBox seconds_cmb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.ComboBox mins_cmb;
        private System.Windows.Forms.Label timer_lbl;
        private System.Windows.Forms.ComboBox hours_cmb;
        private System.Windows.Forms.ComboBox task_cmb;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart progressBar;
    }
}