namespace Multi_Lease_Mangement_System
{
    partial class Vehicles
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
            this.VehicleVIN = new System.Windows.Forms.Label();
            this.VehicleVINBox = new System.Windows.Forms.TextBox();
            this.Modellabel = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.Typelabel = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.Colourlabel = new System.Windows.Forms.Label();
            this.ColourBox = new System.Windows.Forms.TextBox();
            this.Yearlabel = new System.Windows.Forms.Label();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.Kilometresonodometerlabel = new System.Windows.Forms.Label();
            this.KilometresonodometerBox = new System.Windows.Forms.TextBox();
            this.clabel = new System.Windows.Forms.Label();
            this.WhetherornotthevehiclehasbeenleasedbeforeBox = new System.Windows.Forms.TextBox();
            this.Bookvaluelabel = new System.Windows.Forms.Label();
            this.BookvalueBox = new System.Windows.Forms.TextBox();
            this.Whetherornotthevehiclehaslabel = new System.Windows.Forms.Label();
            this.automatictransmissionairconditioningpowerlocksbox = new System.Windows.Forms.TextBox();
            this.Insert6 = new System.Windows.Forms.Button();
            this.Update6 = new System.Windows.Forms.Button();
            this.Delete6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VehicleVIN
            // 
            this.VehicleVIN.AutoSize = true;
            this.VehicleVIN.Location = new System.Drawing.Point(302, 38);
            this.VehicleVIN.Name = "VehicleVIN";
            this.VehicleVIN.Size = new System.Drawing.Size(96, 20);
            this.VehicleVIN.TabIndex = 0;
            this.VehicleVIN.Text = "Vehicle VIN:";
            // 
            // VehicleVINBox
            // 
            this.VehicleVINBox.Location = new System.Drawing.Point(417, 38);
            this.VehicleVINBox.Name = "VehicleVINBox";
            this.VehicleVINBox.Size = new System.Drawing.Size(352, 26);
            this.VehicleVINBox.TabIndex = 1;
            // 
            // Modellabel
            // 
            this.Modellabel.AutoSize = true;
            this.Modellabel.Location = new System.Drawing.Point(342, 86);
            this.Modellabel.Name = "Modellabel";
            this.Modellabel.Size = new System.Drawing.Size(56, 20);
            this.Modellabel.TabIndex = 2;
            this.Modellabel.Text = "Model:";
            this.Modellabel.Click += new System.EventHandler(this.Modellabel_Click);
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(417, 86);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(352, 26);
            this.ModelBox.TabIndex = 3;
            // 
            // Typelabel
            // 
            this.Typelabel.AutoSize = true;
            this.Typelabel.Location = new System.Drawing.Point(351, 129);
            this.Typelabel.Name = "Typelabel";
            this.Typelabel.Size = new System.Drawing.Size(47, 20);
            this.Typelabel.TabIndex = 4;
            this.Typelabel.Text = "Type:";
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(417, 129);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(352, 26);
            this.TypeBox.TabIndex = 5;
            this.TypeBox.TextChanged += new System.EventHandler(this.TypeBox_TextChanged);
            // 
            // Colourlabel
            // 
            this.Colourlabel.AutoSize = true;
            this.Colourlabel.Location = new System.Drawing.Point(339, 174);
            this.Colourlabel.Name = "Colourlabel";
            this.Colourlabel.Size = new System.Drawing.Size(59, 20);
            this.Colourlabel.TabIndex = 6;
            this.Colourlabel.Text = "Colour:";
            this.Colourlabel.Click += new System.EventHandler(this.Colourlabel_Click);
            // 
            // ColourBox
            // 
            this.ColourBox.Location = new System.Drawing.Point(417, 174);
            this.ColourBox.Name = "ColourBox";
            this.ColourBox.Size = new System.Drawing.Size(352, 26);
            this.ColourBox.TabIndex = 7;
            // 
            // Yearlabel
            // 
            this.Yearlabel.AutoSize = true;
            this.Yearlabel.Location = new System.Drawing.Point(351, 217);
            this.Yearlabel.Name = "Yearlabel";
            this.Yearlabel.Size = new System.Drawing.Size(47, 20);
            this.Yearlabel.TabIndex = 8;
            this.Yearlabel.Text = "Year:";
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(417, 217);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(352, 26);
            this.YearBox.TabIndex = 9;
            // 
            // Kilometresonodometerlabel
            // 
            this.Kilometresonodometerlabel.AutoSize = true;
            this.Kilometresonodometerlabel.Location = new System.Drawing.Point(218, 263);
            this.Kilometresonodometerlabel.Name = "Kilometresonodometerlabel";
            this.Kilometresonodometerlabel.Size = new System.Drawing.Size(181, 20);
            this.Kilometresonodometerlabel.TabIndex = 10;
            this.Kilometresonodometerlabel.Text = "Kilometres on odometer:";
            // 
            // KilometresonodometerBox
            // 
            this.KilometresonodometerBox.Location = new System.Drawing.Point(417, 263);
            this.KilometresonodometerBox.Name = "KilometresonodometerBox";
            this.KilometresonodometerBox.Size = new System.Drawing.Size(352, 26);
            this.KilometresonodometerBox.TabIndex = 11;
            // 
            // clabel
            // 
            this.clabel.AutoSize = true;
            this.clabel.Location = new System.Drawing.Point(28, 317);
            this.clabel.Name = "clabel";
            this.clabel.Size = new System.Drawing.Size(369, 20);
            this.clabel.TabIndex = 12;
            this.clabel.Text = "Whether or not the vehicle has been leased before:";
            this.clabel.Click += new System.EventHandler(this.clabel_Click);
            // 
            // WhetherornotthevehiclehasbeenleasedbeforeBox
            // 
            this.WhetherornotthevehiclehasbeenleasedbeforeBox.Location = new System.Drawing.Point(417, 317);
            this.WhetherornotthevehiclehasbeenleasedbeforeBox.Name = "WhetherornotthevehiclehasbeenleasedbeforeBox";
            this.WhetherornotthevehiclehasbeenleasedbeforeBox.Size = new System.Drawing.Size(352, 26);
            this.WhetherornotthevehiclehasbeenleasedbeforeBox.TabIndex = 13;
            // 
            // Bookvaluelabel
            // 
            this.Bookvaluelabel.AutoSize = true;
            this.Bookvaluelabel.Location = new System.Drawing.Point(308, 368);
            this.Bookvaluelabel.Name = "Bookvaluelabel";
            this.Bookvaluelabel.Size = new System.Drawing.Size(91, 20);
            this.Bookvaluelabel.TabIndex = 14;
            this.Bookvaluelabel.Text = "Book value:";
            // 
            // BookvalueBox
            // 
            this.BookvalueBox.Location = new System.Drawing.Point(417, 368);
            this.BookvalueBox.Name = "BookvalueBox";
            this.BookvalueBox.Size = new System.Drawing.Size(352, 26);
            this.BookvalueBox.TabIndex = 15;
            // 
            // Whetherornotthevehiclehaslabel
            // 
            this.Whetherornotthevehiclehaslabel.AutoSize = true;
            this.Whetherornotthevehiclehaslabel.Location = new System.Drawing.Point(170, 412);
            this.Whetherornotthevehiclehaslabel.Name = "Whetherornotthevehiclehaslabel";
            this.Whetherornotthevehiclehaslabel.Size = new System.Drawing.Size(228, 20);
            this.Whetherornotthevehiclehaslabel.TabIndex = 16;
            this.Whetherornotthevehiclehaslabel.Text = "Whether or not the vehicle has:";
            // 
            // automatictransmissionairconditioningpowerlocksbox
            // 
            this.automatictransmissionairconditioningpowerlocksbox.Location = new System.Drawing.Point(417, 412);
            this.automatictransmissionairconditioningpowerlocksbox.Name = "automatictransmissionairconditioningpowerlocksbox";
            this.automatictransmissionairconditioningpowerlocksbox.Size = new System.Drawing.Size(352, 26);
            this.automatictransmissionairconditioningpowerlocksbox.TabIndex = 17;
            // 
            // Insert6
            // 
            this.Insert6.Location = new System.Drawing.Point(174, 465);
            this.Insert6.Name = "Insert6";
            this.Insert6.Size = new System.Drawing.Size(75, 35);
            this.Insert6.TabIndex = 18;
            this.Insert6.Text = "Insert";
            this.Insert6.UseVisualStyleBackColor = true;
            this.Insert6.Click += new System.EventHandler(this.Insert6_Click);
            // 
            // Update6
            // 
            this.Update6.Location = new System.Drawing.Point(306, 465);
            this.Update6.Name = "Update6";
            this.Update6.Size = new System.Drawing.Size(75, 35);
            this.Update6.TabIndex = 19;
            this.Update6.Text = "Update";
            this.Update6.UseVisualStyleBackColor = true;
            this.Update6.Click += new System.EventHandler(this.Update6_Click);
            // 
            // Delete6
            // 
            this.Delete6.Location = new System.Drawing.Point(440, 465);
            this.Delete6.Name = "Delete6";
            this.Delete6.Size = new System.Drawing.Size(75, 35);
            this.Delete6.TabIndex = 20;
            this.Delete6.Text = "Delete";
            this.Delete6.UseVisualStyleBackColor = true;
            this.Delete6.Click += new System.EventHandler(this.Delete6_Click);
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 525);
            this.Controls.Add(this.Delete6);
            this.Controls.Add(this.Update6);
            this.Controls.Add(this.Insert6);
            this.Controls.Add(this.automatictransmissionairconditioningpowerlocksbox);
            this.Controls.Add(this.Whetherornotthevehiclehaslabel);
            this.Controls.Add(this.BookvalueBox);
            this.Controls.Add(this.Bookvaluelabel);
            this.Controls.Add(this.WhetherornotthevehiclehasbeenleasedbeforeBox);
            this.Controls.Add(this.clabel);
            this.Controls.Add(this.KilometresonodometerBox);
            this.Controls.Add(this.Kilometresonodometerlabel);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.Yearlabel);
            this.Controls.Add(this.ColourBox);
            this.Controls.Add(this.Colourlabel);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.Typelabel);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.Modellabel);
            this.Controls.Add(this.VehicleVINBox);
            this.Controls.Add(this.VehicleVIN);
            this.Name = "Vehicles";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Vehicles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VehicleVIN;
        private System.Windows.Forms.TextBox VehicleVINBox;
        private System.Windows.Forms.Label Modellabel;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.Label Typelabel;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.Label Colourlabel;
        private System.Windows.Forms.TextBox ColourBox;
        private System.Windows.Forms.Label Yearlabel;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.Label Kilometresonodometerlabel;
        private System.Windows.Forms.TextBox KilometresonodometerBox;
        private System.Windows.Forms.Label clabel;
        private System.Windows.Forms.TextBox WhetherornotthevehiclehasbeenleasedbeforeBox;
        private System.Windows.Forms.Label Bookvaluelabel;
        private System.Windows.Forms.TextBox BookvalueBox;
        private System.Windows.Forms.Label Whetherornotthevehiclehaslabel;
        private System.Windows.Forms.TextBox automatictransmissionairconditioningpowerlocksbox;
        private System.Windows.Forms.Button Insert6;
        private System.Windows.Forms.Button Update6;
        private System.Windows.Forms.Button Delete6;
    }
}