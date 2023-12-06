
namespace Ex4
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
            this.lblAddCar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddCar
            // 
            this.lblAddCar.AutoSize = true;
            this.lblAddCar.BackColor = System.Drawing.Color.Transparent;
            this.lblAddCar.Location = new System.Drawing.Point(12, 53);
            this.lblAddCar.Name = "lblAddCar";
            this.lblAddCar.Size = new System.Drawing.Size(69, 315);
            this.lblAddCar.TabIndex = 6;
            this.lblAddCar.Text = "\r\n\r\nID:\r\n\r\nFirst Name:\r\n\r\nLast Name: \r\n\r\nPhone:\r\n\r\nAddress:\r\n\r\nLicense:\r\n\r\nMaker:" +
    "\r\n\r\nYear:\r\n\r\nEngine:\r\n\r\nModel:";
            this.lblAddCar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(130, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Car 1            Car 2           Car 3            Car 4             Car 5        " +
    "    Car 6            Car 7           Car 8            Car 9            Car 10";
            this.label1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddCar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCar;
        private System.Windows.Forms.Label label1;
    }
}