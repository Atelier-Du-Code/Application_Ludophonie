
namespace Application_Ludophonie.Vue.Patient
{
    partial class Vue_Carnet_De_Quetes
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
            this.btnJeuDuMot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitrePrincipal
            // 
            this.txtTitrePrincipal.AutoSize = true;
            this.txtTitrePrincipal.Font = new System.Drawing.Font("Montserrat SemiBold", 25.8F, System.Drawing.FontStyle.Bold);
            this.txtTitrePrincipal.Location = new System.Drawing.Point(130, 106);
            this.txtTitrePrincipal.Name = "txtTitrePrincipal";
            this.txtTitrePrincipal.Size = new System.Drawing.Size(512, 60);
            this.txtTitrePrincipal.TabIndex = 2;
            this.txtTitrePrincipal.Text = "Ton carnet de mission";
            // 
            // btnJeuDuMot
            // 
            this.btnJeuDuMot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.btnJeuDuMot.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnJeuDuMot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJeuDuMot.Font = new System.Drawing.Font("Montserrat", 14F);
            this.btnJeuDuMot.Location = new System.Drawing.Point(345, 572);
            this.btnJeuDuMot.Name = "btnJeuDuMot";
            this.btnJeuDuMot.Size = new System.Drawing.Size(82, 59);
            this.btnJeuDuMot.TabIndex = 9;
            this.btnJeuDuMot.Text = "Ok !";
            this.btnJeuDuMot.UseVisualStyleBackColor = false;
            // 
            // Vue_Carnet_De_Quetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(802, 743);
            this.Controls.Add(this.btnJeuDuMot);
            this.Controls.Add(this.txtTitrePrincipal);
            this.Font = new System.Drawing.Font("Montserrat", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Vue_Carnet_De_Quetes";
            this.Text = "Vue_Carnet_De_Quetes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtTitrePrincipal;
        private System.Windows.Forms.Button btnJeuDuMot;
    }
}