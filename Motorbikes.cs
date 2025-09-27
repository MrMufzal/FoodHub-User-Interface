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
    public partial class Motorbikes : Form
    {
        // Connection String
        private string connectionString = ConfigurationManager.ConnectionStrings["FoodHubDB"].ConnectionString;
        public Motorbikes()
        {
            InitializeComponent();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void Back_button53_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
        private void Clear_button_345_Click(object sender, EventArgs e)
        {
            motorbike_registration_number.Text = string.Empty;
            motorbike_brand.Text = string.Empty;
            motorbike_model.Text = string.Empty;
            motorbike_engine_number.Text = string.Empty;
            motorbike_registration_date.Value = DateTime.Now;
            motorbike_color.Text = string.Empty;
        }
        private void Insert_Button_54_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Motorbike (motorbike_registeration_number, motorbike_brand, motorbike_model, motorbike_engine_number, motorbike_registration_date, motorbike_color) " +
                               "VALUES (@RegNo, @Brand, @Model, @EngineNo, @RegDate, @Color)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@RegNo", motorbike_registration_number.Text);
                    cmd.Parameters.AddWithValue("@Brand", motorbike_brand.Text);
                    cmd.Parameters.AddWithValue("@Model", motorbike_model.Text);
                    cmd.Parameters.AddWithValue("@EngineNo", motorbike_engine_number.Text);
                    cmd.Parameters.AddWithValue("@RegDate", motorbike_registration_date.Value.Date);
                    cmd.Parameters.AddWithValue("@Color", motorbike_color.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Motorbike inserted successfully.");
                }
            }
        }
        private void Update_button_54_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Motorbike SET motorbike_brand = @Brand, motorbike_model = @Model, motorbike_engine_number = @EngineNo, " +
                               "motorbike_registration_date = @RegDate, motorbike_color = @Color " +
                               "WHERE motorbike_registeration_number = @RegNo";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@RegNo", motorbike_registration_number.Text);
                    cmd.Parameters.AddWithValue("@Brand", motorbike_brand.Text);
                    cmd.Parameters.AddWithValue("@Model", motorbike_model.Text);
                    cmd.Parameters.AddWithValue("@EngineNo", motorbike_engine_number.Text);
                    cmd.Parameters.AddWithValue("@RegDate", motorbike_registration_date.Value.Date);
                    cmd.Parameters.AddWithValue("@Color", motorbike_color.Text);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Motorbike updated successfully.");
                    else
                        MessageBox.Show("Update failed: Record not found.");
                }
            }
        }
        private void Delete_button_54_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Motorbike WHERE motorbike_registeration_number = @RegNo";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@RegNo", motorbike_registration_number.Text);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Motorbike deleted successfully.");
                    else
                        MessageBox.Show("Delete failed: Record not found.");
                }
            }
        }
    }
}
