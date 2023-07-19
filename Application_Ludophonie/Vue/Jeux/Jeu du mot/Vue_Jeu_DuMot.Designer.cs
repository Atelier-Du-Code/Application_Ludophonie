
namespace Application_Ludophonie.Vue.Jeux
{
    partial class Vue_Jeu_DuMot
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
            this.components = new System.ComponentModel.Container();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblVerdict = new System.Windows.Forms.Label();
            this.txtbReponse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitrePrincipal = new System.Windows.Forms.Label();
            this.btnValiderReponse = new System.Windows.Forms.Button();
            this.btnEcouter = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.pSerieFinie = new System.Windows.Forms.Panel();
            this.lblMotsAcquis = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSecondesFIn = new System.Windows.Forms.Label();
            this.lblMinureFin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErreur = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNewSerie = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flpDesEtoiles = new System.Windows.Forms.FlowLayoutPanel();
            this.chrono = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSecondes = new System.Windows.Forms.Label();
            this.lblSeparation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pSerieFinie.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.lblMessage.Location = new System.Drawing.Point(50, 345);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(498, 31);
            this.lblMessage.TabIndex = 19;
            this.lblMessage.Text = "Message + Indice";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVerdict
            // 
            this.lblVerdict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.lblVerdict.Location = new System.Drawing.Point(128, 536);
            this.lblVerdict.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerdict.Name = "lblVerdict";
            this.lblVerdict.Size = new System.Drawing.Size(343, 31);
            this.lblVerdict.TabIndex = 18;
            this.lblVerdict.Text = "Verdict de la réponse soumise";
            this.lblVerdict.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbReponse
            // 
            this.txtbReponse.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtbReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtbReponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.txtbReponse.Location = new System.Drawing.Point(170, 442);
            this.txtbReponse.Margin = new System.Windows.Forms.Padding(4);
            this.txtbReponse.Name = "txtbReponse";
            this.txtbReponse.Size = new System.Drawing.Size(259, 36);
            this.txtbReponse.TabIndex = 14;
            this.txtbReponse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbReponse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbReponse_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(104, 398);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ecris le mot que tu as entendus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(170, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Clique pour écouter ";
            // 
            // txtTitrePrincipal
            // 
            this.txtTitrePrincipal.AutoSize = true;
            this.txtTitrePrincipal.Font = new System.Drawing.Font("Montserrat SemiBold", 25.8F, System.Drawing.FontStyle.Bold);
            this.txtTitrePrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.txtTitrePrincipal.Location = new System.Drawing.Point(160, 49);
            this.txtTitrePrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitrePrincipal.Name = "txtTitrePrincipal";
            this.txtTitrePrincipal.Size = new System.Drawing.Size(278, 60);
            this.txtTitrePrincipal.TabIndex = 10;
            this.txtTitrePrincipal.Text = "Jeu du mot";
            // 
            // btnValiderReponse
            // 
            this.btnValiderReponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.btnValiderReponse.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnValiderReponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderReponse.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnValiderReponse.Location = new System.Drawing.Point(185, 607);
            this.btnValiderReponse.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnValiderReponse.Name = "btnValiderReponse";
            this.btnValiderReponse.Size = new System.Drawing.Size(229, 43);
            this.btnValiderReponse.TabIndex = 21;
            this.btnValiderReponse.Text = "Valider";
            this.btnValiderReponse.UseVisualStyleBackColor = false;
            this.btnValiderReponse.Click += new System.EventHandler(this.btnValiderReponse_Click);
            // 
            // btnEcouter
            // 
            this.btnEcouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(111)))));
            this.btnEcouter.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnEcouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEcouter.Font = new System.Drawing.Font("Montserrat", 12F);
            this.btnEcouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.btnEcouter.Location = new System.Drawing.Point(185, 296);
            this.btnEcouter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEcouter.Name = "btnEcouter";
            this.btnEcouter.Size = new System.Drawing.Size(229, 43);
            this.btnEcouter.TabIndex = 22;
            this.btnEcouter.Text = "Ecouter";
            this.btnEcouter.UseVisualStyleBackColor = false;
            this.btnEcouter.Click += new System.EventHandler(this.btnEcouter_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.btnRetour.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnRetour.Location = new System.Drawing.Point(581, 34);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(127, 37);
            this.btnRetour.TabIndex = 23;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // pSerieFinie
            // 
            this.pSerieFinie.Controls.Add(this.lblMotsAcquis);
            this.pSerieFinie.Controls.Add(this.label6);
            this.pSerieFinie.Controls.Add(this.panel2);
            this.pSerieFinie.Controls.Add(this.label1);
            this.pSerieFinie.Controls.Add(this.lblErreur);
            this.pSerieFinie.Controls.Add(this.label10);
            this.pSerieFinie.Controls.Add(this.btnNewSerie);
            this.pSerieFinie.Controls.Add(this.btnMenuPrincipal);
            this.pSerieFinie.Controls.Add(this.label4);
            this.pSerieFinie.Location = new System.Drawing.Point(11, 13);
            this.pSerieFinie.Margin = new System.Windows.Forms.Padding(4);
            this.pSerieFinie.Name = "pSerieFinie";
            this.pSerieFinie.Size = new System.Drawing.Size(710, 658);
            this.pSerieFinie.TabIndex = 24;
            // 
            // lblMotsAcquis
            // 
            this.lblMotsAcquis.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotsAcquis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.lblMotsAcquis.Location = new System.Drawing.Point(280, 431);
            this.lblMotsAcquis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotsAcquis.Name = "lblMotsAcquis";
            this.lblMotsAcquis.Size = new System.Drawing.Size(145, 46);
            this.lblMotsAcquis.TabIndex = 51;
            this.lblMotsAcquis.Text = "53";
            this.lblMotsAcquis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Montserrat", 14F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.label6.Location = new System.Drawing.Point(119, 403);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(467, 33);
            this.label6.TabIndex = 50;
            this.label6.Text = "Ton nombre de mots acquis";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSecondesFIn);
            this.panel2.Controls.Add(this.lblMinureFin);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(254, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 63);
            this.panel2.TabIndex = 49;
            // 
            // lblSecondesFIn
            // 
            this.lblSecondesFIn.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondesFIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.lblSecondesFIn.Location = new System.Drawing.Point(107, 8);
            this.lblSecondesFIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondesFIn.Name = "lblSecondesFIn";
            this.lblSecondesFIn.Size = new System.Drawing.Size(76, 46);
            this.lblSecondesFIn.TabIndex = 46;
            this.lblSecondesFIn.Text = "00";
            this.lblSecondesFIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinureFin
            // 
            this.lblMinureFin.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinureFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.lblMinureFin.Location = new System.Drawing.Point(10, 8);
            this.lblMinureFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinureFin.Name = "lblMinureFin";
            this.lblMinureFin.Size = new System.Drawing.Size(76, 46);
            this.lblMinureFin.TabIndex = 45;
            this.lblMinureFin.Text = "00";
            this.lblMinureFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.label8.Location = new System.Drawing.Point(62, 2);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 55);
            this.label8.TabIndex = 47;
            this.label8.Text = ":";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(279, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 61);
            this.label1.TabIndex = 44;
            this.label1.Text = "Bravo !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErreur
            // 
            this.lblErreur.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.lblErreur.Location = new System.Drawing.Point(280, 335);
            this.lblErreur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(145, 46);
            this.lblErreur.TabIndex = 43;
            this.lblErreur.Text = "10";
            this.lblErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Montserrat", 14F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.label10.Location = new System.Drawing.Point(119, 307);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(467, 33);
            this.label10.TabIndex = 42;
            this.label10.Text = "Ton nombre d\'erreurs pour cette série";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewSerie
            // 
            this.btnNewSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(111)))));
            this.btnNewSerie.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnNewSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSerie.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnNewSerie.Location = new System.Drawing.Point(238, 514);
            this.btnNewSerie.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNewSerie.Name = "btnNewSerie";
            this.btnNewSerie.Size = new System.Drawing.Size(229, 43);
            this.btnNewSerie.TabIndex = 41;
            this.btnNewSerie.Text = "Nouvelle série";
            this.btnNewSerie.UseVisualStyleBackColor = false;
            this.btnNewSerie.Click += new System.EventHandler(this.btnNewSerie_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.btnMenuPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnMenuPrincipal.Location = new System.Drawing.Point(238, 567);
            this.btnMenuPrincipal.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(229, 43);
            this.btnMenuPrincipal.TabIndex = 40;
            this.btnMenuPrincipal.Text = "Menu principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = false;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(272, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 33);
            this.label4.TabIndex = 36;
            this.label4.Text = "Ton chrono ";
            // 
            // flpDesEtoiles
            // 
            this.flpDesEtoiles.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flpDesEtoiles.Location = new System.Drawing.Point(526, 145);
            this.flpDesEtoiles.Name = "flpDesEtoiles";
            this.flpDesEtoiles.Size = new System.Drawing.Size(190, 424);
            this.flpDesEtoiles.TabIndex = 25;
            // 
            // chrono
            // 
            this.chrono.Interval = 1;
            this.chrono.Tick += new System.EventHandler(this.chrono_Tick);
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(227, 485);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(145, 46);
            this.lblScore.TabIndex = 44;
            this.lblScore.Text = "10";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutes
            // 
            this.lblMinutes.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(10, 14);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(58, 46);
            this.lblMinutes.TabIndex = 45;
            this.lblMinutes.Text = "10";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondes
            // 
            this.lblSecondes.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondes.Location = new System.Drawing.Point(76, 14);
            this.lblSecondes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondes.Name = "lblSecondes";
            this.lblSecondes.Size = new System.Drawing.Size(61, 46);
            this.lblSecondes.TabIndex = 46;
            this.lblSecondes.Text = "10";
            this.lblSecondes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeparation
            // 
            this.lblSeparation.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparation.Location = new System.Drawing.Point(42, 2);
            this.lblSeparation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeparation.Name = "lblSeparation";
            this.lblSeparation.Size = new System.Drawing.Size(62, 71);
            this.lblSeparation.TabIndex = 47;
            this.lblSeparation.Text = ":";
            this.lblSeparation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSecondes);
            this.panel1.Controls.Add(this.lblMinutes);
            this.panel1.Controls.Add(this.lblSeparation);
            this.panel1.Location = new System.Drawing.Point(226, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 76);
            this.panel1.TabIndex = 48;
            // 
            // Vue_Jeu_DuMot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(735, 689);
            this.Controls.Add(this.pSerieFinie);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.flpDesEtoiles);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnEcouter);
            this.Controls.Add(this.btnValiderReponse);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblVerdict);
            this.Controls.Add(this.txtbReponse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitrePrincipal);
            this.Font = new System.Drawing.Font("Montserrat", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Vue_Jeu_DuMot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vue_Jeu_DuMot";
            this.Load += new System.EventHandler(this.Vue_Jeu_DuMot_Load);
            this.pSerieFinie.ResumeLayout(false);
            this.pSerieFinie.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblVerdict;
        private System.Windows.Forms.TextBox txtbReponse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtTitrePrincipal;
        private System.Windows.Forms.Button btnValiderReponse;
        private System.Windows.Forms.Button btnEcouter;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Panel pSerieFinie;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNewSerie;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flpDesEtoiles;
        private System.Windows.Forms.Timer chrono;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSecondes;
        private System.Windows.Forms.Label lblSeparation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSecondesFIn;
        private System.Windows.Forms.Label lblMinureFin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMotsAcquis;
        private System.Windows.Forms.Label label6;
    }
}