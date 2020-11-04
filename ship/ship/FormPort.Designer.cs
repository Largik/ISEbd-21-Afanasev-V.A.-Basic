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
            this.groupBoxTakeShip = new System.Windows.Forms.GroupBox();
            this.buttonTakeShip = new System.Windows.Forms.Button();
            this.maskedTextBoxPlaceShip = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.buttonDeletePort = new System.Windows.Forms.Button();
            this.listBoxPorts = new System.Windows.Forms.ListBox();
            this.buttonAddPort = new System.Windows.Forms.Button();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.Ports = new System.Windows.Forms.Label();
            this.buttonSetShip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).BeginInit();
            this.groupBoxTakeShip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPort
            // 
            this.pictureBoxPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxPort.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPort.Name = "pictureBoxPort";
            this.pictureBoxPort.Size = new System.Drawing.Size(686, 490);
            this.pictureBoxPort.TabIndex = 0;
            this.pictureBoxPort.TabStop = false;
            // 
            // groupBoxTakeShip
            // 
            this.groupBoxTakeShip.Controls.Add(this.buttonTakeShip);
            this.groupBoxTakeShip.Controls.Add(this.maskedTextBoxPlaceShip);
            this.groupBoxTakeShip.Controls.Add(this.labelPlace);
            this.groupBoxTakeShip.Location = new System.Drawing.Point(696, 384);
            this.groupBoxTakeShip.Name = "groupBoxTakeShip";
            this.groupBoxTakeShip.Size = new System.Drawing.Size(120, 100);
            this.groupBoxTakeShip.TabIndex = 9;
            this.groupBoxTakeShip.TabStop = false;
            this.groupBoxTakeShip.Text = "Забрать Судно";
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
            // maskedTextBoxPlaceShip
            // 
            this.maskedTextBoxPlaceShip.Location = new System.Drawing.Point(51, 24);
            this.maskedTextBoxPlaceShip.Name = "maskedTextBoxPlaceShip";
            this.maskedTextBoxPlaceShip.Size = new System.Drawing.Size(44, 20);
            this.maskedTextBoxPlaceShip.TabIndex = 10;
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
            // buttonDeletePort
            // 
            this.buttonDeletePort.Location = new System.Drawing.Point(696, 199);
            this.buttonDeletePort.Name = "buttonDeletePort";
            this.buttonDeletePort.Size = new System.Drawing.Size(120, 25);
            this.buttonDeletePort.TabIndex = 10;
            this.buttonDeletePort.Text = "Удалить порт\r\n";
            this.buttonDeletePort.UseVisualStyleBackColor = true;
            this.buttonDeletePort.Click += new System.EventHandler(this.buttonDeletePort_Click);
            // 
            // listBoxPorts
            // 
            this.listBoxPorts.FormattingEnabled = true;
            this.listBoxPorts.Location = new System.Drawing.Point(696, 98);
            this.listBoxPorts.Name = "listBoxPorts";
            this.listBoxPorts.Size = new System.Drawing.Size(120, 95);
            this.listBoxPorts.TabIndex = 11;
            this.listBoxPorts.SelectedIndexChanged += new System.EventHandler(this.listBoxPorts_SelectedIndexChanged);
            // 
            // buttonAddPort
            // 
            this.buttonAddPort.Location = new System.Drawing.Point(696, 67);
            this.buttonAddPort.Name = "buttonAddPort";
            this.buttonAddPort.Size = new System.Drawing.Size(120, 25);
            this.buttonAddPort.TabIndex = 12;
            this.buttonAddPort.Text = "Добавить порт\r\n";
            this.buttonAddPort.UseVisualStyleBackColor = true;
            this.buttonAddPort.Click += new System.EventHandler(this.buttonAddPort_Click);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(696, 41);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(120, 20);
            this.textBoxNewLevelName.TabIndex = 13;
            // 
            // Ports
            // 
            this.Ports.AutoSize = true;
            this.Ports.Location = new System.Drawing.Point(735, 25);
            this.Ports.Name = "Ports";
            this.Ports.Size = new System.Drawing.Size(43, 13);
            this.Ports.TabIndex = 15;
            this.Ports.Text = "Порты:\r\n";
            // 
            // buttonSetShip
            // 
            this.buttonSetShip.Location = new System.Drawing.Point(696, 320);
            this.buttonSetShip.Name = "buttonSetShip";
            this.buttonSetShip.Size = new System.Drawing.Size(120, 58);
            this.buttonSetShip.TabIndex = 16;
            this.buttonSetShip.Text = "Добавить корабль\r\n";
            this.buttonSetShip.UseVisualStyleBackColor = true;
            this.buttonSetShip.Click += new System.EventHandler(this.buttonSetShip_Click);
            // 
            // FormPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 490);
            this.Controls.Add(this.buttonSetShip);
            this.Controls.Add(this.Ports);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.buttonAddPort);
            this.Controls.Add(this.listBoxPorts);
            this.Controls.Add(this.buttonDeletePort);
            this.Controls.Add(this.groupBoxTakeShip);
            this.Controls.Add(this.pictureBoxPort);
            this.Name = "FormPort";
            this.Text = "Порт";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).EndInit();
            this.groupBoxTakeShip.ResumeLayout(false);
            this.groupBoxTakeShip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPort;
        private System.Windows.Forms.GroupBox groupBoxTakeShip;
        private System.Windows.Forms.Button buttonTakeShip;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaceShip;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonDeletePort;
        private System.Windows.Forms.ListBox listBoxPorts;
        private System.Windows.Forms.Button buttonAddPort;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label Ports;
        private System.Windows.Forms.Button buttonSetShip;
    }
}