using Aug31_Ver1_WebAp.Interfaces;
using Aug31_Ver1_WebAp.Models;
using Microsoft.EntityFrameworkCore;

namespace Aug31_Ver1_WebAp.UnitOfWorkPattern
{
	public class PersonRepository : IPersonRepository
	{
        // Field Properties
        private readonly ApplicationDbContext _context;


        // Constuctor
        public PersonRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Methods

        /// <summary>
        /// Gets a Student information based on Student ID
        /// </summary>
        /// <returns></returns>
        public Person GetPersonById(int id)
        {
            Person person = _context.Person.First(e => e.id == id);
            return person;
        }

    }
}

