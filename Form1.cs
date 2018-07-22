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
        public frmMain(String uname)
        {
            InitializeComponent();
            lbUname.Text = uname;
        }
        //Form Loading Event:
        private void frmMain_Load(object sender, EventArgs e)
        {
            lbDate.Text=DateTime.Now.ToString("dd, MMMM, yyyy");

            SqlConnection cnn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Database\\MLDBTest.mdf;Integrated Security=True;Connect Timeout=30");

            cnn.Open();
            string sqlquery = "select * from tbMovie Order by id DESC";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sqlquery, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if (lbNumber.Text == "3")
            {
                textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[1].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.Rows[2].Cells[0].Value.ToString();
            }
            cnn.Close();

            //Image One
            cnn.Open();
            sqlquery = "select Photo from tbMovie where id='" + textBox1.Text + "'";
            cmd = new SqlCommand(sqlquery, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                byte[] images = ((byte[])dr[0]);
                if (images == null)
                {
                    pbHome1.Image = null;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(images);
                    pbHome1.Image = Image.FromStream(ms);
                    textBox1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                }
                dr.Close();
            }
            cnn.Close();

            //image two
            cnn.Open();
            sqlquery = "select Photo from tbMovie where id='" + textBox2.Text + "'";
            cmd = new SqlCommand(sqlquery, cnn);
            SqlDataReader dr1 = cmd.ExecuteReader();
            dr1.Read();
            if (dr1.HasRows)
            {
                byte[] images = ((byte[])dr1[0]);
                if (images == null)
                {
                    pbHome1.Image = null;
                }
                else
                {
                    MemoryStream ms1 = new MemoryStream(images);
                    pbHome2.Image = Image.FromStream(ms1);
                    textBox2.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();
                }
            }
            cnn.Close();

            //Image 3

            cnn.Open();
            sqlquery = "select Photo from tbMovie where id='" + textBox3.Text + "'";
            cmd = new SqlCommand(sqlquery, cnn);
            SqlDataReader dr2 = cmd.ExecuteReader();
            dr2.Read();
            if (dr2.HasRows)
            {
                byte[] images = ((byte[])dr2[0]);
                if (images == null)
                {
                    pbHome1.Image = null;
                }
                else
                {
                    MemoryStream ms2 = new MemoryStream(images);
                    pbHome3.Image = Image.FromStream(ms2);
                    textBox3.Text = dataGridView1.Rows[3].Cells[1].Value.ToString();
                }
            }
            cnn.Close();


            ////Profile Image
            //cnn.Open();
            //sqlquery = "select Photo from tbLogin where Name='" + lbUname.Text + "'";
            //cmd = new SqlCommand(sqlquery, cnn);
            //SqlDataReader dr3 = cmd.ExecuteReader();
            //dr2.Read();
            //if (dr3.HasRows)
            //{
            //    byte[] images = ((byte[])dr3[0]);
            //    if (images == null)
            //    {
            //        pbHome1.Image = null;
            //    }
            //    else
            //    {
            //        MemoryStream ms3 = new MemoryStream(images);
            //        pbHome3.Image = Image.FromStream(ms3);
            //    }
            //}
            //cnn.Close();


        }


        private void pbHome1_Click(object sender, EventArgs e)
        {
            frmMoviedetail moviedetail = new frmMoviedetail();
            moviedetail.Show();
            this.Hide();
        }

        private void lbDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard fDashboard = new frmDashboard();
            fDashboard.Show();
            this.Hide();
        }

        private void lbEntry_Click(object sender, EventArgs e)
        {
            frmEntry fEntry = new frmEntry();
            fEntry.Show();
        }

        private void lbList_Click(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit?";
            frmPopup fPopup = new frmPopup(message);
            fPopup.Show();
        }
    }
}
