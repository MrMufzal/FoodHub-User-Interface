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
    public partial class Delivery_Assigned : Form
    {
        // Connection String
        private string connectionString = ConfigurationManager.ConnectionStrings["FoodHubDB"].ConnectionString;
        public Delivery_Assigned()
        {
            InitializeComponent();
        }
        private void Back_Button2345_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();
            this.Close();   
        }
        private void Clear_Button234_Click(object sender, EventArgs e)
        {
            assignment_id.Text = string.Empty;
            order_id.Text = string.Empty;
        }
        private void Insert_Button12343_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Delivery_Assigned (assignment_id, order_id) " +
                               "VALUES (@AssignmentId, @OrderId)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AssignmentId", int.Parse(assignment_id.Text));
                    cmd.Parameters.AddWithValue("@OrderId", int.Parse(order_id.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delivery assignment inserted successfully.");
                }
            }
        }
        private void Update_Button234_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Delivery_Assigned SET order_id = @OrderId" +
                               "WHERE assignment_id = @AssignmentId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AssignmentId", int.Parse(assignment_id.Text));
                    cmd.Parameters.AddWithValue("@OrderId", int.Parse(order_id.Text));
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Delivery assignment updated successfully.");
                    else
                        MessageBox.Show("Update failed: Record not found.");
                }
            }
        }
        private void Delete_Button234_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Delivery_Assigned WHERE assignment_id = @AssignmentId AND order_id = @OrderId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AssignmentId", int.Parse(assignment_id.Text));
                    cmd.Parameters.AddWithValue("@OrderId", int.Parse(order_id.Text));

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Delivery assignment deleted.");
                    else
                        MessageBox.Show("Delete failed: Record not found.");
                }
            }
        }
    }
}
