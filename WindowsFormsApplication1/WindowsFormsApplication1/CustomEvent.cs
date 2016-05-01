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
        public string start;
        public string end;
        public CustomEvent(string e, string l, int p, int le)
        {
            eventName = e;
            location = l;
            priority = p;
            length = le;
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
    }
}
