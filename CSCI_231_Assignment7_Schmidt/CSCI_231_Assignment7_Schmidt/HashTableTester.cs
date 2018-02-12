using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI_231_Assignment7_Schmidt
{
    class HashTableTester
    {
        public class student
        {
            private string studentId;
            private string name;
            private string GPA;
            private string major;
            private string email;

            public student(string v_studentID)
            {
                studentId = v_studentID;
                name = "Fred";
                GPA = "1";
                major = "Liberal Arts";
                email = "Somethingkool@gmail.com";
            }

            public string getStudentID()
            {
                return studentId;
            }


        }

        static void Main(string[] args)
        {
            SchmidtsHashTable newHasher = new SchmidtsHashTable(199);
            LinkedList<student> students = new LinkedList<student>();

            students.AddLast(new student("10056486"));
            students.AddLast(new student("50098451"));
            students.AddLast(new student("70056165"));
            students.AddLast(new student("80856495"));
            students.AddLast(new student("50056168"));
            students.AddLast(new student("10056498"));
            students.AddLast(new student("05686492"));
            students.AddLast(new student("60058945"));
            students.AddLast(new student("80058794"));
            students.AddLast(new student("87948148"));
            
            foreach(student c_Student in students)
            {
                newHasher.set(c_Student.getStudentID(), c_Student);

            }

            foreach(student c_Student in students)
            {

                foreach (student h_student in newHasher.get(c_Student.getStudentID()))
                    {
                    if(newHasher.get(c_Student.getStudentID()).Length > 1)
                        {
                        Console.WriteLine("Collision found with student ID: " + h_student.getStudentID());
                    }
                    Console.WriteLine("Pulled student id: " + h_student.getStudentID() + " from the HashTable.");
                    }
            }

            Console.ReadLine();

        }
    }
}
