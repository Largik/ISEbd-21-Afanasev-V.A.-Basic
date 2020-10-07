namespace ship
{
    partial class FormPort
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
            this.pictureBoxPort = new System.Windows.Forms.PictureBox();
            this.buttonParkingShip = new System.Windows.Forms.Button();
            this.buttonMotorShip = new System.Windows.Forms.Button();
            this.groupBoxTakeShip = new System.Windows.Forms.GroupBox();
            this.buttonTakeShip = new System.Windows.Forms.Button();
            this.maskedTextBoxPlaceShip = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).BeginInit();
            this.groupBoxTakeShip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPort
            // 
            this.pictureBoxPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxPort.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPort.Name = "pictureBoxPort";
            this.pictureBoxPort.Size = new System.Drawing.Size(681, 450);
            this.pictureBoxPort.TabIndex = 0;
            this.pictureBoxPort.TabStop = false;
            // 
            // buttonParkingShip
            // 
            this.buttonParkingShip.Location = new System.Drawing.Point(687, 12);
            this.buttonParkingShip.Name = "buttonParkingShip";
            this.buttonParkingShip.Size = new System.Drawing.Size(101, 48);
            this.buttonParkingShip.TabIndex = 1;
            this.buttonParkingShip.Text = "Припарковать корабль";
            this.buttonParkingShip.UseVisualStyleBackColor = true;
            this.buttonParkingShip.Click += new System.EventHandler(this.buttonParkingShip_Click);
            // 
            // buttonMotorShip
            // 
            this.buttonMotorShip.Location = new System.Drawing.Point(687, 66);
            this.buttonMotorShip.Name = "buttonMotorShip";
            this.buttonMotorShip.Size = new System.Drawing.Size(101, 48);
            this.buttonMotorShip.TabIndex = 2;
            this.buttonMotorShip.Text = "Припарковать теплоход";
            this.buttonMotorShip.UseVisualStyleBackColor = true;
            this.buttonMotorShip.Click += new System.EventHandler(this.buttonMotorShip_Click);
            // 
            // groupBoxTakeShip
            // 
            this.groupBoxTakeShip.Controls.Add(this.buttonTakeShip);
            this.groupBoxTakeShip.Controls.Add(this.maskedTextBoxPlaceShip);
            this.groupBoxTakeShip.Controls.Add(this.labelPlace);
            this.groupBoxTakeShip.Location = new System.Drawing.Point(687, 120);
            this.groupBoxTakeShip.Name = "groupBoxTakeShip";
            this.groupBoxTakeShip.Size = new System.Drawing.Size(110, 91);
            this.groupBoxTakeShip.TabIndex = 3;
            this.groupBoxTakeShip.TabStop = false;
            this.groupBoxTakeShip.Text = "Забрать корабль";
            // 
            // buttonTakeShip
            // 
            this.buttonTakeShip.Location = new System.Drawing.Point(12, 51);
            this.buttonTakeShip.Name = "buttonTakeShip";
            this.buttonTakeShip.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeShip.TabIndex = 4;
            this.buttonTakeShip.Text = "Забрать";
            this.buttonTakeShip.UseVisualStyleBackColor = true;
            this.buttonTakeShip.Click += new System.EventHandler(this.buttonTakeShip_Click);
            // 
            // maskedTextBoxPlaceShip
            // 
            this.maskedTextBoxPlaceShip.Location = new System.Drawing.Point(54, 25);
            this.maskedTextBoxPlaceShip.Name = "maskedTextBoxPlaceShip";
            this.maskedTextBoxPlaceShip.Size = new System.Drawing.Size(33, 20);
            this.maskedTextBoxPlaceShip.TabIndex = 4;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 28);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 4;
            this.labelPlace.Text = "Место:";
            // 
            // FormPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxTakeShip);
            this.Controls.Add(this.buttonMotorShip);
            this.Controls.Add(this.buttonParkingShip);
            this.Controls.Add(this.pictureBoxPort);
            this.Name = "FormPort";
            this.Text = "Port";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).EndInit();
            this.groupBoxTakeShip.ResumeLayout(false);
            this.groupBoxTakeShip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPort;
        private System.Windows.Forms.Button buttonParkingShip;
        private System.Windows.Forms.Button buttonMotorShip;
        private System.Windows.Forms.GroupBox groupBoxTakeShip;
        private System.Windows.Forms.Button buttonTakeShip;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaceShip;
        private System.Windows.Forms.Label labelPlace;
    }
}