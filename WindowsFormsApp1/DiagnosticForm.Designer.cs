namespace WindowsFormsApp1
{
    partial class DiagnosticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosticForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DiagId = new Guna.UI2.WinForms.Guna2TextBox();
            this.PatientIdCb = new System.Windows.Forms.ComboBox();
            this.PatientTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.SymptomsTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.DiagnosisTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.MedecineTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.diagsummary = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.Diagnosislbl = new System.Windows.Forms.Label();
            this.SymptomsLbl = new System.Windows.Forms.Label();
            this.Medicineslbl = new System.Windows.Forms.Label();
            this.PatientNamelbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DiagnosisGv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.diagsummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // DiagId
            // 
            this.DiagId.BorderColor = System.Drawing.Color.Gainsboro;
            this.DiagId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DiagId.DefaultText = "DiagnosticId";
            this.DiagId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DiagId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DiagId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DiagId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DiagId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.DiagId, "DiagId");
            this.DiagId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DiagId.Name = "DiagId";
            this.DiagId.PasswordChar = '\0';
            this.DiagId.PlaceholderText = "";
            this.DiagId.SelectedText = "";
            // 
            // PatientIdCb
            // 
            this.PatientIdCb.FormattingEnabled = true;
            resources.ApplyResources(this.PatientIdCb, "PatientIdCb");
            this.PatientIdCb.Name = "PatientIdCb";
            this.PatientIdCb.SelectionChangeCommitted += new System.EventHandler(this.PatientIdCb_SelectionChangeCommitted);
            // 
            // PatientTb
            // 
            this.PatientTb.BorderColor = System.Drawing.Color.Gainsboro;
            this.PatientTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientTb.DefaultText = "PatientNom";
            this.PatientTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatientTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatientTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.PatientTb, "PatientTb");
            this.PatientTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientTb.Name = "PatientTb";
            this.PatientTb.PasswordChar = '\0';
            this.PatientTb.PlaceholderText = "";
            this.PatientTb.SelectedText = "";
            // 
            // SymptomsTb
            // 
            this.SymptomsTb.BorderColor = System.Drawing.Color.Gainsboro;
            this.SymptomsTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SymptomsTb.DefaultText = "Les Symptomes";
            this.SymptomsTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SymptomsTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SymptomsTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SymptomsTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SymptomsTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.SymptomsTb, "SymptomsTb");
            this.SymptomsTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SymptomsTb.Name = "SymptomsTb";
            this.SymptomsTb.PasswordChar = '\0';
            this.SymptomsTb.PlaceholderText = "";
            this.SymptomsTb.SelectedText = "";
            // 
            // DiagnosisTb
            // 
            this.DiagnosisTb.BorderColor = System.Drawing.Color.Gainsboro;
            this.DiagnosisTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DiagnosisTb.DefaultText = "Diagnostic id";
            this.DiagnosisTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DiagnosisTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DiagnosisTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DiagnosisTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DiagnosisTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.DiagnosisTb, "DiagnosisTb");
            this.DiagnosisTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DiagnosisTb.Name = "DiagnosisTb";
            this.DiagnosisTb.PasswordChar = '\0';
            this.DiagnosisTb.PlaceholderText = "";
            this.DiagnosisTb.SelectedText = "";
            // 
            // MedecineTb
            // 
            this.MedecineTb.BorderColor = System.Drawing.Color.Gainsboro;
            this.MedecineTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedecineTb.DefaultText = "medicines";
            this.MedecineTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MedecineTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MedecineTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MedecineTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MedecineTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.MedecineTb, "MedecineTb");
            this.MedecineTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MedecineTb.Name = "MedecineTb";
            this.MedecineTb.PasswordChar = '\0';
            this.MedecineTb.PlaceholderText = "";
            this.MedecineTb.SelectedText = "";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Name = "label3";
            // 
            // diagsummary
            // 
            this.diagsummary.Controls.Add(this.label9);
            this.diagsummary.Controls.Add(this.Diagnosislbl);
            this.diagsummary.Controls.Add(this.SymptomsLbl);
            this.diagsummary.Controls.Add(this.Medicineslbl);
            this.diagsummary.Controls.Add(this.PatientNamelbl);
            this.diagsummary.Controls.Add(this.label4);
            resources.ApplyResources(this.diagsummary, "diagsummary");
            this.diagsummary.Name = "diagsummary";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Name = "label9";
            // 
            // Diagnosislbl
            // 
            resources.ApplyResources(this.Diagnosislbl, "Diagnosislbl");
            this.Diagnosislbl.ForeColor = System.Drawing.Color.Black;
            this.Diagnosislbl.Name = "Diagnosislbl";
            // 
            // SymptomsLbl
            // 
            resources.ApplyResources(this.SymptomsLbl, "SymptomsLbl");
            this.SymptomsLbl.ForeColor = System.Drawing.Color.Black;
            this.SymptomsLbl.Name = "SymptomsLbl";
            // 
            // Medicineslbl
            // 
            resources.ApplyResources(this.Medicineslbl, "Medicineslbl");
            this.Medicineslbl.ForeColor = System.Drawing.Color.Black;
            this.Medicineslbl.Name = "Medicineslbl";
            // 
            // PatientNamelbl
            // 
            resources.ApplyResources(this.PatientNamelbl, "PatientNamelbl");
            this.PatientNamelbl.ForeColor = System.Drawing.Color.Black;
            this.PatientNamelbl.Name = "PatientNamelbl";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Name = "label4";
            // 
            // DiagnosisGv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DiagnosisGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DiagnosisGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DiagnosisGv.BackgroundColor = System.Drawing.Color.White;
            this.DiagnosisGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiagnosisGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DiagnosisGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiagnosisGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.DiagnosisGv, "DiagnosisGv");
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DiagnosisGv.DefaultCellStyle = dataGridViewCellStyle3;
            this.DiagnosisGv.EnableHeadersVisualStyles = false;
            this.DiagnosisGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisGv.Name = "DiagnosisGv";
            this.DiagnosisGv.RowHeadersVisible = false;
            this.DiagnosisGv.RowTemplate.Height = 30;
            this.DiagnosisGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LimeGreen;
            this.button5.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button5, "button5");
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // DiagnosticForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.DiagnosisGv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diagsummary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MedecineTb);
            this.Controls.Add(this.DiagnosisTb);
            this.Controls.Add(this.SymptomsTb);
            this.Controls.Add(this.PatientTb);
            this.Controls.Add(this.PatientIdCb);
            this.Controls.Add(this.DiagId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagnosticForm";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            this.diagsummary.ResumeLayout(false);
            this.diagsummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox DiagId;
        private System.Windows.Forms.ComboBox PatientIdCb;
        private Guna.UI2.WinForms.Guna2TextBox PatientTb;
        private Guna.UI2.WinForms.Guna2TextBox SymptomsTb;
        private Guna.UI2.WinForms.Guna2TextBox DiagnosisTb;
        private Guna.UI2.WinForms.Guna2TextBox MedecineTb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel diagsummary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Diagnosislbl;
        private System.Windows.Forms.Label SymptomsLbl;
        private System.Windows.Forms.Label Medicineslbl;
        private System.Windows.Forms.Label PatientNamelbl;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView DiagnosisGv;
        private System.Windows.Forms.Button button5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}