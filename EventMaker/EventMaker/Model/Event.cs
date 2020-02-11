using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    public class Event
    {
        private int _ID;
        private string _Name;
        private string _Description;
        private string _Place;
        private DateTime _DateTime;

        public Event(int id, string name, string description, string place, DateTime dateTime)
        {
            _ID = id;
            _Name = name;
            _Description = description;
            _Place = place;
            _DateTime = dateTime;
        }

        public int Id
        {
            get { return _ID; }
        }

        public string Name
        {
            get { return _Name; }
        }

        public string Description
        {
            get { return _Description; }
        }

        public string Place
        {
            get { return _Place; }
        }

        public DateTime DateTime
        {
            get { return _DateTime; }
        }

        public override string ToString()
        {
            return $"Event:" + Id + " " + Name + " " + Description + " " + Place + " " + DateTime + " " ;
        }
    }
}
