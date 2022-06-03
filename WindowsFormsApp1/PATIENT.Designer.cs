namespace WindowsFormsApp1
{
    partial class PATIENT
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
            this.PateAd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PatName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PatPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PatId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PatAge = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.majorTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.GenderCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BloodCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PatientGv = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGv)).BeginInit();
            this.SuspendLayout();
            // 
            // PateAd
            // 
            this.PateAd.Depth = 0;
            this.PateAd.Hint = "Adresse Du Patient";
            this.PateAd.Location = new System.Drawing.Point(45, 111);
            this.PateAd.MouseState = MaterialSkin.MouseState.HOVER;
            this.PateAd.Name = "PateAd";
            this.PateAd.PasswordChar = '\0';
            this.PateAd.SelectedText = "";
            this.PateAd.SelectionLength = 0;
            this.PateAd.SelectionStart = 0;
            this.PateAd.Size = new System.Drawing.Size(176, 23);
            this.PateAd.TabIndex = 47;
            this.PateAd.UseSystemPasswordChar = false;
            // 
            // PatName
            // 
            this.PatName.Depth = 0;
            this.PatName.Hint = "Nom Du Patient";
            this.PatName.Location = new System.Drawing.Point(45, 66);
            this.PatName.MouseState = MaterialSkin.MouseState.HOVER;
            this.PatName.Name = "PatName";
            this.PatName.PasswordChar = '\0';
            this.PatName.SelectedText = "";
            this.PatName.SelectionLength = 0;
            this.PatName.SelectionStart = 0;
            this.PatName.Size = new System.Drawing.Size(176, 23);
            this.PatName.TabIndex = 46;
            this.PatName.UseSystemPasswordChar = false;
            // 
            // PatPhone
            // 
            this.PatPhone.Depth = 0;
            this.PatPhone.Hint = "N .Telephone du patient";
            this.PatPhone.Location = new System.Drawing.Point(45, 152);
            this.PatPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.PasswordChar = '\0';
            this.PatPhone.SelectedText = "";
            this.PatPhone.SelectionLength = 0;
            this.PatPhone.SelectionStart = 0;
            this.PatPhone.Size = new System.Drawing.Size(176, 23);
            this.PatPhone.TabIndex = 45;
            this.PatPhone.UseSystemPasswordChar = false;
            // 
            // PatId
            // 
            this.PatId.Depth = 0;
            this.PatId.Hint = "Patient Id";
            this.PatId.Location = new System.Drawing.Point(45, 25);
            this.PatId.MouseState = MaterialSkin.MouseState.HOVER;
            this.PatId.Name = "PatId";
            this.PatId.PasswordChar = '\0';
            this.PatId.SelectedText = "";
            this.PatId.SelectionLength = 0;
            this.PatId.SelectionStart = 0;
            this.PatId.Size = new System.Drawing.Size(176, 23);
            this.PatId.TabIndex = 44;
            this.PatId.UseSystemPasswordChar = false;
            // 
            // PatAge
            // 
            this.PatAge.Depth = 0;
            this.PatAge.Hint = "Age Du Patient";
            this.PatAge.Location = new System.Drawing.Point(45, 220);
            this.PatAge.MouseState = MaterialSkin.MouseState.HOVER;
            this.PatAge.Name = "PatAge";
            this.PatAge.PasswordChar = '\0';
            this.PatAge.SelectedText = "";
            this.PatAge.SelectionLength = 0;
            this.PatAge.SelectionStart = 0;
            this.PatAge.Size = new System.Drawing.Size(176, 23);
            this.PatAge.TabIndex = 48;
            this.PatAge.UseSystemPasswordChar = false;
            // 
            // majorTb
            // 
            this.majorTb.Depth = 0;
            this.majorTb.Hint = "Autres Informations";
            this.majorTb.Location = new System.Drawing.Point(45, 384);
            this.majorTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.majorTb.Name = "majorTb";
            this.majorTb.PasswordChar = '\0';
            this.majorTb.SelectedText = "";
            this.majorTb.SelectionLength = 0;
            this.majorTb.SelectionStart = 0;
            this.majorTb.Size = new System.Drawing.Size(176, 23);
            this.majorTb.TabIndex = 49;
            this.majorTb.UseSystemPasswordChar = false;
            // 
            // GenderCb
            // 
            this.GenderCb.AutoRoundedCorners = true;
            this.GenderCb.BackColor = System.Drawing.Color.Transparent;
            this.GenderCb.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.GenderCb.BorderRadius = 17;
            this.GenderCb.BorderThickness = 3;
            this.GenderCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenderCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GenderCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GenderCb.ForeColor = System.Drawing.Color.Black;
            this.GenderCb.ItemHeight = 30;
            this.GenderCb.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.GenderCb.Location = new System.Drawing.Point(45, 265);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(135, 36);
            this.GenderCb.TabIndex = 50;
            // 
            // BloodCb
            // 
            this.BloodCb.AutoRoundedCorners = true;
            this.BloodCb.BackColor = System.Drawing.Color.Transparent;
            this.BloodCb.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.BloodCb.BorderRadius = 17;
            this.BloodCb.BorderThickness = 3;
            this.BloodCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BloodCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BloodCb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BloodCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BloodCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BloodCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BloodCb.ForeColor = System.Drawing.Color.Black;
            this.BloodCb.ItemHeight = 30;
            this.BloodCb.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+"});
            this.BloodCb.Location = new System.Drawing.Point(45, 311);
            this.BloodCb.Name = "BloodCb";
            this.BloodCb.Size = new System.Drawing.Size(135, 36);
            this.BloodCb.TabIndex = 51;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::WindowsFormsApp1.Properties.Resources.icons8_supprimer_48;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(202, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 82);
            this.button3.TabIndex = 54;
            this.button3.Text = "Supprimer";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::WindowsFormsApp1.Properties.Resources.icons8_approuver_et_mettre_à_jour_48;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(112, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 82);
            this.button2.TabIndex = 53;
            this.button2.Text = "Modifier";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_ajouter_une_règle_481;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(13, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 78);
            this.button1.TabIndex = 52;
            this.button1.Text = "Ajouter";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatientGv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PatientGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientGv.BackgroundColor = System.Drawing.Color.White;
            this.PatientGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PatientGv.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientGv.DefaultCellStyle = dataGridViewCellStyle3;
            this.PatientGv.EnableHeadersVisualStyles = false;
            this.PatientGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientGv.Location = new System.Drawing.Point(287, 34);
            this.PatientGv.Name = "PatientGv";
            this.PatientGv.RowHeadersVisible = false;
            this.PatientGv.RowTemplate.Height = 30;
            this.PatientGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientGv.Size = new System.Drawing.Size(717, 353);
            this.PatientGv.TabIndex = 55;
            this.PatientGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PatientGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PatientGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PatientGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PatientGv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PatientGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LimeGreen;
            this.PatientGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PatientGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PatientGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PatientGv.ThemeStyle.HeaderStyle.Height = 25;
            this.PatientGv.ThemeStyle.ReadOnly = false;
            this.PatientGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientGv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PatientGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatientGv.ThemeStyle.RowsStyle.Height = 30;
            this.PatientGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatientGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientGv_CellContentClick);
            // 
            // PATIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 497);
            this.Controls.Add(this.PatientGv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BloodCb);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.majorTb);
            this.Controls.Add(this.PatAge);
            this.Controls.Add(this.PateAd);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.PatPhone);
            this.Controls.Add(this.PatId);
            this.Name = "PATIENT";
            this.Text = "PATIENT";
            this.Load += new System.EventHandler(this.patient2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientGv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField PateAd;
        private MaterialSkin.Controls.MaterialSingleLineTextField PatName;
        private MaterialSkin.Controls.MaterialSingleLineTextField PatPhone;
        private MaterialSkin.Controls.MaterialSingleLineTextField PatId;
        private MaterialSkin.Controls.MaterialSingleLineTextField PatAge;
        private MaterialSkin.Controls.MaterialSingleLineTextField majorTb;
        private Guna.UI2.WinForms.Guna2ComboBox GenderCb;
        private Guna.UI2.WinForms.Guna2ComboBox BloodCb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2DataGridView PatientGv;
    }
}