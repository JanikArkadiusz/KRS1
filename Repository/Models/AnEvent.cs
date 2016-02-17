using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Repository.Models
{   
    public abstract class AnEvent
    {
        public long AnEventId { get; set; }
        public DateTime EventDate { get; set; }
        protected Dictionary<string, string> EventType = new Dictionary<string, string>();

        [ForeignKey("FromHerd"), Column(Order = 0)]
        public string FromHerdId { get; set; }
        [ForeignKey("DestinationHerd"), Column(Order = 1)]
        public string DestinationHerdId { get; set; }
        
      
        public virtual ICollection<Animal> Animals { get; set; }
        public virtual Herd FromHerd { get; set; }
        public virtual Herd DestinationHerd { get; set; }
     //   
        public AnEvent()
        {
            EventTypeSeed();
        }

 
        private void EventTypeSeed()
        {
            EventType.Add("U", "urodzenie zwierzęcia");
            EventType.Add("Do", "przemieszczenie \"do\" siedziby stada");
            EventType.Add("Z", "przemieszczenie \"z\" siedziby stada");
            EventType.Add("P", "wwóz na terytorium Rzeczypospolitej Polskiej");
            EventType.Add("W", "wywóz poza terytorium Rzeczypospolitej Polskiej");
            EventType.Add("PD", "padnięcie zwierzęcia");
            EventType.Add("ZN", "zabicie zwierzęcia z nakazu Inspekcji Weterynaryjnej");
            EventType.Add("UG", "ubój zwierzęcia w gospodarstwie");
        }

    }

 
}

 