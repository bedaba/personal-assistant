using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using S22.Imap;
using MetroFramework;


namespace assistant
{
    public partial class chat : MetroFramework.Forms.MetroForm
    {
        static chat f;
        public chat()
        {
            

            InitializeComponent();
            //dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            f = this;
            button1_Click_1(null, null);

        }
        string smtpAddress = "smtp.gmail.com";
        int portNumber = 587;
        bool enableSSL = true;

        string emailFrom = "bolaa682@gmail.com";
        string password = "01277755208";
        //public void Alert(string msg, Form_Alert.enmType type)
        //{
        //    Form_Alert frm = new Form_Alert();
        //    frm.showAlert(msg, type);
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            ////    var message = new MailMessage(txtemail.Text, txttooo.Text);
            ////    message.Subject = txtsupp.Text;
            ////    message.Body = txtbody.Text;
            ////    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))

            ////    {
            ////        smtp.Credentials = new NetworkCredential(txtemail.Text, txtpass.Text);
            ////        smtp.EnableSsl = true;
            ////        smtp.Send(message);
            ////    }
            ////    txttooo.Text = null;
            ////    txtsupp.Text = null;
            ////    txtbody.Text = null;
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(txttooo.Text);
                    mail.Subject = txtsupp.Text;
                    mail.Body = txtbody.Text;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                    }
                }

                MessageBox.Show("تم الارسال بنجاح  \n سنعاود الاتصال بك فى اقرب وقت", "ارسال", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startReseving();

        }
        private void startReseving()
        {
            try
            {

                //Task.Run(() =>
                //{
                //    using (ImapClient client = new ImapClient("imap.gmail.com", 993, txtemail.Text,
                //        txtpass.Text, AuthMethod.Login, true))
                //    {
                //        if (client.Supports("IDLE") == false)
                //        {
                //            MessageBox.Show("فشل الاتصال");
                //            return;
                //        }
                //        client.NewMessage += new EventHandler<IdleMessageEventArgs>(OnNewMessage);
                //        while (true) ;
                //    }
                //});
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
            }
        }
        //public void OnNewMessage(object sender, IdleMessageEventArgs e)
        //{
        //    MetroMessageBox.Show(this, "", "يوجد لديك رسالة جديدة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    MailMessage m = e.Client.GetMessage(e.MessageUID, FetchOptions.Normal);
        //    f.Invoke((MethodInvoker)delegate
        //    {
        //        f.textBox1.AppendText("من:" + m.From + "\n" +
        //            "الموضوع:" + m.Subject + "\n\n" +
        //            "الرسالة:" + m.Body + "\n");
        //    });
        //}

       

        private void chat_Load_1(object sender, EventArgs e)
        {
            startReseving();

            //button2.PerformClick();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //dataGridView2.DataSource = CLASS_Email.SP_EmailReceipt_Display();
            //dataGridView1.DataSource = CLASS_Email.SP_emailsender_Display();

        }
    }

}