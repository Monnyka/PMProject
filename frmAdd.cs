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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            movie rMovie = new movie();
            rMovie.endPoint = "https://yts.pe/api/v2/list_movies.json?query_term=" + txtRequest.Text;
            string strResponse = string.Empty;
            strResponse = rMovie.MakeRequest();
            txtRespone.Text = strResponse;
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
