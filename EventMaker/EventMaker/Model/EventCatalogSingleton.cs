using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;
using Windows.ApplicationModel.Store.Preview.InstallControl;

namespace EventMaker.Model
{
    public class EventCatalogSingleton
    {

        public ObservableCollection<Event> Events { get; set; }
        private static EventCatalogSingleton _instance;

        public static EventCatalogSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EventCatalogSingleton();
                }

                return _instance;
            }

            /*get
            {
                return  _instance ?? new EventCatalogSingleton();
               
            }*/
        }

        private EventCatalogSingleton()
        {
            Events = new ObservableCollection<Event>();
            Events.Add(new Event(1,"Patrick","Den er go fin","Næstved", DateTime.Now));
            Events.Add(new Event(2,"Saad","Muskuløs", "Køge", DateTime.Today));
        }



        public void addEvent(Event newEvent)
        {
            Events.Add(newEvent);
        }

        
    }
}
