namespace WeatherApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelFeelsLike;
        private System.Windows.Forms.Label labelTempMin;
        private System.Windows.Forms.Label labelTempMax;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelVisibility;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label labelWindDirection;
        private System.Windows.Forms.Label labelWindGust;
        private System.Windows.Forms.Label labelCloudiness;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelSunrise;
        private System.Windows.Forms.Label labelSunset;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelFeelsLike = new System.Windows.Forms.Label();
            this.labelTempMin = new System.Windows.Forms.Label();
            this.labelTempMax = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelVisibility = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.labelWindDirection = new System.Windows.Forms.Label();
            this.labelWindGust = new System.Windows.Forms.Label();
            this.labelCloudiness = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelSunrise = new System.Windows.Forms.Label();
            this.labelSunset = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Получить погоду";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(12, 45);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(70, 13);
            this.labelTemp.TabIndex = 2;
            this.labelTemp.Text = "Temperature:";
            // 
            // labelFeelsLike
            // 
            this.labelFeelsLike.AutoSize = true;
            this.labelFeelsLike.Location = new System.Drawing.Point(12, 68);
            this.labelFeelsLike.Name = "labelFeelsLike";
            this.labelFeelsLike.Size = new System.Drawing.Size(58, 13);
            this.labelFeelsLike.TabIndex = 3;
            this.labelFeelsLike.Text = "Feels Like:";
            // 
            // labelTempMin
            // 
            this.labelTempMin.AutoSize = true;
            this.labelTempMin.Location = new System.Drawing.Point(12, 91);
            this.labelTempMin.Name = "labelTempMin";
            this.labelTempMin.Size = new System.Drawing.Size(57, 13);
            this.labelTempMin.TabIndex = 4;
            this.labelTempMin.Text = "Temp Min:";
            // 
            // labelTempMax
            // 
            this.labelTempMax.AutoSize = true;
            this.labelTempMax.Location = new System.Drawing.Point(12, 114);
            this.labelTempMax.Name = "labelTempMax";
            this.labelTempMax.Size = new System.Drawing.Size(60, 13);
            this.labelTempMax.TabIndex = 5;
            this.labelTempMax.Text = "Temp Max:";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Location = new System.Drawing.Point(12, 137);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(51, 13);
            this.labelPressure.TabIndex = 6;
            this.labelPressure.Text = "Pressure:";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Location = new System.Drawing.Point(12, 160);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(50, 13);
            this.labelHumidity.TabIndex = 7;
            this.labelHumidity.Text = "Humidity:";
            // 
            // labelVisibility
            // 
            this.labelVisibility.AutoSize = true;
            this.labelVisibility.Location = new System.Drawing.Point(12, 183);
            this.labelVisibility.Name = "labelVisibility";
            this.labelVisibility.Size = new System.Drawing.Size(46, 13);
            this.labelVisibility.TabIndex = 8;
            this.labelVisibility.Text = "Visibility:";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.Location = new System.Drawing.Point(12, 206);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(69, 13);
            this.labelWindSpeed.TabIndex = 9;
            this.labelWindSpeed.Text = "Wind Speed:";
            // 
            // labelWindDirection
            // 
            this.labelWindDirection.AutoSize = true;
            this.labelWindDirection.Location = new System.Drawing.Point(12, 229);
            this.labelWindDirection.Name = "labelWindDirection";
            this.labelWindDirection.Size = new System.Drawing.Size(80, 13);
            this.labelWindDirection.TabIndex = 10;
            this.labelWindDirection.Text = "Wind Direction:";
            // 
            // labelWindGust
            // 
            this.labelWindGust.AutoSize = true;
            this.labelWindGust.Location = new System.Drawing.Point(12, 252);
            this.labelWindGust.Name = "labelWindGust";
            this.labelWindGust.Size = new System.Drawing.Size(60, 13);
            this.labelWindGust.TabIndex = 11;
            this.labelWindGust.Text = "Wind Gust:";
            // 
            // labelCloudiness
            // 
            this.labelCloudiness.AutoSize = true;
            this.labelCloudiness.Location = new System.Drawing.Point(12, 275);
            this.labelCloudiness.Name = "labelCloudiness";
            this.labelCloudiness.Size = new System.Drawing.Size(61, 13);
            this.labelCloudiness.TabIndex = 12;
            this.labelCloudiness.Text = "Cloudiness:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 298);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 13;
            this.labelDescription.Text = "Description:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(12, 321);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(46, 13);
            this.labelCountry.TabIndex = 14;
            this.labelCountry.Text = "Country:";
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.Location = new System.Drawing.Point(12, 344);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(45, 13);
            this.labelSunrise.TabIndex = 15;
            this.labelSunrise.Text = "Sunrise:";
            // 
            // labelSunset
            // 
            this.labelSunset.AutoSize = true;
            this.labelSunset.Location = new System.Drawing.Point(12, 367);
            this.labelSunset.Name = "labelSunset";
            this.labelSunset.Size = new System.Drawing.Size(43, 13);
            this.labelSunset.TabIndex = 16;
            this.labelSunset.Text = "Sunset:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(299, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1158, 600);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 632);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSunset);
            this.Controls.Add(this.labelSunrise);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelCloudiness);
            this.Controls.Add(this.labelWindGust);
            this.Controls.Add(this.labelWindDirection);
            this.Controls.Add(this.labelWindSpeed);
            this.Controls.Add(this.labelVisibility);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.labelPressure);
            this.Controls.Add(this.labelTempMax);
            this.Controls.Add(this.labelTempMin);
            this.Controls.Add(this.labelFeelsLike);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Weather App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
