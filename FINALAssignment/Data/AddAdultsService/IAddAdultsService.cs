using System.Collections.Generic;
using Models;

namespace FINALAssignment.Data.AddAdultsService
{
    public interface IAddAdultsService
    {
        void AddAdult(Adult adult);

        IList<Adult> GetAdults();
        void RemoveAdult(Adult adult);
        // void EditAdult(Adult adult);
        // Adult GetAdult(int adultID);
    }
}