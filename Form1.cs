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
using System.IO;

namespace Prime_Movie_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //Form Loading Event:
        private void frmMain_Load(object sender, EventArgs e)
        {
            lbDate.Text=DateTime.Now.ToString("dd, MMMM, yyyy");

            SqlConnection cnn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Database\\MLDBTest.mdf;Integrated Security=True;Connect Timeout=30");

            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd1 = new SqlCommand();
            SqlCommand cmdcount = new SqlCommand();
            string sqlquery = "";
            string sqlquery1 = "";
            string sqlcount = "";
            //get number of all record
            sqlcount= "SELECT COUNT(ID) FROM tbMovie;";
            cmdcount = new SqlCommand(sqlcount, cnn);
            int a = 20;



            sqlquery = "SELECT photo FROM tbMovie WHERE id='a';";
            cmd = new SqlCommand(sqlquery, cnn);

            


            SqlDataReader dr1 = cmd.ExecuteReader();        
            dr1.Read();
            if (dr1.HasRows)
            {
                byte[] images1 = ((byte[])dr1[0]);
                if (images1 == null)
                {
                    pbHome1.Image = null;
                }
                else
                {
                    MemoryStream ms1 = new MemoryStream(images1);
                    pbHome1.Image = Image.FromStream(ms1);
                }
            }
            dr1.Close();

            sqlquery1 = "select Photo from tbMovie where id=46";
            cmd1 = new SqlCommand(sqlquery1, cnn);
            SqlDataReader dr2 = cmd1.ExecuteReader();

            dr2.Read();
            if (dr2.HasRows)
            {
                byte[] images2 = ((byte[])dr2[0]);
                if (images2 == null)
                {
                    pbHome2.Image = null;
                }
                else
                {
                    MemoryStream ms2 = new MemoryStream(images2);
                    pbHome2.Image = Image.FromStream(ms2);
                }
            }

            dr2.Close();
            string sqlquery2 = "";
            sqlquery2 = "select Photo from tbMovie where id=33";
            SqlCommand cmd2 = new SqlCommand(sqlquery2, cnn);
            SqlDataReader dr3 = cmd2.ExecuteReader();

            dr3.Read();
            if (dr3.HasRows)
            {
                byte[] images3 = ((byte[])dr3[0]);
                if (images3 == null)
                {
                    pbHome3.Image = null;
                }
                else
                {
                    MemoryStream ms3 = new MemoryStream(images3);
                    pbHome3.Image = Image.FromStream(ms3);
                }
            }
            cnn.Close();




















        }

        private void pbHome1_Click(object sender, EventArgs e)
        {
            frmMoviedetail moviedetail = new frmMoviedetail();
            moviedetail.Show();
            this.Hide();
        }
    }
}
