
namespace WeCalculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.RemainingLabel = new System.Windows.Forms.Label();
            this.UsedLabel = new System.Windows.Forms.Label();
            this.TotalQuoteLabel = new System.Windows.Forms.Label();
            this.RemainingText = new System.Windows.Forms.TextBox();
            this.UsedText = new System.Windows.Forms.TextBox();
            this.TotalQuoteText = new System.Windows.Forms.TextBox();
            this.ActualQuoteDailyLabel = new System.Windows.Forms.Label();
            this.DaysLeftLabel = new System.Windows.Forms.Label();
            this.Line1 = new System.Windows.Forms.Label();
            this.Line2 = new System.Windows.Forms.Label();
            this.supDailyQuoteLabel = new System.Windows.Forms.Label();
            this.SavingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdditionalQuoteText = new System.Windows.Forms.TextBox();
            this.AdditionalQuoteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate.Location = new System.Drawing.Point(171, 12);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(149, 27);
            this.EndDate.TabIndex = 1;
            this.EndDate.Leave += new System.EventHandler(this.EndDate_Leave);
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EndDateLabel.Location = new System.Drawing.Point(12, 16);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(89, 19);
            this.EndDateLabel.TabIndex = 1;
            this.EndDateLabel.Text = "End Date:";
            // 
            // RemainingLabel
            // 
            this.RemainingLabel.AutoSize = true;
            this.RemainingLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemainingLabel.Location = new System.Drawing.Point(12, 59);
            this.RemainingLabel.Name = "RemainingLabel";
            this.RemainingLabel.Size = new System.Drawing.Size(102, 19);
            this.RemainingLabel.TabIndex = 2;
            this.RemainingLabel.Text = "Remaining:";
            // 
            // UsedLabel
            // 
            this.UsedLabel.AutoSize = true;
            this.UsedLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsedLabel.Location = new System.Drawing.Point(12, 102);
            this.UsedLabel.Name = "UsedLabel";
            this.UsedLabel.Size = new System.Drawing.Size(55, 19);
            this.UsedLabel.TabIndex = 3;
            this.UsedLabel.Text = "Used:";
            // 
            // TotalQuoteLabel
            // 
            this.TotalQuoteLabel.AutoSize = true;
            this.TotalQuoteLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalQuoteLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalQuoteLabel.Location = new System.Drawing.Point(12, 145);
            this.TotalQuoteLabel.Name = "TotalQuoteLabel";
            this.TotalQuoteLabel.Size = new System.Drawing.Size(112, 19);
            this.TotalQuoteLabel.TabIndex = 4;
            this.TotalQuoteLabel.Text = "Total Quote:";
            // 
            // RemainingText
            // 
            this.RemainingText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingText.Location = new System.Drawing.Point(171, 55);
            this.RemainingText.Name = "RemainingText";
            this.RemainingText.Size = new System.Drawing.Size(149, 27);
            this.RemainingText.TabIndex = 0;
            this.RemainingText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RemainingText.TextChanged += new System.EventHandler(this.RemainingText_TextChanged);
            // 
            // UsedText
            // 
            this.UsedText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsedText.Location = new System.Drawing.Point(171, 98);
            this.UsedText.Name = "UsedText";
            this.UsedText.Size = new System.Drawing.Size(149, 27);
            this.UsedText.TabIndex = 2;
            this.UsedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalQuoteText
            // 
            this.TotalQuoteText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalQuoteText.Location = new System.Drawing.Point(171, 141);
            this.TotalQuoteText.Name = "TotalQuoteText";
            this.TotalQuoteText.Size = new System.Drawing.Size(149, 27);
            this.TotalQuoteText.TabIndex = 3;
            this.TotalQuoteText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalQuoteText.TextChanged += new System.EventHandler(this.TotalQuoteText_TextChanged);
            // 
            // ActualQuoteDailyLabel
            // 
            this.ActualQuoteDailyLabel.AutoSize = true;
            this.ActualQuoteDailyLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualQuoteDailyLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ActualQuoteDailyLabel.Location = new System.Drawing.Point(12, 277);
            this.ActualQuoteDailyLabel.Name = "ActualQuoteDailyLabel";
            this.ActualQuoteDailyLabel.Size = new System.Drawing.Size(180, 19);
            this.ActualQuoteDailyLabel.TabIndex = 5;
            this.ActualQuoteDailyLabel.Text = "Actual quote daily = ";
            // 
            // DaysLeftLabel
            // 
            this.DaysLeftLabel.AutoSize = true;
            this.DaysLeftLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysLeftLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DaysLeftLabel.Location = new System.Drawing.Point(12, 227);
            this.DaysLeftLabel.Name = "DaysLeftLabel";
            this.DaysLeftLabel.Size = new System.Drawing.Size(104, 19);
            this.DaysLeftLabel.TabIndex = 6;
            this.DaysLeftLabel.Text = "Days left = ";
            // 
            // Line1
            // 
            this.Line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Line1.Location = new System.Drawing.Point(5, 182);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(331, 2);
            this.Line1.TabIndex = 7;
            // 
            // Line2
            // 
            this.Line2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Line2.Location = new System.Drawing.Point(5, 260);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(331, 2);
            this.Line2.TabIndex = 8;
            // 
            // supDailyQuoteLabel
            // 
            this.supDailyQuoteLabel.AutoSize = true;
            this.supDailyQuoteLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supDailyQuoteLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supDailyQuoteLabel.Location = new System.Drawing.Point(12, 196);
            this.supDailyQuoteLabel.Name = "supDailyQuoteLabel";
            this.supDailyQuoteLabel.Size = new System.Drawing.Size(206, 19);
            this.supDailyQuoteLabel.TabIndex = 9;
            this.supDailyQuoteLabel.Text = "Supposed quote daily = ";
            // 
            // SavingLabel
            // 
            this.SavingLabel.AutoSize = true;
            this.SavingLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SavingLabel.Location = new System.Drawing.Point(12, 311);
            this.SavingLabel.Name = "SavingLabel";
            this.SavingLabel.Size = new System.Drawing.Size(172, 19);
            this.SavingLabel.TabIndex = 10;
            this.SavingLabel.Text = "You need to save = ";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(5, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 2);
            this.label1.TabIndex = 11;
            // 
            // AdditionalQuoteText
            // 
            this.AdditionalQuoteText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalQuoteText.Location = new System.Drawing.Point(171, 356);
            this.AdditionalQuoteText.Name = "AdditionalQuoteText";
            this.AdditionalQuoteText.Size = new System.Drawing.Size(149, 27);
            this.AdditionalQuoteText.TabIndex = 12;
            this.AdditionalQuoteText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdditionalQuoteText.TextChanged += new System.EventHandler(this.AdditionalQuoteText_TextChanged);
            // 
            // AdditionalQuoteLabel
            // 
            this.AdditionalQuoteLabel.AutoSize = true;
            this.AdditionalQuoteLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalQuoteLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdditionalQuoteLabel.Location = new System.Drawing.Point(12, 360);
            this.AdditionalQuoteLabel.Name = "AdditionalQuoteLabel";
            this.AdditionalQuoteLabel.Size = new System.Drawing.Size(153, 19);
            this.AdditionalQuoteLabel.TabIndex = 13;
            this.AdditionalQuoteLabel.Text = "Additional Quote:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(340, 396);
            this.Controls.Add(this.AdditionalQuoteText);
            this.Controls.Add(this.AdditionalQuoteLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SavingLabel);
            this.Controls.Add(this.supDailyQuoteLabel);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.DaysLeftLabel);
            this.Controls.Add(this.ActualQuoteDailyLabel);
            this.Controls.Add(this.TotalQuoteText);
            this.Controls.Add(this.UsedText);
            this.Controls.Add(this.RemainingText);
            this.Controls.Add(this.TotalQuoteLabel);
            this.Controls.Add(this.UsedLabel);
            this.Controls.Add(this.RemainingLabel);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.EndDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "We";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label RemainingLabel;
        private System.Windows.Forms.Label UsedLabel;
        private System.Windows.Forms.Label TotalQuoteLabel;
        private System.Windows.Forms.TextBox RemainingText;
        private System.Windows.Forms.TextBox UsedText;
        private System.Windows.Forms.TextBox TotalQuoteText;
        private System.Windows.Forms.Label ActualQuoteDailyLabel;
        private System.Windows.Forms.Label DaysLeftLabel;
        private System.Windows.Forms.Label Line1;
        private System.Windows.Forms.Label Line2;
        private System.Windows.Forms.Label supDailyQuoteLabel;
        private System.Windows.Forms.Label SavingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdditionalQuoteText;
        private System.Windows.Forms.Label AdditionalQuoteLabel;
    }
}

