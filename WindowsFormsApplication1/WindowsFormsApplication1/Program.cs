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

        /*
        Gets the next free time based off of the priority and next free time.
        */
        public EventDateTime getStartTime()
        {
            return null;
        }

        public void addNewEvent(String summary, String location, EventDateTime startDate, EventDateTime endDate)
        {
            getStartTime();

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
                Start = startDate, /* new EventDateTime()
                {
                    DateTime = new DateTime(2014, 6, 2, 10, 0, 0),
                    TimeZone = "America/Los_Angeles"
                }*/
                End = endDate /* new EventDateTime()
                {
                    DateTime = new DateTime(2014, 6, 2, 10, 30, 0),
                    TimeZone = "America/Los_Angeles"
                },*/
                /*Recurrence = recurrence, new String[] {
                    "RRULE:FREQ=WEEKLY;BYDAY=MO"
                },
                Attendees = new List<EventAttendee>()
                {
                    new EventAttendee() { Email = "johndoe@gmail.com" }
                }*/
            };

            myEvent = service.Events.Insert(myEvent, "primary").Execute();
            //Event recurringEvent = Events.Insert(myEvent, "primary").Execute();
        }
    }
}