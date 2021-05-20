using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace george
{
    public class Speak
    {
        SpeechSynthesizer george = new SpeechSynthesizer();
        public void noOptionAvailable()
        {
            george.Speak("There is currently no command for this");
        }


        public void ELZA()
        {
            george.Speak("BAS YA BABA EGRY MEN HENA");
        }
        //Say opening file as well
        public void askForFilename()
        {
            george.Speak("What file are you looking for?");
        }

        public void sayAppointment(string[] whatToSay)
        {
            //whatToSay[0] = index
            //whatToSay[1] = Subject
            //whatToSay[2] = Date       
            string[] date = whatToSay[2].Split('/');
            string newDate = date[1] + "/" + date[0];
            //whatToSay[3] = Time
            string[] time = whatToSay[3].Split(':');
            string newTime = time[0] + ":" + time[1];
            //whatToSay[4] = Location

            PromptBuilder appointmentBuilder = new PromptBuilder();
            appointmentBuilder.StartVoice("IVONA 2 Brian");
            appointmentBuilder.AppendText("Appointment " + whatToSay[0]);
            appointmentBuilder.AppendText(", subject is: " + whatToSay[1]);
            appointmentBuilder.AppendSsmlMarkup(", on <say-as interpret-as=\"date_md\">" + newDate + "</say-as>");
            appointmentBuilder.AppendSsmlMarkup(" <say-as interpret-as=\"time\">" + newTime + "</say-as>");
            appointmentBuilder.AppendText(", at " + whatToSay[4]);
            appointmentBuilder.EndVoice();

            george.Speak(appointmentBuilder);
            appointmentBuilder.ClearContent();
        }

        public void sayAppointmentError()
        {
            george.Speak("No Appointments found for the next 7 days.");
        }

        public void searchFor()
        {
            george.Speak("What do you want to search for?");
        }

        public void currentTime()
        {
            string timeString = DateTime.Now.ToShortTimeString();
            PromptBuilder timeBuilder = new PromptBuilder();
            timeBuilder.StartVoice("IVONA 2 Brian");
            timeBuilder.AppendText("The time is: ");
            timeBuilder.AppendSsmlMarkup(" <say-as interpret-as=\"time\">" + timeString + "</say-as>");
            timeBuilder.EndVoice();

            george.Speak(timeBuilder);
        }

        public void currentDate()
        {
            string dateString = DateTime.Now.ToShortDateString();
            PromptBuilder dateBuilder = new PromptBuilder();
            dateBuilder.StartVoice("IVONA 2 Brian");
            dateBuilder.AppendText("The date is: ");
            dateBuilder.AppendSsmlMarkup(" <say-as interpret-as=\"date_md\">" + dateString + "</say-as>");
            dateBuilder.EndVoice();

            george.Speak(dateBuilder);
        }

        public void hello()
        {
            DateTime timeNow = DateTime.Now;
            string username = Environment.UserName;
            if (timeNow.Hour >= 0 && timeNow.Hour < 12)
            {
                george.Speak("Good morning " + username);
            }
            else if (timeNow.Hour >= 12 && timeNow.Hour < 18)
            {
                george.Speak("Good afternoon " + username);
            }
            else if (timeNow.Hour >= 18 && timeNow.Hour < 24)
            {
                george.Speak("Good evening " + username);
            }
        }

        public void sayForecast(string[] conditions)
        {
            george.Speak("Tomorrows forecast is " + conditions[5] + " with highs of " + conditions[6] + " and lows of " + conditions[7]);
        }

        public void sayWeather(string[] conditions)
        {
            PromptBuilder builder = new PromptBuilder();
            builder.StartVoice("IVONA 2 Brian");
            builder.AppendText("The weather in hale sowen is " + conditions[0] + " at " + conditions[1] + " degrees. There is a wind speed of " + conditions[2] + " miles per hour with highs of " + conditions[3] + " and lows of " + conditions[4]);
            builder.EndVoice();
            george.Speak(builder);
        }

        public void loading()
        {
            george.Speak("Loading, Please hold");
        }

        int originalVolume = 50;
        public void georgeMute(bool mute)
        {
            if (mute)
            {
                george.Speak("Muting");
                originalVolume = george.Volume;
                george.Volume = 0;
            }
            else
            {
                george.Volume = originalVolume;
                george.Speak("Volume levels restored");
            }
        }


        public void georgeVol(bool sh)
        {
            int volume = george.Volume;
            if (sh)
            {
                if (george.Volume == 0 || (george.Volume - 20) < 0)
                {
                    george.Volume = 20;
                    george.Speak("Muted");
                    george.Volume = 0;
                }
                else
                {
                    george.Volume -= 20;
                    george.Speak("Volume decreased");
                }
            }
            else
            {
                if (george.Volume == 100 || (george.Volume + 20) > 100)
                {
                    george.Speak("I cannot get any louder");
                }
                else
                {
                    george.Volume += 20;
                    george.Speak("Volume increased");
                }
            }
        }

        public void tooManyRecipients()
        {
            george.Speak("Maximum number of recipients added");
        }

        public void closing()
        {
            george.SpeakAsyncCancelAll();
            george.Dispose();
        }

    }
}
