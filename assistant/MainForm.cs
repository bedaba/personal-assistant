using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using System.Speech.Synthesis;
namespace george
{
    public partial class FrmPrincipal : Form
    {


        public FrmPrincipal()
        {
            InitializeComponent();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            new RegisterFace().ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Attendance().ShowDialog();
            this.Show();
        }


        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Do You Want To Quit Application?", "Quit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.No)
            {

            }
            else
            {
                Application.ExitThread();
            }

        }
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Do You Want To Quit Application?", "Quit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;

            }
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            List<string> _items = new List<string>();


            Dictionary<string, int> uniquedate = new Dictionary<string, int>();




        }





        private void buttonAll_Click(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            SpeechSynthesizer talk = new SpeechSynthesizer();
            talk.SelectVoiceByHints(VoiceGender.Female);

            talk.SpeakAsync("Thank you for choosing our program");
            talk.Volume = 100;
            timer1.Stop();
        }



    }
}


