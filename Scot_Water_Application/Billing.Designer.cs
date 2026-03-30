namespace Scot_Water_Application
{
    partial class frmBilling
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
            this.cmbBusinesses = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBacktoMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBusinesses
            // 
            this.cmbBusinesses.FormattingEnabled = true;
            this.cmbBusinesses.Location = new System.Drawing.Point(224, 64);
            this.cmbBusinesses.Name = "cmbBusinesses";
            this.cmbBusinesses.Size = new System.Drawing.Size(121, 21);
            this.cmbBusinesses.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Bill";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBacktoMain
            // 
            this.btnBacktoMain.Location = new System.Drawing.Point(336, 240);
            this.btnBacktoMain.Name = "btnBacktoMain";
            this.btnBacktoMain.Size = new System.Drawing.Size(75, 38);
            this.btnBacktoMain.TabIndex = 2;
            this.btnBacktoMain.Text = "Back to main menu";
            this.btnBacktoMain.UseVisualStyleBackColor = true;
            // 
            // frmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBacktoMain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbBusinesses);
            this.Name = "frmBilling";
            this.Text = "Billing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBusinesses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBacktoMain;
    }
}