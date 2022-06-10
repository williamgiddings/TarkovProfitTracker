using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarkovProfitTracker
{
    public partial class TarkovProfitTracker : Form
    {
        struct TarkovProfitTrackerData
        {
            public DateTime CurrentDate;
            public string TableData;
        }

        TarkovProfitTrackerData ProgramData;
        ProfitTracker Tracker;

        public TarkovProfitTracker()
        {
            InitializeComponent();
            ProgramData = new TarkovProfitTrackerData();
            Tracker = new ProfitTracker();
            VersionLabel.Text = Environment.VERSIONNUMBER;
        }

        private void UpdateDate()
        {
            ProgramData.CurrentDate = DateTime.Now.Date;
            DateText.Text = ProgramData.CurrentDate.ToShortDateString();
        }

        private void DateText_Click(object sender, EventArgs e)
        {
            UpdateDate();
        }

        private void TarkovProfitTracker_Load(object sender, EventArgs e)
        {
            UpdateDate();
        }

        private void UpdateStashButton_Click(object sender, EventArgs e)
        {
            Tracker.UpdateTracker(
                    new ProfitTracker.TrackingData(
                        ProgramData.CurrentDate,
                        (Int64)RoublesBox.Value,
                        (Int64)EurosBox.Value,
                        (Int64)DollarsBox.Value
                    )
                );

            MessageBox.Show("Successfully recorded stash values for " + ProgramData.CurrentDate.Date.ToShortDateString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowGraphButton_Click(object sender, EventArgs e)
        {
            var Data = Tracker.GetTableData();

            if ( Data.Count() > 1 )
            {
                new Graph( Data ).Show();
            }
            else
            {
                MessageBox.Show("No Data Stored Yet!", "Oh noes!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetDataButton_Click(object sender, EventArgs e)
        {
            var Result = MessageBox.Show("Are you sure you want to wipe the data sheet?", "Reset all data?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if ( Result == DialogResult.Yes )
            {
                Tracker.RebuildDataFile();
            }
        }
    }
}
