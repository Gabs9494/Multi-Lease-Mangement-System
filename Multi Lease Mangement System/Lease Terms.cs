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
    public partial class Lease_Terms : Form
    {
        public Lease_Terms()
        {
            InitializeComponent();
        }

        private void Chargeforextramileagelabel_Click(object sender, EventArgs e)
        {

        }

        private void Lease_Terms_Load(object sender, EventArgs e)
        {
          /* try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO LeaseTerms (Years, Kilometers, extremileagecharge) VALUES(2000, 100,000,25);", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item has been added to the table.");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }   */
        }
          
        private void Insert2_Click(object sender, EventArgs e)
        {/*
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO LeaseTerms (Years, Kilometers, extremileagecharge) VALUES(2000, 100,000,25);", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item has been added to the table.");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("InsertIntoLeaseTerms", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("Years", SqlDbType.Int).Value = NumberofyearsBox.Text;
                    cmd.Parameters.Add("Kilometers", SqlDbType.Int).Value = MaximumkilometresBox.Text;
                    cmd.Parameters.Add("extramileagecharge", SqlDbType.Int).Value = centskilometreBox.Text;


                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been added Successfully.");

                }
            }
        }

        private void Update2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateLeaseTerms", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("Years", SqlDbType.Int).Value = NumberofyearsBox.Text;
                    cmd.Parameters.Add("Kilometers", SqlDbType.Int).Value = MaximumkilometresBox.Text;
                    cmd.Parameters.Add("extramileagecharge", SqlDbType.Int).Value = centskilometreBox.Text;


                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been Updated Successfully.");

                }
            }

        }

        private void Delete2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteLeaseTerms", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("Years", SqlDbType.Int).Value = NumberofyearsBox.Text;
                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been Deleted Successfully.");

                }
            }
        }
    }
}
