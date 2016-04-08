using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest
{
    
    class Person
    {
        String firstName;
        String middleName;
        String lastName;
        public Person()
        {

        }

        public String getName()
        {
            String Name;
            if (middleName != null)
                Name = firstName + ' ' + middleName + ' ' + lastName;
            else
                Name = firstName + ' ' + lastName; 
            return Name;
        }

        public void setName(String firstName, String middleName, String lastName)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }

        public void setName(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
