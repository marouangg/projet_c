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
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
  (
      int nLeftRect,     // x-coordinate of upper-left corner
      int nTopRect,      // y-coordinate of upper-left corner
      int nRightRect,    // x-coordinate of lower-right corner
      int nBottomRect,   // y-coordinate of lower-right corner
      int nWidthEllipse, // height of ellipse
      int nHeightEllipse // width of ellipse
  );


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GOUDI\OneDrive\Documents\HMS2db.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* if (DocNameTb.Text == "" || PassTb.Text == "")
                 MessageBox.Show("entrer username and mot de passe");
             else
             {
                 Con.Open();
                 SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) from DoctorTbl where DocName='" + DocNameTb.Text + "' and DocPass='" + PassTb.Text + "'", Con);
                 DataTable dt = new DataTable();
                 sda.Fill(dt);
                 if(dt.Rows[0][0].ToString()=="1")
                 {
                    
                 }
                else
                 {
                     MessageBox.Show("invalide utilisateur ou mot de passe");
                 }
                 Con.Close();
             }
            */

 Menu f = new Menu();
                     f.Show();
                    this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            DocNameTb.Text = "";
            PassTb.Text = "";
        }
    }
}
