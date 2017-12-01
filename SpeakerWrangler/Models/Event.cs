using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakerWrangler.Models
{
    public class Event
    {
        public int ID { get; set; }

        public string EventName { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string VenueName { get; set; }

        public string CityStateRegion { get; set; }

        public string Country { get; set; }

        public string LocaleZipCode { get; set; }

        public string LinkToMap { get; set; }

        public string ContactEmail { get; set; }

        public string URL { get; set; }

        public string Twitter { get; set; }

        public string SessionLength { get; set; }

        public string SessionTypes { get; set; }

    }
}
