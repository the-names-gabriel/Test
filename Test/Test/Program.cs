using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("I'm a test!");

      var pm = new PersonManager();
      pm.AddPerson(new Person("John", "Doe"));
      pm.AddPerson(new Person("Jane", "Doe"));
      pm.ListPeople();
    }
  }
}
