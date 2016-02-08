using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models
{
  
    
    public abstract class AnEvent
    {
        public ulong AnEventID { get; set; }
        public DateTime EventDate { get; set; }
        public Herd FromHerd { get; set; }
        public Herd DestinationHerd { get; set; }

        protected Dictionary<string, string> EventType = new Dictionary<string, string>();

        List<Animal> Animals = new List<Animal>();
        
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

 