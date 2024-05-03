namespace AppDesktop
{
    partial class SearchDoctor
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
            this.lstDoctors = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Adress = new System.Windows.Forms.TextBox();
            this.lstServices = new System.Windows.Forms.ListBox();
            this.SaveServices = new System.Windows.Forms.Button();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lstDoctors
            // 
            this.lstDoctors.ItemHeight = 16;
            this.lstDoctors.Location = new System.Drawing.Point(410, 89);
            this.lstDoctors.Name = "lstDoctors";
            this.lstDoctors.Size = new System.Drawing.Size(120, 84);
            this.lstDoctors.TabIndex = 6;
            this.lstDoctors.SelectedIndexChanged += new System.EventHandler(this.lstDoctors_SelectedIndexChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(12, 89);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 22);
            this.LastName.TabIndex = 4;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(25, 151);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(100, 22);
            this.Adress.TabIndex = 3;
            this.Adress.TextChanged += new System.EventHandler(this.Adress_TextChanged);
            // 
            // lstServices
            // 
            this.lstServices.ItemHeight = 16;
            this.lstServices.Location = new System.Drawing.Point(410, 179);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(120, 84);
            this.lstServices.TabIndex = 2;
            this.lstServices.SelectedIndexChanged += new System.EventHandler(this.lstServices_SelectedIndexChanged);
            // 
            // SaveServices
            // 
            this.SaveServices.Location = new System.Drawing.Point(25, 194);
            this.SaveServices.Name = "SaveServices";
            this.SaveServices.Size = new System.Drawing.Size(75, 23);
            this.SaveServices.TabIndex = 1;
            this.SaveServices.Click += new System.EventHandler(this.SaveServices_Click);
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(25, 293);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(200, 22);
            this.Birthday.TabIndex = 0;
            this.Birthday.ValueChanged += new System.EventHandler(this.Birthday_ValueChanged);
            // 
            // SearchDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.SaveServices);
            this.Controls.Add(this.lstServices);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstDoctors);
            this.Name = "SearchDoctor";
            this.Text = "SearchDoctor";
            this.Load += new System.EventHandler(this.SearchDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDoctors;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.Button SaveServices;
        private System.Windows.Forms.DateTimePicker Birthday;
    }
}