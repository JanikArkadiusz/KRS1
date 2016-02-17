using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public enum Gender
    {
        male, fimale
    }

    public class IndividuallyRegisteredAnimals : Animal
    {
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Breed Breed { get; set; }
        public string MatherID { get; set; }
        public string FatherID { get; set; }
        public DateTime ComeDate { get; set; }
        public DateTime LeaveDate { get; set; }

        public override void LiveHerd()
        {
            throw new NotImplementedException();
        }
        public override void ComeToHerd()
        {
            throw new NotImplementedException();
        }
    }



}

