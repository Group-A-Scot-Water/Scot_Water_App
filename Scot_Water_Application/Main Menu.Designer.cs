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
            this.btnExitMain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChangeWaterLavel = new System.Windows.Forms.Button();
            this.btnChangeCharge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewBusinesses
            // 
            this.btnViewBusinesses.BackColor = System.Drawing.Color.Blue;
            this.btnViewBusinesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBusinesses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewBusinesses.Location = new System.Drawing.Point(24, 73);
            this.btnViewBusinesses.Name = "btnViewBusinesses";
            this.btnViewBusinesses.Size = new System.Drawing.Size(339, 52);
            this.btnViewBusinesses.TabIndex = 0;
            this.btnViewBusinesses.Text = "View Businesses";
            this.btnViewBusinesses.UseVisualStyleBackColor = false;
            // 
            // btnMeterReadings
            // 
            this.btnMeterReadings.BackColor = System.Drawing.Color.Blue;
            this.btnMeterReadings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeterReadings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMeterReadings.Location = new System.Drawing.Point(24, 162);
            this.btnMeterReadings.Name = "btnMeterReadings";
            this.btnMeterReadings.Size = new System.Drawing.Size(339, 62);
            this.btnMeterReadings.TabIndex = 1;
            this.btnMeterReadings.Text = "Add meter readings";
            this.btnMeterReadings.UseVisualStyleBackColor = false;
            // 
            // btnBilling
            // 
            this.btnBilling.BackColor = System.Drawing.Color.Blue;
            this.btnBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilling.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBilling.Location = new System.Drawing.Point(24, 254);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(339, 72);
            this.btnBilling.TabIndex = 2;
            this.btnBilling.Text = "Generate Bill";
            this.btnBilling.UseVisualStyleBackColor = false;
            // 
            // btnExitMain
            // 
            this.btnExitMain.BackColor = System.Drawing.Color.Red;
            this.btnExitMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExitMain.Location = new System.Drawing.Point(609, 375);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(100, 50);
            this.btnExitMain.TabIndex = 3;
            this.btnExitMain.Text = "Exit";
            this.btnExitMain.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Scot_Water_Application.Properties.Resources.Scot_Water_Company_Logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(686, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnChangeWaterLavel
            // 
            this.btnChangeWaterLavel.BackColor = System.Drawing.Color.Blue;
            this.btnChangeWaterLavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeWaterLavel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangeWaterLavel.Location = new System.Drawing.Point(520, 104);
            this.btnChangeWaterLavel.Name = "btnChangeWaterLavel";
            this.btnChangeWaterLavel.Size = new System.Drawing.Size(234, 98);
            this.btnChangeWaterLavel.TabIndex = 5;
            this.btnChangeWaterLavel.Text = "Change Water Level";
            this.btnChangeWaterLavel.UseVisualStyleBackColor = false;
            // 
            // btnChangeCharge
            // 
            this.btnChangeCharge.BackColor = System.Drawing.Color.Blue;
            this.btnChangeCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeCharge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangeCharge.Location = new System.Drawing.Point(520, 208);
            this.btnChangeCharge.Name = "btnChangeCharge";
            this.btnChangeCharge.Size = new System.Drawing.Size(234, 128);
            this.btnChangeCharge.TabIndex = 6;
            this.btnChangeCharge.Text = "Change Water Charge";
            this.btnChangeCharge.UseVisualStyleBackColor = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangeCharge);
            this.Controls.Add(this.btnChangeWaterLavel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExitMain);
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
        private System.Windows.Forms.Button btnExitMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChangeWaterLavel;
        private System.Windows.Forms.Button btnChangeCharge;
    }
}