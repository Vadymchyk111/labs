using System;

namespace Lab_11_2
{
    public class Student
    {
        public delegate bool StudentPredicateDelegate(Student student);
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static bool AgePredicate(Student student)
        {
            if (student.Age >= 18)
                return true;
            return false;
        }

        public static bool FirstNameFirstLetterPredicate(Student student)
        {
            if (student.FirstName?[0] == 'A')
                return true;
            return false;
        }

        public static bool LastNameSizePredicate(Student student)
        {
            if (student.LastName?.Length > 3)
                return true;
            return false;
        }

        public void PrintStudent()
        {
            Console.WriteLine($"Имя: {FirstName}" +
                              $" Фамилия: {LastName}" +
                              $" Возраст: {Age}");
            
        }
    }
}
