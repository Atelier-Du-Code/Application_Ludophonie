
namespace Application_Ludophonie.Vue.Praticien
{
    partial class Vue_Detail_Patient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.lblLeNom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblLePrenom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblLaClasse = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.dgvDernieresSeries = new System.Windows.Forms.DataGridView();
            this.C_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_NbQuestionsDeLaSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_NbErreurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Timer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxJeux = new System.Windows.Forms.ComboBox();
            this.lblCboxJeux = new System.Windows.Forms.Label();
            this.lblTitreMoyenneErreurs = new System.Windows.Forms.Label();
            this.lblTitreMoyenneChrono = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDernieresSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Location = new System.Drawing.Point(38, 125);
            this.pbxAvatar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(229, 232);
            this.pbxAvatar.TabIndex = 0;
            this.pbxAvatar.TabStop = false;
            // 
            // lblLeNom
            // 
            this.lblLeNom.Location = new System.Drawing.Point(302, 135);
            this.lblLeNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeNom.Name = "lblLeNom";
            this.lblLeNom.Size = new System.Drawing.Size(56, 22);
            this.lblLeNom.TabIndex = 1;
            this.lblLeNom.Text = "Nom :";
            // 
            // lblNom
            // 
            this.lblNom.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblNom.Location = new System.Drawing.Point(302, 158);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(269, 41);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "lilou";
            // 
            // lblLePrenom
            // 
            this.lblLePrenom.Location = new System.Drawing.Point(302, 209);
            this.lblLePrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLePrenom.Name = "lblLePrenom";
            this.lblLePrenom.Size = new System.Drawing.Size(160, 26);
            this.lblLePrenom.TabIndex = 3;
            this.lblLePrenom.Text = "Prénom :";
            this.lblLePrenom.Click += new System.EventHandler(this.lblLePrenom_Click);
            // 
            // lblPrenom
            // 
            this.lblPrenom.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblPrenom.Location = new System.Drawing.Point(302, 233);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(284, 33);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Lilou";
            // 
            // lblLaClasse
            // 
            this.lblLaClasse.Location = new System.Drawing.Point(302, 278);
            this.lblLaClasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaClasse.Name = "lblLaClasse";
            this.lblLaClasse.Size = new System.Drawing.Size(111, 22);
            this.lblLaClasse.TabIndex = 5;
            this.lblLaClasse.Text = "Classe :";
            // 
            // lblClasse
            // 
            this.lblClasse.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblClasse.Location = new System.Drawing.Point(302, 303);
            this.lblClasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(152, 38);
            this.lblClasse.TabIndex = 6;
            this.lblClasse.Text = "CM2";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblIdentifiant.Location = new System.Drawing.Point(38, 361);
            this.lblIdentifiant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(229, 40);
            this.lblIdentifiant.TabIndex = 7;
            this.lblIdentifiant.Text = "label7";
            this.lblIdentifiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(618, 200);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(192, 21);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Modifier le mot de passe";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Montserrat", 10F);
            this.button11.Location = new System.Drawing.Point(604, 228);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(221, 41);
            this.button11.TabIndex = 16;
            this.button11.Text = "Modifier";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // dgvDernieresSeries
            // 
            this.dgvDernieresSeries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDernieresSeries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDernieresSeries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvDernieresSeries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDernieresSeries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDernieresSeries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDernieresSeries.ColumnHeadersHeight = 65;
            this.dgvDernieresSeries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Nom,
            this.C_NbQuestionsDeLaSerie,
            this.C_NbErreurs,
            this.C_Timer,
            this.C_Date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDernieresSeries.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDernieresSeries.EnableHeadersVisualStyles = false;
            this.dgvDernieresSeries.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDernieresSeries.Location = new System.Drawing.Point(38, 546);
            this.dgvDernieresSeries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDernieresSeries.MultiSelect = false;
            this.dgvDernieresSeries.Name = "dgvDernieresSeries";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDernieresSeries.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDernieresSeries.RowHeadersVisible = false;
            this.dgvDernieresSeries.RowHeadersWidth = 120;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.dgvDernieresSeries.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDernieresSeries.RowTemplate.Height = 24;
            this.dgvDernieresSeries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDernieresSeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDernieresSeries.Size = new System.Drawing.Size(839, 449);
            this.dgvDernieresSeries.TabIndex = 21;
            // 
            // C_Nom
            // 
            this.C_Nom.HeaderText = "Date";
            this.C_Nom.MinimumWidth = 6;
            this.C_Nom.Name = "C_Nom";
            // 
            // C_NbQuestionsDeLaSerie
            // 
            this.C_NbQuestionsDeLaSerie.HeaderText = "Jeu";
            this.C_NbQuestionsDeLaSerie.MinimumWidth = 6;
            this.C_NbQuestionsDeLaSerie.Name = "C_NbQuestionsDeLaSerie";
            // 
            // C_NbErreurs
            // 
            this.C_NbErreurs.HeaderText = "Nombre de questions";
            this.C_NbErreurs.MinimumWidth = 6;
            this.C_NbErreurs.Name = "C_NbErreurs";
            // 
            // C_Timer
            // 
            this.C_Timer.HeaderText = "Nombre d\'erreur(s)";
            this.C_Timer.MinimumWidth = 6;
            this.C_Timer.Name = "C_Timer";
            // 
            // C_Date
            // 
            this.C_Date.HeaderText = "Chrono";
            this.C_Date.MinimumWidth = 6;
            this.C_Date.Name = "C_Date";
            // 
            // cbxJeux
            // 
            this.cbxJeux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxJeux.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.cbxJeux.FormattingEnabled = true;
            this.cbxJeux.Location = new System.Drawing.Point(116, 463);
            this.cbxJeux.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxJeux.Name = "cbxJeux";
            this.cbxJeux.Size = new System.Drawing.Size(150, 29);
            this.cbxJeux.TabIndex = 22;
            // 
            // lblCboxJeux
            // 
            this.lblCboxJeux.AutoSize = true;
            this.lblCboxJeux.Location = new System.Drawing.Point(127, 436);
            this.lblCboxJeux.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCboxJeux.Name = "lblCboxJeux";
            this.lblCboxJeux.Size = new System.Drawing.Size(110, 21);
            this.lblCboxJeux.TabIndex = 23;
            this.lblCboxJeux.Text = "Liste des jeux";
            // 
            // lblTitreMoyenneErreurs
            // 
            this.lblTitreMoyenneErreurs.AutoSize = true;
            this.lblTitreMoyenneErreurs.Location = new System.Drawing.Point(343, 436);
            this.lblTitreMoyenneErreurs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreMoyenneErreurs.Name = "lblTitreMoyenneErreurs";
            this.lblTitreMoyenneErreurs.Size = new System.Drawing.Size(237, 21);
            this.lblTitreMoyenneErreurs.TabIndex = 24;
            this.lblTitreMoyenneErreurs.Text = "Moyenne du nombre d\'erreurs";
            // 
            // lblTitreMoyenneChrono
            // 
            this.lblTitreMoyenneChrono.AutoSize = true;
            this.lblTitreMoyenneChrono.Location = new System.Drawing.Point(649, 436);
            this.lblTitreMoyenneChrono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreMoyenneChrono.Name = "lblTitreMoyenneChrono";
            this.lblTitreMoyenneChrono.Size = new System.Drawing.Size(172, 21);
            this.lblTitreMoyenneChrono.TabIndex = 25;
            this.lblTitreMoyenneChrono.Text = "Moyenne des chronos";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label4.Location = new System.Drawing.Point(401, 460);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 34);
            this.label4.TabIndex = 26;
            this.label4.Text = "5";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label5.Location = new System.Drawing.Point(675, 463);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 34);
            this.label5.TabIndex = 27;
            this.label5.Text = "00:00:00";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 25.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(284, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 60);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fiche patient";
            // 
            // Vue_Detail_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(907, 1053);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTitreMoyenneChrono);
            this.Controls.Add(this.lblTitreMoyenneErreurs);
            this.Controls.Add(this.lblCboxJeux);
            this.Controls.Add(this.cbxJeux);
            this.Controls.Add(this.dgvDernieresSeries);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.lblLaClasse);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblLePrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblLeNom);
            this.Controls.Add(this.pbxAvatar);
            this.Font = new System.Drawing.Font("Montserrat", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Vue_Detail_Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vue_Detail_Patient";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDernieresSeries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.Label lblLeNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblLePrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblLaClasse;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView dgvDernieresSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_NbQuestionsDeLaSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_NbErreurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Date;
        private System.Windows.Forms.ComboBox cbxJeux;
        private System.Windows.Forms.Label lblCboxJeux;
        private System.Windows.Forms.Label lblTitreMoyenneErreurs;
        private System.Windows.Forms.Label lblTitreMoyenneChrono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}