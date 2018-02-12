using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI234_Exercise_17_4_Schmidt
{
    [Serializable]
    class StudentData
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ID { get; set; }
        public string StudentClass { get; set; }
        public string Grade { get; set; }

        public StudentData()
        
            :this(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty)
        { 
        }
        public StudentData(string lastName, string firstName, string id, string studentClass, string grade)
        {
            LastName = lastName;
            FirstName = firstName;
            ID = id;
            StudentClass = studentClass;
            Grade = grade;
        }

    }
}
