using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest
{
    class Poule
    {

        List<Person> personList;
        public Poule()
        {
            personList = new List<Person>();
        }

        public void addJudoka(Person person)
        {
            personList.Add(person);
        }

        public List<Person> getPersonList()
        {
            return personList;
        }
    }
}
