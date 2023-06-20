
namespace Application_Ludophonie.Vue.Praticien
{
    partial class Vue_Gestion_Carnets_De_Quetes
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
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblTitrePrincipal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lstBMissions = new System.Windows.Forms.ListBox();
            this.txtbMission = new System.Windows.Forms.RichTextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnToutSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(111)))));
            this.btnEnregistrer.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnEnregistrer.Location = new System.Drawing.Point(400, 666);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(219, 43);
            this.btnEnregistrer.TabIndex = 11;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // lblTitrePrincipal
            // 
            this.lblTitrePrincipal.AutoSize = true;
            this.lblTitrePrincipal.Font = new System.Drawing.Font("Montserrat SemiBold", 25.8F, System.Drawing.FontStyle.Bold);
            this.lblTitrePrincipal.Location = new System.Drawing.Point(162, 100);
            this.lblTitrePrincipal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitrePrincipal.Name = "lblTitrePrincipal";
            this.lblTitrePrincipal.Size = new System.Drawing.Size(693, 60);
            this.lblTitrePrincipal.TabIndex = 9;
            this.lblTitrePrincipal.Text = "Gestion du carnet de missions";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(296, 483);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(427, 35);
            this.label9.TabIndex = 14;
            this.label9.Text = "Création d\'une nouvelle mission";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(362, 183);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(294, 35);
            this.label10.TabIndex = 15;
            this.label10.Text = "Missions enregistrées";
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.btnRetour.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnRetour.Location = new System.Drawing.Point(902, 13);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(115, 34);
            this.btnRetour.TabIndex = 16;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lstBMissions
            // 
            this.lstBMissions.Font = new System.Drawing.Font("Montserrat", 14F);
            this.lstBMissions.FormattingEnabled = true;
            this.lstBMissions.ItemHeight = 32;
            this.lstBMissions.Location = new System.Drawing.Point(221, 256);
            this.lstBMissions.Name = "lstBMissions";
            this.lstBMissions.Size = new System.Drawing.Size(576, 164);
            this.lstBMissions.TabIndex = 17;
            // 
            // txtbMission
            // 
            this.txtbMission.Location = new System.Drawing.Point(221, 537);
            this.txtbMission.Name = "txtbMission";
            this.txtbMission.Size = new System.Drawing.Size(576, 85);
            this.txtbMission.TabIndex = 18;
            this.txtbMission.Text = "";
            this.txtbMission.TextChanged += new System.EventHandler(this.txtbMission_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(221, 628);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(576, 34);
            this.lblMessage.TabIndex = 19;
            this.lblMessage.Text = "label1";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(174)))), ((int)(((byte)(131)))));
            this.btnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnSupprimer.Location = new System.Drawing.Point(336, 427);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(171, 33);
            this.btnSupprimer.TabIndex = 20;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnToutSupprimer
            // 
            this.btnToutSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(174)))), ((int)(((byte)(131)))));
            this.btnToutSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnToutSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToutSupprimer.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnToutSupprimer.Location = new System.Drawing.Point(519, 427);
            this.btnToutSupprimer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnToutSupprimer.Name = "btnToutSupprimer";
            this.btnToutSupprimer.Size = new System.Drawing.Size(171, 33);
            this.btnToutSupprimer.TabIndex = 21;
            this.btnToutSupprimer.Text = "Tout supprimer";
            this.btnToutSupprimer.UseVisualStyleBackColor = false;
            this.btnToutSupprimer.Click += new System.EventHandler(this.btnToutSupprimer_Click);
            // 
            // Vue_Gestion_Carnets_De_Quetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1031, 771);
            this.Controls.Add(this.btnToutSupprimer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtbMission);
            this.Controls.Add(this.lstBMissions);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.lblTitrePrincipal);
            this.Font = new System.Drawing.Font("Montserrat", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Vue_Gestion_Carnets_De_Quetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vue_Gestion_Carnets_De_Quetes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblTitrePrincipal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ListBox lstBMissions;
        private System.Windows.Forms.RichTextBox txtbMission;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnToutSupprimer;
    }
}