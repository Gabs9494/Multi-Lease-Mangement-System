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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {/* 
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Payments (LeaseID, Date, Amount) VALUES('4321', '2021-08-02', 3000);", conn); 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item has been added to the table.");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } */
        }

        private void Insert3_Click(object sender, EventArgs e)
        {
             try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Payments (LeaseID, Date, Amount) VALUES('4321', '2021-08-02', 3000);", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item has been added to the table.");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("InsertIntoPayments", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@LeaseID", SqlDbType.NVarChar).Value = LeaseIDBox.Text;
                    cmd.Parameters.Add("@Date", SqlDbType.NVarChar).Value = DateBox.Text;
                    cmd.Parameters.Add("@Amount", SqlDbType.NVarChar).Value = AmountBox.Text;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been added to the table.");
                }
        
            }
        }

        private void Update3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("UpdatePayments", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@LeaseID", SqlDbType.NVarChar).Value = LeaseIDBox.Text;
                    cmd.Parameters.Add("@Date", SqlDbType.NVarChar).Value = DateBox.Text;
                    cmd.Parameters.Add("@Amount", SqlDbType.NVarChar).Value = AmountBox.Text;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been Successfully updated.");
                }
            }
        }
    

    private void Delete3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("DeletePayments", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@LeaseID", SqlDbType.VarChar).Value = LeaseIDBox.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been Successfully Deleted.");

                }
            }
       }
    }
}




