
namespace Ex4
{
    partial class GarageG1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GarageG1));
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnFixCar = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnTakeCar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAddCar = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.txtlName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.txtMaker = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnOKaddCar = new System.Windows.Forms.Button();
            this.lblShowCars = new System.Windows.Forms.Label();
            this.lblInProcess = new System.Windows.Forms.Label();
            this.txtInProcess = new System.Windows.Forms.TextBox();
            this.btnInProcessOk = new System.Windows.Forms.Button();
            this.btnRemoveCar = new System.Windows.Forms.Button();
            this.lblTakeLicense = new System.Windows.Forms.Label();
            this.lblTakeId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(46, 126);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnAddCar.TabIndex = 0;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFixCar
            // 
            this.btnFixCar.Location = new System.Drawing.Point(46, 174);
            this.btnFixCar.Name = "btnFixCar";
            this.btnFixCar.Size = new System.Drawing.Size(75, 23);
            this.btnFixCar.TabIndex = 1;
            this.btnFixCar.Text = "Fix The Car";
            this.btnFixCar.UseVisualStyleBackColor = true;
            this.btnFixCar.Click += new System.EventHandler(this.btnFixCar_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(46, 220);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Show Cars";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnTakeCar
            // 
            this.btnTakeCar.Location = new System.Drawing.Point(46, 265);
            this.btnTakeCar.Name = "btnTakeCar";
            this.btnTakeCar.Size = new System.Drawing.Size(75, 23);
            this.btnTakeCar.TabIndex = 3;
            this.btnTakeCar.Text = "Take Car";
            this.btnTakeCar.UseVisualStyleBackColor = true;
            this.btnTakeCar.Click += new System.EventHandler(this.btnTakeCar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(46, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAddCar
            // 
            this.lblAddCar.AutoSize = true;
            this.lblAddCar.BackColor = System.Drawing.Color.Transparent;
            this.lblAddCar.Location = new System.Drawing.Point(215, 9);
            this.lblAddCar.Name = "lblAddCar";
            this.lblAddCar.Size = new System.Drawing.Size(69, 315);
            this.lblAddCar.TabIndex = 5;
            this.lblAddCar.Text = "\r\n\r\nID:\r\n\r\nFirst Name:\r\n\r\nLast Name: \r\n\r\nPhone:\r\n\r\nAddress:\r\n\r\nLicense:\r\n\r\nMaker:" +
    "\r\n\r\nYear:\r\n\r\nEngine:\r\n\r\nModel:";
            this.lblAddCar.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(296, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 7;
            this.txtId.Visible = false;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtfName
            // 
            this.txtfName.Location = new System.Drawing.Point(296, 65);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(100, 23);
            this.txtfName.TabIndex = 8;
            this.txtfName.Visible = false;
            this.txtfName.TextChanged += new System.EventHandler(this.txtfName_TextChanged);
            // 
            // txtlName
            // 
            this.txtlName.Location = new System.Drawing.Point(296, 95);
            this.txtlName.Name = "txtlName";
            this.txtlName.Size = new System.Drawing.Size(100, 23);
            this.txtlName.TabIndex = 9;
            this.txtlName.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(296, 125);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 23);
            this.txtPhone.TabIndex = 10;
            this.txtPhone.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(296, 155);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 23);
            this.txtAddress.TabIndex = 11;
            this.txtAddress.Visible = false;
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(296, 185);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(100, 23);
            this.txtLicense.TabIndex = 12;
            this.txtLicense.Visible = false;
            // 
            // txtMaker
            // 
            this.txtMaker.Location = new System.Drawing.Point(296, 215);
            this.txtMaker.Name = "txtMaker";
            this.txtMaker.Size = new System.Drawing.Size(100, 23);
            this.txtMaker.TabIndex = 13;
            this.txtMaker.Visible = false;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(296, 245);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 23);
            this.txtYear.TabIndex = 14;
            this.txtYear.Visible = false;
            // 
            // txtEngine
            // 
            this.txtEngine.Location = new System.Drawing.Point(296, 275);
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(100, 23);
            this.txtEngine.TabIndex = 15;
            this.txtEngine.Visible = false;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(296, 305);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 23);
            this.txtModel.TabIndex = 16;
            this.txtModel.Visible = false;
            // 
            // btnOKaddCar
            // 
            this.btnOKaddCar.Location = new System.Drawing.Point(269, 350);
            this.btnOKaddCar.Name = "btnOKaddCar";
            this.btnOKaddCar.Size = new System.Drawing.Size(75, 23);
            this.btnOKaddCar.TabIndex = 17;
            this.btnOKaddCar.Text = "OK";
            this.btnOKaddCar.UseVisualStyleBackColor = true;
            this.btnOKaddCar.Visible = false;
            this.btnOKaddCar.Click += new System.EventHandler(this.btnOKaddCar_Click);
            // 
            // lblShowCars
            // 
            this.lblShowCars.AutoSize = true;
            this.lblShowCars.BackColor = System.Drawing.Color.Transparent;
            this.lblShowCars.Location = new System.Drawing.Point(144, 20);
            this.lblShowCars.Name = "lblShowCars";
            this.lblShowCars.Size = new System.Drawing.Size(33, 15);
            this.lblShowCars.TabIndex = 18;
            this.lblShowCars.Text = "Cars:";
            this.lblShowCars.Visible = false;
            this.lblShowCars.Click += new System.EventHandler(this.lblShowCars_Click);
            // 
            // lblInProcess
            // 
            this.lblInProcess.AutoSize = true;
            this.lblInProcess.Location = new System.Drawing.Point(445, 35);
            this.lblInProcess.Name = "lblInProcess";
            this.lblInProcess.Size = new System.Drawing.Size(49, 15);
            this.lblInProcess.TabIndex = 19;
            this.lblInProcess.Text = "License:";
            this.lblInProcess.Visible = false;
            // 
            // txtInProcess
            // 
            this.txtInProcess.Location = new System.Drawing.Point(500, 32);
            this.txtInProcess.Name = "txtInProcess";
            this.txtInProcess.Size = new System.Drawing.Size(100, 23);
            this.txtInProcess.TabIndex = 20;
            this.txtInProcess.Visible = false;
            // 
            // btnInProcessOk
            // 
            this.btnInProcessOk.Location = new System.Drawing.Point(512, 65);
            this.btnInProcessOk.Name = "btnInProcessOk";
            this.btnInProcessOk.Size = new System.Drawing.Size(75, 23);
            this.btnInProcessOk.TabIndex = 21;
            this.btnInProcessOk.Text = "OK";
            this.btnInProcessOk.UseVisualStyleBackColor = true;
            this.btnInProcessOk.Visible = false;
            this.btnInProcessOk.Click += new System.EventHandler(this.btnInProcessOk_Click);
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.Location = new System.Drawing.Point(512, 194);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveCar.TabIndex = 22;
            this.btnRemoveCar.Text = "OK";
            this.btnRemoveCar.UseVisualStyleBackColor = true;
            // 
            // lblTakeLicense
            // 
            this.lblTakeLicense.AutoSize = true;
            this.lblTakeLicense.Location = new System.Drawing.Point(445, 116);
            this.lblTakeLicense.Name = "lblTakeLicense";
            this.lblTakeLicense.Size = new System.Drawing.Size(49, 15);
            this.lblTakeLicense.TabIndex = 23;
            this.lblTakeLicense.Text = "License:";
            this.lblTakeLicense.Visible = false;
            // 
            // lblTakeId
            // 
            this.lblTakeId.AutoSize = true;
            this.lblTakeId.Location = new System.Drawing.Point(445, 158);
            this.lblTakeId.Name = "lblTakeId";
            this.lblTakeId.Size = new System.Drawing.Size(21, 15);
            this.lblTakeId.TabIndex = 24;
            this.lblTakeId.Text = "ID:";
            this.lblTakeId.Visible = false;
            this.lblTakeId.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(500, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 26;
            // 
            // GarageG1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTakeId);
            this.Controls.Add(this.lblTakeLicense);
            this.Controls.Add(this.btnRemoveCar);
            this.Controls.Add(this.btnInProcessOk);
            this.Controls.Add(this.txtInProcess);
            this.Controls.Add(this.lblInProcess);
            this.Controls.Add(this.lblShowCars);
            this.Controls.Add(this.btnOKaddCar);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtEngine);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMaker);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtlName);
            this.Controls.Add(this.txtfName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblAddCar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTakeCar);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnFixCar);
            this.Controls.Add(this.btnAddCar);
            this.Name = "GarageG1";
            this.Text = "G1 Garage Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnFixCar;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnTakeCar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAddCar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtfName;
        private System.Windows.Forms.TextBox txtlName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.TextBox txtMaker;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtEngine;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnOKaddCar;
        private System.Windows.Forms.Label lblShowCars;
        private System.Windows.Forms.Label lblInProcess;
        private System.Windows.Forms.TextBox txtInProcess;
        private System.Windows.Forms.Button btnInProcessOk;
        private System.Windows.Forms.Button btnRemoveCar;
        private System.Windows.Forms.Label lblTakeLicense;
        private System.Windows.Forms.Label lblTakeId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

