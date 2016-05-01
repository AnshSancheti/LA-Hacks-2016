using CalendarQuickstart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        
        List<CustomEvent> customEvents = new List<CustomEvent>();
        List<CustomEvent> userInputEvent = new List<CustomEvent>();

        Dictionary<string, ListViewItem> timeToListView = new Dictionary<string, ListViewItem>();
        public Form2()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        internal void getEvents(List<CustomEvent> c)
        {
            customEvents = c;
        }

        private void addToDictionary()
        {
            timeToListView.Add("8:00:00 AM", listView1.Items[0]);
            timeToListView.Add("8:30:00 AM", listView1.Items[1]);
            timeToListView.Add("9:00:00 AM", listView1.Items[2]);
            timeToListView.Add("9:30:00 AM", listView1.Items[3]);
            timeToListView.Add("10:00:00 AM", listView1.Items[4]);
            timeToListView.Add("10:30:00 AM", listView1.Items[5]);
            timeToListView.Add("11:00:00 AM", listView1.Items[6]);
            timeToListView.Add("11:30:00 AM", listView1.Items[7]);
            timeToListView.Add("12:00:00 PM", listView1.Items[8]);
            timeToListView.Add("12:30:00 PM", listView1.Items[9]);
            timeToListView.Add("1:00:00 PM", listView1.Items[10]);
            timeToListView.Add("1:30:00 PM", listView1.Items[11]);
            timeToListView.Add("2:00:00 PM", listView1.Items[12]);
            timeToListView.Add("2:30:00 PM", listView1.Items[13]);
            timeToListView.Add("3:00:00 PM", listView1.Items[14]);
            timeToListView.Add("3:30:00 PM", listView1.Items[15]);
            timeToListView.Add("4:00:00 PM", listView1.Items[16]);
            timeToListView.Add("4:30:00 PM", listView1.Items[17]);
            timeToListView.Add("5:00:00 PM", listView1.Items[18]);
            timeToListView.Add("5:30:00 PM", listView1.Items[19]);
            timeToListView.Add("6:00:00 PM", listView1.Items[20]);
            timeToListView.Add("6:30:00 PM", listView1.Items[21]);
            timeToListView.Add("7:00:00 PM", listView1.Items[22]);
            timeToListView.Add("7:30:00 PM", listView1.Items[23]);
            timeToListView.Add("8:00:00 PM", listView1.Items[24]);
            timeToListView.Add("8:30:00 PM", listView1.Items[25]);
            timeToListView.Add("9:00:00 PM", listView1.Items[26]);
            timeToListView.Add("9:30:00 PM", listView1.Items[27]);
            timeToListView.Add("10:00:00 PM", listView1.Items[28]);
            timeToListView.Add("10:30:00 PM", listView1.Items[29]);
            timeToListView.Add("11:00:00 PM", listView1.Items[30]);
            timeToListView.Add("11:30:00 PM", listView1.Items[31]);
            timeToListView.Add("12:00:00 AM", listView1.Items[32]);
            timeToListView.Add("12:30:00 AM", listView1.Items[33]);
            timeToListView.Add("1:00:00 AM", listView1.Items[34]);
            timeToListView.Add("1:30:00 AM", listView1.Items[35]);
            timeToListView.Add("2:00:00 AM", listView1.Items[36]);
            timeToListView.Add("2:30:00 AM", listView1.Items[37]);
            timeToListView.Add("3:00:00 AM", listView1.Items[38]);
            timeToListView.Add("3:30:00 AM", listView1.Items[39]);
            timeToListView.Add("4:00:00 AM", listView1.Items[40]);
            timeToListView.Add("4:30:00 AM", listView1.Items[41]);
            timeToListView.Add("5:00:00 AM", listView1.Items[42]);
            timeToListView.Add("5:30:00 AM", listView1.Items[43]);
            timeToListView.Add("6:00:00 AM", listView1.Items[44]);
            timeToListView.Add("6:30:00 AM", listView1.Items[45]);
            timeToListView.Add("7:00:00 AM", listView1.Items[46]);
            timeToListView.Add("7:30:00 AM", listView1.Items[47]);

        }
        internal void AddUserInputEvents(List<CustomEvent> e)
        {
            userInputEvent = e;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            addToDictionary();
            Program prg = new Program();
            
            List<string> events = new List<string>();
            List<string> loc = new List<string>();
            //prg.addEvent();
            List<string> start = new List<string>();
            List<string> end = new List<string>();
            List<CustomEvent> c = new List<CustomEvent>();
            List<string> dayofweek = new List<string>();
            List<double> duration = new List<double>();


            //////////////////////////////////////
            //Gets current google calendar events
            List<CustomEvent> currentEvents = prg.getEvent(events, loc, start, end,dayofweek,duration);

            foreach( CustomEvent x in currentEvents) 
            {
                Console.WriteLine(x.getEventName());
            }
            for (int i = 0; i < events.Count; i++)
            {
                
                CustomEvent ev = new CustomEvent(events[i], loc[i], null, null);
                string day = dayofweek[i];
                int dayOfWeekInt = 0;
                switch (day)
                {
                    case "Sunday":
                        dayOfWeekInt = 1;
                        break;
                    case "Monday":
                        dayOfWeekInt = 2;
                        break;
                    case "Tuesday":
                        dayOfWeekInt = 3;
                        break;
                    case "Wednesday":
                        dayOfWeekInt = 4;
                        break;
                    case "Thursday":
                        dayOfWeekInt = 5;
                        break;
                    case "Friday":
                        dayOfWeekInt = 6;
                        break;
                    case "Saturday":
                        dayOfWeekInt = 7;
                        break;
                }
                string time = start[i].ToString().Split(' ')[1] + " " + start[i].ToString().Split(' ')[2];
                timeToListView[time].SubItems[dayOfWeekInt].Text = events[i];

                for (int j = 1; j < duration[i]; j++)
                {
                    time = dateIncrementer(time);
                    timeToListView[time].SubItems[dayOfWeekInt].Text = events[i];

                }


            }

            
        }
    
        private string dateIncrementer(string time)
        {
            StringBuilder timebuilder = new StringBuilder(time);
            //special cases
            if (time == "11:30:00 AM")
            {
                time = "12:00:00 PM";
                return time;
            }
            if (time == "11:30:00 PM")
            {
                time = "12:00:00 AM";
                return time;
            }
            if (time == "9:30:00 AM")
            {
                time = "10:00:00 AM";
                return time;
            }
            if (time == "9:30:00 PM")
            {
                time = "10:00:00 PM";
                return time;
            }
            if (time == "12:30:00 AM")
            {
                time = "1:00:00 AM";
                return time;
            }
            if (time == "12:30:00 PM")
            {
                time = "1:00:00 PM";
                return time;
            }
            

            if (time[0] == '1' && time[1] != ':')
            {
                if (time[3] == '0')
                {
                    timebuilder[3] = '3';
                }
                else if (time[3] == '3')
                {
                    timebuilder[1] = (char)((int)Char.GetNumericValue(time[0]) + 1+48);
                    timebuilder[3] = '0';
                    
                }
                return timebuilder.ToString();
            }
            else
            {
                if (time[2] == '0')
                {
                    
                    timebuilder[2] = '3';
                }
                else if (time[2] == '3')
                {
                    
                    

                    timebuilder[0] = Convert.ToChar((int) (Char.GetNumericValue(time[0]) + 1+48));
                    timebuilder[2] = '0';

                }
                return timebuilder.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
