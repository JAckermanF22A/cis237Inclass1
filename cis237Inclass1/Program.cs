using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("David", "Barnes", 25);

            person.PrintFullName();

            PersonCollection personCollection = new PersonCollection();

            personCollection.addPerson(person);

            personCollection.addPerson(new Person("Not", "DeclaredFirst", 34));

            Console.WriteLine(personCollection.getPersonCollectionToString());

            Console.WriteLine("Branchsona! Ziodyne!");

            Console.WriteLine("");
            Console.WriteLine("Branch Mage used Branchraga.");
        }
    }
}
