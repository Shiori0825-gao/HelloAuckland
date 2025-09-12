using System.Drawing;

namespace HelloAuckland
{
    partial class Form2
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
            this.Taxi = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Train = new System.Windows.Forms.Button();
            this.Bus = new System.Windows.Forms.Button();
            this.Rent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Taxi
            // 
            this.Taxi.BackgroundImage = Image.FromFile("Images/taxi.jpg");
            this.Taxi.Location = new System.Drawing.Point(323, 147);
            this.Taxi.Name = "Taxi";
            this.Taxi.Size = new System.Drawing.Size(270, 250);
            this.Taxi.TabIndex = 0;
            this.Taxi.UseVisualStyleBackColor = true;
            this.Taxi.Click += new System.EventHandler(this.Taxi_Click);
            // 
            // Train
            // 
            this.Train.BackgroundImage = Image.FromFile("Images/train.jpg");
            this.Train.Location = new System.Drawing.Point(670, 147);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(270, 250);
            this.Train.TabIndex = 1;
            this.Train.UseVisualStyleBackColor = true;
            this.Train.Click += new System.EventHandler(this.Train_Click);
            // 
            // Bus
            // 
            this.Bus.BackgroundImage = Image.FromFile("Images/bus.jpg");
            this.Bus.Location = new System.Drawing.Point(323, 450);
            this.Bus.Name = "Bus";
            this.Bus.Size = new System.Drawing.Size(270, 250);
            this.Bus.TabIndex = 2;
            this.Bus.UseVisualStyleBackColor = true;
            this.Bus.Click += new System.EventHandler(this.Bus_Click);
            // 
            // Rent
            // 
            this.Rent.BackgroundImage = Image.FromFile("Images/rent.jpg");
            this.Rent.Location = new System.Drawing.Point(670, 450);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(270, 250);
            this.Rent.TabIndex = 3;
            this.Rent.UseVisualStyleBackColor = true;
            this.Rent.Click += new System.EventHandler(this.Rent_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = Image.FromFile("Images/TransportBackGround.jpg");
            this.ClientSize = new System.Drawing.Size(1280, 848);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.Bus);
            this.Controls.Add(this.Train);
            this.Controls.Add(this.Taxi);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Taxi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Train;
        private System.Windows.Forms.Button Bus;
        private System.Windows.Forms.Button Rent;
    }
}