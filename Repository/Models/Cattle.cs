using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository.Models;

namespace Repository.Models
{
    public enum Gender
    {
        male, fimale
    }



    public class Cattle : IndividuallyRegisteredAnimals,IRepository
    {
        public string CattleID { get; set; }
      
        public string ComeFromHerd { get; set; }
        public string DestinationHerd { get; set; }
        public string PresentHerd { get; set; }

        public void Create() { throw new NotImplementedException(); }
        public void Remove() { throw new NotImplementedException(); }
        public void Update() { throw new NotImplementedException(); }
        public void Delete() { throw new NotImplementedException(); }
       
        public bool CheckControlDigit()
        {
            //ARiMR przewidziało tylko kontrolę dla polskich oznaczeń bydła             
            if (CattleID.Substring(0, 2).Equals("PL"))
            {
                return ControlNumber.CheckCattleControlDigit(CattleID);
            }//sztuki zaczynające się inaczej niż "PL" nie zostaną poddane weryfikacji cyfry kontrolnej
            else
                return true;    
        }
       


    }

}