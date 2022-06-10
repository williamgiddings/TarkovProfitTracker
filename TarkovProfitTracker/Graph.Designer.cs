namespace TarkovProfitTracker
{
    partial class Graph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graph));
            this.chartGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PlotModeCheckBox = new System.Windows.Forms.CheckBox();
            this.ThreeDCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGraphic
            // 
            this.chartGraphic.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.Title = "Date";
            chartArea1.AxisY.Title = "Currency";
            chartArea1.Name = "ChartArea1";
            this.chartGraphic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraphic.Legends.Add(legend1);
            this.chartGraphic.Location = new System.Drawing.Point(-9, -2);
            this.chartGraphic.Name = "chartGraphic";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Roubles";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Euros";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Dollars";
            this.chartGraphic.Series.Add(series1);
            this.chartGraphic.Series.Add(series2);
            this.chartGraphic.Series.Add(series3);
            this.chartGraphic.Size = new System.Drawing.Size(970, 730);
            this.chartGraphic.TabIndex = 0;
            this.chartGraphic.Text = "Profit Tracker";
            this.MouseWheel += chart1_MouseWheel;
            // 
            // PlotModeCheckBox
            // 
            this.PlotModeCheckBox.AutoSize = true;
            this.PlotModeCheckBox.Location = new System.Drawing.Point(843, 77);
            this.PlotModeCheckBox.Name = "PlotModeCheckBox";
            this.PlotModeCheckBox.Size = new System.Drawing.Size(78, 17);
            this.PlotModeCheckBox.TabIndex = 1;
            this.PlotModeCheckBox.Text = "Show Gain";
            this.PlotModeCheckBox.UseVisualStyleBackColor = true;
            this.PlotModeCheckBox.CheckedChanged += new System.EventHandler(this.PlotModeCheckBox_CheckedChanged);
            // 
            // ThreeDCheckBox
            // 
            this.ThreeDCheckBox.AutoSize = true;
            this.ThreeDCheckBox.Location = new System.Drawing.Point(843, 100);
            this.ThreeDCheckBox.Name = "ThreeDCheckBox";
            this.ThreeDCheckBox.Size = new System.Drawing.Size(70, 17);
            this.ThreeDCheckBox.TabIndex = 2;
            this.ThreeDCheckBox.Text = "Show 3D";
            this.ThreeDCheckBox.UseVisualStyleBackColor = true;
            this.ThreeDCheckBox.CheckedChanged += new System.EventHandler(this.ThreeDCheckBox_CheckedChanged);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 722);
            this.Controls.Add(this.ThreeDCheckBox);
            this.Controls.Add(this.PlotModeCheckBox);
            this.Controls.Add(this.chartGraphic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Graph";
            this.Text = "Stash Graph";
            this.Load += new System.EventHandler(this.Graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphic;
        private System.Windows.Forms.CheckBox PlotModeCheckBox;
        private System.Windows.Forms.CheckBox ThreeDCheckBox;
    }
}