
namespace Application_Ludophonie
{
    partial class Authentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbMotDePasse = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblMdp = new System.Windows.Forms.Label();
            this.titrePrincipal = new System.Windows.Forms.Label();
            this.pbxAvatarIdentifie = new System.Windows.Forms.PictureBox();
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pIdentifiant = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtIdentifiant = new System.Windows.Forms.Label();
            this.txtbIdentifiant = new System.Windows.Forms.TextBox();
            this.lblMessageMDP = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatarIdentifie)).BeginInit();
            this.pIdentifiant.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbMotDePasse
            // 
            this.txtbMotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbMotDePasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.txtbMotDePasse.Location = new System.Drawing.Point(286, 547);
            this.txtbMotDePasse.Name = "txtbMotDePasse";
            this.txtbMotDePasse.Size = new System.Drawing.Size(221, 30);
            this.txtbMotDePasse.TabIndex = 12;
            this.txtbMotDePasse.TextChanged += new System.EventHandler(this.txtbMotDePasse_TextChanged);
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.btnConnexion.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.btnConnexion.Location = new System.Drawing.Point(286, 628);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(220, 44);
            this.btnConnexion.TabIndex = 11;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblMdp
            // 
            this.lblMdp.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold);
            this.lblMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.lblMdp.Location = new System.Drawing.Point(-5, 496);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(803, 35);
            this.lblMdp.TabIndex = 10;
            this.lblMdp.Text = "Mot de passe";
            this.lblMdp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titrePrincipal
            // 
            this.titrePrincipal.AutoSize = true;
            this.titrePrincipal.Font = new System.Drawing.Font("Lucida Bright", 27F, System.Drawing.FontStyle.Bold);
            this.titrePrincipal.Location = new System.Drawing.Point(245, -60);
            this.titrePrincipal.Name = "titrePrincipal";
            this.titrePrincipal.Size = new System.Drawing.Size(294, 52);
            this.titrePrincipal.TabIndex = 9;
            this.titrePrincipal.Text = "Ludophonie";
            // 
            // pbxAvatarIdentifie
            // 
            this.pbxAvatarIdentifie.Location = new System.Drawing.Point(280, 265);
            this.pbxAvatarIdentifie.Name = "pbxAvatarIdentifie";
            this.pbxAvatarIdentifie.Size = new System.Drawing.Size(233, 207);
            this.pbxAvatarIdentifie.TabIndex = 13;
            this.pbxAvatarIdentifie.TabStop = false;
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.Font = new System.Drawing.Font("Montserrat SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.lblBienvenue.Location = new System.Drawing.Point(-7, 190);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(806, 46);
            this.lblBienvenue.TabIndex = 14;
            this.lblBienvenue.Text = "Bienvenue Utilisateur !";
            this.lblBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(266, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 52);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ludophonie";
            // 
            // pIdentifiant
            // 
            this.pIdentifiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.pIdentifiant.Controls.Add(this.lblMessage);
            this.pIdentifiant.Controls.Add(this.btnValider);
            this.pIdentifiant.Controls.Add(this.txtIdentifiant);
            this.pIdentifiant.Controls.Add(this.txtbIdentifiant);
            this.pIdentifiant.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.pIdentifiant.Location = new System.Drawing.Point(12, 136);
            this.pIdentifiant.Name = "pIdentifiant";
            this.pIdentifiant.Size = new System.Drawing.Size(778, 536);
            this.pIdentifiant.TabIndex = 16;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.lblMessage.Location = new System.Drawing.Point(33, 231);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(683, 24);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "label1";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.btnValider.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.btnValider.Location = new System.Drawing.Point(264, 273);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(221, 40);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.AutoSize = true;
            this.txtIdentifiant.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold);
            this.txtIdentifiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.txtIdentifiant.Location = new System.Drawing.Point(296, 135);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(157, 35);
            this.txtIdentifiant.TabIndex = 1;
            this.txtIdentifiant.Text = "Identifiant";
            // 
            // txtbIdentifiant
            // 
            this.txtbIdentifiant.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtbIdentifiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.txtbIdentifiant.Location = new System.Drawing.Point(264, 182);
            this.txtbIdentifiant.Name = "txtbIdentifiant";
            this.txtbIdentifiant.Size = new System.Drawing.Size(221, 28);
            this.txtbIdentifiant.TabIndex = 4;
            this.txtbIdentifiant.TextChanged += new System.EventHandler(this.txtbIdentifiant_TextChanged);
            // 
            // lblMessageMDP
            // 
            this.lblMessageMDP.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lblMessageMDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.lblMessageMDP.Location = new System.Drawing.Point(-3, 584);
            this.lblMessageMDP.Name = "lblMessageMDP";
            this.lblMessageMDP.Size = new System.Drawing.Size(798, 23);
            this.lblMessageMDP.TabIndex = 17;
            this.lblMessageMDP.Text = "label2";
            this.lblMessageMDP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.btnQuitter.Location = new System.Drawing.Point(641, 689);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(139, 42);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(802, 743);
            this.Controls.Add(this.pIdentifiant);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblMessageMDP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbMotDePasse);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.titrePrincipal);
            this.Controls.Add(this.pbxAvatarIdentifie);
            this.Controls.Add(this.lblBienvenue);
            this.Name = "Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatarIdentifie)).EndInit();
            this.pIdentifiant.ResumeLayout(false);
            this.pIdentifiant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbMotDePasse;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label titrePrincipal;
        private System.Windows.Forms.PictureBox pbxAvatarIdentifie;
        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pIdentifiant;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label txtIdentifiant;
        private System.Windows.Forms.TextBox txtbIdentifiant;
        private System.Windows.Forms.Label lblMessageMDP;
        private System.Windows.Forms.Button btnQuitter;
    }
}

