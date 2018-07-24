using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Prime_Movie_Project
{
    public partial class frmEntry : Form
    {
        public frmEntry()
        {
            InitializeComponent();
        }
        string message = "";
        string imglocation = "";
        SqlConnection cnn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Database\\MLDBTest.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnCancel.Text == "Cancel") { this.Close(); }
            if (btnCancel.Text == "Edit")
            {

            }
            if (btnCancel.Text == "Search")
            {
                cnn.Open();
                string sqlquery = "select Title,Year,Genre,Quality,Rating,Country,Language,Runtime,Synopsis,Director,Cast,D720,D1080,Photo from tbMovie where id='" + txtMID.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlquery, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    txtTitle.Text = dr[0].ToString();
                    cbYear.Text = dr[1].ToString();
                    cbGenre.Text = dr[2].ToString();
                    cbQuality.Text = dr[3].ToString();
                    cbRating.Text = dr[4].ToString();
                    cbCountry.Text = dr[5].ToString();
                    cbLanguage.Text = dr[6].ToString();
                    txtRuntime.Text = dr[7].ToString();
                    txtSynopsis.Text = dr[8].ToString();
                    cbDirector.Text = dr[9].ToString();
                    cbCast.Text = dr[10].ToString();
                    txtD720.Text = dr[11].ToString();
                    txtD1080.Text = dr[12].ToString();
                    byte[] images = ((byte[])dr[13]);
                    if (images == null)
                    {
                        pbMovie.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(images);
                        pbMovie.Image = Image.FromStream(ms);
                        btnSave.Enabled = true;
                        cnn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No record found!");
                }
                cnn.Close();
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbEdit_Paint(object sender, PaintEventArgs e)
        {
            txtMID.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (btnSave.Text == "Save")
            {
                if (pbMovie.Image == null) {
                    message = "Please Input Image.";
                    frmPopup fPopup1 = new frmPopup(message);
                    fPopup1.Show();

                goto Start; }

                cnn.Open();
                byte[] images;
                FileStream streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                images = brs.ReadBytes((int)streem.Length);

                string query = "insert into tbMovie (Title,Year,Genre,Quality,Rating,Country,Language,Runtime,Synopsis,Director,Cast,D720,D1080,Photo) Values ('" + txtTitle.Text + "','" + cbYear.Text + "','" + cbGenre.Text + "','" + cbQuality.Text + "','" + cbRating.Text + "','" + cbCountry.Text + "','"+cbLanguage+"','"+txtRuntime+"','" + txtSynopsis.Text + "','" + cbDirector.Text + "','" + cbCast.Text + "','" + txtD720.Text + "','" + txtD1080.Text + "',@images)";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                cmd.ExecuteNonQuery();
                cnn.Close();

                txtTitle.Text = "";
                cbYear.Text = "Year";
                cbGenre.Text = "Genre";
                cbCountry.Text = "Country";
                cbRating.Text = "Rating";
                cbQuality.Text = "Quality";
                txtSynopsis.Text = "";
                cbDirector.Text = "Director";
                txtD1080.Text = "";
                txtD720.Text = "";
                cbLanguage.Text = "Select Language";
                txtRuntime.Text = "";
                cbCast.Text = "Select Cast";
                pbMovie.Image = null;
                message = "Record has been saved successfull";
                frmPopup fPopup = new frmPopup(message);
                fPopup.Show();
                Start:;
            }
            if (btnSave.Text == "Update")
            {

            }
        }

        private void pbMovie_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = "c:\\Desktop\\Movie";
            fd.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                imglocation = fd.FileName.ToString();
                pbMovie.ImageLocation = imglocation;
            }
        }

        private void frmEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
