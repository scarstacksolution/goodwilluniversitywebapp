using Aug31_Ver1_WebAp.Interfaces;
using Aug31_Ver1_WebAp.Models;

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
            var _employees = new List<Person>();

            IEnumerable<Person> employees = (IQueryable<Person>)_context.Person
                .OrderBy(e => e.id);
            //.AsNoTracking(); 

            foreach (var employee in employees)
            {
                _employees.Add(employee);
            }

            var data = _employees;

            Person person = _context.Person.First(e => e.id == id);
            return person;
        }

    }
}

