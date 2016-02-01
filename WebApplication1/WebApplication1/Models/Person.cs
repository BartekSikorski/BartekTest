using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Person
    {
        public Person()
        {
            Addresses = new HashSet<Address>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }


    }
}