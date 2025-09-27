namespace FoodHub_Database_Interfaces
{
    partial class Delivery_Assigned
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery_Assigned));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Back_Button2345 = new System.Windows.Forms.Button();
            this.Clear_Button234 = new System.Windows.Forms.Button();
            this.Insert_Button12343 = new System.Windows.Forms.Button();
            this.Update_Button234 = new System.Windows.Forms.Button();
            this.Delete_Button234 = new System.Windows.Forms.Button();
            this.assignment_id = new System.Windows.Forms.TextBox();
            this.order_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "DELIVERY ASSIGNMENT DATABASE MANAGEMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assignment ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order ID";
            // 
            // Back_Button2345
            // 
            this.Back_Button2345.Location = new System.Drawing.Point(12, 22);
            this.Back_Button2345.Name = "Back_Button2345";
            this.Back_Button2345.Size = new System.Drawing.Size(75, 23);
            this.Back_Button2345.TabIndex = 5;
            this.Back_Button2345.Text = "Back";
            this.Back_Button2345.UseVisualStyleBackColor = true;
            this.Back_Button2345.Click += new System.EventHandler(this.Back_Button2345_Click);
            // 
            // Clear_Button234
            // 
            this.Clear_Button234.Location = new System.Drawing.Point(84, 223);
            this.Clear_Button234.Name = "Clear_Button234";
            this.Clear_Button234.Size = new System.Drawing.Size(75, 23);
            this.Clear_Button234.TabIndex = 6;
            this.Clear_Button234.Text = "Clear";
            this.Clear_Button234.UseVisualStyleBackColor = true;
            this.Clear_Button234.Click += new System.EventHandler(this.Clear_Button234_Click);
            // 
            // Insert_Button12343
            // 
            this.Insert_Button12343.Location = new System.Drawing.Point(241, 223);
            this.Insert_Button12343.Name = "Insert_Button12343";
            this.Insert_Button12343.Size = new System.Drawing.Size(75, 23);
            this.Insert_Button12343.TabIndex = 7;
            this.Insert_Button12343.Text = "Insert";
            this.Insert_Button12343.UseVisualStyleBackColor = true;
            this.Insert_Button12343.Click += new System.EventHandler(this.Insert_Button12343_Click);
            // 
            // Update_Button234
            // 
            this.Update_Button234.Location = new System.Drawing.Point(440, 223);
            this.Update_Button234.Name = "Update_Button234";
            this.Update_Button234.Size = new System.Drawing.Size(75, 23);
            this.Update_Button234.TabIndex = 8;
            this.Update_Button234.Text = "Update";
            this.Update_Button234.UseVisualStyleBackColor = true;
            this.Update_Button234.Click += new System.EventHandler(this.Update_Button234_Click);
            // 
            // Delete_Button234
            // 
            this.Delete_Button234.Location = new System.Drawing.Point(614, 223);
            this.Delete_Button234.Name = "Delete_Button234";
            this.Delete_Button234.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button234.TabIndex = 9;
            this.Delete_Button234.Text = "Delete";
            this.Delete_Button234.UseVisualStyleBackColor = true;
            this.Delete_Button234.Click += new System.EventHandler(this.Delete_Button234_Click);
            // 
            // assignment_id
            // 
            this.assignment_id.Location = new System.Drawing.Point(305, 114);
            this.assignment_id.Name = "assignment_id";
            this.assignment_id.Size = new System.Drawing.Size(366, 22);
            this.assignment_id.TabIndex = 10;
            // 
            // order_id
            // 
            this.order_id.Location = new System.Drawing.Point(305, 164);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(366, 22);
            this.order_id.TabIndex = 11;
            // 
            // Delivery_Assigned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 267);
            this.Controls.Add(this.order_id);
            this.Controls.Add(this.assignment_id);
            this.Controls.Add(this.Delete_Button234);
            this.Controls.Add(this.Update_Button234);
            this.Controls.Add(this.Insert_Button12343);
            this.Controls.Add(this.Clear_Button234);
            this.Controls.Add(this.Back_Button2345);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Delivery_Assigned";
            this.Text = "Delivery Assignement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Back_Button2345;
        private System.Windows.Forms.Button Clear_Button234;
        private System.Windows.Forms.Button Insert_Button12343;
        private System.Windows.Forms.Button Update_Button234;
        private System.Windows.Forms.Button Delete_Button234;
        private System.Windows.Forms.TextBox assignment_id;
        private System.Windows.Forms.TextBox order_id;
    }
}