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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBoxTaxi = new System.Windows.Forms.PictureBox();
            this.pictureBoxTrain = new System.Windows.Forms.PictureBox();
            this.pictureBoxBus = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTaxi
            // 
            this.pictureBoxTaxi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTaxi.BackgroundImage")));
            this.pictureBoxTaxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTaxi.Location = new System.Drawing.Point(318, 113);
            this.pictureBoxTaxi.Name = "pictureBoxTaxi";
            this.pictureBoxTaxi.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxTaxi.TabIndex = 0;
            this.pictureBoxTaxi.TabStop = false;
            this.pictureBoxTaxi.Click += new System.EventHandler(this.pictureBoxTaxi_Click);
            // 
            // pictureBoxTrain
            // 
            this.pictureBoxTrain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTrain.BackgroundImage")));
            this.pictureBoxTrain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTrain.Location = new System.Drawing.Point(785, 113);
            this.pictureBoxTrain.Name = "pictureBoxTrain";
            this.pictureBoxTrain.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxTrain.TabIndex = 1;
            this.pictureBoxTrain.TabStop = false;
            this.pictureBoxTrain.Click += new System.EventHandler(this.pictureBoxTrain_Click);
            // 
            // pictureBoxBus
            // 
            this.pictureBoxBus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBus.BackgroundImage")));
            this.pictureBoxBus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBus.Location = new System.Drawing.Point(318, 509);
            this.pictureBoxBus.Name = "pictureBoxBus";
            this.pictureBoxBus.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxBus.TabIndex = 2;
            this.pictureBoxBus.TabStop = false;
            this.pictureBoxBus.Click += new System.EventHandler(this.pictureBoxBus_Click);
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar.BackgroundImage")));
            this.pictureBoxCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCar.Location = new System.Drawing.Point(785, 509);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxCar.TabIndex = 3;
            this.pictureBoxCar.TabStop = false;
            this.pictureBoxCar.Click += new System.EventHandler(this.pictureBoxCar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(50, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1388, 882);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.pictureBoxBus);
            this.Controls.Add(this.pictureBoxTrain);
            this.Controls.Add(this.pictureBoxTaxi);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBoxTaxi;
        private System.Windows.Forms.PictureBox pictureBoxTrain;
        private System.Windows.Forms.PictureBox pictureBoxBus;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}