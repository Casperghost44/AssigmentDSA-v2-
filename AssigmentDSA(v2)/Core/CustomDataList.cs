using System;
using System.Collections.Generic;
using System.Text;
using AssigmentDSA_v2_.Entities;

namespace AssigmentDSA_v2_.Core
{
    public class CustomDataList
    {
        private Student[] students;
        private int dataindex;



        public int Lenght;
        public Student First;
        public Student Last;
        public void PopulateWithSampleData()
        {
            Random rnd = new Random();
            int len = 20;
            students = new Student[len];


            for (int i = 0; i < len; ++i)
            {
                students[i] = new Student
                {
                    FirstName = $"Ivan {i}",
                    LastName = $"Jhhon {i}",
                    StudentNumber = $"{i}",
                    AverageScore = (float)rnd.NextDouble() * 5,
                };
                dataindex++;
            }
            Lenght = students.Length;

            First = students[0];
            Last = students[students.Length - 1];


        }
        public void Add(Student newStudent)
        {
            IncreaseCapacity();
            students[dataindex] = newStudent;
            Last = students[dataindex];
            dataindex++;
            Lenght = dataindex;
        }
        public Student GetElement(int index)
        {

            if (index < 0 || index >= dataindex)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid data index: " + dataindex);
            }
            return students[index];
        }
        public void RemoveByIndex(int index)
        {
            Student rems = students[index];
            if (index < 0 || index >= dataindex)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid data index: " + dataindex);
            }

            for (int i = index; i < dataindex - 1; i++)
            {
                students[i] = students[i + 1];
            }

            students[dataindex - 1] = default;

            dataindex--;
            Lenght = dataindex;
            Last = students[dataindex - 1];
            Console.WriteLine($"Removed student is: {rems}");
        }
        public void RemoveFirst()
        {
            Student rems = students[0];
            students[0] = null;
            for (int i = 0; i < students.Length - 1; ++i)
            {
                students[i] = students[i + 1];
            }
            First = students[0];
            dataindex--;
            Lenght = dataindex;
            Console.WriteLine($"Removed student is: {rems}");
        }
        public void RemoveLast()
        {
            Student rems = students[dataindex - 1];


            for (int i = students.Length - 1; i < dataindex - 1; i++)
            {
                students[i] = students[i + 1];
            }

            students[dataindex - 1] = default;

            dataindex--;
            Lenght = dataindex;
            Last = students[dataindex - 1];
            Console.WriteLine($"Removed student is: {rems}");

        }
        public void IncreaseCapacity()
        {
            if (dataindex >= students.Length)
            {
                Student[] resizedArray = new Student[students.Length + 1];

                Array.Copy(students, 0, resizedArray, 0, students.Length);

                students = resizedArray;
                Lenght = students.Length;

            }
        }
    }
}
