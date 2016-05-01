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
    public partial class Schedlr : Form
    {
        List<CustomEvent> customEvents = new List<CustomEvent>();
        
        public Schedlr()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Program prg = new Program();
            List<string> events = new List<string>();
            List<string> loc = new List<string>();
            //prg.addEvent();
            List<string> start = new List<string>();
            List<string> end = new List<string>();
            prg.getEvent(events, loc, start, end);
            for (int i = 0; i < events.Count; i++)
            {
                MessageBox.Show(events[i]);
            }
            */
            int length;
            int priority;
            try
            {
                length = Int32.Parse(tbEventLength.Text);
                priority = Int32.Parse(tbPriority.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number for priority and event length!");
                return;
            }
            if (priority > 10 || priority < 1)
            {
                MessageBox.Show("Priority should be between 1 and 10!");
                return;
            }
            if (length > 1440 || length < 0)
            {
                MessageBox.Show("Please constrain the event time within a day.");
                return;
            }
            if (tbEventName.Text == "")
            {
                MessageBox.Show("Please enter an event name");
                return;
            }
            CustomEvent custom = new CustomEvent(tbEventName.Text, tbEventLocation.Text, dtDueDate.Value, priority, length);
            customEvents.Add(custom);
            tbEventLength.Clear();
            tbEventName.Clear();
            tbEventLocation.Clear();
            tbPriority.Clear();
            MessageBox.Show("Event added successfully!");

            Program prg = new Program();

            /*List<CustomEvent> x = new List<CustomEvent>();
            x.Add(new CustomEvent("event 1", "here", new DateTime(2000, 12, 23), 1, 60));
            x.Add(new CustomEvent("event 2", "here", new DateTime(2000, 12, 23), 6, 60));
            x.Add(new CustomEvent("event 3", "here", new DateTime(2000, 12, 23), 2, 60));
            x.Add(new CustomEvent("event 4", "here", new DateTime(2000, 12, 24), 9, 60));
            x.Add(new CustomEvent("event 5", "here", new DateTime(2000, 12, 24), 3, 60));
            x.Add(new CustomEvent("event 6", "here", new DateTime(2000, 12, 24), 5, 60));*/

            //prg.sortEvents(x);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void tbPriority_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEventName_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            List<CustomEvent> currentCalender = new List<CustomEvent>();
            Form2 form2 = new Form2();

            Program prg = new Program();

            MessageBox.Show("Connecting to Internet");
            
            //Sorts events
            customEvents = prg.sortEvents(customEvents);
            form2.AddUserInputEvents(customEvents);


            //prg.addSortedEvents(customEvents,)
            form2.Show();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
