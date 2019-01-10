using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WeeklyProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageList StudentList = new ManageList();
            List<Student> Students=StudentList.GetAllStudents("Lab3_Names.txt");
            Console.WriteLine("Choose what you want:\n1.Student List sorted by last name.\n2.Student List sorted by age.\n3.Student List sorted by Phone");
            int input = Convert.ToInt16(Console.ReadLine());
            while (input!=1 && input!=2 && input!=3) //checks if the input is correct, otherwise the program doesn't continue
            {
                Console.WriteLine("Choose a valid option.");
                input = Convert.ToInt16(Console.ReadLine());
            }
            if (input==1)
            {
                Students = StudentList.SortByLastName(Students);
            }
            else if (input==2)
            {
                Students = StudentList.SortByAge(Students);
            }
            else if (input==3)
            {
                Students = StudentList.SortByPhoneNumber(Students);
            }
            StudentList.PrintList(Students);
            Console.ReadLine();
        }
    }
}
