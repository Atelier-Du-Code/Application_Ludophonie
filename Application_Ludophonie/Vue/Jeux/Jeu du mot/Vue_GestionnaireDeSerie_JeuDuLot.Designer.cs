
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
            this.cbxNbQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxNbQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.cbxNbQuestions.FormattingEnabled = true;
            this.cbxNbQuestions.Location = new System.Drawing.Point(290, 354);
            this.cbxNbQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNbQuestions.Name = "cbxNbQuestions";
            this.cbxNbQuestions.Size = new System.Drawing.Size(150, 29);
            this.cbxNbQuestions.TabIndex = 12;
            this.cbxNbQuestions.SelectedIndexChanged += new System.EventHandler(this.cbxNbQuestions_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Liste";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNbQuestions
            // 
            this.txtNbQuestions.AutoSize = true;
            this.txtNbQuestions.Location = new System.Drawing.Point(280, 318);
            this.txtNbQuestions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNbQuestions.Name = "txtNbQuestions";
            this.txtNbQuestions.Size = new System.Drawing.Size(171, 21);
            this.txtNbQuestions.TabIndex = 10;
            this.txtNbQuestions.Text = "Nombre de questions";
            this.txtNbQuestions.Click += new System.EventHandler(this.txtNbQuestions_Click);
            // 
            // cbxNiveau
            // 
            this.cbxNiveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxNiveau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.cbxNiveau.FormattingEnabled = true;
            this.cbxNiveau.Location = new System.Drawing.Point(290, 241);
            this.cbxNiveau.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNiveau.Name = "cbxNiveau";
            this.cbxNiveau.Size = new System.Drawing.Size(150, 29);
            this.cbxNiveau.TabIndex = 9;
            this.cbxNiveau.SelectedIndexChanged += new System.EventHandler(this.cbxNiveau_SelectedIndexChanged);
            // 
            // txtTitrePrincipal
            // 
            this.txtTitrePrincipal.AutoSize = true;
            this.txtTitrePrincipal.Font = new System.Drawing.Font("Montserrat SemiBold", 25.8F, System.Drawing.FontStyle.Bold);
            this.txtTitrePrincipal.Location = new System.Drawing.Point(157, 103);
            this.txtTitrePrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitrePrincipal.Name = "txtTitrePrincipal";
            this.txtTitrePrincipal.Size = new System.Drawing.Size(456, 60);
            this.txtTitrePrincipal.TabIndex = 8;
            this.txtTitrePrincipal.Text = "Paramètre ta série !";
            this.txtTitrePrincipal.Click += new System.EventHandler(this.txtTitrePrincipal_Click);
            // 
            // btnDebutSerie
            // 
            this.btnDebutSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.btnDebutSerie.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnDebutSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebutSerie.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnDebutSerie.Location = new System.Drawing.Point(265, 456);
            this.btnDebutSerie.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDebutSerie.Name = "btnDebutSerie";
            this.btnDebutSerie.Size = new System.Drawing.Size(219, 43);
            this.btnDebutSerie.TabIndex = 15;
            this.btnDebutSerie.Text = "Commencer";
            this.btnDebutSerie.UseVisualStyleBackColor = false;
            // 
            // Vue_GestionnaireDeSerie_JeuDuLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(802, 636);
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
    }
}