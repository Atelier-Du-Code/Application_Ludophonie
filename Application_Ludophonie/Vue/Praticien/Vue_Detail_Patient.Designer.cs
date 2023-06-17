
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
            this.dgvSeries = new System.Windows.Forms.DataGridView();
            this.C_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_NbQuestionsDeLaSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_NbErreurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Timer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxJeux = new System.Windows.Forms.ComboBox();
            this.lblCboxJeux = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Image = global::Application_Ludophonie.Properties.Resources.brun;
            this.pbxAvatar.Location = new System.Drawing.Point(197, 128);
            this.pbxAvatar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(128, 133);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatar.TabIndex = 0;
            this.pbxAvatar.TabStop = false;
            // 
            // lblLeNom
            // 
            this.lblLeNom.Location = new System.Drawing.Point(398, 131);
            this.lblLeNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeNom.Name = "lblLeNom";
            this.lblLeNom.Size = new System.Drawing.Size(83, 22);
            this.lblLeNom.TabIndex = 1;
            this.lblLeNom.Text = "Nom :";
            // 
            // lblNom
            // 
            this.lblNom.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblNom.Location = new System.Drawing.Point(396, 154);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(170, 41);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "lilou";
            // 
            // lblLePrenom
            // 
            this.lblLePrenom.Location = new System.Drawing.Point(612, 130);
            this.lblLePrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLePrenom.Name = "lblLePrenom";
            this.lblLePrenom.Size = new System.Drawing.Size(160, 30);
            this.lblLePrenom.TabIndex = 3;
            this.lblLePrenom.Text = "Prénom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblPrenom.Location = new System.Drawing.Point(612, 154);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(168, 37);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Lilou";
            // 
            // lblLaClasse
            // 
            this.lblLaClasse.Location = new System.Drawing.Point(818, 128);
            this.lblLaClasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaClasse.Name = "lblLaClasse";
            this.lblLaClasse.Size = new System.Drawing.Size(63, 22);
            this.lblLaClasse.TabIndex = 5;
            this.lblLaClasse.Text = "Classe :";
            // 
            // lblClasse
            // 
            this.lblClasse.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblClasse.Location = new System.Drawing.Point(818, 153);
            this.lblClasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(144, 38);
            this.lblClasse.TabIndex = 6;
            this.lblClasse.Text = "CM2";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblIdentifiant.Location = new System.Drawing.Point(147, 261);
            this.lblIdentifiant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(229, 30);
            this.lblIdentifiant.TabIndex = 7;
            this.lblIdentifiant.Text = "label7";
            this.lblIdentifiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSeries
            // 
            this.dgvSeries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSeries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvSeries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSeries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSeries.ColumnHeadersHeight = 65;
            this.dgvSeries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvSeries.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSeries.EnableHeadersVisualStyles = false;
            this.dgvSeries.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSeries.Location = new System.Drawing.Point(93, 320);
            this.dgvSeries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSeries.MultiSelect = false;
            this.dgvSeries.Name = "dgvSeries";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeries.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSeries.RowHeadersVisible = false;
            this.dgvSeries.RowHeadersWidth = 120;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.dgvSeries.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSeries.RowTemplate.Height = 24;
            this.dgvSeries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeries.Size = new System.Drawing.Size(839, 359);
            this.dgvSeries.TabIndex = 21;
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
            this.cbxJeux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJeux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxJeux.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.cbxJeux.FormattingEnabled = true;
            this.cbxJeux.Location = new System.Drawing.Point(434, 268);
            this.cbxJeux.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxJeux.Name = "cbxJeux";
            this.cbxJeux.Size = new System.Drawing.Size(150, 29);
            this.cbxJeux.TabIndex = 29;
            this.cbxJeux.SelectedValueChanged += new System.EventHandler(this.cbxJeux_SelectedValueChanged);
            // 
            // lblCboxJeux
            // 
            this.lblCboxJeux.AutoSize = true;
            this.lblCboxJeux.Location = new System.Drawing.Point(449, 244);
            this.lblCboxJeux.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCboxJeux.Name = "lblCboxJeux";
            this.lblCboxJeux.Size = new System.Drawing.Size(110, 21);
            this.lblCboxJeux.TabIndex = 23;
            this.lblCboxJeux.Text = "Liste des jeux";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 25.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(339, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 60);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fiche patient";
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.btnRetour.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.btnRetour.Location = new System.Drawing.Point(880, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(139, 42);
            this.btnRetour.TabIndex = 30;
            this.btnRetour.Text = "Quitter";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // Vue_Detail_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1031, 716);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCboxJeux);
            this.Controls.Add(this.cbxJeux);
            this.Controls.Add(this.dgvSeries);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeries)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_NbQuestionsDeLaSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_NbErreurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Date;
        private System.Windows.Forms.ComboBox cbxJeux;
        private System.Windows.Forms.Label lblCboxJeux;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetour;
    }
}