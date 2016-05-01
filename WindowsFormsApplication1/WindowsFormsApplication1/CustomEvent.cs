using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CustomEvent
    {

        private string eventName;
        private string location;
        private int priority;
        private int length;
        private DateTime startDate;
        private DateTime endDate;

        /*public CustomEvent(string e, string l, int p, int le)
        {
            eventName = e;
            location = l;
            priority = p;
            length = le;
        }*/

        public CustomEvent(string eventName, string location, DateTime value, int priority, int length)
        {
            this.eventName = eventName;
            this.location = location;
            this.startDate = new DateTime();
            this.endDate = value;
            this.priority = priority;
            this.length = length;
        }

        //Constructor for google calendar event
        public CustomEvent(string eventName, string location, DateTime? startDate, DateTime? endDate)
        {
            this.eventName = eventName;
            this.location = location;

            if (!startDate.HasValue) this.startDate = new DateTime();
            else this.startDate = startDate.Value;

            if (!endDate.HasValue) this.endDate = new DateTime();
            else this.endDate = endDate.Value;
            this.priority = 1;
            this.length = 0;
        }

        public string getEventName()
        {
            return eventName;
        }
        public string getLocation()
        {
            return location;
        }

        public int getPriority()
        {
            return priority;

        }
        public int getLength()
        {
            return length;
        }

        public DateTime getDateTime()
        {
            return endDate;
        }
    }
}
