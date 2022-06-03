namespace WindowsFormsApp1
{
    partial class DIAGNOSTIC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MedecineTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PatientTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DiagnosisTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SymptomsTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DiagId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PatientIdCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.diagsummary = new System.Windows.Forms.Panel();
            this.Medicineslbl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PatientNamelbl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SymptomsLbl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Diagnosislbl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DiagnosisGv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.diagsummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGv)).BeginInit();
            this.SuspendLayout();
            // 
            // MedecineTb
            // 
            this.MedecineTb.Depth = 0;
            this.MedecineTb.Hint = "Medicaments";
            this.MedecineTb.Location = new System.Drawing.Point(250, 224);
            this.MedecineTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.MedecineTb.Name = "MedecineTb";
            this.MedecineTb.PasswordChar = '\0';
            this.MedecineTb.SelectedText = "";
            this.MedecineTb.SelectionLength = 0;
            this.MedecineTb.SelectionStart = 0;
            this.MedecineTb.Size = new System.Drawing.Size(176, 23);
            this.MedecineTb.TabIndex = 36;
            this.MedecineTb.UseSystemPasswordChar = false;
            // 
            // PatientTb
            // 
            this.PatientTb.Depth = 0;
            this.PatientTb.Hint = "Nom Du Patient";
            this.PatientTb.Location = new System.Drawing.Point(31, 224);
            this.PatientTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.PatientTb.Name = "PatientTb";
            this.PatientTb.PasswordChar = '\0';
            this.PatientTb.SelectedText = "";
            this.PatientTb.SelectionLength = 0;
            this.PatientTb.SelectionStart = 0;
            this.PatientTb.Size = new System.Drawing.Size(176, 23);
            this.PatientTb.TabIndex = 37;
            this.PatientTb.UseSystemPasswordChar = false;
            // 
            // DiagnosisTb
            // 
            this.DiagnosisTb.Depth = 0;
            this.DiagnosisTb.Hint = "Diagnostic ";
            this.DiagnosisTb.Location = new System.Drawing.Point(250, 169);
            this.DiagnosisTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.DiagnosisTb.Name = "DiagnosisTb";
            this.DiagnosisTb.PasswordChar = '\0';
            this.DiagnosisTb.SelectedText = "";
            this.DiagnosisTb.SelectionLength = 0;
            this.DiagnosisTb.SelectionStart = 0;
            this.DiagnosisTb.Size = new System.Drawing.Size(176, 23);
            this.DiagnosisTb.TabIndex = 38;
            this.DiagnosisTb.UseSystemPasswordChar = false;
            // 
            // SymptomsTb
            // 
            this.SymptomsTb.Depth = 0;
            this.SymptomsTb.Hint = "Les Symptoms";
            this.SymptomsTb.Location = new System.Drawing.Point(250, 111);
            this.SymptomsTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.SymptomsTb.Name = "SymptomsTb";
            this.SymptomsTb.PasswordChar = '\0';
            this.SymptomsTb.SelectedText = "";
            this.SymptomsTb.SelectionLength = 0;
            this.SymptomsTb.SelectionStart = 0;
            this.SymptomsTb.Size = new System.Drawing.Size(176, 23);
            this.SymptomsTb.TabIndex = 39;
            this.SymptomsTb.UseSystemPasswordChar = false;
            // 
            // DiagId
            // 
            this.DiagId.Depth = 0;
            this.DiagId.Hint = "Diagnostic Id";
            this.DiagId.Location = new System.Drawing.Point(31, 111);
            this.DiagId.MouseState = MaterialSkin.MouseState.HOVER;
            this.DiagId.Name = "DiagId";
            this.DiagId.PasswordChar = '\0';
            this.DiagId.SelectedText = "";
            this.DiagId.SelectionLength = 0;
            this.DiagId.SelectionStart = 0;
            this.DiagId.Size = new System.Drawing.Size(176, 23);
            this.DiagId.TabIndex = 40;
            this.DiagId.UseSystemPasswordChar = false;
            // 
            // PatientIdCb
            // 
            this.PatientIdCb.BackColor = System.Drawing.Color.Transparent;
            this.PatientIdCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PatientIdCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatientIdCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientIdCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientIdCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PatientIdCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PatientIdCb.ItemHeight = 30;
            this.PatientIdCb.Location = new System.Drawing.Point(31, 156);
            this.PatientIdCb.Name = "PatientIdCb";
            this.PatientIdCb.Size = new System.Drawing.Size(140, 36);
            this.PatientIdCb.TabIndex = 41;
            this.PatientIdCb.SelectionChangeCommitted += new System.EventHandler(this.PatientIdCb_SelectionChangeCommitted);
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
            this.button3.Location = new System.Drawing.Point(246, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 82);
            this.button3.TabIndex = 44;
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
            this.button2.Location = new System.Drawing.Point(129, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 80);
            this.button2.TabIndex = 43;
            this.button2.Text = "MODIFIER";
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
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_ajouter_une_règle_48;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(31, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 80);
            this.button1.TabIndex = 42;
            this.button1.Text = "AJOUTER";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // diagsummary
            // 
            this.diagsummary.Controls.Add(this.Medicineslbl);
            this.diagsummary.Controls.Add(this.PatientNamelbl);
            this.diagsummary.Controls.Add(this.SymptomsLbl);
            this.diagsummary.Controls.Add(this.Diagnosislbl);
            this.diagsummary.Controls.Add(this.label9);
            this.diagsummary.Controls.Add(this.label4);
            this.diagsummary.Location = new System.Drawing.Point(471, 70);
            this.diagsummary.Name = "diagsummary";
            this.diagsummary.Size = new System.Drawing.Size(553, 349);
            this.diagsummary.TabIndex = 45;
            // 
            // Medicineslbl
            // 
            this.Medicineslbl.Depth = 0;
            this.Medicineslbl.Hint = "Medecines";
            this.Medicineslbl.Location = new System.Drawing.Point(263, 157);
            this.Medicineslbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.Medicineslbl.Name = "Medicineslbl";
            this.Medicineslbl.PasswordChar = '\0';
            this.Medicineslbl.SelectedText = "";
            this.Medicineslbl.SelectionLength = 0;
            this.Medicineslbl.SelectionStart = 0;
            this.Medicineslbl.Size = new System.Drawing.Size(176, 23);
            this.Medicineslbl.TabIndex = 43;
            this.Medicineslbl.UseSystemPasswordChar = false;
            // 
            // PatientNamelbl
            // 
            this.PatientNamelbl.Depth = 0;
            this.PatientNamelbl.Hint = "Le Nom du Patient";
            this.PatientNamelbl.Location = new System.Drawing.Point(36, 99);
            this.PatientNamelbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.PatientNamelbl.Name = "PatientNamelbl";
            this.PatientNamelbl.PasswordChar = '\0';
            this.PatientNamelbl.SelectedText = "";
            this.PatientNamelbl.SelectionLength = 0;
            this.PatientNamelbl.SelectionStart = 0;
            this.PatientNamelbl.Size = new System.Drawing.Size(176, 23);
            this.PatientNamelbl.TabIndex = 42;
            this.PatientNamelbl.UseSystemPasswordChar = false;
            // 
            // SymptomsLbl
            // 
            this.SymptomsLbl.Depth = 0;
            this.SymptomsLbl.Hint = "Les Symptomes";
            this.SymptomsLbl.Location = new System.Drawing.Point(36, 157);
            this.SymptomsLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SymptomsLbl.Name = "SymptomsLbl";
            this.SymptomsLbl.PasswordChar = '\0';
            this.SymptomsLbl.SelectedText = "";
            this.SymptomsLbl.SelectionLength = 0;
            this.SymptomsLbl.SelectionStart = 0;
            this.SymptomsLbl.Size = new System.Drawing.Size(176, 23);
            this.SymptomsLbl.TabIndex = 41;
            this.SymptomsLbl.UseSystemPasswordChar = false;
            // 
            // Diagnosislbl
            // 
            this.Diagnosislbl.Depth = 0;
            this.Diagnosislbl.Hint = "Diagnostic";
            this.Diagnosislbl.Location = new System.Drawing.Point(263, 99);
            this.Diagnosislbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.Diagnosislbl.Name = "Diagnosislbl";
            this.Diagnosislbl.PasswordChar = '\0';
            this.Diagnosislbl.SelectedText = "";
            this.Diagnosislbl.SelectionLength = 0;
            this.Diagnosislbl.SelectionStart = 0;
            this.Diagnosislbl.Size = new System.Drawing.Size(176, 23);
            this.Diagnosislbl.TabIndex = 40;
            this.Diagnosislbl.UseSystemPasswordChar = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(455, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(113, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Le Résumé Du Diagnostic";
            // 
            // DiagnosisGv
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DiagnosisGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DiagnosisGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DiagnosisGv.BackgroundColor = System.Drawing.Color.White;
            this.DiagnosisGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiagnosisGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DiagnosisGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiagnosisGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DiagnosisGv.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DiagnosisGv.DefaultCellStyle = dataGridViewCellStyle6;
            this.DiagnosisGv.EnableHeadersVisualStyles = false;
            this.DiagnosisGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisGv.Location = new System.Drawing.Point(31, 498);
            this.DiagnosisGv.Name = "DiagnosisGv";
            this.DiagnosisGv.RowHeadersVisible = false;
            this.DiagnosisGv.RowTemplate.Height = 30;
            this.DiagnosisGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DiagnosisGv.Size = new System.Drawing.Size(989, 204);
            this.DiagnosisGv.TabIndex = 48;
            this.DiagnosisGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DiagnosisGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DiagnosisGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DiagnosisGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DiagnosisGv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LimeGreen;
            this.DiagnosisGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DiagnosisGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosisGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DiagnosisGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DiagnosisGv.ThemeStyle.HeaderStyle.Height = 25;
            this.DiagnosisGv.ThemeStyle.ReadOnly = false;
            this.DiagnosisGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DiagnosisGv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DiagnosisGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DiagnosisGv.ThemeStyle.RowsStyle.Height = 30;
            this.DiagnosisGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DiagnosisGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosisGv_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::WindowsFormsApp1.Properties.Resources.icons8_ajouter_une_règle_48;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(703, 425);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 67);
            this.button4.TabIndex = 49;
            this.button4.Text = "AJOUTER";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(340, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 50;
            this.label1.Text = "La Liste Du Diagnostic";
            // 
            // DIAGNOSTIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1036, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DiagnosisGv);
            this.Controls.Add(this.diagsummary);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PatientIdCb);
            this.Controls.Add(this.DiagId);
            this.Controls.Add(this.SymptomsTb);
            this.Controls.Add(this.DiagnosisTb);
            this.Controls.Add(this.PatientTb);
            this.Controls.Add(this.MedecineTb);
            this.Name = "DIAGNOSTIC";
            this.Text = "DIAGNOSTIC";
            this.Load += new System.EventHandler(this.diagnostic2_Load);
            this.diagsummary.ResumeLayout(false);
            this.diagsummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField MedecineTb;
        private MaterialSkin.Controls.MaterialSingleLineTextField PatientTb;
        private MaterialSkin.Controls.MaterialSingleLineTextField DiagnosisTb;
        private MaterialSkin.Controls.MaterialSingleLineTextField SymptomsTb;
        private MaterialSkin.Controls.MaterialSingleLineTextField DiagId;
        private Guna.UI2.WinForms.Guna2ComboBox PatientIdCb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel diagsummary;
        private MaterialSkin.Controls.MaterialSingleLineTextField Medicineslbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField PatientNamelbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField SymptomsLbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField Diagnosislbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView DiagnosisGv;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}