namespace Multi_Lease_Mangement_System
{
    partial class Payments
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
            this.Datelabel = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.Amountlabel = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.LeaseID = new System.Windows.Forms.Label();
            this.LeaseIDBox = new System.Windows.Forms.TextBox();
            this.Insert3 = new System.Windows.Forms.Button();
            this.Update3 = new System.Windows.Forms.Button();
            this.Delete3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Location = new System.Drawing.Point(92, 57);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(48, 20);
            this.Datelabel.TabIndex = 0;
            this.Datelabel.Text = "Date:";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(146, 57);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(100, 26);
            this.DateBox.TabIndex = 1;
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.Location = new System.Drawing.Point(70, 105);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(69, 20);
            this.Amountlabel.TabIndex = 2;
            this.Amountlabel.Text = "Amount:";
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(146, 105);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(100, 26);
            this.AmountBox.TabIndex = 3;
            // 
            // LeaseID
            // 
            this.LeaseID.AutoSize = true;
            this.LeaseID.Location = new System.Drawing.Point(62, 155);
            this.LeaseID.Name = "LeaseID";
            this.LeaseID.Size = new System.Drawing.Size(78, 20);
            this.LeaseID.TabIndex = 4;
            this.LeaseID.Text = "Lease ID:";
            // 
            // LeaseIDBox
            // 
            this.LeaseIDBox.Location = new System.Drawing.Point(146, 155);
            this.LeaseIDBox.Name = "LeaseIDBox";
            this.LeaseIDBox.Size = new System.Drawing.Size(100, 26);
            this.LeaseIDBox.TabIndex = 5;
            // 
            // Insert3
            // 
            this.Insert3.Location = new System.Drawing.Point(34, 212);
            this.Insert3.Name = "Insert3";
            this.Insert3.Size = new System.Drawing.Size(75, 35);
            this.Insert3.TabIndex = 6;
            this.Insert3.Text = "Insert";
            this.Insert3.UseVisualStyleBackColor = true;
            this.Insert3.Click += new System.EventHandler(this.Insert3_Click);
            // 
            // Update3
            // 
            this.Update3.Location = new System.Drawing.Point(146, 212);
            this.Update3.Name = "Update3";
            this.Update3.Size = new System.Drawing.Size(75, 35);
            this.Update3.TabIndex = 7;
            this.Update3.Text = "Update";
            this.Update3.UseVisualStyleBackColor = true;
            this.Update3.Click += new System.EventHandler(this.Update3_Click);
            // 
            // Delete3
            // 
            this.Delete3.Location = new System.Drawing.Point(258, 212);
            this.Delete3.Name = "Delete3";
            this.Delete3.Size = new System.Drawing.Size(75, 35);
            this.Delete3.TabIndex = 8;
            this.Delete3.Text = "Delete";
            this.Delete3.UseVisualStyleBackColor = true;
            this.Delete3.Click += new System.EventHandler(this.Delete3_Click);
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 260);
            this.Controls.Add(this.Delete3);
            this.Controls.Add(this.Update3);
            this.Controls.Add(this.Insert3);
            this.Controls.Add(this.LeaseIDBox);
            this.Controls.Add(this.LeaseID);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.Amountlabel);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.Datelabel);
            this.Name = "Payments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label LeaseID;
        private System.Windows.Forms.TextBox LeaseIDBox;
        private System.Windows.Forms.Button Insert3;
        private System.Windows.Forms.Button Update3;
        private System.Windows.Forms.Button Delete3;
    }
}