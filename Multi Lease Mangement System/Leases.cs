using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Multi_Lease_Mangement_System
{
    public partial class Leases : Form
    {
        public Leases()
        {
            InitializeComponent();
        }

        private void Insert4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Leases (termsoftheLease, CustomerID, StartDate, PaymentDate, AmountofMonthlypayment, NumberofMonthlypayment, NameofCustomer, TypeofVehicle) VALUES('Wow', '6565', '2021-08-02', '2021-09-02', 2000, 2, 'Anuge The King', 'Coupe');", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item has been added to the table.");
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("InsertIntoLeases", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@termsoftheLease", SqlDbType.NVarChar).Value = ThetermsoftheleaseBox.Text;
                    cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = FirstpaymentdateBox.Text;
                    cmd.Parameters.Add("@StartDate", SqlDbType.NVarChar).Value = Datetheleasecontractbeginsbox.Text;
                    cmd.Parameters.Add("@PaymentDate", SqlDbType.NVarChar).Value = FirstpaymentdateBox.Text;
                    cmd.Parameters.Add("@AmountofMonthlypayment", SqlDbType.NVarChar).Value = AmountofmonthlypaymentBox.Text;
                    cmd.Parameters.Add("@NumberofMonthlypayment", SqlDbType.NVarChar).Value = NumberofmonthlypaymentsBox.Text;
                    cmd.Parameters.Add("@NameofCustomer", SqlDbType.NVarChar).Value = WhichcustomertheleaseisforBox.Text;
                    cmd.Parameters.Add("@TypeofVehicle", SqlDbType.NVarChar).Value = WhichvehicletheleaseisforBox1.Text;
                }
            }
        }

        private void Leases_Load(object sender, EventArgs e)
        {

        }

        private void Update4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateLeases", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@termsoftheLease", SqlDbType.NVarChar).Value = ThetermsoftheleaseBox.Text;
                    cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = FirstpaymentdateBox.Text;
                    cmd.Parameters.Add("@StartDate", SqlDbType.NVarChar).Value = Datetheleasecontractbeginsbox.Text;
                    cmd.Parameters.Add("@PaymentDate", SqlDbType.NVarChar).Value = FirstpaymentdateBox.Text;
                    cmd.Parameters.Add("@AmountofMonthlypayment", SqlDbType.NVarChar).Value = AmountofmonthlypaymentBox.Text;
                    cmd.Parameters.Add("@NumberofMonthlypayment", SqlDbType.NVarChar).Value = NumberofmonthlypaymentsBox.Text;
                    cmd.Parameters.Add("@NameofCustomer", SqlDbType.NVarChar).Value = WhichcustomertheleaseisforBox.Text;
                    cmd.Parameters.Add("@TypeofVehicle", SqlDbType.NVarChar).Value = WhichvehicletheleaseisforBox1.Text;
                }
            }
        }

        private void Delete4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteLeases", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@NameofCustomer", SqlDbType.NVarChar).Value = WhichcustomertheleaseisforBox.Text;
                    
                }
            }
        }
    }
}
