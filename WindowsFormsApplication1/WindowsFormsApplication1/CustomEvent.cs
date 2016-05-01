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
        private string text1;
        private string text2;
        private string text3;
        private DateTime value;

        public CustomEvent(string e, string l, int p, int le)
        {
            eventName = e;
            location = l;
            priority = p;
            length = le;
        }

        public CustomEvent(string eventName, string location, DateTime value, int priority, int length)
        {
            this.eventName = eventName;
            this.location = location;
            this.value = value;
            this.priority = priority;
            this.length = length;
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
            return value;
        }
    }
}
