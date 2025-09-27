namespace FoodHub_Database_Interfaces
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Rider_Button = new System.Windows.Forms.Button();
            this.Customer_Button = new System.Windows.Forms.Button();
            this.ItemDetails_Button = new System.Windows.Forms.Button();
            this.Order_Button = new System.Windows.Forms.Button();
            this.MotorBike_Button = new System.Windows.Forms.Button();
            this.Assignment_Button = new System.Windows.Forms.Button();
            this.DeliveryAssigned_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rider_Button
            // 
            this.Rider_Button.Location = new System.Drawing.Point(84, 217);
            this.Rider_Button.Name = "Rider_Button";
            this.Rider_Button.Size = new System.Drawing.Size(121, 40);
            this.Rider_Button.TabIndex = 2;
            this.Rider_Button.Text = "Rider";
            this.Rider_Button.UseVisualStyleBackColor = true;
            this.Rider_Button.Click += new System.EventHandler(this.Rider_Button_Click);
            // 
            // Customer_Button
            // 
            this.Customer_Button.Location = new System.Drawing.Point(370, 217);
            this.Customer_Button.Name = "Customer_Button";
            this.Customer_Button.Size = new System.Drawing.Size(121, 40);
            this.Customer_Button.TabIndex = 3;
            this.Customer_Button.Text = "Customer";
            this.Customer_Button.UseVisualStyleBackColor = true;
            this.Customer_Button.Click += new System.EventHandler(this.Customer_Button_Click);
            // 
            // ItemDetails_Button
            // 
            this.ItemDetails_Button.Location = new System.Drawing.Point(662, 217);
            this.ItemDetails_Button.Name = "ItemDetails_Button";
            this.ItemDetails_Button.Size = new System.Drawing.Size(121, 40);
            this.ItemDetails_Button.TabIndex = 4;
            this.ItemDetails_Button.Text = "Item Details";
            this.ItemDetails_Button.UseVisualStyleBackColor = true;
            this.ItemDetails_Button.Click += new System.EventHandler(this.ItemDetails_Button_Click);
            // 
            // Order_Button
            // 
            this.Order_Button.Location = new System.Drawing.Point(84, 309);
            this.Order_Button.Name = "Order_Button";
            this.Order_Button.Size = new System.Drawing.Size(121, 39);
            this.Order_Button.TabIndex = 5;
            this.Order_Button.Text = "Order";
            this.Order_Button.UseVisualStyleBackColor = true;
            this.Order_Button.Click += new System.EventHandler(this.Order_Button_Click);
            // 
            // MotorBike_Button
            // 
            this.MotorBike_Button.Location = new System.Drawing.Point(370, 309);
            this.MotorBike_Button.Name = "MotorBike_Button";
            this.MotorBike_Button.Size = new System.Drawing.Size(121, 39);
            this.MotorBike_Button.TabIndex = 5;
            this.MotorBike_Button.Text = "MotorBike";
            this.MotorBike_Button.UseVisualStyleBackColor = true;
            this.MotorBike_Button.Click += new System.EventHandler(this.MotorBike_Button_Click);
            // 
            // Assignment_Button
            // 
            this.Assignment_Button.Location = new System.Drawing.Point(662, 309);
            this.Assignment_Button.Name = "Assignment_Button";
            this.Assignment_Button.Size = new System.Drawing.Size(121, 39);
            this.Assignment_Button.TabIndex = 6;
            this.Assignment_Button.Text = "Assignment";
            this.Assignment_Button.UseVisualStyleBackColor = true;
            this.Assignment_Button.Click += new System.EventHandler(this.Assignment_Button_Click);
            // 
            // DeliveryAssigned_Button
            // 
            this.DeliveryAssigned_Button.Location = new System.Drawing.Point(370, 396);
            this.DeliveryAssigned_Button.Name = "DeliveryAssigned_Button";
            this.DeliveryAssigned_Button.Size = new System.Drawing.Size(121, 36);
            this.DeliveryAssigned_Button.TabIndex = 7;
            this.DeliveryAssigned_Button.Text = "Delivery ";
            this.DeliveryAssigned_Button.UseVisualStyleBackColor = true;
            this.DeliveryAssigned_Button.Click += new System.EventHandler(this.DeliveryAssigned_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome to FoodHub Database Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Table";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(870, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeliveryAssigned_Button);
            this.Controls.Add(this.Assignment_Button);
            this.Controls.Add(this.MotorBike_Button);
            this.Controls.Add(this.Order_Button);
            this.Controls.Add(this.ItemDetails_Button);
            this.Controls.Add(this.Customer_Button);
            this.Controls.Add(this.Rider_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "FoodHub Database Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rider_Button;
        private System.Windows.Forms.Button Customer_Button;
        private System.Windows.Forms.Button ItemDetails_Button;
        private System.Windows.Forms.Button Order_Button;
        private System.Windows.Forms.Button MotorBike_Button;
        private System.Windows.Forms.Button Assignment_Button;
        private System.Windows.Forms.Button DeliveryAssigned_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

