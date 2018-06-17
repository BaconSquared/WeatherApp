namespace WeatherApp
{
    partial class WeatherApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherApp));
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.enterCityTextLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.weatherInfoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(108, 25);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(132, 20);
            this.cityTextBox.TabIndex = 0;
            // 
            // enterCityTextLabel
            // 
            this.enterCityTextLabel.AutoSize = true;
            this.enterCityTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCityTextLabel.Location = new System.Drawing.Point(24, 26);
            this.enterCityTextLabel.Name = "enterCityTextLabel";
            this.enterCityTextLabel.Size = new System.Drawing.Size(78, 16);
            this.enterCityTextLabel.TabIndex = 1;
            this.enterCityTextLabel.Text = "Enter City:";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(258, 24);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // weatherInfoTextBox
            // 
            this.weatherInfoTextBox.Location = new System.Drawing.Point(39, 78);
            this.weatherInfoTextBox.Multiline = true;
            this.weatherInfoTextBox.Name = "weatherInfoTextBox";
            this.weatherInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.weatherInfoTextBox.Size = new System.Drawing.Size(720, 345);
            this.weatherInfoTextBox.TabIndex = 3;
            // 
            // WeatherApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.weatherInfoTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.enterCityTextLabel);
            this.Controls.Add(this.cityTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeatherApp";
            this.Text = "Weather App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label enterCityTextLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox weatherInfoTextBox;
    }
}

