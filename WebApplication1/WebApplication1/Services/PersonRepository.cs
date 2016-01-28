using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace WebApplication1.Services
{
    public class PersonRepository : IPersonRepository
    {
        private WebAppContext db;

        public PersonRepository()
        {
            db = new WebAppContext();

    }
    public IEnumerable<PersonVM> getAllPeople()
        {
          

            return db.People.Select(p => new PersonVM
            {
                Firstname = p.FirsName,
                Surname = p.Surname,
                Birthdate = p.Birthdate,
                Addresses = p.Addresses.Select(a => new AddressVM
                {
                    City = a.City,
                    HouseNo = a.HouseNo,
                    FlatNo = a.FlatNo,
                    Street = a.Street,
                    ZipCode = a.ZipCode

                }).ToList()
            });
  
        }

        public PersonVM getPersonById(int PersonID)
        {
            throw new NotImplementedException();
        }
    }
}