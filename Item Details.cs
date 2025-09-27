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
    public partial class Item_Details : Form
    {
        // Connection String
        private string connectionString = ConfigurationManager.ConnectionStrings["FoodHubDB"].ConnectionString;
        public Item_Details()
        {
            InitializeComponent();
        }
        private void Back_Button_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            item_number.Text = string.Empty;
            item_name.Text = string.Empty;
            item_category.Text = string.Empty;
            price.Text = string.Empty;
            ingrediants.Text = string.Empty;
        }
        private void Insert_Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Item_Details (item_name, item_category, price, ingredients) " +
                               "VALUES (@Name, @Category, @Price, @Ingredients)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", item_name.Text);
                    cmd.Parameters.AddWithValue("@Category", item_category.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(price.Text));
                    cmd.Parameters.AddWithValue("@Ingredients", ingrediants.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item inserted successfully!");
                }
            }
        }
        private void Update_Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Item_Details SET item_name=@Name, item_category=@Category, " +
                               "price=@Price, ingredients=@Ingredients WHERE item_number=@ItemNumber";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ItemNumber", item_number.Text);
                    cmd.Parameters.AddWithValue("@Name", item_name.Text);
                    cmd.Parameters.AddWithValue("@Category", item_category.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(price.Text));
                    cmd.Parameters.AddWithValue("@Ingredients", ingrediants.Text);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Item updated successfully!");
                    else
                        MessageBox.Show("Update failed: Item not found.");
                }
            }
        }
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Item_Details WHERE item_number=@ItemNumber";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ItemNumber", item_number.Text);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Item deleted.");
                    else
                        MessageBox.Show("Delete failed: Item not found.");
                }
            }
        }
    }
}
