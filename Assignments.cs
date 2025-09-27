using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    

namespace FoodHub_Database_Interfaces
{
    public partial class Assignments : Form
    {
        // Connection String
        private string connectionString = ConfigurationManager.ConnectionStrings["FoodHubDB"].ConnectionString;
        public Assignments()
        {
            InitializeComponent();
        }
        private void Back_button_102_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
        private void Clear_button104_Click(object sender, EventArgs e)
        {
            assignment_id.Text = string.Empty;
            rider_id.Text = string.Empty;
            registration_number.Text = string.Empty;
            assignment_date.Value = DateTime.Now;
            start_meter_reading.Value = DateTime.Now;
            end_meter_reading.Value = DateTime.Now;

        }
        private void Insert_button102_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Assignment (rider_id, registration_number, assignment_date, start_meter_reading, end_meter_reading) " +
                               "VALUES (@RiderId, @RegNo, @AssignDate, @StartMeter, @EndMeter)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@RiderId", int.Parse(rider_id.Text));
                    cmd.Parameters.AddWithValue("@RegNo", registration_number.Text);
                    cmd.Parameters.AddWithValue("@AssignDate", assignment_date.Value.Date);
                    cmd.Parameters.AddWithValue("@StartMeter", int.Parse(start_meter_reading.Text));
                    cmd.Parameters.AddWithValue("@EndMeter", int.Parse(end_meter_reading.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Assignment inserted successfully.");
                }
            }
        }
        private void update_button120_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Assignment SET rider_id = @RiderId, registration_number = @RegNo, " +
                               "assignment_date = @AssignDate, start_meter_reading = @StartMeter, end_meter_reading = @EndMeter " +
                               "WHERE assignment_id = @AssignmentId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AssignmentId", int.Parse(assignment_id.Text));
                    cmd.Parameters.AddWithValue("@RiderId", int.Parse(rider_id.Text));
                    cmd.Parameters.AddWithValue("@RegNo", registration_number.Text);
                    cmd.Parameters.AddWithValue("@AssignDate", assignment_date.Value.Date);
                    cmd.Parameters.AddWithValue("@StartMeter", int.Parse(start_meter_reading.Text));
                    cmd.Parameters.AddWithValue("@EndMeter", int.Parse(end_meter_reading.Text));

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Assignment updated successfully.");
                    else
                        MessageBox.Show("Update failed: Assignment not found.");
                }
            }
        }
        private void Delete_buttons12_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Assignment WHERE assignment_id = @AssignmentId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AssignmentId", int.Parse(assignment_id.Text));

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Assignment deleted.");
                    else
                        MessageBox.Show("Delete failed: Assignment not found.");
                }
            }
        }
    }
}
