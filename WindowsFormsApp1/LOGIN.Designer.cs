namespace WindowsFormsApp1
{
    partial class LOGIN
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.DocNameTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PassTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 192);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(99, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Docteur Nom";
            // 
            // DocNameTb
            // 
            this.DocNameTb.BackColor = System.Drawing.Color.White;
            this.DocNameTb.Depth = 0;
            this.DocNameTb.Hint = "";
            this.DocNameTb.Location = new System.Drawing.Point(150, 192);
            this.DocNameTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.DocNameTb.Name = "DocNameTb";
            this.DocNameTb.PasswordChar = '\0';
            this.DocNameTb.SelectedText = "";
            this.DocNameTb.SelectionLength = 0;
            this.DocNameTb.SelectionStart = 0;
            this.DocNameTb.Size = new System.Drawing.Size(191, 23);
            this.DocNameTb.TabIndex = 16;
            this.DocNameTb.UseSystemPasswordChar = false;
            // 
            // PassTb
            // 
            this.PassTb.BackColor = System.Drawing.Color.White;
            this.PassTb.Depth = 0;
            this.PassTb.Hint = "";
            this.PassTb.Location = new System.Drawing.Point(150, 262);
            this.PassTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.PassTb.Name = "PassTb";
            this.PassTb.PasswordChar = '*';
            this.PassTb.SelectedText = "";
            this.PassTb.SelectionLength = 0;
            this.PassTb.SelectionStart = 0;
            this.PassTb.Size = new System.Drawing.Size(191, 23);
            this.PassTb.TabIndex = 18;
            this.PassTb.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(25, 262);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(99, 19);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Docteur Nom";
            // 
            // button1
            // 
            this.button1.Animated = true;
            this.button1.AnimatedGIF = true;
            this.button1.AutoRoundedCorners = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderRadius = 20;
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.FocusedColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(29, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "Se connecter";
            this.button1.UseTransparentBackground = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.young_handsome_physician_medical_robe_with_stethoscope;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(713, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.DocNameTb);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField DocNameTb;
        private MaterialSkin.Controls.MaterialSingleLineTextField PassTb;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Guna.UI2.WinForms.Guna2Button button1;
    }
}

