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
    public partial class Audits : Form
    {
        public Audits()
        {
            InitializeComponent();
        }

        private void Datelabel1_Click(object sender, EventArgs e)
        {

        }

        private void Fieldinformationchanged_Click(object sender, EventArgs e)
        {

        }

        private void Audits_Load(object sender, EventArgs e)
        {/*
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Audit (DateofChange, ChangedFeild, OldValue, LeaseID) VALUES(2010-08-03, '1', '45,000', '1234');", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item has been added to the table.");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            */
        }

        private void Insert1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("insertIntoAuditTable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@DateofChange", SqlDbType.Int).Value = DateBox1.Text;
                    cmd.Parameters.Add("@ChangedFeild", SqlDbType.NVarChar).Value = FieldinformationchangedBox.Text;
                    cmd.Parameters.Add("@OldValue", SqlDbType.NVarChar).Value = oldandnewvaluesBox.Text;
                    cmd.Parameters.Add("@NewValue", SqlDbType.NVarChar).Value = oldandnewvaluesBox.Text;
                    cmd.Parameters.Add("@LeaseID", SqlDbType.NVarChar).Value = LeaseIDBox1.Text;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been added to the table.");
                }

                    
            }
        }

        private void Update1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateAuditTable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@DateofChange", SqlDbType.Int).Value = DateBox1.Text;
                    cmd.Parameters.Add("@ChangedFeild", SqlDbType.NVarChar).Value = FieldinformationchangedBox.Text;
                    cmd.Parameters.Add("@OldValue", SqlDbType.NVarChar).Value = oldandnewvaluesBox.Text;
                    cmd.Parameters.Add("@NewValue", SqlDbType.NVarChar).Value = oldandnewvaluesBox.Text;
                    cmd.Parameters.Add("@LeaseID", SqlDbType.NVarChar).Value = LeaseIDBox1.Text;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been Updated.");

                }
            }
        }

        private void Delete1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteAuditTable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                   
                    cmd.Parameters.Add("@LeaseID", SqlDbType.NVarChar).Value = LeaseIDBox1.Text;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been Deleted.");
                }
            }
        }
    }
}




