using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class DIAGNOSTIC : Form
    {
        public DIAGNOSTIC()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GOUDI\OneDrive\Documents\HMS2db.mdf;Integrated Security=True;Connect Timeout=30");
        void poulatecombo()
        {
            string sql = "Select * from PatientTbl";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                PatientIdCb.ValueMember = "PatId";
                PatientIdCb.DataSource = dt;
                Con.Close();
            }
            catch
            {




            }
        }
        string patname;
        void fetchpatientname()
        {
            Con.Open();

            string mysql = "Select * From PatientTbl where PatId=" + PatientIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                patname = dr["PatName"].ToString();
                PatientTb.Text = patname;
            }

            Con.Close();

        }
        void populate()
        {
            Con.Open();
            string query = "Select * from DiagnosisTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DiagnosisGv.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void diagnostic2_Load(object sender, EventArgs e)
        {
            //poulatecombo();
            //populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "" || MedecineTb.Text == "" || DiagnosisTb.Text == "" || PatientTb.Text == "" || MedecineTb.Text == "")
                MessageBox.Show("veuillez remplir tous les champs");
            else
            {
                Con.Open();
                string query = "insert into DiagnosisTbl values (" + DiagId.Text + " ," + PatientIdCb.SelectedValue.ToString() + ",'" + PatientTb.Text + "','" + SymptomsTb.Text + "','" + DiagnosisTb.Text + "','" + MedecineTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnossis ajoutee avec succes");

                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DiagnosisTbl set PatId =" + PatientIdCb.SelectedValue.ToString() + ",PatName='" + PatientTb.Text + "',Symptoms='" + SymptomsTb.Text + "',Diagnosis='" + DiagnosisTb.Text + "',Medecines='" + MedecineTb.Text + "' where DiagId=" + DiagId.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnostique modifie avec succes");

            Con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "")
                MessageBox.Show("Entrer le id du diagnostique");
            else
            {
                Con.Open();
                string query = "delete from PatientTbl where DiagId=" + DiagId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnostique supprime avec succes");
                Con.Close();
                populate();
            }
        }

        private void DiagnosisGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DiagId.Text = DiagnosisGv.SelectedRows[0].Cells[0].Value.ToString();
            PatientIdCb.SelectedValue = DiagnosisGv.SelectedRows[0].Cells[1].Value.ToString();
            PatientTb.Text = DiagnosisGv.SelectedRows[0].Cells[2].Value.ToString();
            SymptomsTb.Text = DiagnosisGv.SelectedRows[0].Cells[3].Value.ToString();
            DiagnosisTb.Text = DiagnosisGv.SelectedRows[0].Cells[4].Value.ToString();
            MedecineTb.Text = DiagnosisGv.SelectedRows[0].Cells[5].Value.ToString();
            PatientNamelbl.Text = DiagnosisGv.SelectedRows[0].Cells[2].Value.ToString();
            Diagnosislbl.Text = DiagnosisGv.SelectedRows[0].Cells[4].Value.ToString();
            SymptomsLbl.Text = DiagnosisGv.SelectedRows[0].Cells[3].Value.ToString();
            Medicineslbl.Text = DiagnosisGv.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpatientname();
        }
    }
}
