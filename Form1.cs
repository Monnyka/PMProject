using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Movie_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
                    }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbDate.Text=DateTime.Now.ToString("dd, MMMM, yyyy");
        }

        private void pbHome1_Click(object sender, EventArgs e)
        {
            frmMoviedetail moviedetail = new frmMoviedetail();
            moviedetail.Show();
            this.Hide();
        }
    }
}
