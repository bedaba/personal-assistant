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

namespace george
{
    public partial class george : Form
    {
        public static WelcomeAndGoodbye wAndG;
        public static Email email;
        public static Speak speak = new Speak();
        public static Calender calender;
        public static string choice;
        public static int volume = 50;


        //محرك التعرف علي الصوت
        public static SpeechRecognitionEngine myVoice = new SpeechRecognitionEngine();

        System.Windows.Forms.Timer stopListeningTimer = new System.Windows.Forms.Timer();

        public george()
        {
            InitializeComponent();


            




            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //اختيار جهاز الصوت الافتراضي
            myVoice.SetInputToDefaultAudioDevice();

            string[] phrases = getPhrases();
            //استدعاء المصطلحات المستخدمة
            myVoice.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(phrases))));
///            انشاء دالة التعرف علي الصوت
            myVoice.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(myVoice_SpeechRecognized);
           //مزامنة متعددة للكلمات
            myVoice.RecognizeAsync(RecognizeMode.Multiple);

            loadUpWelcome();

            stopListeningTimer.Tick += new EventHandler(time_Tick);
            stopListeningTimer.Interval = 1000; analyzer = new Analyzer(progressBar1, progressBar2, spectrum1, comboBox1, chart1);
            analyzer.Enable = true;
            analyzer.DisplayEnable = true;



            timer1.Enabled = true;
        }
        Analyzer analyzer;

        
        private void myVoice_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string input = e.Result.Text.ToUpper();
           
            try
            {
                switch (input)
                {
                    ////////////////////////////////////////////////////////////////////
                    case ("HOSP"):
                    case ("HOSPITAL"):
                    case ("MOSTASHFA"):
                        assistant.Properties.Settings.Default.location = "https://www.google.com/maps/search/مستشفيات";
                        assistant.Properties.Settings.Default.Save();
                        frm_gps asd = new frm_gps();
                        asd.Show();
                        break;



                    case ("COFE"):

                        assistant.Properties.Settings.Default.location = "https://www.google.com/maps/search/COFE";
                        assistant.Properties.Settings.Default.Save();
                        frm_gps f3 = new frm_gps();
                        f3.ShowDialog();
                        break;

                    case ("SCHOOL"):

                        assistant.Properties.Settings.Default.location = "https://www.google.com/maps/search/school";
                        assistant.Properties.Settings.Default.Save();
                        frm_gps f4 = new frm_gps();
                        f4.ShowDialog();
                        break;

                    case ("RESTAURANTS"):

                        assistant.Properties.Settings.Default.location = "https://www.google.com/maps/search/مطاعم";
                        assistant.Properties.Settings.Default.Save();
                        frm_gps f5 = new frm_gps();
                        f5.ShowDialog();
                        break;


                    case ("PHARMACIES"):

                        assistant.Properties.Settings.Default.location = "https://www.google.com/maps/search/صيدليات";
                        assistant.Properties.Settings.Default.Save();
                        frm_gps f6 = new frm_gps();
                        f6.ShowDialog();
                        break;

                    case ("BANK"):

                        assistant.Properties.Settings.Default.location = "https://www.google.com/maps/search/بنك";
                        assistant.Properties.Settings.Default.Save();
                        frm_gps f7 = new frm_gps();
                        f7.ShowDialog();
                        break;


                    ////////////////////////////////////////////////////////////////////






                    case ("SEARCH"):
                    case ("SEARCH FOR"):
                    case ("FIND"):
                        search();
                        break;

                    //Works with no appointments - Haven't checked when appointment is present
                    case ("CALENDER"):
                    case ("CHECK CALENDER"):
                    case ("APPOINTMENTS"):
                    case ("TASKS"):
                        Console.WriteLine("Calender");
                        checkCalender();
                        break;

                    case ("GOOGLE"):
                        googleSearch();
                        break;

                    case ("SHOW TIME"):
                    case ("TIME"):
                    case ("CURRENT TIME"):
                    case ("TELL TIME"):
                    case ("SAY TIME"):
                        currentTime();
                        break;

                    case ("SHOW DAY"):
                    case ("DAY"):
                    case ("CURRENT DAY"):
                    case ("TELL DAY"):
                    case ("SAY DAY"):
                    case ("SHOW DATE"):
                    case ("DATE"):
                    case ("CURRENT DATE"):
                    case ("TELL DATE"):
                    case ("SAY DATE"):
                        currentDate();
                        break;

                    case ("HELLO"):
                    case ("HEY george"):
                    case ("HEY"):
                    case ("SUP"):
                    case ("GOOD MORNING"):
                    case ("GOOD AFTERNOON"):
                    case ("GOOD EVENING"):
                        helloResponse();
                        break;





                    case ("Firefox BROWSER"):
                    case ("FIREFOX"):
                    case ("FOX"):
                        Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe");
                        break;


                    case ("VLC"):
                    case ("OPEN VLC"):
                    case ("OPENVLC"):
                        Process.Start(@"C:\Program Files (x86)\VideoLAN\VLC\Vlc.exe");
                        break;




                    ///////////////////////////////////////////////////////////////////////////////////////////

                    ////////////////////////////////////////////////////////////////////////////a
                    case ("EGYBEST"):
                    case ("EGY BEST"):
                    case ("EGY"):
                        Process.Start("https://upon.egybest.name/");
                        Thread loadLeague = new Thread(new ThreadStart(() => speak.loading()));
                        loadLeague.IsBackground = true;
                        loadLeague.Start();
                        break;

                    case ("TELEGRAM"):
                        Process.Start("https://web.telegram.org/");
                        Thread loadLeague1 = new Thread(new ThreadStart(() => speak.loading()));
                        loadLeague1.IsBackground = true;
                        loadLeague1.Start();
                        break;


                    case ("OPEN TRANSLATE"):
                    case ("TRANSLATE"):
                    case ("OPENTRANSLATE"):
                        Process.Start("https://translate.google.com");
                        Thread loadLeague2 = new Thread(new ThreadStart(() => speak.loading()));
                        loadLeague2.IsBackground = true;
                        loadLeague2.Start();
                        break;

                    case ("FACEBOOK"):
                    case ("OPEN FACEBOOK"):
                    case ("OPENFACEBOOK"):
                        Process.Start("https://facebook.com/eg");
                        Thread loadLeague3 = new Thread(new ThreadStart(() => speak.loading()));
                        loadLeague3.IsBackground = true;
                        loadLeague3.Start();
                        break;

                    case ("YOUTUBE"):
                    case ("OPEN YOUTUBE"):
                    case ("OPENYOUTUBE"):
                        Process.Start("https://youtube.com");
                        Thread loadLeague4 = new Thread(new ThreadStart(() => speak.loading()));
                        loadLeague4.IsBackground = true;
                        loadLeague4.Start();
                        break;

                    case ("WEATHER"):
                    case ("OPEN WEATHER"):
                    case ("OPENWEATHER"):
                        Process.Start("https://www.google.com/search?q=weather");

                        break;

                    case ("CALCULATOR"):
                    case ("OPEN CALCULATOR"):
                    case ("OPENCALCULATOR"):
                        Process.Start("calc"); ;

                        break;

                    case ("NOTEBAD"):
                    case ("OPEN NOTEBAD"):
                    case ("OPENNOTEBAD"):

                        Process.Start("notepad.exe");

                        break;



                    case ("george QUIET"):
                    case ("george SH"):
                    case ("george VOLUME DOWN"):
                        georgeVolume(true);
                        break;

                    case ("george LOUD"):
                    case ("I CANT HEAR YOU"):
                    case ("I CANT HEAR YOU george"):
                    case ("george VOLUME UP"):
                        georgeVolume(false);
                        break;

                    case ("george MUTE"):
                    case ("MUTE"):
                        georgeMute(true);
                        break;

                    case ("george SPEAK"):
                    case ("UNDO MUTE"):
                        georgeMute(false);
                        break;

                    case ("STOP LISTENING"):
                        stopListening();
                        break;

                    case ("EXIT CHROME"):
                    case ("CLOSE CHROME"):
                        exitChromeWindows();
                        break;

                    case ("OPEN CHROME"):
                        openChromeWindow();
                        break;

                    case ("ALL PROCESSES"):
                    case ("SHOW PROCESSES"):
                        showProcesses();
                        break;

                    case ("CLOSE MAIL"):
                    case ("EXIT MAIL"):
                    case ("CLOSE OUTLOOK"):
                    case ("EXIT OUTLOOK"):
                        closeEmail();
                        break;

                    case ("CLOSE ITUNES"):
                    case ("EXIT ITUNES"):
                        endProcess("itunes");
                        break;

                    case ("MOVIES"):
                        loadMovies();
                        break;

                    case ("MINIMIZE"):
                    case ("george SMALL"):
                        minimize();
                        break;

                    case ("george COME BACK"):
                    case ("george NORMAL"):
                    case ("NORMAL"):
                        normalSize();
                        break;

                    case ("QUIT"):
                    case ("Q"):
                    case ("STOP"):
                    case ("END"):
                        endProgram(this);
                        break;

                    default:
                        noCommand();
                        break;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("الامر غير متوفر");
              
            }
           
        }

        //..........................................Welcome/Goodbye/Hello Response messages................................

        public static void loadUpWelcome()
        {
            wAndG = new WelcomeAndGoodbye();
            Thread welcomeThread = new Thread(new ThreadStart(wAndG.welcome));
            welcomeThread.IsBackground = true;
            welcomeThread.Start();
        }


        public static void endProgram(Form thisForm)
        {
            wAndG = new WelcomeAndGoodbye();
            Thread goodbyeThread = new Thread(new ThreadStart(wAndG.goodbye));
            goodbyeThread.IsBackground = true;
            goodbyeThread.Start();
            goodbyeThread.Join();
            thisForm.Close();
        }

        public static void helloResponse()
        {

            Thread hello = new Thread(new ThreadStart(speak.hello));
            hello.IsBackground = true;
            hello.Start();
        }

        //....................................................................................................

        //........................................Weather.....................................................


        //.....................................................................................................

        //......................................Email..........................................................
        //public static void openMail()
        //{
        //    email = new Email();
        //    email.openMail();
        //}

        //public static void sendMail()
        //{
        //    email = new Email();
        //    email.sendMail();
        //}

        //private static void readMail()
        //{
        //    email = new Email();
        //    email.readMail();
        //}
        //.....................................................................................................

        //.....................................Search Files....................................................

        public static Search getSearchFile = new Search();
        public static SpeechRecognitionEngine whatToSearch = new SpeechRecognitionEngine();
        public string getFile = "No Data";

        public void search()
        {
            getSearchFile.Show();
            myVoice.RecognizeAsyncCancel();
            whatToSearch.SetInputToDefaultAudioDevice();
            whatToSearch.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(getPhrases()))));
            whatToSearch.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(whatToSearch_SpeechRecognized);
            whatToSearch.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void whatToSearch_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.ToUpper().Equals("SEARCH"))
            {
                Console.WriteLine("Getting Input");
                this.getFileMethod = getSearchFile.inputFound();
                Console.WriteLine("Searching");
                try
                {
                    myVoice.RecognizeAsync(RecognizeMode.Multiple);
                }
                catch
                {
                }
                whatToSearch.RecognizeAsyncStop();
                findFile(this.getFileMethod);
            }
        }

        public string getFileMethod
        {
            get
            {
                return getFile;
            }
            set
            {
                getFile = value;
            }
        }


        public static void findFile(string filename)
        {
            getSearchFile.Close();
            string[] files = null;

            try
            {
                files = Directory.GetFiles("C:\\Users\\Alex\\Downloads", filename + ".*", SearchOption.AllDirectories);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.ToString());
            }

            if (files != null)
            {
                foreach (string file in files)
                {
                    Console.WriteLine(file);

                    try
                    {
                        ProcessStartInfo psi = new ProcessStartInfo(file);
                        Process proc = new Process();
                        proc.StartInfo = psi;
                        if (proc.Start())
                        {
                            Thread loading = new Thread(new ThreadStart(() => speak.loading()));
                            loading.IsBackground = true;
                            loading.Start();
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        //.....................................................................................................

        //.....................................Check Calender..................................................
        public static void checkCalender()
        {
            calender = new Calender();
            calender.calenderAppointments();
        }
        //.....................................................................................................

        //........................................Google search................................................

        public static SpeechRecognitionEngine whatToGoogle = new SpeechRecognitionEngine();
        public static googleOther google = new googleOther();
        public static void googleSearch()
        {
            google.Show();

            Thread searchForThread = new Thread(new ThreadStart(() => speak.searchFor()));
            searchForThread.IsBackground = true;
            searchForThread.Start();

            myVoice.RecognizeAsyncCancel();

            whatToGoogle.SetInputToDefaultAudioDevice();
            whatToGoogle.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(getPhrases()))));
            whatToGoogle.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(whatToGoogle_SpeechRecognized);
            whatToGoogle.RecognizeAsync(RecognizeMode.Multiple);
        }

        private static void whatToGoogle_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.ToUpper().Equals("SEARCH"))
            {
                google.searchGoogle();

                Thread loading = new Thread(new ThreadStart(() => speak.loading()));
                loading.IsBackground = true;
                loading.Start();
                try
                {
                    myVoice.RecognizeAsync(RecognizeMode.Multiple);
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                whatToGoogle.RecognizeAsyncStop();
            }

        }
        //...................................................................................................

        //........................................Get Time and Date..........................................
        public static void currentTime()
        {

            speak.currentTime();
        }

        public static void currentDate()
        {

            speak.currentDate();
        }
        //..................................................................................................

        //....................................................Itunes Volume.................................

       

        //..................................................................................................

        //....................................................Other.........................................             

        public static void georgeVolume(bool volumeDown)
        {

            speak.georgeVol(volumeDown);
        }

        public static void georgeMute(bool mute)
        {

            speak.georgeMute(mute);
        }

        public static string[] getPhrases()
        {
            string[] phrases = File.ReadAllLines(@"Grammar.txt");
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

        int time = 60;
        public void stopListening()
        {
            time = 60;
            myVoice.RecognizeAsyncStop();
            Console.WriteLine("Not Listening");
            stopListeningTimer.Start();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            time = time - 1;
            Console.WriteLine(time.ToString());
            if (time == 0)
            {
                myVoice.RecognizeAsync(RecognizeMode.Multiple);
                Console.WriteLine("You may speak");
                stopListeningTimer.Stop();
            }
        }
        //..................................................................................................

        private void george_Click(object sender, EventArgs e)
        {
            time = 1;
        }

        private void exitChromeWindows()
        {
            endProcess("chrome");
        }

        private void openChromeWindow()
        {
            Process.Start("chrome.exe");
        }

        private void noCommand()
        {
            Thread noOptAvail = new Thread(new ThreadStart(() => speak.noOptionAvailable()));
            noOptAvail.IsBackground = true;
            noOptAvail.Start();
        }

        private void loadMovies()
        {
            try
            {
                Process.Start(@"C:\Users\Alex\Documents\Visual Studio 2013\Projects\Movies\Movies\bin\Debug\Movies.exe");
            }
            catch (System.Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }
        }

        private void showProcesses()
        {
            try
            {
                Process[] allProcesses = Process.GetProcesses();
                foreach (Process item in allProcesses)
                {
                    Console.WriteLine(item.ProcessName.ToString());
                }
            }
            catch (System.Exception exce)
            {
                Console.WriteLine(exce.ToString());
            }
        }

        private void endProcess(string process)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process currentProcess in processes)
            {
                if (currentProcess.ProcessName.ToString().ToUpper().Contains(process.ToUpper()))
                {
                    Console.WriteLine("Process: {0} ID: {1}", currentProcess.ProcessName, currentProcess.Id);
                    currentProcess.Kill();
                }
            }
        }

        private void closeEmail()
        {
            endProcess("outlook");
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void george_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void minimize()
        {
            this.WindowState = FormWindowState.Minimized;
            georgeApp.Icon = SystemIcons.Application;
            georgeApp.BalloonTipTitle = "george";
            georgeApp.BalloonTipText = "Running in background";
            georgeApp.ShowBalloonTip(1500);
            georgeApp.Visible = true;
        }
            

        private void normalSize()
        {
            this.WindowState = FormWindowState.Normal;
            georgeApp.Visible = false;
        }

        private void georgeApp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            normalSize();
            georgeApp.Visible = false;
        }

        private void george_FormClosing(object sender, FormClosingEventArgs e)
        {
            speak.closing();
        }

        private void elementHost2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.minimize();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Websearch f2 = new Websearch();
            f2.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FrmPrincipal f2 = new FrmPrincipal();
            f2.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
