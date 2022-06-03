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
    public partial class docteur3 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GOUDI\OneDrive\Documents\HMS2db.mdf;Integrated Security=True;Connect Timeout=30");
        public docteur3()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "Select*from DoctorTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void docteur3_Load(object sender, EventArgs e)
        {
            //populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "" || DocName.Text == "" || DocPass.Text == "" || DocExp.Text == "")
                MessageBox.Show("veuillez remplir tous les champs");
            else
            {
                Con.Open();
                string query = "insert into DoctorTbl values (" + DocId.Text + ",'" + DocName.Text + "'," + DocExp.Text + ",'" + DocPass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Docteur ajoutee avec succes");

                Con.Close();
                populate();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DoctorTbl set DocName ='" + DocName.Text + "',DocExp='" + DocExp.Text + "',DocPass='" + DocPass.Text + "' where DocId=" + DocId.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("docteur modifie avec succes");

            Con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "")
                MessageBox.Show("Entrer le id du docteur ");
            else
            {
                Con.Open();
                string query = "delete from DoctorTbl where DocId=" + DocId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Docteur supprime avec succes");
                Con.Close();
                populate();
            }
        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocId.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            DocName.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
            DocExp.Text = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
            DocPass.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
