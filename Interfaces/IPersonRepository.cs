
using Aug31_Ver1_WebAp.Models;

namespace Aug31_Ver1_WebAp.Interfaces
{
	public interface IPersonRepository
	{
        public Person GetPersonById(int id);
    }
}

