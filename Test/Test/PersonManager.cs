using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
  public class PersonManager
  {
    private List<Person> people;

    public PersonManager()
    {
      people = new List<Person>();
    }

    public void AddPerson(Person person)
    {
      people.Add(person);
    }

    public void ListPeople()
    {
      people.ForEach(p => Console.WriteLine("{0} {1}", p.FirstName, p.LastName));
    }
  }
}
