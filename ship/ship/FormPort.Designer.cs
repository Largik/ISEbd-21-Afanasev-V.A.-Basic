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
            this.buttonCreateMotorShip = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.groupBoxTakeShip = new System.Windows.Forms.GroupBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBoxPlaceShip = new System.Windows.Forms.MaskedTextBox();
            this.buttonTakeShip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).BeginInit();
            this.groupBoxTakeShip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPort
            // 
            this.pictureBoxPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxPort.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPort.Name = "pictureBoxPort";
            this.pictureBoxPort.Size = new System.Drawing.Size(686, 450);
            this.pictureBoxPort.TabIndex = 0;
            this.pictureBoxPort.TabStop = false;
            // 
            // buttonCreateMotorShip
            // 
            this.buttonCreateMotorShip.Location = new System.Drawing.Point(692, 63);
            this.buttonCreateMotorShip.Name = "buttonCreateMotorShip";
            this.buttonCreateMotorShip.Size = new System.Drawing.Size(96, 58);
            this.buttonCreateMotorShip.TabIndex = 7;
            this.buttonCreateMotorShip.Text = "Припарковать теплоход";
            this.buttonCreateMotorShip.UseVisualStyleBackColor = true;
            this.buttonCreateMotorShip.Click += new System.EventHandler(this.buttonCreateMotorShip_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(692, 12);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(96, 45);
            this.buttonCreate.TabIndex = 8;
            this.buttonCreate.Text = "Припарковать корабль";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // groupBoxTakeShip
            // 
            this.groupBoxTakeShip.Controls.Add(this.buttonTakeShip);
            this.groupBoxTakeShip.Controls.Add(this.maskedTextBoxPlaceShip);
            this.groupBoxTakeShip.Controls.Add(this.labelPlace);
            this.groupBoxTakeShip.Location = new System.Drawing.Point(687, 127);
            this.groupBoxTakeShip.Name = "groupBoxTakeShip";
            this.groupBoxTakeShip.Size = new System.Drawing.Size(115, 100);
            this.groupBoxTakeShip.TabIndex = 9;
            this.groupBoxTakeShip.TabStop = false;
            this.groupBoxTakeShip.Text = "Забрать Судно";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 27);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 10;
            this.labelPlace.Text = "Место:";
            // 
            // maskedTextBoxPlaceShip
            // 
            this.maskedTextBoxPlaceShip.Location = new System.Drawing.Point(51, 24);
            this.maskedTextBoxPlaceShip.Name = "maskedTextBoxPlaceShip";
            this.maskedTextBoxPlaceShip.Size = new System.Drawing.Size(44, 20);
            this.maskedTextBoxPlaceShip.TabIndex = 10;
            // 
            // buttonTakeShip
            // 
            this.buttonTakeShip.Location = new System.Drawing.Point(9, 62);
            this.buttonTakeShip.Name = "buttonTakeShip";
            this.buttonTakeShip.Size = new System.Drawing.Size(86, 23);
            this.buttonTakeShip.TabIndex = 10;
            this.buttonTakeShip.Text = "Забрать ";
            this.buttonTakeShip.UseVisualStyleBackColor = true;
            this.buttonTakeShip.Click += new System.EventHandler(this.buttonTakeShip_Click);
            // 
            // FormPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxTakeShip);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonCreateMotorShip);
            this.Controls.Add(this.pictureBoxPort);
            this.Name = "FormPort";
            this.Text = "Порт";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).EndInit();
            this.groupBoxTakeShip.ResumeLayout(false);
            this.groupBoxTakeShip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPort;
        private System.Windows.Forms.Button buttonCreateMotorShip;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.GroupBox groupBoxTakeShip;
        private System.Windows.Forms.Button buttonTakeShip;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaceShip;
        private System.Windows.Forms.Label labelPlace;
    }
}