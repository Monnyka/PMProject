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
    public partial class frmPopup : Form
    {
        public frmPopup(string message)
        {
            InitializeComponent();
            txtMessage.Text = message;
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (btnOK.Text == "Exit")
            {
                Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmPopup_Load(object sender, EventArgs e)
        {
            if(txtMessage.Text=="Are you sure you want to exit?")
            {
                btnOK.Text = "Exit";
            }

        }
    }
}
