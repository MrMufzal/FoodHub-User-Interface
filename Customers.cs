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
using System.Configuration;

namespace FoodHub_Database_Interfaces
{
    public partial class Customer : Form
    {
        // Connection String
        private string connectionString = ConfigurationManager.ConnectionStrings["FoodHubDB"].ConnectionString;
        public Customer()
        {
            InitializeComponent();
        }
        private void Back_Button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();   
        }
        private void Clear_Button1_Click(object sender, EventArgs e)
        {
            customer_id.Text = string.Empty;
            customer_name.Text = string.Empty;
            customer_dob.Value = DateTime.Now;
            customer_address.Text = string.Empty;
            customer_nic.Text = string.Empty;
            customer_contactno.Text = string.Empty;

        }
        private void Insert_Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Customers (customer_name, customer_dob, customer_nic, customer_contactno, customer_address) " +
                               "VALUES (@Name, @DOB, @NIC, @Contact, @Address)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", customer_name.Text);
                    cmd.Parameters.AddWithValue("@DOB", customer_dob.Value.Date);
                    cmd.Parameters.AddWithValue("@NIC", customer_nic.Text);
                    cmd.Parameters.AddWithValue("@Contact", customer_contactno.Text);
                    cmd.Parameters.AddWithValue("@Address", customer_address.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer inserted successfully!");
                }
            }
        }
        private void Update_Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Customers SET customer_name=@Name, customer_dob=@DOB, customer_nic=@NIC, " +
                               "customer_contactno=@Contact, customer_address=@Address WHERE customer_id=@ID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", customer_id.Text);
                    cmd.Parameters.AddWithValue("@Name", customer_name.Text);
                    cmd.Parameters.AddWithValue("@DOB", customer_dob.Value.Date);
                    cmd.Parameters.AddWithValue("@NIC", customer_nic.Text);
                    cmd.Parameters.AddWithValue("@Contact", customer_contactno.Text);
                    cmd.Parameters.AddWithValue("@Address", customer_address.Text);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Customer updated successfully!");
                    else
                        MessageBox.Show("Update failed.");
                }
            }
        }
        private void Delete_Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Customers WHERE customer_id = @ID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", customer_id.Text);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Customer deleted.");
                    else
                        MessageBox.Show("Customer not found.");
                }
            }
        }

    }
}
