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
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }

        private void Modellabel_Click(object sender, EventArgs e)
        {

        }

        private void TypeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Colourlabel_Click(object sender, EventArgs e)
        {

        }

        private void clabel_Click(object sender, EventArgs e)
        {

        }

        private void Vehicles_Load(object sender, EventArgs e)
        {
           /* try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Vechicle (VIN, Model, Type, Colour, Year, Kilometers, LeasedBefore, Bookvalue, CustomerID) Value('3W9T1-2Q10D-12D0P-2E1R2', 'SC-430', 'coupe', 'black', 2000, '100, 000', 'yes', '50,000', '2345');", conn);
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

        private void Insert6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Vechicle (VIN, Model, Type, Colour, Year, Kilometers, LeasedBefore, Bookvalue, CustomerID) Value('3W9T1-2Q10D-12D0P-2E1R2', 'SC-430', 'coupe', 'black', 2000, '100, 000', 'yes', '50,000', '2345');", conn);
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
                using (SqlCommand cmd = new SqlCommand("InsertIntoVehicles", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add("@VIN", SqlDbType.NVarChar).Value = VehicleVINBox.Text;
                    cmd.Parameters.Add("@Model", SqlDbType.VarChar).Value = ModelBox.Text;
                    cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = TypeBox.Text;
                    cmd.Parameters.Add("@Colour", SqlDbType.VarChar).Value = ColourBox.Text;
                    cmd.Parameters.Add("@Year", SqlDbType.Int).Value = YearBox.Text;
                    cmd.Parameters.Add("@Kilometers", SqlDbType.VarChar).Value = KilometresonodometerBox.Text;
                    cmd.Parameters.Add("@LeasedBefore", SqlDbType.VarChar).Value = WhetherornotthevehiclehasbeenleasedbeforeBox.Text;
                    cmd.Parameters.Add("@Bookvalue", SqlDbType.VarChar).Value = BookvalueBox.Text;
                    cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = automatictransmissionairconditioningpowerlocksbox.Text;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been added to the table.");


                }
            }
        }

        private void Update6_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateVehicles", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add("@VIN", SqlDbType.NVarChar).Value = VehicleVINBox.Text;
                    cmd.Parameters.Add("@Model", SqlDbType.VarChar).Value = ModelBox.Text;
                    cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = TypeBox.Text;
                    cmd.Parameters.Add("@Colour", SqlDbType.VarChar).Value = ColourBox.Text;
                    cmd.Parameters.Add("@Year", SqlDbType.Int).Value = YearBox.Text;
                    cmd.Parameters.Add("@Kilometers", SqlDbType.VarChar).Value = KilometresonodometerBox.Text;
                    cmd.Parameters.Add("@LeasedBefore", SqlDbType.VarChar).Value = WhetherornotthevehiclehasbeenleasedbeforeBox.Text;
                    cmd.Parameters.Add("@Bookvalue", SqlDbType.VarChar).Value = BookvalueBox.Text;
                    cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = automatictransmissionairconditioningpowerlocksbox.Text;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been Updated to the table.");

                }
            }
        }

        private void Delete6_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPRHO2Q;Initial Catalog=MultiLease;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteVehicles", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                 
                    cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = automatictransmissionairconditioningpowerlocksbox.Text;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been Deleted.");

                }
            }
        }
    }
}



