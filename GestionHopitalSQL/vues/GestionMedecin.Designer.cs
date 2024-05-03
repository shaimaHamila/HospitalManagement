namespace vues
{
    partial class GestionMedecin
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
            this.btnRecheNom = new System.Windows.Forms.Button();
            this.btnRechAdresse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtCin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRechCin = new System.Windows.Forms.Button();
            this.dgvMedecins = new System.Windows.Forms.DataGridView();
            this.clCin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateNai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecins)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecheNom
            // 
            this.btnRecheNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecheNom.Location = new System.Drawing.Point(419, 91);
            this.btnRecheNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecheNom.Name = "btnRecheNom";
            this.btnRecheNom.Size = new System.Drawing.Size(252, 46);
            this.btnRecheNom.TabIndex = 9;
            this.btnRecheNom.Text = "Recherche par Nom";
            this.btnRecheNom.UseVisualStyleBackColor = true;
            this.btnRecheNom.Click += new System.EventHandler(this.btnRecheNom_Click);
            // 
            // btnRechAdresse
            // 
            this.btnRechAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechAdresse.Location = new System.Drawing.Point(419, 143);
            this.btnRechAdresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRechAdresse.Name = "btnRechAdresse";
            this.btnRechAdresse.Size = new System.Drawing.Size(252, 46);
            this.btnRechAdresse.TabIndex = 8;
            this.btnRechAdresse.Text = "Recherche par Adresse";
            this.btnRechAdresse.UseVisualStyleBackColor = true;
            this.btnRechAdresse.Click += new System.EventHandler(this.btnRechAdresse_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpNaissance);
            this.panel1.Controls.Add(this.txtAdresse);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.txtPrenom);
            this.panel1.Controls.Add(this.txtCin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(20, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 198);
            this.panel1.TabIndex = 7;
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNaissance.Location = new System.Drawing.Point(199, 123);
            this.dtpNaissance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(175, 30);
            this.dtpNaissance.TabIndex = 9;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(199, 161);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(175, 30);
            this.txtAdresse.TabIndex = 8;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(199, 85);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(176, 30);
            this.txtNom.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(199, 48);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(177, 30);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtCin
            // 
            this.txtCin.Location = new System.Drawing.Point(199, 10);
            this.txtCin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCin.Name = "txtCin";
            this.txtCin.Size = new System.Drawing.Size(179, 30);
            this.txtCin.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRechCin
            // 
            this.btnRechCin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechCin.Location = new System.Drawing.Point(419, 33);
            this.btnRechCin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRechCin.Name = "btnRechCin";
            this.btnRechCin.Size = new System.Drawing.Size(252, 46);
            this.btnRechCin.TabIndex = 6;
            this.btnRechCin.Text = "Recherche par CIN";
            this.btnRechCin.UseVisualStyleBackColor = true;
            this.btnRechCin.Click += new System.EventHandler(this.btnRechCin_Click);
            // 
            // dgvMedecins
            // 
            this.dgvMedecins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedecins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCin,
            this.clPrenom,
            this.clNom,
            this.clDateNai,
            this.clAdresse});
            this.dgvMedecins.Location = new System.Drawing.Point(19, 233);
            this.dgvMedecins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMedecins.Name = "dgvMedecins";
            this.dgvMedecins.RowHeadersWidth = 51;
            this.dgvMedecins.Size = new System.Drawing.Size(763, 181);
            this.dgvMedecins.TabIndex = 5;
            // 
            // clCin
            // 
            this.clCin.HeaderText = "CIN";
            this.clCin.MinimumWidth = 6;
            this.clCin.Name = "clCin";
            this.clCin.Width = 125;
            // 
            // clPrenom
            // 
            this.clPrenom.HeaderText = "Prénom";
            this.clPrenom.MinimumWidth = 6;
            this.clPrenom.Name = "clPrenom";
            this.clPrenom.Width = 125;
            // 
            // clNom
            // 
            this.clNom.HeaderText = "Nom";
            this.clNom.MinimumWidth = 6;
            this.clNom.Name = "clNom";
            this.clNom.Width = 125;
            // 
            // clDateNai
            // 
            this.clDateNai.HeaderText = "Date de naissance";
            this.clDateNai.MinimumWidth = 6;
            this.clDateNai.Name = "clDateNai";
            this.clDateNai.Width = 130;
            // 
            // clAdresse
            // 
            this.clAdresse.HeaderText = "Adresse";
            this.clAdresse.MinimumWidth = 6;
            this.clAdresse.Name = "clAdresse";
            this.clAdresse.Width = 125;
            // 
            // GestionMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 437);
            this.Controls.Add(this.btnRecheNom);
            this.Controls.Add(this.btnRechAdresse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRechCin);
            this.Controls.Add(this.dgvMedecins);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GestionMedecin";
            this.Text = "GestionMedecin";
            this.Load += new System.EventHandler(this.GestionMedecin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecheNom;
        private System.Windows.Forms.Button btnRechAdresse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtCin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRechCin;
        private System.Windows.Forms.DataGridView dgvMedecins;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDateNai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdresse;
    }
}