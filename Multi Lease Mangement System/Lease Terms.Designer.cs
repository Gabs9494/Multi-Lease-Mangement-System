namespace Multi_Lease_Mangement_System
{
    partial class Lease_Terms
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
            this.Numberofyearslabel = new System.Windows.Forms.Label();
            this.NumberofyearsBox = new System.Windows.Forms.TextBox();
            this.Maximumkilometreslabel = new System.Windows.Forms.Label();
            this.MaximumkilometresBox = new System.Windows.Forms.TextBox();
            this.Chargeforextramileagelabel = new System.Windows.Forms.Label();
            this.centskilometreBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Insert2 = new System.Windows.Forms.Button();
            this.Update2 = new System.Windows.Forms.Button();
            this.Delete2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numberofyearslabel
            // 
            this.Numberofyearslabel.AutoSize = true;
            this.Numberofyearslabel.Location = new System.Drawing.Point(118, 42);
            this.Numberofyearslabel.Name = "Numberofyearslabel";
            this.Numberofyearslabel.Size = new System.Drawing.Size(129, 20);
            this.Numberofyearslabel.TabIndex = 0;
            this.Numberofyearslabel.Text = "Number of years:";
            // 
            // NumberofyearsBox
            // 
            this.NumberofyearsBox.Location = new System.Drawing.Point(266, 42);
            this.NumberofyearsBox.Name = "NumberofyearsBox";
            this.NumberofyearsBox.Size = new System.Drawing.Size(121, 26);
            this.NumberofyearsBox.TabIndex = 1;
            // 
            // Maximumkilometreslabel
            // 
            this.Maximumkilometreslabel.AutoSize = true;
            this.Maximumkilometreslabel.Location = new System.Drawing.Point(92, 85);
            this.Maximumkilometreslabel.Name = "Maximumkilometreslabel";
            this.Maximumkilometreslabel.Size = new System.Drawing.Size(156, 20);
            this.Maximumkilometreslabel.TabIndex = 2;
            this.Maximumkilometreslabel.Text = "Maximum kilometres:";
            // 
            // MaximumkilometresBox
            // 
            this.MaximumkilometresBox.Location = new System.Drawing.Point(266, 85);
            this.MaximumkilometresBox.Name = "MaximumkilometresBox";
            this.MaximumkilometresBox.Size = new System.Drawing.Size(121, 26);
            this.MaximumkilometresBox.TabIndex = 3;
            // 
            // Chargeforextramileagelabel
            // 
            this.Chargeforextramileagelabel.AutoSize = true;
            this.Chargeforextramileagelabel.Location = new System.Drawing.Point(62, 122);
            this.Chargeforextramileagelabel.Name = "Chargeforextramileagelabel";
            this.Chargeforextramileagelabel.Size = new System.Drawing.Size(186, 20);
            this.Chargeforextramileagelabel.TabIndex = 4;
            this.Chargeforextramileagelabel.Text = "Charge for extra mileage:";
            this.Chargeforextramileagelabel.Click += new System.EventHandler(this.Chargeforextramileagelabel_Click);
            // 
            // centskilometreBox
            // 
            this.centskilometreBox.Location = new System.Drawing.Point(266, 122);
            this.centskilometreBox.Name = "centskilometreBox";
            this.centskilometreBox.Size = new System.Drawing.Size(121, 26);
            this.centskilometreBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            // 
            // Insert2
            // 
            this.Insert2.Location = new System.Drawing.Point(52, 174);
            this.Insert2.Name = "Insert2";
            this.Insert2.Size = new System.Drawing.Size(82, 29);
            this.Insert2.TabIndex = 7;
            this.Insert2.Text = "Insert";
            this.Insert2.UseVisualStyleBackColor = true;
            this.Insert2.Click += new System.EventHandler(this.Insert2_Click);
            // 
            // Update2
            // 
            this.Update2.Location = new System.Drawing.Point(172, 174);
            this.Update2.Name = "Update2";
            this.Update2.Size = new System.Drawing.Size(75, 29);
            this.Update2.TabIndex = 8;
            this.Update2.Text = "Update";
            this.Update2.UseVisualStyleBackColor = true;
            this.Update2.Click += new System.EventHandler(this.Update2_Click);
            // 
            // Delete2
            // 
            this.Delete2.Location = new System.Drawing.Point(291, 174);
            this.Delete2.Name = "Delete2";
            this.Delete2.Size = new System.Drawing.Size(75, 29);
            this.Delete2.TabIndex = 9;
            this.Delete2.Text = "Delete";
            this.Delete2.UseVisualStyleBackColor = true;
            this.Delete2.Click += new System.EventHandler(this.Delete2_Click);
            // 
            // Lease_Terms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 228);
            this.Controls.Add(this.Delete2);
            this.Controls.Add(this.Update2);
            this.Controls.Add(this.Insert2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.centskilometreBox);
            this.Controls.Add(this.Chargeforextramileagelabel);
            this.Controls.Add(this.MaximumkilometresBox);
            this.Controls.Add(this.Maximumkilometreslabel);
            this.Controls.Add(this.NumberofyearsBox);
            this.Controls.Add(this.Numberofyearslabel);
            this.Name = "Lease_Terms";
            this.Text = "Lease Terms";
            this.Load += new System.EventHandler(this.Lease_Terms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Numberofyearslabel;
        private System.Windows.Forms.TextBox NumberofyearsBox;
        private System.Windows.Forms.Label Maximumkilometreslabel;
        private System.Windows.Forms.TextBox MaximumkilometresBox;
        private System.Windows.Forms.Label Chargeforextramileagelabel;
        private System.Windows.Forms.TextBox centskilometreBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Insert2;
        private System.Windows.Forms.Button Update2;
        private System.Windows.Forms.Button Delete2;
    }
}