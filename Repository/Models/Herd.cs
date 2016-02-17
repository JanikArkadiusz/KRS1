using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public class Herd
    {
        public string HerdId { get; set; }
        public string Type { get; set; }
        public string Localization { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}