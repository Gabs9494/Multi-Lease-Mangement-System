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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Insert5_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("insertIntoCustomerTable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@cutomerID", SqlDbType.NVarChar).Value = customerIDTextbox1.Text;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = FullNameBox1.Text;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = AddressBox1.Text;
                    cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = CityBox1.Text;
                    cmd.Parameters.Add("@province", SqlDbType.VarChar).Value = ProvinceBox1.Text;
                    cmd.Parameters.Add("@postal", SqlDbType.VarChar).Value = PostalCodeBox1.Text;
                    cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = PhoneNumberBox.Text;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been added to the table.");


                }
            }
        }

        private void update5_Click(object sender, EventArgs e)
        {
           
                     using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateCustomerTable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@cutomerID", SqlDbType.NVarChar).Value = customerIDTextbox1.Text;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = FullNameBox1.Text;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = AddressBox1.Text;
                    cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = CityBox1.Text;
                    cmd.Parameters.Add("@province", SqlDbType.VarChar).Value = ProvinceBox1.Text;
                    cmd.Parameters.Add("@postal", SqlDbType.VarChar).Value = PostalCodeBox1.Text;
                    cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = PhoneNumberBox.Text;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been Successfully updated.");
                      

                }
            }
        }
            

            private void Delete5_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteCustomerTable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@cutomerID", SqlDbType.NVarChar).Value = customerIDTextbox1.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been Successfully Deleted.");

               
                }
            }
        }
    }
}
    
