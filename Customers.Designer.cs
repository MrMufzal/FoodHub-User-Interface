namespace FoodHub_Database_Interfaces
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.Back_Button1 = new System.Windows.Forms.Button();
            this.Clear_Button1 = new System.Windows.Forms.Button();
            this.Insert_Button1 = new System.Windows.Forms.Button();
            this.Delete_Button1 = new System.Windows.Forms.Button();
            this.Update_Button1 = new System.Windows.Forms.Button();
            this.cussylabel1 = new System.Windows.Forms.Label();
            this.cussylabel = new System.Windows.Forms.Label();
            this.cussydob = new System.Windows.Forms.Label();
            this.cussynic = new System.Windows.Forms.Label();
            this.contactcussy = new System.Windows.Forms.Label();
            this.addresscussy = new System.Windows.Forms.Label();
            this.customer_id = new System.Windows.Forms.TextBox();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.customer_nic = new System.Windows.Forms.TextBox();
            this.customer_contactno = new System.Windows.Forms.TextBox();
            this.customer_address = new System.Windows.Forms.TextBox();
            this.customer_dob = new System.Windows.Forms.DateTimePicker();
            this.cuslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back_Button1
            // 
            this.Back_Button1.Location = new System.Drawing.Point(12, 12);
            this.Back_Button1.Name = "Back_Button1";
            this.Back_Button1.Size = new System.Drawing.Size(75, 23);
            this.Back_Button1.TabIndex = 0;
            this.Back_Button1.Text = "Back";
            this.Back_Button1.UseVisualStyleBackColor = true;
            this.Back_Button1.Click += new System.EventHandler(this.Back_Button1_Click);
            // 
            // Clear_Button1
            // 
            this.Clear_Button1.Location = new System.Drawing.Point(69, 348);
            this.Clear_Button1.Name = "Clear_Button1";
            this.Clear_Button1.Size = new System.Drawing.Size(75, 23);
            this.Clear_Button1.TabIndex = 1;
            this.Clear_Button1.Text = "Clear";
            this.Clear_Button1.UseVisualStyleBackColor = true;
            this.Clear_Button1.Click += new System.EventHandler(this.Clear_Button1_Click);
            // 
            // Insert_Button1
            // 
            this.Insert_Button1.Location = new System.Drawing.Point(248, 348);
            this.Insert_Button1.Name = "Insert_Button1";
            this.Insert_Button1.Size = new System.Drawing.Size(75, 23);
            this.Insert_Button1.TabIndex = 2;
            this.Insert_Button1.Text = "Insert";
            this.Insert_Button1.UseVisualStyleBackColor = true;
            this.Insert_Button1.Click += new System.EventHandler(this.Insert_Button1_Click);
            // 
            // Delete_Button1
            // 
            this.Delete_Button1.Location = new System.Drawing.Point(657, 348);
            this.Delete_Button1.Name = "Delete_Button1";
            this.Delete_Button1.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button1.TabIndex = 3;
            this.Delete_Button1.Text = "Delete";
            this.Delete_Button1.UseVisualStyleBackColor = true;
            this.Delete_Button1.Click += new System.EventHandler(this.Delete_Button1_Click);
            // 
            // Update_Button1
            // 
            this.Update_Button1.Location = new System.Drawing.Point(468, 348);
            this.Update_Button1.Name = "Update_Button1";
            this.Update_Button1.Size = new System.Drawing.Size(75, 23);
            this.Update_Button1.TabIndex = 4;
            this.Update_Button1.Text = "Update";
            this.Update_Button1.UseVisualStyleBackColor = true;
            this.Update_Button1.Click += new System.EventHandler(this.Update_Button1_Click);
            // 
            // cussylabel1
            // 
            this.cussylabel1.AutoSize = true;
            this.cussylabel1.Location = new System.Drawing.Point(100, 64);
            this.cussylabel1.Name = "cussylabel1";
            this.cussylabel1.Size = new System.Drawing.Size(80, 16);
            this.cussylabel1.TabIndex = 5;
            this.cussylabel1.Text = "Customer ID";
            // 
            // cussylabel
            // 
            this.cussylabel.AutoSize = true;
            this.cussylabel.Location = new System.Drawing.Point(100, 106);
            this.cussylabel.Name = "cussylabel";
            this.cussylabel.Size = new System.Drawing.Size(44, 16);
            this.cussylabel.TabIndex = 6;
            this.cussylabel.Text = "Name";
            // 
            // cussydob
            // 
            this.cussydob.AutoSize = true;
            this.cussydob.Location = new System.Drawing.Point(101, 148);
            this.cussydob.Name = "cussydob";
            this.cussydob.Size = new System.Drawing.Size(79, 16);
            this.cussydob.TabIndex = 7;
            this.cussydob.Text = "Date of Birth";
            // 
            // cussynic
            // 
            this.cussynic.AutoSize = true;
            this.cussynic.Location = new System.Drawing.Point(101, 190);
            this.cussynic.Name = "cussynic";
            this.cussynic.Size = new System.Drawing.Size(29, 16);
            this.cussynic.TabIndex = 8;
            this.cussynic.Text = "NIC";
            // 
            // contactcussy
            // 
            this.contactcussy.AutoSize = true;
            this.contactcussy.Location = new System.Drawing.Point(101, 234);
            this.contactcussy.Name = "contactcussy";
            this.contactcussy.Size = new System.Drawing.Size(103, 16);
            this.contactcussy.TabIndex = 9;
            this.contactcussy.Text = "Contact Number";
            // 
            // addresscussy
            // 
            this.addresscussy.AutoSize = true;
            this.addresscussy.Location = new System.Drawing.Point(101, 277);
            this.addresscussy.Name = "addresscussy";
            this.addresscussy.Size = new System.Drawing.Size(58, 16);
            this.addresscussy.TabIndex = 10;
            this.addresscussy.Text = "Address";
            // 
            // customer_id
            // 
            this.customer_id.Location = new System.Drawing.Point(248, 64);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(501, 22);
            this.customer_id.TabIndex = 11;
            // 
            // customer_name
            // 
            this.customer_name.Location = new System.Drawing.Point(248, 106);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(501, 22);
            this.customer_name.TabIndex = 12;
            // 
            // customer_nic
            // 
            this.customer_nic.Location = new System.Drawing.Point(248, 190);
            this.customer_nic.Name = "customer_nic";
            this.customer_nic.Size = new System.Drawing.Size(501, 22);
            this.customer_nic.TabIndex = 13;
            // 
            // customer_contactno
            // 
            this.customer_contactno.Location = new System.Drawing.Point(248, 234);
            this.customer_contactno.Name = "customer_contactno";
            this.customer_contactno.Size = new System.Drawing.Size(501, 22);
            this.customer_contactno.TabIndex = 14;
            // 
            // customer_address
            // 
            this.customer_address.Location = new System.Drawing.Point(248, 271);
            this.customer_address.Name = "customer_address";
            this.customer_address.Size = new System.Drawing.Size(501, 22);
            this.customer_address.TabIndex = 15;
            // 
            // customer_dob
            // 
            this.customer_dob.Location = new System.Drawing.Point(248, 148);
            this.customer_dob.Name = "customer_dob";
            this.customer_dob.Size = new System.Drawing.Size(501, 22);
            this.customer_dob.TabIndex = 16;
            // 
            // cuslabel
            // 
            this.cuslabel.AutoSize = true;
            this.cuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuslabel.Location = new System.Drawing.Point(243, 22);
            this.cuslabel.Name = "cuslabel";
            this.cuslabel.Size = new System.Drawing.Size(390, 25);
            this.cuslabel.TabIndex = 17;
            this.cuslabel.Text = "CUSTOMER DATABASE MANAGEMENT";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(780, 393);
            this.Controls.Add(this.cuslabel);
            this.Controls.Add(this.customer_dob);
            this.Controls.Add(this.customer_address);
            this.Controls.Add(this.customer_contactno);
            this.Controls.Add(this.customer_nic);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.customer_id);
            this.Controls.Add(this.addresscussy);
            this.Controls.Add(this.contactcussy);
            this.Controls.Add(this.cussynic);
            this.Controls.Add(this.cussydob);
            this.Controls.Add(this.cussylabel);
            this.Controls.Add(this.cussylabel1);
            this.Controls.Add(this.Update_Button1);
            this.Controls.Add(this.Delete_Button1);
            this.Controls.Add(this.Insert_Button1);
            this.Controls.Add(this.Clear_Button1);
            this.Controls.Add(this.Back_Button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer";
            this.Text = "Customers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_Button1;
        private System.Windows.Forms.Button Clear_Button1;
        private System.Windows.Forms.Button Insert_Button1;
        private System.Windows.Forms.Button Delete_Button1;
        private System.Windows.Forms.Button Update_Button1;
        private System.Windows.Forms.Label cussylabel1;
        private System.Windows.Forms.Label cussylabel;
        private System.Windows.Forms.Label cussydob;
        private System.Windows.Forms.Label cussynic;
        private System.Windows.Forms.Label contactcussy;
        private System.Windows.Forms.Label addresscussy;
        private System.Windows.Forms.TextBox customer_id;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.TextBox customer_nic;
        private System.Windows.Forms.TextBox customer_contactno;
        private System.Windows.Forms.TextBox customer_address;
        private System.Windows.Forms.DateTimePicker customer_dob;
        private System.Windows.Forms.Label cuslabel;
    }
}

