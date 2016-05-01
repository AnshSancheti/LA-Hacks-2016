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
            CustomEvent custom = new CustomEvent(tbEventName.Text, tbEventLocation.Text, priority, length);
            customEvents.Add(custom);
            tbEventLength.Clear();
            tbEventName.Clear();
            tbEventLocation.Clear();
            tbPriority.Clear();
            MessageBox.Show("Event added successfully!");
               

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
            Form2 form2 = new Form2();
            MessageBox.Show("Connecting to Internet");
            form2.getEvents(customEvents);
            form2.Show();
        }
    }
}
