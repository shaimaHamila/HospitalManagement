namespace AppDesktop
{
    partial class Doctor
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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.lstDoctor = new System.Windows.Forms.ListBox();
            this.ADD = new System.Windows.Forms.Button();
            this.Adress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4g = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbServiceIds = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(161, 37);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 30);
            this.FirstName.TabIndex = 0;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(161, 87);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 30);
            this.LastName.TabIndex = 1;
            // 
            // lstDoctor
            // 
            this.lstDoctor.FormattingEnabled = true;
            this.lstDoctor.ItemHeight = 16;
            this.lstDoctor.Location = new System.Drawing.Point(560, 109);
            this.lstDoctor.Name = "lstDoctor";
            this.lstDoctor.Size = new System.Drawing.Size(190, 180);
            this.lstDoctor.TabIndex = 4;
            this.lstDoctor.SelectedIndexChanged += new System.EventHandler(this.lstDoctor_SelectedIndexChanged);
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(374, 24);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(95, 60);
            this.ADD.TabIndex = 6;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(161, 231);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(100, 30);
            this.Adress.TabIndex = 7;
            this.Adress.TextChanged += new System.EventHandler(this.Adress_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Birthday";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4g
            // 
            this.label4g.AutoSize = true;
            this.label4g.Location = new System.Drawing.Point(29, 185);
            this.label4g.Name = "label4g";
            this.label4g.Size = new System.Drawing.Size(97, 25);
            this.label4g.TabIndex = 11;
            this.label4g.Text = "ServiceID";
            this.label4g.Click += new System.EventHandler(this.label4g_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adress";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbServiceIds
            // 
            this.cmbServiceIds.FormattingEnabled = true;
            this.cmbServiceIds.Location = new System.Drawing.Point(161, 182);
            this.cmbServiceIds.Name = "cmbServiceIds";
            this.cmbServiceIds.Size = new System.Drawing.Size(121, 33);
            this.cmbServiceIds.TabIndex = 13;
            this.cmbServiceIds.SelectedIndexChanged += new System.EventHandler(this.cmbServiceIds_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cmbServiceIds);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4g);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Adress);
            this.panel1.Controls.Add(this.ADD);
            this.panel1.Controls.Add(this.birth);
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(1, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 289);
            this.panel1.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 60);
            this.button3.TabIndex = 18;
            this.button3.Text = "FIND";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 60);
            this.button2.TabIndex = 17;
            this.button2.Text = "PUT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Location = new System.Drawing.Point(159, 44);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(97, 30);
            this.txtDoctorId.TabIndex = 16;
            this.txtDoctorId.TextChanged += new System.EventHandler(this.txtDoctorId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 60);
            this.button1.TabIndex = 14;
            this.button1.Text = "DEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // birth
            // 
            this.birth.Location = new System.Drawing.Point(161, 136);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(200, 30);
            this.birth.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(686, 374);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 57);
            this.button4.TabIndex = 15;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtDoctorId);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel2.Location = new System.Drawing.Point(3, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 97);
            this.panel2.TabIndex = 19;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstDoctor);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.ListBox lstDoctor;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4g;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbServiceIds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker birth;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
    }
}