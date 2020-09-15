using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalUniApp
{
    class Student
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int WorkExperience { get; set; }
        public List<int> Evaluation { get; set; }
        public Groups Group;
        public int Id { get; private set; }
        private static int stuId = 1;
        public Student(string FullName, string Email, string PhoneNumber, int WorkExperience, Groups group)
        {
            this.FullName = FullName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.WorkExperience = WorkExperience;
            Group = group;
            stuId++;
            Id = stuId;

        }

        public Student(string FullName)
        {
            this.FullName = FullName;
        }
   
    }
}
