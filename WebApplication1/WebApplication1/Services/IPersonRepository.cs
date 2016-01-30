using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Services
{
    interface IPersonRepository
    {
        IEnumerable<Person> getAllPeople();
        PersonVM getPersonById(int PersonID);





     
    }
}
