using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinalUniApp
{
    class Groups
    {
        public int Id { get; private set; }
        public string GroupName { get; set; }
        public Teacher Teacher; 
        public static List<Student> StudentList { get; set; }
        public static int GroupId = 1;

        public Groups(string GroupName,Teacher teacher)
        {
            this.GroupName = GroupName;
            StudentList = new List<Student>();
            Teacher = teacher;
            GroupId++;
            Id = GroupId;
        }
        public Groups()
        {
            
        }

        public static void AddGroup()
        {
            Console.ResetColor();
            Console.WriteLine("_______**_______\n");
            Console.WriteLine("Enter a group  name:");
            string groupName = Console.ReadLine();
            Teacher newTeacher = Teacher.AddTeacher();
            Groups group = new Groups(groupName,newTeacher);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Group name:{0} was created succesfully. Teacher name: {1}", group.GroupName, group.Teacher.Firstname) ;
            AllMyList.Groups.Add(group);
            ShowGroup();
        }

        public static void ShowGroup()
        {
            foreach (var group in AllMyList.Groups)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nGroup name: {0}, Teacher name:{1}", group.GroupName, group.Teacher.Firstname);
            }
        }


        int phoneInt;
        public  void AddStudent()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please, write student's name!");
            string name = Console.ReadLine();
           
            if (name.Length > 2)
            {
                Student stu = new Student(name);
                StudentList.Add(stu);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Student's name was added succesfully!");
            }else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please, write true name!");
            }

            //student email

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please, write student's email");
            string email = Console.ReadLine();
          
            if(email.Contains("@"))
            {
                Student stu1 = new Student(email);
                StudentList.Add(stu1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Student's email was added succesfully!");
            }else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please, write with @");
            }

            //student phonenumber

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please, write student's phone number");
            string phone = Console.ReadLine();
          
             if(int.TryParse(phone,out phoneInt)) {
                Student stu2 = new Student(phone);
     
                if(phone.Length==10)
                {
                    StudentList.Add(stu2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Student's number was added succesfully.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Student's number wasn't added.");
                }

            }

        }

        public void AddStudentInfo()
        {
            
            foreach (Student stu in StudentList)
            {
                Console.WriteLine($"ID: {stu.Id}, Name: {stu.FullName}, Email: {stu.Email}, PhoneNumber: {stu.PhoneNumber}");
            }
            Console.Write("Please select student Id: ");
            string stuId = Console.ReadLine();
            int id;
            if(int.TryParse(stuId,out id))
            {
                bool correctId = false;
                foreach ( Student stu in StudentList)
                {
                    if (stu.Id==id)
                    {
                        correctId = true;
                        break;
                    }
                    if (!correctId)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("True write ID!!");
                    }
                }
            }

        }
    }
}
