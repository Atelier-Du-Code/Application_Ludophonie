
namespace Application_Ludophonie.Vue.Patient
{
    partial class Vue_Carnet_De_Missions
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
            this.txtTitrePrincipal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ckLstbMissions = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // txtTitrePrincipal
            // 
            this.txtTitrePrincipal.Font = new System.Drawing.Font("Montserrat SemiBold", 25.8F, System.Drawing.FontStyle.Bold);
            this.txtTitrePrincipal.Location = new System.Drawing.Point(88, 61);
            this.txtTitrePrincipal.Name = "txtTitrePrincipal";
            this.txtTitrePrincipal.Size = new System.Drawing.Size(538, 60);
            this.txtTitrePrincipal.TabIndex = 2;
            this.txtTitrePrincipal.Text = "Ton carnet de mission";
            this.txtTitrePrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(111)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Montserrat", 14F);
            this.btnClose.Location = new System.Drawing.Point(316, 584);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 59);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Ok !";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnJeuDuMot_Click);
            // 
            // ckLstbMissions
            // 
            this.ckLstbMissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.ckLstbMissions.Font = new System.Drawing.Font("Montserrat", 15F);
            this.ckLstbMissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.ckLstbMissions.FormattingEnabled = true;
            this.ckLstbMissions.Location = new System.Drawing.Point(98, 175);
            this.ckLstbMissions.Name = "ckLstbMissions";
            this.ckLstbMissions.Size = new System.Drawing.Size(514, 334);
            this.ckLstbMissions.TabIndex = 11;
            // 
            // Vue_Carnet_De_Missions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(697, 704);
            this.Controls.Add(this.ckLstbMissions);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTitrePrincipal);
            this.Font = new System.Drawing.Font("Montserrat", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Vue_Carnet_De_Missions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vue_Carnet_De_Quetes";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtTitrePrincipal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckedListBox ckLstbMissions;
    }
}