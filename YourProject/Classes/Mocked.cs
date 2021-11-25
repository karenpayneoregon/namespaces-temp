using System.Collections.Generic;

namespace YourProject.Classes
{
    public class Mocked
    {
        public static List<Employees> EmployeesList1 => new()
        {
            new () { FirstName = "Karen",   LastName = "Payne",    Id = 10 },
            new () { FirstName = "Lisa",    LastName = "Smith",    Id = 12 },
            new () { FirstName = "Francis", LastName = "Guarnes",  Id = null},
            new () { FirstName = "Vince",   LastName = "Buchheit", Id = 34},
            new () { FirstName = "Bill",    LastName = "Rickman"}
        };
        public static List<Employees> EmployeesList2 => new()
        {
            new() { FirstName = "Karen", LastName = "Payne", Id = 10 },
            new() { FirstName = "Lisa", LastName = "Smith", Id = 12 },
            new() { FirstName = "Francis", LastName = "Guarnes", Id = 88 },
            new() { FirstName = "Vince", LastName = "Buchheit", Id = 34 },
            new() { FirstName = "Bill", LastName = "Rickman" }
        };
    }
}