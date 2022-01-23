using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Lease_Mangement_System
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Leases lf = new Leases();
            lf.Show();
        }

        private void Auditbttn1_Click(object sender, EventArgs e)
        {
            Audits lf = new Audits();
            lf.Show();
        }

        private void OpenCustomerbttn1_Click(object sender, EventArgs e)
        {
            Customers lf = new Customers();
            lf.Show();
        }

        private void Leasetermsbttn1_Click(object sender, EventArgs e)
        {
           Lease_Terms lf = new Lease_Terms();
            lf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payments lf = new Payments();
            lf.Show();
        }

        private void OpenVehiclesbttn_Click(object sender, EventArgs e)
        {
            Vehicles lf = new Vehicles();
            lf.Show();

        }
    }
}
