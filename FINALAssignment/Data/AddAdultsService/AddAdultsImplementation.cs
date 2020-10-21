using System.Collections.Generic;
using System.Linq;
using FileData;
using Models;

namespace FINALAssignment.Data.AddAdultsService
{
    public class AddAdultsImplementation : IAddAdultsService
    {
        private FileContext _fileContext = new FileContext();
        
        
        public void AddAdult(Adult adult)
        {
            _fileContext.Adults.Add(adult);
            _fileContext.SaveChanges();
        }

        public IList<Adult> GetAdults()
        {
            return _fileContext.Adults;
        }

        public void RemoveAdult(Adult adult)
        { 
            _fileContext.Adults.Remove(adult);
            _fileContext.SaveChanges();
        }

        // public void EditAdult(Adult adult)
        // {
        //     Adult adultToEdit = GetAdults().First(a => a.Id == adult.Id);
        //     adultToEdit.JobTitle = adult.JobTitle;
        //     adultToEdit.Age = adult.Age;
        //     adultToEdit.Height = adult.Height;
        //     adultToEdit.EyeColor = adult.EyeColor;
        //     adultToEdit.HairColor = adult.HairColor;
        //     _fileContext.SaveChanges();
        // }
    }
}