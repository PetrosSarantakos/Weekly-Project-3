using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WeeklyProject3
{
    public class ManageList
    {
        public List<Student> GetAllStudents(string filename)//read student info from txt file
        {
            string[] ListData = File.ReadAllLines(filename);
            List<Student> students = new List<Student>();
            foreach (string item in ListData)
            {
                if (item == "First Name,Last Name,Age,Height,Tuition,Date,Phone" || item == "")
                    continue;

                string[] ListCreator = item.Split(',');
                students.Add(new Student
                {
                    FirstName = ListCreator[0],
                    LastName = ListCreator[1],
                    Age = Convert.ToInt32(ListCreator[2]),
                    Height = Convert.ToSingle(ListCreator[3]),
                    Tuition = Convert.ToSingle(ListCreator[4]),
                    StartingDate = Convert.ToDateTime(ListCreator[5]),
                    PhoneNumber = Convert.ToInt32(ListCreator[6])
                });
            }
            return students;
        }

        public List<Student> SortByLastName(List<Student> students) //sorts list by LastName using Linq
        {
            students = students.OrderBy(s=>s.LastName).ToList();
            return students;
        }

        public List<Student> SortByAge(List<Student> students) //sorts list by Age using Linq
        {
            students = students.OrderBy(s => s.Age).ToList();
            return students;
        }

        public List<Student> SortByPhoneNumber(List<Student> students) //sorts list by Phone 
        {
            students = students.OrderBy(s => s.PhoneNumber).ToList();
            return students;
        }

        public void PrintList(List<Student> Students) //prints on screen the result
        {
            foreach (Student item in Students)
            {
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName}, {item.Age}, {item.Height}, {item.Tuition}, {item.StartingDate.Date}, {item.PhoneNumber}");
                }
            }
        }
    }
}
