using System;
using System.Collections.Generic;

namespace Lab_11_2
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                string firstName;
                string lastName;
                int randomFirstNameNumber = rand.Next(5);
                int randomLastNameNumber = rand.Next(5);
                int randomAge = rand.Next(15, 25);

                switch (randomFirstNameNumber)
                {
                    case 0:
                        firstName = "Anna";
                        break;
                    case 1:
                        firstName = "Andrew";
                        break;
                    case 2:
                        firstName = "Jason";
                        break;
                    case 3:
                        firstName = "John";
                        break;
                    case 4:
                        firstName = "David";
                        break;
                    default:
                        firstName = "Billy";
                        break;
                }

                switch (randomLastNameNumber)
                {
                    case 0:
                        lastName = "Zew";
                        break;
                    case 1:
                        lastName = "Van";
                        break;
                    case 2:
                        lastName = "Herrington";
                        break;
                    case 3:
                        lastName = "Rosley";
                        break;
                    case 4:
                        lastName = "Troelsen";
                        break;
                    default:
                        lastName = "Anyan";
                        break;
                }

                Student student = new Student()
                {
                    Age = randomAge,
                    FirstName = firstName,
                    LastName = lastName
                };
                students.Add(student);
            }

            Console.WriteLine("Список всех студентов:");
            foreach (var student in students)
                student.PrintStudent();
            Console.WriteLine();

            // 8
            List<Student> selectedStudents;
            Console.WriteLine("Студенты старше 18");
            selectedStudents = students.FindStudent(Student.AgePredicate);
            foreach (var student in selectedStudents)
                student.PrintStudent();
            Console.WriteLine();

            Console.WriteLine("Студенты с первой буквой в имени \"А\"");
            selectedStudents = students.FindStudent(Student.FirstNameFirstLetterPredicate);
            foreach (var student in selectedStudents)
                student.PrintStudent();
            Console.WriteLine();

            Console.WriteLine("Студенты с фамилией длиннее 3 букв");
            selectedStudents = students.FindStudent(Student.LastNameSizePredicate);
            foreach (var student in selectedStudents)
                student.PrintStudent();
            Console.WriteLine();

            // 9
            Console.WriteLine("Студенты старше 18");
            selectedStudents = students.FindStudent(s => s.Age >= 18);
            foreach (var student in selectedStudents)
                student.PrintStudent();
            Console.WriteLine();

            Console.WriteLine("Студенты с первой буквой в имени \"А\"");
            selectedStudents = students.FindStudent(s => s.FirstName?[0] == 'A');
            foreach (var student in selectedStudents)
                student.PrintStudent();
            Console.WriteLine();

            Console.WriteLine("Студенты с фамилией длиннее 3 букв");
            selectedStudents =  students.FindStudent(s => s.LastName?.Length > 3);
            foreach (var student in selectedStudents)
                student.PrintStudent();
            Console.WriteLine();

            //10
            Console.WriteLine("Студенты с возрастом от 20 до 25");
            selectedStudents = students.FindStudent(s => s.Age >= 20 && s.Age <= 25);
            foreach (var student in selectedStudents)
                student.PrintStudent();
            Console.WriteLine();

            Console.WriteLine("Студенты с именем \"Andrew\"");
            selectedStudents = students.FindStudent(s => s.FirstName == "Andrew");
            foreach (var student in selectedStudents)
                student.PrintStudent();
            Console.WriteLine();

            Console.WriteLine("Студенты с фамилией \"Troelsen\"");
            selectedStudents = students.FindStudent(s => s.LastName == "Troelsen");
            foreach (var student in selectedStudents)
                student.PrintStudent();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
