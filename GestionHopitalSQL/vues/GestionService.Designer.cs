namespace vues
{
    partial class GestionService
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.clNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNbreLits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChefServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMedecins = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNbreLits = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnChercherNom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAjouter.Location = new System.Drawing.Point(489, 70);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(209, 41);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgvServices
            // 
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNom,
            this.clNbreLits,
            this.clChefServ});
            this.dgvServices.Location = new System.Drawing.Point(20, 290);
            this.dgvServices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.Size = new System.Drawing.Size(639, 161);
            this.dgvServices.TabIndex = 7;
            this.dgvServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellContentClick);
            // 
            // clNom
            // 
            this.clNom.HeaderText = "Nom";
            this.clNom.MinimumWidth = 6;
            this.clNom.Name = "clNom";
            this.clNom.Width = 125;
            // 
            // clNbreLits
            // 
            this.clNbreLits.HeaderText = "Nbre de lits";
            this.clNbreLits.MinimumWidth = 6;
            this.clNbreLits.Name = "clNbreLits";
            this.clNbreLits.Width = 125;
            // 
            // clChefServ
            // 
            this.clChefServ.HeaderText = "Chef Service";
            this.clChefServ.MinimumWidth = 6;
            this.clChefServ.Name = "clChefServ";
            this.clChefServ.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbMedecins);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNbreLits);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(21, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 205);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbMedecins
            // 
            this.cbMedecins.FormattingEnabled = true;
            this.cbMedecins.Location = new System.Drawing.Point(187, 129);
            this.cbMedecins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMedecins.Name = "cbMedecins";
            this.cbMedecins.Size = new System.Drawing.Size(203, 33);
            this.cbMedecins.TabIndex = 5;
            this.cbMedecins.SelectedIndexChanged += new System.EventHandler(this.cbMedecins_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chef service";
            // 
            // txtNbreLits
            // 
            this.txtNbreLits.Location = new System.Drawing.Point(187, 76);
            this.txtNbreLits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNbreLits.Name = "txtNbreLits";
            this.txtNbreLits.Size = new System.Drawing.Size(204, 30);
            this.txtNbreLits.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nbre Lits";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(187, 30);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(204, 30);
            this.txtNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnModifier.Location = new System.Drawing.Point(492, 130);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(207, 41);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnChercherNom
            // 
            this.btnChercherNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercherNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChercherNom.Location = new System.Drawing.Point(492, 186);
            this.btnChercherNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChercherNom.Name = "btnChercherNom";
            this.btnChercherNom.Size = new System.Drawing.Size(207, 41);
            this.btnChercherNom.TabIndex = 10;
            this.btnChercherNom.Text = "Chercher par nom";
            this.btnChercherNom.UseVisualStyleBackColor = true;
            this.btnChercherNom.Click += new System.EventHandler(this.btnChercherNom_Click);
            // 
            // GestionService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 452);
            this.Controls.Add(this.btnChercherNom);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GestionService";
            this.Text = "GestionService";
            this.Load += new System.EventHandler(this.GestionService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNbreLits;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChefServ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMedecins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNbreLits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnChercherNom;
    }
}