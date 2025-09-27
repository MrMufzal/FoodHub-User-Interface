using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_Database_Interfaces
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Rider_Button_Click(object sender, EventArgs e)
        {
         Rider rider = new Rider();
            rider.Show();
            this.Hide();
        }

        private void Customer_Button_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void ItemDetails_Button_Click(object sender, EventArgs e)
        {
            Item_Details item = new Item_Details();
            item.Show();
            this.Hide();
        }

        private void Order_Button_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.Show();
            this.Hide();
        }

        private void MotorBike_Button_Click(object sender, EventArgs e)
        {
            Motorbikes motorbikes = new Motorbikes();
            motorbikes.Show();
            this.Hide();
        }

        private void Assignment_Button_Click(object sender, EventArgs e)
        {
            Assignments assignment = new Assignments();
            assignment.Show();
            this.Hide();
        }

        private void DeliveryAssigned_Button_Click(object sender, EventArgs e)
        {
            Delivery_Assigned deliveryAssigned = new Delivery_Assigned();
            deliveryAssigned.Show();
            this.Hide();

        }
    }
}
