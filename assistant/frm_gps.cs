using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assistant
{
    public partial class frm_gps : Form
    {
        public frm_gps()
        {
            InitializeComponent();
        }

        private void frm_gps_Load(object sender, EventArgs e)
        {


            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.ScrollBarsEnabled = false;
            webBrowser1.Navigate("https://www.google.com/maps/search/مستشفيات");



            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
