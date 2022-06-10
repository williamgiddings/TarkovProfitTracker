using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TarkovProfitTracker
{
    public partial class Graph : Form
    {
        enum PlotStyle
        {
            Raw,
            Gain
        }

        class Zooming
        {
            public float CZoomScale = 4f;
            public int FZoomLevel = 0;
        }

        IEnumerable<string> TableData;
        string[] CurrencyStrings = new string[] { "Roubles", "Euros", "Dollars" };
        Zooming Zoom = new Zooming();

        public Graph( IEnumerable<string> InTableData )
        {
            InitializeComponent();
            TableData = InTableData;
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            chartGraphic.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartGraphic.ChartAreas[0].CursorY.IsUserEnabled = true;
            chartGraphic.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartGraphic.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chartGraphic.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartGraphic.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            chartGraphic.ChartAreas[0].Area3DStyle.Rotation = 15;
            chartGraphic.ChartAreas[0].AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Cursor;

            for ( int i = 0; i < 3; i++ ) // Roubles, Euros and Dollars
            {
                chartGraphic.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chartGraphic.Series[i].MarkerSize = 10;
                chartGraphic.Series[i].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                chartGraphic.Series[i].ToolTip = CurrencyStrings[i];
            }

            Plot( PlotStyle.Raw );
        }

        void Plot( PlotStyle PlotMode )
        {
            chartGraphic.Series[0].Points.Clear();
            chartGraphic.Series[1].Points.Clear();
            chartGraphic.Series[2].Points.Clear();

            int Line = 0;

            foreach (string s in TableData)
            {
                int PMDIM = 0; //PlotModeDataIndexMod

                if ( PlotMode == PlotStyle.Gain )
                {
                    PMDIM = 3;
                }

                if (Line != 0)
                {
                    string[] Data = s.Split(',');

                    var RoublePoint = chartGraphic.Series[0].Points;
                    var EuroPoint = chartGraphic.Series[1].Points;
                    var DollarPoint = chartGraphic.Series[2].Points;

                    RoublePoint.AddXY(Data[0], Data[1+ PMDIM]); //R
                    EuroPoint.AddXY(Data[0], Data[2+ PMDIM]); //R
                    DollarPoint.AddXY(Data[0], Data[3+ PMDIM]); //R

                    RoublePoint.Last().Label = Currencyfy( 0, Data[1 + PMDIM] );
                    RoublePoint.Last().LabelForeColor = GetCurrecnyColor( Data[1 + PMDIM] );

                    EuroPoint.Last().Label = Currencyfy(1, Data[2 + PMDIM]);
                    EuroPoint.Last().LabelForeColor = GetCurrecnyColor(Data[2 + PMDIM]);

                    DollarPoint.Last().Label = Currencyfy(2, Data[3 + PMDIM]);
                    DollarPoint.Last().LabelForeColor = GetCurrecnyColor(Data[3 + PMDIM]);
                }
                Line++;
            }
        }

        private Color GetCurrecnyColor( string Value )
        {
            if ( Int64.Parse( Value ) > 0 )
            {
                return Color.Green;
            }
            return Color.Red;
        }

        private string Currencyfy( int CurrencyType, string Amount )
        {
            string Value = String.Format("{0:n0}", Int64.Parse(Amount));

            switch (CurrencyType)
            {
                case 0:
                    return Value + "₽";
                case 1:
                    return "€" + Value;
                case 2:
                    return "$" + Value;
            }
            return "ERROR - Nill Currency Type!"; 
        }

        private void PlotModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PlotModeCheckBox.Checked)
            {
                Plot(PlotStyle.Gain);
            }
            else
            {
                Plot(PlotStyle.Raw);
            }
        }

        private void ThreeDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            chartGraphic.ChartAreas[0].Area3DStyle.Enable3D = ThreeDCheckBox.Checked;
        }

        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                Axis xAxis = chartGraphic.ChartAreas[0].AxisX;
                double xMin = xAxis.ScaleView.ViewMinimum;
                double xMax = xAxis.ScaleView.ViewMaximum;
                double xPixelPos = xAxis.PixelPositionToValue(e.Location.X);

                if (e.Delta < 0 && Zoom.FZoomLevel > 0)
                {
                    // Scrolled down, meaning zoom out
                    if (--Zoom.FZoomLevel <= 0)
                    {
                        Zoom.FZoomLevel = 0;
                        xAxis.ScaleView.ZoomReset();
                    }
                    else
                    {
                        double xStartPos = Math.Max(xPixelPos - (xPixelPos - xMin) * Zoom.CZoomScale, 0);
                        double xEndPos = Math.Min(xStartPos + (xMax - xMin) * Zoom.CZoomScale, xAxis.Maximum);
                        xAxis.ScaleView.Zoom(xStartPos, xEndPos);
                    }
                }
                else if (e.Delta > 0)
                {
                    // Scrolled up, meaning zoom in
                    double xStartPos = Math.Max(xPixelPos - (xPixelPos - xMin) / Zoom.CZoomScale, 0);
                    double xEndPos = Math.Min(xStartPos + (xMax - xMin) / Zoom.CZoomScale, xAxis.Maximum);
                    xAxis.ScaleView.Zoom(xStartPos, xEndPos);
                    Zoom.FZoomLevel++;
                }
            }
            catch { }
        }
    }
}
