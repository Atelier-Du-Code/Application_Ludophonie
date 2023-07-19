
namespace Application_Ludophonie.Vue.Praticien.Gestion_des_jeux
{
    partial class Vue_Gestionnaire_JeuLeMot
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
            this.dgvLstMots = new System.Windows.Forms.DataGridView();
            this.C_Mot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Piege1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Piege2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitreCbxTitre = new System.Windows.Forms.Label();
            this.cbxTriListes = new System.Windows.Forms.ComboBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEcouter = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbContexte = new System.Windows.Forms.TextBox();
            this.cbxTypeListe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbMot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstMots)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLstMots
            // 
            this.dgvLstMots.AllowUserToAddRows = false;
            this.dgvLstMots.AllowUserToDeleteRows = false;
            this.dgvLstMots.AllowUserToResizeColumns = false;
            this.dgvLstMots.AllowUserToResizeRows = false;
            this.dgvLstMots.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLstMots.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLstMots.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvLstMots.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLstMots.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLstMots.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLstMots.ColumnHeadersHeight = 65;
            this.dgvLstMots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Mot,
            this.C_Piege1,
            this.C_Piege2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLstMots.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLstMots.EnableHeadersVisualStyles = false;
            this.dgvLstMots.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvLstMots.Location = new System.Drawing.Point(46, 212);
            this.dgvLstMots.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvLstMots.MultiSelect = false;
            this.dgvLstMots.Name = "dgvLstMots";
            this.dgvLstMots.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLstMots.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLstMots.RowHeadersVisible = false;
            this.dgvLstMots.RowHeadersWidth = 120;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.dgvLstMots.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLstMots.RowTemplate.Height = 24;
            this.dgvLstMots.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLstMots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLstMots.Size = new System.Drawing.Size(510, 590);
            this.dgvLstMots.TabIndex = 25;
            this.dgvLstMots.SelectionChanged += new System.EventHandler(this.dgvLstMots_SelectionChanged);
            // 
            // C_Mot
            // 
            this.C_Mot.HeaderText = "Mot";
            this.C_Mot.MinimumWidth = 6;
            this.C_Mot.Name = "C_Mot";
            this.C_Mot.ReadOnly = true;
            this.C_Mot.Width = 68;
            // 
            // C_Piege1
            // 
            this.C_Piege1.HeaderText = "Contexte";
            this.C_Piege1.MinimumWidth = 6;
            this.C_Piege1.Name = "C_Piege1";
            this.C_Piege1.ReadOnly = true;
            this.C_Piege1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.C_Piege1.Width = 107;
            // 
            // C_Piege2
            // 
            this.C_Piege2.HeaderText = "Liste";
            this.C_Piege2.MinimumWidth = 6;
            this.C_Piege2.Name = "C_Piege2";
            this.C_Piege2.ReadOnly = true;
            this.C_Piege2.Width = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 25.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(233, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 60);
            this.label1.TabIndex = 23;
            this.label1.Text = "Gestionnaire jeu du mot";
            // 
            // lblTitreCbxTitre
            // 
            this.lblTitreCbxTitre.AutoSize = true;
            this.lblTitreCbxTitre.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lblTitreCbxTitre.Location = new System.Drawing.Point(143, 133);
            this.lblTitreCbxTitre.Name = "lblTitreCbxTitre";
            this.lblTitreCbxTitre.Size = new System.Drawing.Size(58, 24);
            this.lblTitreCbxTitre.TabIndex = 27;
            this.lblTitreCbxTitre.Text = "Listes";
            // 
            // cbxTriListes
            // 
            this.cbxTriListes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTriListes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTriListes.FormattingEnabled = true;
            this.cbxTriListes.Location = new System.Drawing.Point(93, 159);
            this.cbxTriListes.Name = "cbxTriListes";
            this.cbxTriListes.Size = new System.Drawing.Size(153, 29);
            this.cbxTriListes.TabIndex = 28;
            this.cbxTriListes.SelectedIndexChanged += new System.EventHandler(this.cbxTriListes_SelectedIndexChanged);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(174)))), ((int)(((byte)(131)))));
            this.btnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnSupprimer.Location = new System.Drawing.Point(367, 154);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(154, 36);
            this.btnSupprimer.TabIndex = 19;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.btnRetour.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.btnRetour.Location = new System.Drawing.Point(880, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(139, 39);
            this.btnRetour.TabIndex = 29;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(615, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 46);
            this.label3.TabIndex = 30;
            this.label3.Text = "Création d\'un nouveau mot";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnEcouter);
            this.panel2.Controls.Add(this.btnEnregistrer);
            this.panel2.Controls.Add(this.lblMessage);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtbContexte);
            this.panel2.Controls.Add(this.cbxTypeListe);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtbMot);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(591, 212);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 357);
            this.panel2.TabIndex = 30;
            // 
            // btnEcouter
            // 
            this.btnEcouter.Location = new System.Drawing.Point(279, 9);
            this.btnEcouter.Name = "btnEcouter";
            this.btnEcouter.Size = new System.Drawing.Size(111, 42);
            this.btnEcouter.TabIndex = 31;
            this.btnEcouter.Text = "Ecouter";
            this.btnEcouter.UseVisualStyleBackColor = true;
            this.btnEcouter.Click += new System.EventHandler(this.btnEcouter_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(111)))));
            this.btnEnregistrer.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnEnregistrer.Location = new System.Drawing.Point(133, 309);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(120, 36);
            this.btnEnregistrer.TabIndex = 29;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lblMessage.Location = new System.Drawing.Point(29, 274);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(335, 28);
            this.lblMessage.TabIndex = 18;
            this.lblMessage.Text = "label3";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Montserrat", 11F);
            this.label4.Location = new System.Drawing.Point(29, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Liste";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbContexte
            // 
            this.txtbContexte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbContexte.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtbContexte.Location = new System.Drawing.Point(29, 151);
            this.txtbContexte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbContexte.Name = "txtbContexte";
            this.txtbContexte.Size = new System.Drawing.Size(335, 25);
            this.txtbContexte.TabIndex = 11;
            this.txtbContexte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxTypeListe
            // 
            this.cbxTypeListe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTypeListe.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cbxTypeListe.FormattingEnabled = true;
            this.cbxTypeListe.Location = new System.Drawing.Point(29, 220);
            this.cbxTypeListe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxTypeListe.Name = "cbxTypeListe";
            this.cbxTypeListe.Size = new System.Drawing.Size(335, 35);
            this.cbxTypeListe.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Montserrat", 11F);
            this.label5.Location = new System.Drawing.Point(29, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contexte";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbMot
            // 
            this.txtbMot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbMot.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtbMot.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtbMot.Location = new System.Drawing.Point(29, 83);
            this.txtbMot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbMot.Name = "txtbMot";
            this.txtbMot.Size = new System.Drawing.Size(335, 25);
            this.txtbMot.TabIndex = 9;
            this.txtbMot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Montserrat", 11F);
            this.label6.Location = new System.Drawing.Point(29, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mot";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Vue_Gestionnaire_JeuLeMot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1031, 859);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.cbxTriListes);
            this.Controls.Add(this.lblTitreCbxTitre);
            this.Controls.Add(this.dgvLstMots);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Vue_Gestionnaire_JeuLeMot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vue_Gestionnaire_JeuLeMot";
            this.Load += new System.EventHandler(this.Vue_Gestionnaire_JeuLeMot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstMots)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLstMots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitreCbxTitre;
        private System.Windows.Forms.ComboBox cbxTriListes;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Mot;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Piege1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Piege2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTypeListe;
        private System.Windows.Forms.TextBox txtbContexte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbMot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEcouter;
    }
}