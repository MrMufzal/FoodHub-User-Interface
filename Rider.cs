using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;


namespace FoodHub_Database_Interfaces
{
    public partial class Rider : Form
    {
        // Connection String
        private string connectionString = ConfigurationManager.ConnectionStrings["FoodHubDB"].ConnectionString;


        public Rider()
        {
            InitializeComponent();
        }

        private void Back_Button987_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void Clear_Button098_Click(object sender, EventArgs e)
        {
            rider_id.Text = string.Empty;
            rider_name.Text = string.Empty;
            rider_dob.Value = DateTime.Now;
            rider_contactno.Text = string.Empty;
            rider_nic.Text = string.Empty;
            license_number.Text = string.Empty;
        }

        private void Insert_Buttonsd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Riders (rider_name, rider_dob, rider_nic, license_number, rider_contactno) " +
                               "VALUES (@name, @dob, @nic, @license, @contact)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", rider_name.Text);
                    cmd.Parameters.AddWithValue("@dob", rider_dob.Value.Date);
                    cmd.Parameters.AddWithValue("@nic", rider_nic.Text);
                    cmd.Parameters.AddWithValue("@license", license_number.Text);
                    cmd.Parameters.AddWithValue("@contact", rider_contactno.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rider inserted successfully.");
                    Clear_Button098_Click(null, null); // Optionally clear fields after insert
                }
            }
        }

        
        private void Update_Buttons345_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rider_id.Text))
            {
                MessageBox.Show("Please enter Rider ID to update.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Riders SET rider_name=@name, rider_dob=@dob, rider_nic=@nic, " +
                               "license_number=@license, rider_contactno=@contact WHERE rider_id=@id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", rider_name.Text);
                    cmd.Parameters.AddWithValue("@dob", rider_dob.Value.Date);
                    cmd.Parameters.AddWithValue("@nic", rider_nic.Text);
                    cmd.Parameters.AddWithValue("@license", license_number.Text);
                    cmd.Parameters.AddWithValue("@contact", rider_contactno.Text);
                    cmd.Parameters.AddWithValue("@id", int.Parse(rider_id.Text));

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "Rider updated." : "No rider found.");
                }
            }
        }

   
        private void Delete_button2345_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rider_id.Text))
            {
                MessageBox.Show("Please enter Rider ID to delete.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Riders WHERE rider_id=@id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(rider_id.Text));
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "Rider deleted." : "No rider found.");
                }
            }
        }
    }
}
