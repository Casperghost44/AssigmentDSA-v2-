using System;
using AssigmentDSA_v2_.Core;
using AssigmentDSA_v2_.Entities;

namespace AssigmentDSA_v2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomDataList Stlist = new CustomDataList();
            Stlist.PopulateWithSampleData();
            Console.WriteLine(Stlist.Lenght);
            Stlist.RemoveFirst();
            Stlist.RemoveByIndex(4);
            Stlist.RemoveLast();
            // Student emp_st = new Student { FirstName = " ", LastName = " ", StudentNumber = " ", AverageScore = 0 };
            // Stlist.Add(emp_st);
            // Stlist.DisplayList();
            // Console.WriteLine($"First student is: {Stlist.First}");
            // Stlist.RemoveByIndex(3);
            // Stlist.DisplayList();
            // Student fs = Stlist.GetElement(3);
            // Console.WriteLine(fs);
            // Stlist.RemoveLast();
            // Stlist.DisplayList();
            // Console.WriteLine($"Last student is: {Stlist.Last}");
            Console.WriteLine(Stlist.Lenght);
            Console.WriteLine($"First student is: {Stlist.First}");
            Console.WriteLine($"Last student is: {Stlist.Last}");
            Student emp_st = new Student { FirstName = " ", LastName = " ", StudentNumber = " ", AverageScore = 0 };
            Stlist.Add(emp_st);
            Student new_st = new Student { FirstName = " LLLL", LastName = " JJJJ", StudentNumber = " 76868", AverageScore = 0 };
            Stlist.Add(new_st);
            Student fs = Stlist.GetElement(17);
            Console.WriteLine(fs);
            Console.WriteLine(Stlist.Lenght);
            Console.WriteLine($"First student is: {Stlist.First}");
            Console.WriteLine($"Last student is: {Stlist.Last}");
        }
    }
}
