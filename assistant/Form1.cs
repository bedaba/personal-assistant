using System;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Word;
using System.Drawing;
using assistant;
using george;
using System.Speech.Synthesis;
using System.Net;
using System.Net.Mail;

namespace assistant
{
    public partial class Form1 : Form
    {
        public static WelcomeAndGoodbye wAndG;
        public static Email email;
        public static Speak speak = new Speak();
        public static Calender calender;
        public static string choice;
        public static int volume = 50;
        public static SpeechRecognitionEngine myVoice = new SpeechRecognitionEngine();
        System.Windows.Forms.Timer stopListeningTimer = new System.Windows.Forms.Timer();


        SpeechRecognitionEngine sen = new SpeechRecognitionEngine();
       
        SpeechRecognitionEngine sen1 = new SpeechRecognitionEngine();
       
        public Form1()
        {
            InitializeComponent();
            se();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //Set output, load grammar and set up speech recognisition event handler
            myVoice.SetInputToDefaultAudioDevice();

            string[] phrases = getPhrases();
            myVoice.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(phrases))));

            myVoice.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(myVoice_SpeechRecognized);
            myVoice.RecognizeAsync(RecognizeMode.Multiple);
        }
        public void se()
        {
            Choices list = new Choices();

            list.Add(new string[] { "sd","as"});
            Grammar gramar = new Grammar(new GrammarBuilder(list));
            Grammar DiGrammar = new DictationGrammar();
            {
                sen.RequestRecognizerUpdate();
                sen.LoadGrammar(DiGrammar);
                sen.SpeechRecognized += start_SpeechRecognized;
                sen.SetInputToDefaultAudioDevice();
                sen.RecognizeAsync(RecognizeMode.Multiple);

            }
            {
                sen1.RequestRecognizerUpdate();
                sen1.LoadGrammar(gramar);
                sen1.SpeechRecognized += start_SpeechRecognized;
                sen1.SetInputToDefaultAudioDevice();
                sen1.RecognizeAsync(RecognizeMode.Multiple);

            }
        }
        void start_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

           
           
            txtbody.Text = txtbody.Text + " " + e.Result.Text;
        }

        private void myVoice_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string input = e.Result.Text;
            switch (input.ToUpper())
            {

                //////////////////////////////
                case ("SEND"):
                case ("SEND EMAIL"):
                case ("GO"):
                    button1_Click(null, null);
                   
                    break;

            }





        }
        public static string[] getPhrases()
        {
            string[] phrases = File.ReadAllLines(@"F:\old windows\desktop\assistant2\Grammar.txt");
            int index = 0;
            foreach (string phrase in phrases)
            {
                if (phrase == string.Empty)
                {
                    phrases[index] = "Empty";
                }
                index++;
            }
            return phrases;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            var fromAddress = new MailAddress("bedaba", "From Name");
            var toAddress = new MailAddress("to@example.com", "To Name");
            const string fromPassword = "fromPassword";
             string subject = txtsup.Text;
             string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new System.Net.Mail.MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
            MessageBox.Show("تم الارسال بنجاح");
        }
    }
}
