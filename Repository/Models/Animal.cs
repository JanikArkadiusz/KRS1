using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public abstract class Animal
    {
        public int AnimalId { get; set; }
        public string Comments { get; set; }

        public abstract void LiveHerd();
        public abstract void ComeToHerd();

        public virtual ICollection<AnEvent> AnEvent { get; set; }
        public virtual Herd Herd {get; set;}
    }
}