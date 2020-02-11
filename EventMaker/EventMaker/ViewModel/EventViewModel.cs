using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Model;

namespace EventMaker.ViewModel
{
    public class EventViewModel
    {
        //private int _ID;
        //private string _Name;
        //private string _Description;
        //private string _Place;
        //private DateTime _DateTime;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTimeOffset Date { get; set; }
        public TimeSpan Time { get; set; }

        public EventCatalogSingleton EventCatalogSingleton { get; set; }

        public EventCatalogSingleton CatalogSingleton
        {
           get { return CatalogSingleton; }
        }

        public EventViewModel()
        {
            EventCatalogSingleton = EventCatalogSingleton.Instance;
            DateTime dt = System.DateTime.Now;
            Date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute,0,0,new TimeSpan());
            Time = new TimeSpan(dt.Hour, dt.Minute,dt.Second);
        }


       

        
        


    }
}
