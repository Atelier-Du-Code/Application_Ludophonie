
namespace Application_Ludophonie.Vue.Patient
{
    partial class Vue_MenuPrincipal_Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vue_MenuPrincipal_Patient));
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnModifAvatar = new System.Windows.Forms.Button();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.btnCarnetDeMission = new System.Windows.Forms.Button();
            this.btnJeuDuMot = new System.Windows.Forms.Button();
            this.txtTitrePrincipal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.btnDeconnexion.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnexion.Font = new System.Drawing.Font("Montserrat", 9F);
            this.btnDeconnexion.Location = new System.Drawing.Point(545, 9);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(140, 36);
            this.btnDeconnexion.TabIndex = 13;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnModifAvatar
            // 
            this.btnModifAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.btnModifAvatar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModifAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifAvatar.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnModifAvatar.Location = new System.Drawing.Point(245, 372);
            this.btnModifAvatar.Name = "btnModifAvatar";
            this.btnModifAvatar.Size = new System.Drawing.Size(185, 39);
            this.btnModifAvatar.TabIndex = 12;
            this.btnModifAvatar.Text = "Modifie ton avatar !";
            this.btnModifAvatar.UseVisualStyleBackColor = false;
            this.btnModifAvatar.Click += new System.EventHandler(this.btnModifAvatar_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.Location = new System.Drawing.Point(248, 209);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(179, 164);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 11;
            this.pbAvatar.TabStop = false;
            // 
            // btnCarnetDeMission
            // 
            this.btnCarnetDeMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(111)))));
            this.btnCarnetDeMission.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCarnetDeMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarnetDeMission.Font = new System.Drawing.Font("Montserrat", 19F);
            this.btnCarnetDeMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.btnCarnetDeMission.Location = new System.Drawing.Point(150, 457);
            this.btnCarnetDeMission.Name = "btnCarnetDeMission";
            this.btnCarnetDeMission.Size = new System.Drawing.Size(374, 62);
            this.btnCarnetDeMission.TabIndex = 10;
            this.btnCarnetDeMission.Text = "Carnet de quêtes";
            this.btnCarnetDeMission.UseVisualStyleBackColor = false;
            this.btnCarnetDeMission.Click += new System.EventHandler(this.btnCarnetDeMission_Click);
            // 
            // btnJeuDuMot
            // 
            this.btnJeuDuMot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.btnJeuDuMot.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnJeuDuMot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJeuDuMot.Font = new System.Drawing.Font("Montserrat", 14F);
            this.btnJeuDuMot.Location = new System.Drawing.Point(262, 539);
            this.btnJeuDuMot.Name = "btnJeuDuMot";
            this.btnJeuDuMot.Size = new System.Drawing.Size(151, 107);
            this.btnJeuDuMot.TabIndex = 8;
            this.btnJeuDuMot.Text = "Jeu du mot";
            this.btnJeuDuMot.UseVisualStyleBackColor = false;
            this.btnJeuDuMot.Click += new System.EventHandler(this.btnJeuDuMot_Click);
            // 
            // txtTitrePrincipal
            // 
            this.txtTitrePrincipal.AutoSize = true;
            this.txtTitrePrincipal.Font = new System.Drawing.Font("Montserrat SemiBold", 25.8F, System.Drawing.FontStyle.Bold);
            this.txtTitrePrincipal.Location = new System.Drawing.Point(145, 105);
            this.txtTitrePrincipal.Name = "txtTitrePrincipal";
            this.txtTitrePrincipal.Size = new System.Drawing.Size(384, 60);
            this.txtTitrePrincipal.TabIndex = 7;
            this.txtTitrePrincipal.Text = "Tableau de bord";
            // 
            // Vue_MenuPrincipal_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(697, 704);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnModifAvatar);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.btnCarnetDeMission);
            this.Controls.Add(this.btnJeuDuMot);
            this.Controls.Add(this.txtTitrePrincipal);
            this.Font = new System.Drawing.Font("Montserrat", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Vue_MenuPrincipal_Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vue_MenuPrincipal_Patient";
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnModifAvatar;
        private System.Windows.Forms.Button btnCarnetDeMission;
        private System.Windows.Forms.Button btnJeuDuMot;
        private System.Windows.Forms.Label txtTitrePrincipal;
        public System.Windows.Forms.PictureBox pbAvatar;
    }
}