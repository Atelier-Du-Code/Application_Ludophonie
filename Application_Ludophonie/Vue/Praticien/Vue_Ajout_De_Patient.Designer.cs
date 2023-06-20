
namespace Application_Ludophonie.Vue.Praticien
{
    partial class Vue_Ajout_De_Patient
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
            this.pNouveauPatient = new System.Windows.Forms.Panel();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.txtbMotDePasseConfirmation = new System.Windows.Forms.TextBox();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txtbMotDePasse = new System.Windows.Forms.TextBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.txtbClasse = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtbPrenom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtbNom = new System.Windows.Forms.TextBox();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.txtbIdentifiant = new System.Windows.Forms.TextBox();
            this.lblTitrePModifAjoutPatient = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pNouveauPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pNouveauPatient
            // 
            this.pNouveauPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNouveauPatient.Controls.Add(this.btnEnregistrer);
            this.pNouveauPatient.Controls.Add(this.lblMessage);
            this.pNouveauPatient.Controls.Add(this.lblConfirmation);
            this.pNouveauPatient.Controls.Add(this.txtbMotDePasseConfirmation);
            this.pNouveauPatient.Controls.Add(this.lblMotDePasse);
            this.pNouveauPatient.Controls.Add(this.txtbMotDePasse);
            this.pNouveauPatient.Controls.Add(this.lblClasse);
            this.pNouveauPatient.Controls.Add(this.txtbClasse);
            this.pNouveauPatient.Controls.Add(this.lblPrenom);
            this.pNouveauPatient.Controls.Add(this.txtbPrenom);
            this.pNouveauPatient.Controls.Add(this.lblNom);
            this.pNouveauPatient.Controls.Add(this.txtbNom);
            this.pNouveauPatient.Controls.Add(this.lblIdentifiant);
            this.pNouveauPatient.Controls.Add(this.txtbIdentifiant);
            this.pNouveauPatient.Controls.Add(this.lblTitrePModifAjoutPatient);
            this.pNouveauPatient.Controls.Add(this.pictureBox2);
            this.pNouveauPatient.Location = new System.Drawing.Point(33, 22);
            this.pNouveauPatient.Name = "pNouveauPatient";
            this.pNouveauPatient.Size = new System.Drawing.Size(967, 727);
            this.pNouveauPatient.TabIndex = 48;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(111)))));
            this.btnEnregistrer.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnEnregistrer.Location = new System.Drawing.Point(432, 672);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(140, 38);
            this.btnEnregistrer.TabIndex = 62;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lblMessage.Location = new System.Drawing.Point(165, 601);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(648, 68);
            this.lblMessage.TabIndex = 60;
            this.lblMessage.Text = "Le mot de passe doit contenir au moins 12 caractères dont une majuscule, une minu" +
    "sucle, un chiffre et un caractère spécial autorisé(@#$%^&*+$)";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lblConfirmation.Location = new System.Drawing.Point(428, 539);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(123, 24);
            this.lblConfirmation.TabIndex = 58;
            this.lblConfirmation.Text = "Confirmation";
            // 
            // txtbMotDePasseConfirmation
            // 
            this.txtbMotDePasseConfirmation.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtbMotDePasseConfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.txtbMotDePasseConfirmation.Location = new System.Drawing.Point(308, 565);
            this.txtbMotDePasseConfirmation.Name = "txtbMotDePasseConfirmation";
            this.txtbMotDePasseConfirmation.Size = new System.Drawing.Size(363, 32);
            this.txtbMotDePasseConfirmation.TabIndex = 57;
            this.txtbMotDePasseConfirmation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbMotDePasseConfirmation.UseSystemPasswordChar = true;
            this.txtbMotDePasseConfirmation.TextChanged += new System.EventHandler(this.txtbMotDePasseConfirmation_TextChanged);
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lblMotDePasse.Location = new System.Drawing.Point(428, 469);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(122, 24);
            this.lblMotDePasse.TabIndex = 56;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // txtbMotDePasse
            // 
            this.txtbMotDePasse.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtbMotDePasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.txtbMotDePasse.Location = new System.Drawing.Point(308, 495);
            this.txtbMotDePasse.Name = "txtbMotDePasse";
            this.txtbMotDePasse.Size = new System.Drawing.Size(363, 32);
            this.txtbMotDePasse.TabIndex = 55;
            this.txtbMotDePasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbMotDePasse.UseSystemPasswordChar = true;
            this.txtbMotDePasse.TextChanged += new System.EventHandler(this.txtbMotDePasse_TextChanged);
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lblClasse.Location = new System.Drawing.Point(359, 395);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(63, 24);
            this.lblClasse.TabIndex = 54;
            this.lblClasse.Text = "Classe";
            // 
            // txtbClasse
            // 
            this.txtbClasse.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtbClasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.txtbClasse.Location = new System.Drawing.Point(301, 421);
            this.txtbClasse.Name = "txtbClasse";
            this.txtbClasse.Size = new System.Drawing.Size(168, 32);
            this.txtbClasse.TabIndex = 53;
            this.txtbClasse.TextChanged += new System.EventHandler(this.txtbClasse_TextChanged);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lblPrenom.Location = new System.Drawing.Point(539, 323);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(79, 24);
            this.lblPrenom.TabIndex = 52;
            this.lblPrenom.Text = "Prénom";
            // 
            // txtbPrenom
            // 
            this.txtbPrenom.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtbPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.txtbPrenom.Location = new System.Drawing.Point(494, 349);
            this.txtbPrenom.Name = "txtbPrenom";
            this.txtbPrenom.Size = new System.Drawing.Size(168, 32);
            this.txtbPrenom.TabIndex = 51;
            this.txtbPrenom.TextChanged += new System.EventHandler(this.txtbPrenom_TextChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lblNom.Location = new System.Drawing.Point(359, 323);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(53, 24);
            this.lblNom.TabIndex = 50;
            this.lblNom.Text = "Nom";
            // 
            // txtbNom
            // 
            this.txtbNom.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtbNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.txtbNom.Location = new System.Drawing.Point(301, 349);
            this.txtbNom.Name = "txtbNom";
            this.txtbNom.Size = new System.Drawing.Size(168, 32);
            this.txtbNom.TabIndex = 49;
            this.txtbNom.TextChanged += new System.EventHandler(this.txtbNom_TextChanged);
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lblIdentifiant.Location = new System.Drawing.Point(529, 395);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(98, 24);
            this.lblIdentifiant.TabIndex = 48;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // txtbIdentifiant
            // 
            this.txtbIdentifiant.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtbIdentifiant.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtbIdentifiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.txtbIdentifiant.Location = new System.Drawing.Point(494, 421);
            this.txtbIdentifiant.Name = "txtbIdentifiant";
            this.txtbIdentifiant.Size = new System.Drawing.Size(168, 32);
            this.txtbIdentifiant.TabIndex = 47;
            this.txtbIdentifiant.TextChanged += new System.EventHandler(this.txtbIdentifiant_TextChanged);
            // 
            // lblTitrePModifAjoutPatient
            // 
            this.lblTitrePModifAjoutPatient.Font = new System.Drawing.Font("Montserrat SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitrePModifAjoutPatient.Location = new System.Drawing.Point(320, 18);
            this.lblTitrePModifAjoutPatient.Name = "lblTitrePModifAjoutPatient";
            this.lblTitrePModifAjoutPatient.Size = new System.Drawing.Size(334, 95);
            this.lblTitrePModifAjoutPatient.TabIndex = 46;
            this.lblTitrePModifAjoutPatient.Text = "Création d\'un nouveau patient";
            this.lblTitrePModifAjoutPatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Application_Ludophonie.Properties.Resources.avatar_par_defaut;
            this.pictureBox2.Location = new System.Drawing.Point(378, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // Vue_Ajout_De_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1031, 771);
            this.Controls.Add(this.pNouveauPatient);
            this.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.Name = "Vue_Ajout_De_Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vue_Ajout_De_Patient";
            this.Load += new System.EventHandler(this.Vue_Ajout_De_Patient_Load);
            this.pNouveauPatient.ResumeLayout(false);
            this.pNouveauPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pNouveauPatient;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.TextBox txtbMotDePasseConfirmation;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtbMotDePasse;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.TextBox txtbClasse;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtbPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtbNom;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox txtbIdentifiant;
        private System.Windows.Forms.Label lblTitrePModifAjoutPatient;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}