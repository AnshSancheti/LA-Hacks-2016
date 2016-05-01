/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Schedlr());
        }
    }
}*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Text;
using System.Threading;
using WindowsFormsApplication1;

namespace CalendarQuickstart
{
    class Program
    {

        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/calendar-dotnet-quickstart.json
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Google Calendar API .NET Quickstart";
        
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Schedlr());
            
        }

        public void addEvent(String summary, String location, EventDateTime startTime, EventDateTime endTime)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/calendar-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            Event myEvent = new Event
            {
                Summary = summary,
                Location = location,
                Start = startTime, /*new EventDateTime()
                {
                    DateTime = new DateTime(2014, 6, 2, 10, 0, 0),
                    TimeZone = "America/Los_Angeles"
                }*/
                End = endTime /*new EventDateTime()
                {
                    DateTime = new DateTime(2014, 6, 2, 10, 30, 0),
                    TimeZone = "America/Los_Angeles"
                }*/
            };

            Event recurringEvent = service.Events.Insert(myEvent, "primary").Execute();
        }

        public void getEvent(List<string> eventlist, List<string> location, List<string> starttime, List<string> endtime, List<string> dayOfWeek)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/calendar-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            Console.WriteLine("Upcoming events:");
            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {
                    string when = eventItem.Start.DateTime.ToString();
                    string end = eventItem.End.DateTime.ToString();
                    string loc = " ";
                    

                    if (eventItem.Location != null)
                    {
                        loc = eventItem.Location.ToString();

                    }
                    
                    if (String.IsNullOrEmpty(when))
                    {
                        
                        when = eventItem.Start.Date;
                        end = eventItem.End.Date;


                    }
                    DateTime datevaluewhen = new DateTime(Int32.Parse(when.Split(' ')[0].Split('/')[2]), Int32.Parse(when.Split(' ')[0].Split('/')[0]), Int32.Parse(when.Split(' ')[0].Split('/')[1]));
                    DateTime datevalueend = new DateTime(Int32.Parse(end.Split(' ')[0].Split('/')[2]), Int32.Parse(end.Split(' ')[0].Split('/')[0]), Int32.Parse(end.Split(' ')[0].Split('/')[1]));
                    eventlist.Add(eventItem.Summary);
                    dayOfWeek.Add(datevaluewhen.DayOfWeek.ToString());
                    starttime.Add(when);
                    endtime.Add(end);
                    location.Add(loc);

                }
            }
            else
            {
            }
            

            //myEvent.
            //Event recurringEvent = Events.Insert(myEvent, "primary").Execute();
        }

        public List<CustomEvent> sortEvents(List<CustomEvent> toBeAdded)
        {
            toBeAdded.Sort(delegate(CustomEvent x, CustomEvent y)
            {
                if (x.getDateTime() == null && y.getDateTime() == null) return 0;
                else if (x.getDateTime() == null) return -1;
                else if (y.getDateTime() == null) return 1;
                else return x.getDateTime().CompareTo(y.getDateTime());
            });

            /*foreach(CustomEvent x in toBeAdded)
            {
                Console.WriteLine(x.getEventName());
            }*/

            int count = 1;
            CustomEventComparer cec = new CustomEventComparer();

            //foreach(CustomEvent x in toBeAdded)
            for(int i = 0; i < toBeAdded.Count; i+=count)
            {
                count = 1;
                //foreach(CustomEvent y in toBeAdded)
                for (int j = i+1; j <toBeAdded.Count; j++)
                {
                    if(toBeAdded[i].getDateTime().Equals(toBeAdded[j].getDateTime()))
                    {
                        count++;
                    }
                }

                if(count > 1)
                {
                    toBeAdded.Sort(i, count, cec);
                }
            }

            foreach(CustomEvent x in toBeAdded)
            {
                Console.WriteLine(x.getEventName());
            }
            return toBeAdded;
        }

        public void ac()
        {

        }

    }

}