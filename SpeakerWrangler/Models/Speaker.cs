using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakerWrangler.Models
{
    public class Speaker
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Blog { get; set; }

        public string Twitter { get; set; }

        public string LinkedIn { get; set; }

        public string GitHub { get; set; }

        public string Location { get; set; }

        public string ShirtSize { get; set; }

        public string DietaryNeeds { get; set; }

        public string Bio { get; set; }

        public byte[] Image { get; set; }
    }
}
