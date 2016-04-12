using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest
{
    public class WedstrijdList
    {
        List<Person> personList;
        List<Wedstrijd> wedstrijdList;
        public WedstrijdList()
        {
            personList = new List<Person>();
            wedstrijdList = new List<Wedstrijd>();
        }

        public void getPersonsFromPoule(Poule poule)
        {
            personList = poule.getPersonList();
        }

        public void createWedstrijden()
        {
            if (personList.Count < 2)
                return;
            else
            {

            }
        }

    }
}
