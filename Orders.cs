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
    public partial class Orders : Form
    {
        // Connection String
        private string connectionString = ConfigurationManager.ConnectionStrings["FoodHubDB"].ConnectionString;
        public Orders()
        {
            InitializeComponent();
        }
        private void Back_buttonsae_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
        private void Clear_button_32_Click(object sender, EventArgs e)
        {
            order_id.Text = string.Empty;
            order_date.Value = DateTime.Now;
            order_time.Value = DateTime.Now;
            order_status.Text = string.Empty;
            payment_method.Text = string.Empty;
            customer_id.Text = string.Empty;
            item_number.Text = string.Empty;
            dispatch_time.Text = string.Empty;
            total_amount.Text = string.Empty;
        }
        private void Insert_Button_32_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Orders (order_date, order_time, order_status, payment_method, customer_id, item_number, dispatch_time, total_amount) " +
                               "VALUES (@Date, @Time, @Status, @Payment, @CustomerId, @ItemNumber, @DispatchTime, @TotalAmount)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Date", order_date.Value.Date);
                    cmd.Parameters.AddWithValue("@Time", order_time.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@Status", order_status.Text);
                    cmd.Parameters.AddWithValue("@Payment", payment_method.Text);
                    cmd.Parameters.AddWithValue("@CustomerId", int.Parse(customer_id.Text));
                    cmd.Parameters.AddWithValue("@ItemNumber", int.Parse(item_number.Text));
                    cmd.Parameters.AddWithValue("@DispatchTime", TimeSpan.Parse(dispatch_time.Text));
                    cmd.Parameters.AddWithValue("@TotalAmount", decimal.Parse(total_amount.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order inserted successfully.");
                }
            }
        }
        private void Update_button_32_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Orders SET order_date=@Date, order_time=@Time, order_status=@Status, " +
                               "payment_method=@Payment, customer_id=@CustomerId, item_number=@ItemNumber, " +
                               "dispatch_time=@DispatchTime, total_amount=@TotalAmount WHERE order_id=@OrderId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@OrderId", int.Parse(order_id.Text));
                    cmd.Parameters.AddWithValue("@Date", order_date.Value.Date);
                    cmd.Parameters.AddWithValue("@Time", order_time.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@Status", order_status.Text);
                    cmd.Parameters.AddWithValue("@Payment", payment_method.Text);
                    cmd.Parameters.AddWithValue("@CustomerId", int.Parse(customer_id.Text));
                    cmd.Parameters.AddWithValue("@ItemNumber", int.Parse(item_number.Text));
                    cmd.Parameters.AddWithValue("@DispatchTime", TimeSpan.Parse(dispatch_time.Text));
                    cmd.Parameters.AddWithValue("@TotalAmount", decimal.Parse(total_amount.Text));

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Order updated successfully.");
                    else
                        MessageBox.Show("Update failed: Order not found.");
                }
            }
        }
        private void Delete_button_32_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Orders WHERE order_id=@OrderId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@OrderId", int.Parse(order_id.Text));
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Order deleted.");
                    else
                        MessageBox.Show("Delete failed: Order not found.");
                }
            }
        }
    }
}
