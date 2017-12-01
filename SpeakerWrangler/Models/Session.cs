using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakerWrangler.Models
{
    public class Session
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Level { get; set; }

        public string SessionType { get; set; }

        public string Abstract { get; set; }

    }
}
