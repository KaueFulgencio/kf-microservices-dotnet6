using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementations : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(Person person)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Kauana",
                LastName = "Costa",
                Address = "Santa Helena - Parana - Brasil",
                Gender = "Female"
            };

        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),

                FirstName = "Person Name" + i,

                LastName = "Person Last Name" + i,

                Address = "Some Address" + i,

                Gender = "Female" + i
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        void IPersonService.Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
