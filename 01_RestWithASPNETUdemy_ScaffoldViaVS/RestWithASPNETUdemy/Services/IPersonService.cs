using RestWithASPNETUdemy.Model;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RestWithASPNETUdemy.Services
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person FindByID(long id);

        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long id);

    }
}
