using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Student
    {
        private String firstName;
        private String lastName;
        private int age;

        public Student(String fName,String lName,int sAge)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.age = sAge;
        }

        public String getFirstName()
        {
            return this.firstName;
        }

        public String getLasttName()
        {
            return this.lastName;
        }

        public int getAge()
        {
            return this.age;
        }
    }
}
