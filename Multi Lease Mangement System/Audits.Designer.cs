namespace Multi_Lease_Mangement_System
{
    partial class Audits
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
            this.Datelabel1 = new System.Windows.Forms.Label();
            this.DateBox1 = new System.Windows.Forms.TextBox();
            this.Fieldinformationchanged = new System.Windows.Forms.Label();
            this.FieldinformationchangedBox = new System.Windows.Forms.TextBox();
            this.Changelabel1 = new System.Windows.Forms.Label();
            this.oldandnewvaluesBox = new System.Windows.Forms.TextBox();
            this.LeaseIDlabel1 = new System.Windows.Forms.Label();
            this.LeaseIDBox1 = new System.Windows.Forms.TextBox();
            this.Insert1 = new System.Windows.Forms.Button();
            this.Update1 = new System.Windows.Forms.Button();
            this.Delete1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Datelabel1
            // 
            this.Datelabel1.AutoSize = true;
            this.Datelabel1.Location = new System.Drawing.Point(172, 45);
            this.Datelabel1.Name = "Datelabel1";
            this.Datelabel1.Size = new System.Drawing.Size(48, 20);
            this.Datelabel1.TabIndex = 0;
            this.Datelabel1.Text = "Date:";
            this.Datelabel1.Click += new System.EventHandler(this.Datelabel1_Click);
            // 
            // DateBox1
            // 
            this.DateBox1.Location = new System.Drawing.Point(244, 45);
            this.DateBox1.Name = "DateBox1";
            this.DateBox1.Size = new System.Drawing.Size(100, 26);
            this.DateBox1.TabIndex = 1;
            // 
            // Fieldinformationchanged
            // 
            this.Fieldinformationchanged.AutoSize = true;
            this.Fieldinformationchanged.Location = new System.Drawing.Point(24, 78);
            this.Fieldinformationchanged.Name = "Fieldinformationchanged";
            this.Fieldinformationchanged.Size = new System.Drawing.Size(196, 20);
            this.Fieldinformationchanged.TabIndex = 2;
            this.Fieldinformationchanged.Text = "Field information changed:";
            this.Fieldinformationchanged.Click += new System.EventHandler(this.Fieldinformationchanged_Click);
            // 
            // FieldinformationchangedBox
            // 
            this.FieldinformationchangedBox.Location = new System.Drawing.Point(244, 78);
            this.FieldinformationchangedBox.Name = "FieldinformationchangedBox";
            this.FieldinformationchangedBox.Size = new System.Drawing.Size(100, 26);
            this.FieldinformationchangedBox.TabIndex = 3;
            // 
            // Changelabel1
            // 
            this.Changelabel1.AutoSize = true;
            this.Changelabel1.Location = new System.Drawing.Point(152, 120);
            this.Changelabel1.Name = "Changelabel1";
            this.Changelabel1.Size = new System.Drawing.Size(69, 20);
            this.Changelabel1.TabIndex = 4;
            this.Changelabel1.Text = "Change:";
            // 
            // oldandnewvaluesBox
            // 
            this.oldandnewvaluesBox.Location = new System.Drawing.Point(244, 120);
            this.oldandnewvaluesBox.Name = "oldandnewvaluesBox";
            this.oldandnewvaluesBox.Size = new System.Drawing.Size(100, 26);
            this.oldandnewvaluesBox.TabIndex = 5;
            // 
            // LeaseIDlabel1
            // 
            this.LeaseIDlabel1.AutoSize = true;
            this.LeaseIDlabel1.Location = new System.Drawing.Point(142, 171);
            this.LeaseIDlabel1.Name = "LeaseIDlabel1";
            this.LeaseIDlabel1.Size = new System.Drawing.Size(78, 20);
            this.LeaseIDlabel1.TabIndex = 6;
            this.LeaseIDlabel1.Text = "Lease ID:";
            // 
            // LeaseIDBox1
            // 
            this.LeaseIDBox1.Location = new System.Drawing.Point(244, 168);
            this.LeaseIDBox1.Name = "LeaseIDBox1";
            this.LeaseIDBox1.Size = new System.Drawing.Size(100, 26);
            this.LeaseIDBox1.TabIndex = 7;
            // 
            // Insert1
            // 
            this.Insert1.Location = new System.Drawing.Point(44, 215);
            this.Insert1.Name = "Insert1";
            this.Insert1.Size = new System.Drawing.Size(75, 28);
            this.Insert1.TabIndex = 8;
            this.Insert1.Text = "Insert";
            this.Insert1.UseVisualStyleBackColor = true;
            this.Insert1.Click += new System.EventHandler(this.Insert1_Click);
            // 
            // Update1
            // 
            this.Update1.Location = new System.Drawing.Point(154, 215);
            this.Update1.Name = "Update1";
            this.Update1.Size = new System.Drawing.Size(75, 29);
            this.Update1.TabIndex = 9;
            this.Update1.Text = "Update";
            this.Update1.UseVisualStyleBackColor = true;
            this.Update1.Click += new System.EventHandler(this.Update1_Click);
            // 
            // Delete1
            // 
            this.Delete1.Location = new System.Drawing.Point(270, 215);
            this.Delete1.Name = "Delete1";
            this.Delete1.Size = new System.Drawing.Size(75, 29);
            this.Delete1.TabIndex = 10;
            this.Delete1.Text = "Delete";
            this.Delete1.UseVisualStyleBackColor = true;
            this.Delete1.Click += new System.EventHandler(this.Delete1_Click);
            // 
            // Audits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 265);
            this.Controls.Add(this.Delete1);
            this.Controls.Add(this.Update1);
            this.Controls.Add(this.Insert1);
            this.Controls.Add(this.LeaseIDBox1);
            this.Controls.Add(this.LeaseIDlabel1);
            this.Controls.Add(this.oldandnewvaluesBox);
            this.Controls.Add(this.Changelabel1);
            this.Controls.Add(this.FieldinformationchangedBox);
            this.Controls.Add(this.Fieldinformationchanged);
            this.Controls.Add(this.DateBox1);
            this.Controls.Add(this.Datelabel1);
            this.Name = "Audits";
            this.Text = "Audits";
            this.Load += new System.EventHandler(this.Audits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Datelabel1;
        private System.Windows.Forms.TextBox DateBox1;
        private System.Windows.Forms.Label Fieldinformationchanged;
        private System.Windows.Forms.TextBox FieldinformationchangedBox;
        private System.Windows.Forms.Label Changelabel1;
        private System.Windows.Forms.TextBox oldandnewvaluesBox;
        private System.Windows.Forms.Label LeaseIDlabel1;
        private System.Windows.Forms.TextBox LeaseIDBox1;
        private System.Windows.Forms.Button Insert1;
        private System.Windows.Forms.Button Update1;
        private System.Windows.Forms.Button Delete1;
    }
}