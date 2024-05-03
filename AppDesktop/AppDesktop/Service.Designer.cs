namespace AppDesktop
{
    partial class Service
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
            this.lstServices = new System.Windows.Forms.ListBox();
            this.name = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.ADD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PUT = new System.Windows.Forms.Button();
            this.discriptin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Removee = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstServices
            // 
            this.lstServices.ItemHeight = 16;
            this.lstServices.Location = new System.Drawing.Point(451, 53);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(237, 228);
            this.lstServices.TabIndex = 4;
            this.lstServices.SelectedIndexChanged += new System.EventHandler(this.lstServices_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(118, 25);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(109, 30);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(118, 62);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(109, 30);
            this.description.TabIndex = 2;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(261, 10);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(78, 47);
            this.ADD.TabIndex = 3;
            this.ADD.Text = "ADD ";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PUT);
            this.panel1.Controls.Add(this.discriptin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ADD);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.name);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(12, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 123);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PUT
            // 
            this.PUT.Location = new System.Drawing.Point(261, 63);
            this.PUT.Name = "PUT";
            this.PUT.Size = new System.Drawing.Size(78, 48);
            this.PUT.TabIndex = 6;
            this.PUT.Text = "PUT";
            this.PUT.UseVisualStyleBackColor = true;
            this.PUT.Click += new System.EventHandler(this.PUT_Click);
            // 
            // discriptin
            // 
            this.discriptin.AutoSize = true;
            this.discriptin.Location = new System.Drawing.Point(-6, 62);
            this.discriptin.Name = "discriptin";
            this.discriptin.Size = new System.Drawing.Size(109, 25);
            this.discriptin.TabIndex = 5;
            this.discriptin.Text = "Description";
            this.discriptin.Click += new System.EventHandler(this.discriptin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Removee);
            this.panel2.Controls.Add(this.Remove);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel2.Location = new System.Drawing.Point(12, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 62);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Removee
            // 
            this.Removee.Location = new System.Drawing.Point(233, 6);
            this.Removee.Name = "Removee";
            this.Removee.Size = new System.Drawing.Size(78, 45);
            this.Removee.TabIndex = 1;
            this.Removee.Text = "DEL";
            this.Removee.UseVisualStyleBackColor = true;
            this.Removee.Click += new System.EventHandler(this.Removee_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(118, 14);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(109, 30);
            this.Remove.TabIndex = 0;
            this.Remove.TextChanged += new System.EventHandler(this.Remove_TextChanged);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(678, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 57);
            this.button4.TabIndex = 17;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "FIND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstServices);
            this.Name = "Service";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Remove;
        private System.Windows.Forms.Label discriptin;
        private System.Windows.Forms.Button Removee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PUT;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}