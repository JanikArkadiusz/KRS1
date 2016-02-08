using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
 
    public interface IRepository
    {
        void Create();
        void Remove();
        void Update();
        void Delete();
       
        /*
         * Create
         * Remove
         * Update
         * Delete
         * NumberCheck
         * 
         * 
         */
    }

    public interface IAnimalRepository
    {
        bool CheckControlDigit();
    }
}
