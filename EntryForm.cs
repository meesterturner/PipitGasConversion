using System;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace PipitGasConversion
{
    public partial class EntryForm : Form
    {

        private Settings settings;
        private int DaysInstalled()
        {
            return Convert.ToInt32((DateTime.Now - settings.InstallDate).TotalDays);
        }

        public EntryForm()
        {
            InitializeComponent();
        }

        private Settings LoadSettings()
        {
            Settings retVal;

            // To go
            //retVal = new Settings();
            //retVal.InstallDate = Convert.ToDateTime("2016-12-13");
            //retVal.DeltaPerDay = 0.60719462;

            string filename = "settings.json";
            string jsonString = File.ReadAllText(filename);
            retVal = JsonSerializer.Deserialize<Settings>(jsonString);

            return retVal;
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            settings = LoadSettings();

            txtInstall.Text = settings.InstallDate.ToString("dd/MM/yyyy");
            txtToday.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtDeltaPerDay.Text = settings.DeltaPerDay.ToString();
            txtDaysInstall.Text = DaysInstalled().ToString();

            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int pipitKwh = Convert.ToInt32(txtInput.Text);
                double realKwh = pipitKwh + (settings.DeltaPerDay * DaysInstalled());
                double realMeterRead = realKwh * 3.6 / 1.02264 / 40;
                int readM3 = Convert.ToInt32(Math.Ceiling(realMeterRead));

                string output = "00000" + readM3.ToString();
                output = output.Substring(output.Length - 5);

                txtOutput.Text = output;
            }

            catch
            {
                txtOutput.Text = "";
            }
        }

        private void EntryForm_Activated(object sender, EventArgs e)
        {
            txtInput.Focus();
        }
    }
}
