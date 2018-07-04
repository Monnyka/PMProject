using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.IO;

namespace Prime_Movie_Project
{
    public partial class frmAdd : Form
    {

        public frmAdd()
        {

        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create the web request  
            HttpWebRequest request = WebRequest.Create("http://developer.yahoo.com/") as HttpWebRequest;

            // Get response  
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                // Get the response stream  
                StreamReader reader = new StreamReader(response.GetResponseStream());

                // Console application output  
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
