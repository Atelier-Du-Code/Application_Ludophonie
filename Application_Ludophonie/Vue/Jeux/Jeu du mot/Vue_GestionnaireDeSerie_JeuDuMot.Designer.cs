
namespace Application_Ludophonie.Vue.Jeux
{
    partial class Vue_GestionnaireDeSerie_JeuDuLot
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.cbxNbQuestions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNbQuestions = new System.Windows.Forms.Label();
            this.cbxNiveau = new System.Windows.Forms.ComboBox();
            this.txtTitrePrincipal = new System.Windows.Forms.Label();
            this.btnDebutSerie = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(845, 788);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(100, 43);
            this.btnRetour.TabIndex = 14;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // cbxNbQuestions
            // 
            this.cbxNbQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNbQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxNbQuestions.Font = new System.Drawing.Font("Montserrat", 10F);
            this.cbxNbQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.cbxNbQuestions.FormattingEnabled = true;
            this.cbxNbQuestions.Location = new System.Drawing.Point(267, 369);
            this.cbxNbQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNbQuestions.Name = "cbxNbQuestions";
            this.cbxNbQuestions.Size = new System.Drawing.Size(218, 32);
            this.cbxNbQuestions.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11F);
            this.label3.Location = new System.Drawing.Point(348, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Liste";
            // 
            // txtNbQuestions
            // 
            this.txtNbQuestions.AutoSize = true;
            this.txtNbQuestions.Font = new System.Drawing.Font("Montserrat", 11F);
            this.txtNbQuestions.Location = new System.Drawing.Point(267, 340);
            this.txtNbQuestions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNbQuestions.Name = "txtNbQuestions";
            this.txtNbQuestions.Size = new System.Drawing.Size(218, 26);
            this.txtNbQuestions.TabIndex = 10;
            this.txtNbQuestions.Text = "Nombre de questions";
            // 
            // cbxNiveau
            // 
            this.cbxNiveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNiveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxNiveau.Font = new System.Drawing.Font("Montserrat", 10F);
            this.cbxNiveau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.cbxNiveau.FormattingEnabled = true;
            this.cbxNiveau.Location = new System.Drawing.Point(270, 267);
            this.cbxNiveau.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNiveau.Name = "cbxNiveau";
            this.cbxNiveau.Size = new System.Drawing.Size(213, 32);
            this.cbxNiveau.TabIndex = 9;
            this.cbxNiveau.SelectedIndexChanged += new System.EventHandler(this.cbxNiveau_SelectedIndexChanged);
            // 
            // txtTitrePrincipal
            // 
            this.txtTitrePrincipal.AutoSize = true;
            this.txtTitrePrincipal.Font = new System.Drawing.Font("Montserrat SemiBold", 25.8F, System.Drawing.FontStyle.Bold);
            this.txtTitrePrincipal.Location = new System.Drawing.Point(148, 128);
            this.txtTitrePrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitrePrincipal.Name = "txtTitrePrincipal";
            this.txtTitrePrincipal.Size = new System.Drawing.Size(456, 60);
            this.txtTitrePrincipal.TabIndex = 8;
            this.txtTitrePrincipal.Text = "Paramètre ta série !";
            // 
            // btnDebutSerie
            // 
            this.btnDebutSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(111)))));
            this.btnDebutSerie.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnDebutSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebutSerie.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnDebutSerie.Location = new System.Drawing.Point(267, 464);
            this.btnDebutSerie.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDebutSerie.Name = "btnDebutSerie";
            this.btnDebutSerie.Size = new System.Drawing.Size(218, 43);
            this.btnDebutSerie.TabIndex = 15;
            this.btnDebutSerie.Text = "Commencer";
            this.btnDebutSerie.UseVisualStyleBackColor = false;
            this.btnDebutSerie.Click += new System.EventHandler(this.btnDebutSerie_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnQuitter.Location = new System.Drawing.Point(559, 13);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(162, 43);
            this.btnQuitter.TabIndex = 16;
            this.btnQuitter.Text = "Quitter le jeu";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(56, 414);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(640, 45);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.Text = "label1";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Vue_GestionnaireDeSerie_JeuDuLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(735, 689);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnDebutSerie);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.cbxNbQuestions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNbQuestions);
            this.Controls.Add(this.cbxNiveau);
            this.Controls.Add(this.txtTitrePrincipal);
            this.Font = new System.Drawing.Font("Montserrat", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Vue_GestionnaireDeSerie_JeuDuLot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vue_GestionnaireDeSerie_JeuDuLot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ComboBox cbxNbQuestions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtNbQuestions;
        private System.Windows.Forms.ComboBox cbxNiveau;
        private System.Windows.Forms.Label txtTitrePrincipal;
        private System.Windows.Forms.Button btnDebutSerie;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblMessage;
    }
}