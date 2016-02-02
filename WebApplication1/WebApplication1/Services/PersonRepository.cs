using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using WebApplication1.ViewModels;

namespace WebApplication1.Services
{
    public class PersonRepository : IPersonRepository
    {
        private WebAppContext db;

        public PersonRepository()
        {
            db = new WebAppContext();

        }
        public IEnumerable<Person> getAllPeople()
        {
            return db.People.ToList();
        }

        public Person getPersonById(int PersonID)
        {
            var person = db.People.Find(PersonID);
            return person;
        }
    }
}