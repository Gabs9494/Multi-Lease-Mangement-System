namespace Multi_Lease_Mangement_System
{
    partial class mainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.Auditbttn1 = new System.Windows.Forms.Button();
            this.OpenCustomerbttn1 = new System.Windows.Forms.Button();
            this.Leasetermsbttn1 = new System.Windows.Forms.Button();
            this.OpenPaymentsbbtn = new System.Windows.Forms.Button();
            this.OpenVehiclesbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Lease";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Auditbttn1
            // 
            this.Auditbttn1.Location = new System.Drawing.Point(47, 73);
            this.Auditbttn1.Name = "Auditbttn1";
            this.Auditbttn1.Size = new System.Drawing.Size(75, 23);
            this.Auditbttn1.TabIndex = 1;
            this.Auditbttn1.Text = "Open Audit";
            this.Auditbttn1.UseVisualStyleBackColor = true;
            this.Auditbttn1.Click += new System.EventHandler(this.Auditbttn1_Click);
            // 
            // OpenCustomerbttn1
            // 
            this.OpenCustomerbttn1.Location = new System.Drawing.Point(47, 120);
            this.OpenCustomerbttn1.Name = "OpenCustomerbttn1";
            this.OpenCustomerbttn1.Size = new System.Drawing.Size(111, 24);
            this.OpenCustomerbttn1.TabIndex = 2;
            this.OpenCustomerbttn1.Text = "Open Customer";
            this.OpenCustomerbttn1.UseVisualStyleBackColor = true;
            this.OpenCustomerbttn1.Click += new System.EventHandler(this.OpenCustomerbttn1_Click);
            // 
            // Leasetermsbttn1
            // 
            this.Leasetermsbttn1.Location = new System.Drawing.Point(47, 168);
            this.Leasetermsbttn1.Name = "Leasetermsbttn1";
            this.Leasetermsbttn1.Size = new System.Drawing.Size(111, 23);
            this.Leasetermsbttn1.TabIndex = 3;
            this.Leasetermsbttn1.Text = "Open Lease Terms";
            this.Leasetermsbttn1.UseVisualStyleBackColor = true;
            this.Leasetermsbttn1.Click += new System.EventHandler(this.Leasetermsbttn1_Click);
            // 
            // OpenPaymentsbbtn
            // 
            this.OpenPaymentsbbtn.Location = new System.Drawing.Point(47, 210);
            this.OpenPaymentsbbtn.Name = "OpenPaymentsbbtn";
            this.OpenPaymentsbbtn.Size = new System.Drawing.Size(111, 23);
            this.OpenPaymentsbbtn.TabIndex = 4;
            this.OpenPaymentsbbtn.Text = "Open Payments";
            this.OpenPaymentsbbtn.UseVisualStyleBackColor = true;
            this.OpenPaymentsbbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // OpenVehiclesbttn
            // 
            this.OpenVehiclesbttn.Location = new System.Drawing.Point(47, 254);
            this.OpenVehiclesbttn.Name = "OpenVehiclesbttn";
            this.OpenVehiclesbttn.Size = new System.Drawing.Size(111, 23);
            this.OpenVehiclesbttn.TabIndex = 5;
            this.OpenVehiclesbttn.Text = "Open Vehicles";
            this.OpenVehiclesbttn.UseVisualStyleBackColor = true;
            this.OpenVehiclesbttn.Click += new System.EventHandler(this.OpenVehiclesbttn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenVehiclesbttn);
            this.Controls.Add(this.OpenPaymentsbbtn);
            this.Controls.Add(this.Leasetermsbttn1);
            this.Controls.Add(this.OpenCustomerbttn1);
            this.Controls.Add(this.Auditbttn1);
            this.Controls.Add(this.button1);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Auditbttn1;
        private System.Windows.Forms.Button OpenCustomerbttn1;
        private System.Windows.Forms.Button Leasetermsbttn1;
        private System.Windows.Forms.Button OpenPaymentsbbtn;
        private System.Windows.Forms.Button OpenVehiclesbttn;
    }
}