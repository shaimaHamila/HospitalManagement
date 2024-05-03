namespace vues
{
    partial class FAffectationService
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
            this.btnMedecin = new System.Windows.Forms.Button();
            this.btnChercherService = new System.Windows.Forms.Button();
            this.btnAfficherTout = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.cbServices = new System.Windows.Forms.ComboBox();
            this.clFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFin = new System.Windows.Forms.Label();
            this.cbMedecins = new System.Windows.Forms.ComboBox();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.clMedecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgvAffecServices = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAffecServices)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMedecin
            // 
            this.btnMedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedecin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMedecin.Location = new System.Drawing.Point(480, 244);
            this.btnMedecin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedecin.Name = "btnMedecin";
            this.btnMedecin.Size = new System.Drawing.Size(200, 41);
            this.btnMedecin.TabIndex = 19;
            this.btnMedecin.Text = "Chercher Medecin";
            this.btnMedecin.UseVisualStyleBackColor = true;
            this.btnMedecin.Click += new System.EventHandler(this.btnMedecin_Click);
            // 
            // btnChercherService
            // 
            this.btnChercherService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercherService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChercherService.Location = new System.Drawing.Point(480, 185);
            this.btnChercherService.Margin = new System.Windows.Forms.Padding(4);
            this.btnChercherService.Name = "btnChercherService";
            this.btnChercherService.Size = new System.Drawing.Size(200, 41);
            this.btnChercherService.TabIndex = 18;
            this.btnChercherService.Text = "Chercher Service";
            this.btnChercherService.UseVisualStyleBackColor = true;
            this.btnChercherService.Click += new System.EventHandler(this.btnChercherService_Click);
            // 
            // btnAfficherTout
            // 
            this.btnAfficherTout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherTout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAfficherTout.Location = new System.Drawing.Point(480, 133);
            this.btnAfficherTout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfficherTout.Name = "btnAfficherTout";
            this.btnAfficherTout.Size = new System.Drawing.Size(200, 41);
            this.btnAfficherTout.TabIndex = 17;
            this.btnAfficherTout.Text = "Afficher Tout";
            this.btnAfficherTout.UseVisualStyleBackColor = true;
            this.btnAfficherTout.Click += new System.EventHandler(this.btnAfficherTout_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnModifier.Location = new System.Drawing.Point(480, 73);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(200, 41);
            this.btnModifier.TabIndex = 16;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(183, 162);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(205, 30);
            this.dtpFin.TabIndex = 9;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(183, 117);
            this.dtpDebut.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(205, 30);
            this.dtpDebut.TabIndex = 8;
            // 
            // cbServices
            // 
            this.cbServices.FormattingEnabled = true;
            this.cbServices.Location = new System.Drawing.Point(187, 73);
            this.cbServices.Margin = new System.Windows.Forms.Padding(4);
            this.cbServices.Name = "cbServices";
            this.cbServices.Size = new System.Drawing.Size(203, 33);
            this.cbServices.TabIndex = 7;
            // 
            // clFin
            // 
            this.clFin.HeaderText = "Fin";
            this.clFin.MinimumWidth = 6;
            this.clFin.Name = "clFin";
            this.clFin.Width = 125;
            // 
            // clDebut
            // 
            this.clDebut.HeaderText = "Début";
            this.clDebut.MinimumWidth = 6;
            this.clDebut.Name = "clDebut";
            this.clDebut.Width = 125;
            // 
            // clService
            // 
            this.clService.HeaderText = "Service";
            this.clService.MinimumWidth = 6;
            this.clService.Name = "clService";
            this.clService.Width = 125;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(24, 169);
            this.lblFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(39, 25);
            this.lblFin.TabIndex = 6;
            this.lblFin.Text = "Fin";
            // 
            // cbMedecins
            // 
            this.cbMedecins.FormattingEnabled = true;
            this.cbMedecins.Location = new System.Drawing.Point(187, 21);
            this.cbMedecins.Margin = new System.Windows.Forms.Padding(4);
            this.cbMedecins.Name = "cbMedecins";
            this.cbMedecins.Size = new System.Drawing.Size(203, 33);
            this.cbMedecins.TabIndex = 5;
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.Location = new System.Drawing.Point(20, 25);
            this.lblMedecin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(87, 25);
            this.lblMedecin.TabIndex = 4;
            this.lblMedecin.Text = "Medecin";
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Location = new System.Drawing.Point(24, 121);
            this.lblDebut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(64, 25);
            this.lblDebut.TabIndex = 2;
            this.lblDebut.Text = "Début";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(31, 73);
            this.lblService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(78, 25);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Service";
            // 
            // clMedecin
            // 
            this.clMedecin.HeaderText = "Medecin";
            this.clMedecin.MinimumWidth = 6;
            this.clMedecin.Name = "clMedecin";
            this.clMedecin.Width = 125;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAjouter.Location = new System.Drawing.Point(480, 17);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(200, 41);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // dgvAffecServices
            // 
            this.dgvAffecServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAffecServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMedecin,
            this.clService,
            this.clDebut,
            this.clFin});
            this.dgvAffecServices.Location = new System.Drawing.Point(13, 321);
            this.dgvAffecServices.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAffecServices.Name = "dgvAffecServices";
            this.dgvAffecServices.RowHeadersWidth = 51;
            this.dgvAffecServices.Size = new System.Drawing.Size(667, 161);
            this.dgvAffecServices.TabIndex = 14;
            this.dgvAffecServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAffecServices_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.dtpDebut);
            this.panel1.Controls.Add(this.cbServices);
            this.panel1.Controls.Add(this.lblFin);
            this.panel1.Controls.Add(this.cbMedecins);
            this.panel1.Controls.Add(this.lblMedecin);
            this.panel1.Controls.Add(this.lblDebut);
            this.panel1.Controls.Add(this.lblService);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(31, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 229);
            this.panel1.TabIndex = 13;
            // 
            // FAffectationService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 523);
            this.Controls.Add(this.btnMedecin);
            this.Controls.Add(this.btnChercherService);
            this.Controls.Add(this.btnAfficherTout);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvAffecServices);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FAffectationService";
            this.Text = "FAffectationService";
            this.Load += new System.EventHandler(this.FAffectationService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAffecServices)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedecin;
        private System.Windows.Forms.Button btnChercherService;
        private System.Windows.Forms.Button btnAfficherTout;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.ComboBox cbServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn clService;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.ComboBox cbMedecins;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMedecin;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgvAffecServices;
        private System.Windows.Forms.Panel panel1;
    }
}