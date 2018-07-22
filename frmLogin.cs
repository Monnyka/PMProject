using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Movie_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
            
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Database\\MLDBTest.mdf;Integrated Security=True;Connect Timeout=30");
            cnn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from tbLogin where Uname='" + txtName.Text + "'and Upassword='" + txtPassword.Text + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                string name = txtName.Text;

                //ss.txtUname.Text = txtUname.Text;
                frmMain frmMain = new frmMain(txtName.Text);
                frmMain.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please Check your User Name and Password again!!");
            }
            cnn.Close();

        }
    }
}
