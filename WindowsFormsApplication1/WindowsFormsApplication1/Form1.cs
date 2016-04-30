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
        public Schedlr()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program prg = new Program();
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

        }
    }
}
