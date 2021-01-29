using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WeCalculator
{
    public partial class MainForm : Form
    {
        DateTime assignedDate;
        float TotalQuote;
        int remainingdays;
        float AdditionalQuote;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\WeCalculator") == null)
                {
                    try
                    {
                        Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\WeCalculator").CreateSubKey("WeCalculator");
                        Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\WeCalculator", "EndDate", DateTime.Now.ToShortDateString());
                        Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\WeCalculator", "TotalQuote", "250");
                        Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\WeCalculator", "AdditionalQuote", "0");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                assignedDate = DateTime.Parse(Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\WeCalculator", "EndDate", DateTime.Now).ToString());
                if (assignedDate < DateTime.Now)
                {
                    assignedDate = assignedDate.AddMonths(1);
                    Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\WeCalculator", "EndDate", assignedDate.ToShortDateString());
                }
                EndDate.Value = assignedDate;
                TotalQuote = float.Parse(Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\WeCalculator", "TotalQuote", "250").ToString());
                AdditionalQuote = float.Parse(Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\WeCalculator", "AdditionalQuote", "0").ToString());
                TotalQuoteText.Text = TotalQuote.ToString();
                AdditionalQuoteText.Text = AdditionalQuote.ToString();
                remainingdays = ((assignedDate - DateTime.Now).Days + 1);
                DaysLeftLabel.Text = "Days left = " + remainingdays.ToString();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void calculate() {
            if (String.IsNullOrEmpty(RemainingText.Text)) { return; }
            float supposedDailyQuote = (TotalQuote + AdditionalQuote) / ((assignedDate - (assignedDate.AddMonths(-1))).Days);
            supDailyQuoteLabel.Text = "Supposed quote daily = " + supposedDailyQuote.ToString("N2");
            supDailyQuoteLabel.ForeColor = Color.Gold;
            UsedText.Text = ((TotalQuote + AdditionalQuote) - float.Parse(RemainingText.Text)).ToString("N2");
            float actualDailyQuote = (float.Parse(RemainingText.Text) / remainingdays);
            ActualQuoteDailyLabel.Text = "Actual quote daily = " + actualDailyQuote.ToString("N2");
            if (actualDailyQuote > supposedDailyQuote)
            {
                SavingLabel.Text = "You have extra = " + Math.Abs(supposedDailyQuote * remainingdays - float.Parse(RemainingText.Text)).ToString("N2");
                ActualQuoteDailyLabel.ForeColor = Color.GreenYellow;
                SavingLabel.ForeColor = Color.GreenYellow;
            }
            else
            {
                SavingLabel.Text = "You need to save = " + (supposedDailyQuote * remainingdays - float.Parse(RemainingText.Text)).ToString("N2");
                ActualQuoteDailyLabel.ForeColor = Color.OrangeRed;
                SavingLabel.ForeColor = Color.OrangeRed;
            }
        }
        private void RemainingText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                calculate();
            }
            catch {
                ActualQuoteDailyLabel.Text = "Invalid format";
                ActualQuoteDailyLabel.ForeColor = Color.OrangeRed;
                supDailyQuoteLabel.Text = "Invalid format";
                supDailyQuoteLabel.ForeColor = Color.OrangeRed;
                SavingLabel.Text = "Invalid format";
                SavingLabel.ForeColor = Color.OrangeRed;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try {
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\WeCalculator", "EndDate", EndDate.Value.ToShortDateString());
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\WeCalculator", "TotalQuote", TotalQuoteText.Text);
                Application.Exit();
            } catch(Exception ex) {
                MessageBox.Show("Saving attempt was unsuccessfull due to " + ex.Message);
            }
        }

        private void TotalQuoteText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(TotalQuoteText.Text))
                {
                    if (float.Parse(TotalQuoteText.Text) != TotalQuote)
                    {
                        Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\WeCalculator", "TotalQuote", TotalQuoteText.Text);
                        TotalQuote = float.Parse(TotalQuoteText.Text);
                        calculate();
                    }
                }
            }
            catch { }
        }

        private void EndDate_Leave(object sender, EventArgs e)
        {
            try
            {
                if (EndDate.Value != assignedDate)
                {
                    Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\WeCalculator", "EndDate", EndDate.Value.ToShortDateString());
                    assignedDate = EndDate.Value;
                    remainingdays = ((assignedDate - DateTime.Now).Days + 1);
                    calculate();
                }
            }
            catch { }
        }

        private void AdditionalQuoteText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(AdditionalQuoteText.Text))
                {
                    if (float.Parse(AdditionalQuoteText.Text) != AdditionalQuote)
                    {
                        Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\WeCalculator", "AdditionalQuote", AdditionalQuoteText.Text);
                        AdditionalQuote = float.Parse(AdditionalQuoteText.Text);
                        calculate();
                    }
                }
            }
            catch { }
        }
    }
}
