namespace Scot_Water_Application
{
    partial class frmMainMenu
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
            this.btnViewBusinesses = new System.Windows.Forms.Button();
            this.btnMeterReadings = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewBusinesses
            // 
            this.btnViewBusinesses.Location = new System.Drawing.Point(106, 288);
            this.btnViewBusinesses.Name = "btnViewBusinesses";
            this.btnViewBusinesses.Size = new System.Drawing.Size(75, 38);
            this.btnViewBusinesses.TabIndex = 0;
            this.btnViewBusinesses.Text = "View Businesses";
            this.btnViewBusinesses.UseVisualStyleBackColor = true;
            // 
            // btnMeterReadings
            // 
            this.btnMeterReadings.Location = new System.Drawing.Point(253, 288);
            this.btnMeterReadings.Name = "btnMeterReadings";
            this.btnMeterReadings.Size = new System.Drawing.Size(75, 38);
            this.btnMeterReadings.TabIndex = 1;
            this.btnMeterReadings.Text = "Add meter readings";
            this.btnMeterReadings.UseVisualStyleBackColor = true;
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(403, 288);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(75, 38);
            this.btnBilling.TabIndex = 2;
            this.btnBilling.Text = "Generate Bill";
            this.btnBilling.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(547, 288);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(289, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 137);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBilling);
            this.Controls.Add(this.btnMeterReadings);
            this.Controls.Add(this.btnViewBusinesses);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewBusinesses;
        private System.Windows.Forms.Button btnMeterReadings;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}