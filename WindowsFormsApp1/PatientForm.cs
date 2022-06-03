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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }
         SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GOUDI\OneDrive\Documents\HMS2db.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string query = "Select * from PatientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientGv.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "" || PatName.Text == "" || PateAd.Text == "" || PatPhone.Text == "" || PatAge.Text == "" || majorTb.Text == "") 
                MessageBox.Show("veuillez remplir tous les champs");
            else
            {
                Con.Open();
                string query = "insert into PatientTbl values (" + PatId.Text + " ,'" + PatName.Text + "','" + PateAd.Text + "','" + PatPhone.Text + "',"+PatAge.Text+",'"+GenderCb.SelectedItem.ToString()+"','"+BloodCb.SelectedItem.ToString()+"','"+majorTb.Text+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient ajoutee avec succes");

                Con.Close();
               populate();

            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
           // populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "")
                MessageBox.Show("Entrer le id du Patient ");
            else
            {
                Con.Open();
                string query = "delete from PatientTbl where PatId=" + PatId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient supprime avec succes");
                Con.Close();
                populate();
            }
        }

        private void PatientGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatId.Text = PatientGv.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = PatientGv.SelectedRows[0].Cells[1].Value.ToString();
            PateAd.Text = PatientGv.SelectedRows[0].Cells[2].Value.ToString();
            PatPhone.Text = PatientGv.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = PatientGv.SelectedRows[0].Cells[4].Value.ToString();
            majorTb.Text= PatientGv.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update PatientTbl set PatName ='" + PatName.Text + "',PatAddress='" + PateAd.Text + "',PatPhone='" + PatPhone.Text + "',PatAge="+PatAge.Text+",PatGender='"+GenderCb.SelectedItem.ToString()+"',PatBlood='"+BloodCb.SelectedItem.ToString()+"' where PatId=" + PatId.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient modifie avec succes");

            Con.Close();
            populate();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
