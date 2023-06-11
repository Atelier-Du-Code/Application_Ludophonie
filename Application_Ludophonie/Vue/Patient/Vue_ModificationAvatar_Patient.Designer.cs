
namespace Application_Ludophonie.Vue.Patient
{
    partial class Vue_ModificationAvatar_Patient
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
            this.plAvatars = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitrePrincipal = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plAvatars
            // 
            this.plAvatars.Location = new System.Drawing.Point(52, 188);
            this.plAvatars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plAvatars.Name = "plAvatars";
            this.plAvatars.Size = new System.Drawing.Size(681, 272);
            this.plAvatars.TabIndex = 6;
            this.plAvatars.Paint += new System.Windows.Forms.PaintEventHandler(this.plAvatars_Paint);
            // 
            // lblTitrePrincipal
            // 
            this.lblTitrePrincipal.AutoSize = true;
            this.lblTitrePrincipal.Font = new System.Drawing.Font("Montserrat SemiBold", 25.8F, System.Drawing.FontStyle.Bold);
            this.lblTitrePrincipal.Location = new System.Drawing.Point(172, 84);
            this.lblTitrePrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitrePrincipal.Name = "lblTitrePrincipal";
            this.lblTitrePrincipal.Size = new System.Drawing.Size(441, 60);
            this.lblTitrePrincipal.TabIndex = 5;
            this.lblTitrePrincipal.Text = "Choisis ton avatar !";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.btnValider.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnValider.Location = new System.Drawing.Point(305, 498);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(175, 46);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Je te choisis !";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // Vue_ModificationAvatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(802, 595);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.plAvatars);
            this.Controls.Add(this.lblTitrePrincipal);
            this.Font = new System.Drawing.Font("Montserrat", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Vue_ModificationAvatar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vue_ModificationAvatar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel plAvatars;
        private System.Windows.Forms.Label lblTitrePrincipal;
        private System.Windows.Forms.Button btnValider;
    }
}