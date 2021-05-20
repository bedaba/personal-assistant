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
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        //تنفيذ الاوامر الاتية عند تحميل  الشاشة 
        private void Form1_Load(object sender, EventArgs e)
        {
            // يتم تعطيل الاخطاء الخاصة متصفح الويب 
            webBrowser1.ScriptErrorsSuppressed = true;
            //يتم ايقاف عملية تحريك الشاشة في الاتجاهات المختلفة  وذلك لاستقرار عملية العرض 
            webBrowser1.ScrollBarsEnabled = false;
           //يتم استدعاء صفحة الويب الي القيمة المخزنة داخل البرنامج 
            webBrowser1.Navigate(assistant.Properties.Settings.Default.location);

        }

        private void asd2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
