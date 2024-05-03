namespace AppDesktop
{
    partial class Patient
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
            this.ADD = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.lstPatient = new System.Windows.Forms.ListBox();
            this.ServiceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PUT = new System.Windows.Forms.Button();
            this.IdPatient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DEL = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(275, 40);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(82, 41);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(117, 27);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(125, 30);
            this.userName.TabIndex = 1;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(117, 69);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(125, 30);
            this.Phone.TabIndex = 2;
            this.Phone.TextChanged += new System.EventHandler(this.Phone_TextChanged);
            // 
            // lstPatient
            // 
            this.lstPatient.FormattingEnabled = true;
            this.lstPatient.ItemHeight = 16;
            this.lstPatient.Location = new System.Drawing.Point(542, 65);
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.Size = new System.Drawing.Size(210, 212);
            this.lstPatient.TabIndex = 4;
            this.lstPatient.SelectedIndexChanged += new System.EventHandler(this.lstPatient_SelectedIndexChanged);
            // 
            // ServiceID
            // 
            this.ServiceID.Location = new System.Drawing.Point(117, 115);
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.Size = new System.Drawing.Size(125, 30);
            this.ServiceID.TabIndex = 5;
            this.ServiceID.TextChanged += new System.EventHandler(this.ServiceID_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "UserName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "ServiceID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PUT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ServiceID);
            this.panel1.Controls.Add(this.Phone);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.ADD);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(24, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 182);
            this.panel1.TabIndex = 9;
            // 
            // PUT
            // 
            this.PUT.Location = new System.Drawing.Point(275, 99);
            this.PUT.Name = "PUT";
            this.PUT.Size = new System.Drawing.Size(82, 46);
            this.PUT.TabIndex = 9;
            this.PUT.Text = "PUT";
            this.PUT.UseVisualStyleBackColor = true;
            this.PUT.Click += new System.EventHandler(this.PUT_Click);
            // 
            // IdPatient
            // 
            this.IdPatient.Location = new System.Drawing.Point(117, 28);
            this.IdPatient.Name = "IdPatient";
            this.IdPatient.Size = new System.Drawing.Size(125, 30);
            this.IdPatient.TabIndex = 10;
            this.IdPatient.TextChanged += new System.EventHandler(this.IdPatient_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.DEL);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.IdPatient);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel2.Location = new System.Drawing.Point(24, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 85);
            this.panel2.TabIndex = 12;
            // 
            // DEL
            // 
            this.DEL.Location = new System.Drawing.Point(249, 28);
            this.DEL.Name = "DEL";
            this.DEL.Size = new System.Drawing.Size(75, 34);
            this.DEL.TabIndex = 12;
            this.DEL.Text = "DEL";
            this.DEL.UseVisualStyleBackColor = true;
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(675, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 57);
            this.button4.TabIndex = 16;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "FIND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstPatient);
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.ListBox lstPatient;
        private System.Windows.Forms.TextBox ServiceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IdPatient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PUT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DEL;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}