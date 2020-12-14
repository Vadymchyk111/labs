﻿using System.Collections.Generic;

namespace Lab_11_2
{
    public static class Extensions
    {
        public static List<Student> FindStudent(this List<Student> students,
            Student.StudentPredicateDelegate studentFindPredicate)
        {
            List<Student> resultList = new List<Student>();
            foreach (var student in students)
            {
                if (studentFindPredicate(student))
                    resultList.Add(student);
            }
            return resultList;
        }
    }
}
