using Homeworks;
using System.Numerics;
using System.Text.RegularExpressions;

namespace SecondConsoleApp
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 10 ლექცია ოპერატორების გადატვირთვა
            //class Student
            //{
            //    public string Name { get; set; }
            //    public int Score { get; set; }

            //    public static Student operator +(Student obj1, Student obj2)
            //    {
            //        Student result = new Student();
            //        result.Score = obj1.Score + obj2.Score;

            //        return result;
            //    }

            //    public static Student operator -(Student obj1, Student obj2)
            //    {
            //        Student result = new Student();
            //        result.Score = obj1.Score - obj2.Score;

            //        return result;
            //    }

            //    public static Student operator *(Student obj1, Student obj2)
            //    {
            //        Student result = new Student();
            //        result.Score = obj1.Score - obj2.Score;

            //        return result;
            //    }

            //    public static Student operator /(Student obj1, Student obj2)
            //    {
            //        Student result = new Student();
            //        result.Score = obj1.Score - obj2.Score;

            //        return result;
            //    }

            //    public static bool operator >(Student obj1, Student obj2)
            //    {
            //        var result = obj1.Score > obj2.Score;

            //        return result;

            //    }

            //    public static bool operator <(Student obj1, Student obj2)
            //    {
            //        var result = obj1.Score < obj2.Score;

            //        return result;
            //    }


            //    public static bool operator >=(Student obj1, Student obj2)
            //    {
            //        var result = obj1.Score >= obj2.Score;

            //        return result;
            //    }


            //    public static bool operator <=(Student obj1, Student obj2)
            //    {
            //        var result = obj1.Score >= obj2.Score;

            //        return result;
            //    }

            //    public static bool operator ==(Student obj1, Student obj2)
            //    {
            //        var result = obj1.Score == obj2.Score && obj1.Name == obj2.Name;

            //        return result;
            //    }

            //    public static bool operator !=(Student obj1, Student obj2)
            //    {
            //        var result = obj1.Score != obj2.Score || obj1.Name != obj2.Name;

            //        return result;
            //    }

            //    public override string ToString()
            //    {
            //        return $"{Name} {Score}";
            //    }
            //}
            #endregion

            #region 11 ლექცია ლისტი ალგორითმები
            //List<int> intList = new List<int>();
            //intList.Add(11);
            //intList.Add(12);
            //intList.Add(132);
            //intList.Add(4);
            //intList.Add(14);
            #endregion

            #region 12 ლექცია მონაცემთა სტრუქტურები


            //LIST
            //List<Patient> names = new List<Patient>()
            //{
            //    new Patient() {FullName = "Nika"},
            //    new Patient() {FullName = "Giorgi"},
            //    new Patient() {FullName = "Daviti"},
            //    new Patient() {FullName = "Irakli"},
            //    new Patient() {FullName = "Irakli"},
            //    new Patient() {FullName = "Irakli"}
            //};


            //HASHSET
            //HashSet<int> intSet = new() { 1, 2, 3 };
            //HashSet<int> intSet2 = new() { 1, 2, 3, 5 };

            //var res = intSet2.IsSupersetOf(intSet);


            //LINKEDLIST
            //LinkedList<string> people = new LinkedList<string>();


            //QUEUE -- FIFO
            //Doctor dr = new Doctor("Gregory House");

            //Queue<Patient> patients = new();
            //patients.Enqueue(new Patient("Nika Chkartishvili"));
            //patients.Enqueue(new Patient("Lasha Andguladze"));
            //patients.Enqueue(new Patient("Tinatin Rodinadze"));
            //patients.Enqueue(new Patient("Tamar Bedoshvili"));

            //while (patients.Count > 0)
            //{
            //    StartWork(dr, patients); 
            //}
            //Console.WriteLine("WORK FINISH");


            //STACK -- LIFO
            //Stack<string> people = new(names);


            //DICTIONARY
            //Dictionary<string, int> dict = new()
            //{
            //    {"Five", 5 },
            //    {"Three", 3 },
            //    {"Eleven", 11 }
            //};

            //dict["Five"] = 12;


            #endregion

            #region 15 ლექცია IEnumerable Regex


            //int[] intNumbers = { 1, 2, 3, 4, 5 };
            //List<int> intList = new() { 1, 2, 3, 4, 5 };
            //HashSet<int> intSet = new() { 1, 2, 3, 4, 5 };
            //Dictionary<int, string> intDictionary = new() { };


            //var result = MyAlgorithms.FindIndex(intSet, x => x < 0);



            //"REGULAR EXPRESSION  REGEX"

            // () [] {} --> [მოსაძებნი მნიშვნელობა] {ზომა}  (დაჯგუფებისთვის)
            // ^ -- Regex დასაწყისი
            // $ -- Regex დასასრული

            // [a-g]

            //inv12345678

            //string value = "09/01/2024";

            //Regex regex = new("^0?[1-9]|1[0-2]$/");
            //var result = regex.IsMatch(value);

            #endregion


            #region 16 ლექცია Unit testing Value reference Extension methods

            //List<int> intlist = new() { 1, 1, 2, 3, 4 };
            //var x = MyAlgorithms.Distinct(intlist);


            //int i = 20;
            //int z = 20;


            //HashSet<string> numbersAsString = new() { "10", "20", "40", "51", "-31", "-225" };

            //უნდა გარდაქმნათ რიცხვების ლისტად, მოძებნოთ ყველა უარყოფით კენტი რიცხვი


            //var result = numbersAsString
            //    .Select(int.Parse)
            //    .Where(x => x % 2 != 0 && x < 0)
            //    .Count(x => x % 7 == 0);


            //var resykt = numbersAsString
            //    .MySelect(int.Parse)
            //    .MyWhere(x => x % 2 != 0 && x < 0);



            #endregion


            #region 17 LINQ

            //Extension მეთოდები               //LINQ Query

            //SELECTIVE OPERATORS: Select SelectMany
            //RESTRINCTION OPERATORS : Where Find FirstOrDefault LastOrDefault First Last...
            //AGGREGATE TYPES: Count Sum Average
            //ORDERED TYPES: OrderBy OrderByDescending
            //GROUP TYPES: Group by


            //List<int> intList = new() { 1, 10, 2 };
            //var result = intList.OrderByDescending(x => x);



            //var data = File.ReadAllLines(@"C:\Users\User\Desktop\IT STEP\BCTFO-20-NC\BCTFO-20-NC\HomeworksIncludeFunctions\vehicles.csv");


            //var vehicles = data
            //    .Skip(1)
            //    .Select(Vehicle.Parse)
            //    .OrderByDescending(x => x.Combined)
            //    .Take(10);
            //.Where(x => x.Make.Contains("BMW", StringComparison.OrdinalIgnoreCase));




            //var vehicles = from item in data
            //               .Skip(1)
            //               let vehicle = Vehicle.Parse(item)
            //               orderby vehicle.Combined descending
            //               group vehicle by vehicle.Make;



            //List<Student> students = new()
            //{
            //    new Student { Id = 1,Name = "Temuri",Subject = "C#"},
            //    new Student { Id = 2,Name = "Daviti",Subject = "JS"},
            //    new Student { Id = 3,Name = "Giorgi",Subject = "C#"},
            //    new Student { Id = 4,Name = "Alex",Subject = "Angular"},
            //    new Student { Id = 5,Name = "Ani",Subject = "Angular"},
            //    new Student { Id = 6,Name = "Keti",Subject = "JS"},
            //    new Student { Id = 7,Name = "Mariami",Subject = "C#"}
            //};


            //IEnumerable<IGrouping<string, Student>> groups = students.GroupBy(x => x.Subject);

            ////IEnumerable<IGrouping<string, Student>> groups = from student in students
            ////                                                 group student by student.Subject;


            //foreach (var group in groups)
            //{
            //    Console.WriteLine($"{group.Key} {group.Sum(x => x.Id)}");

            //    foreach (var student in group)
            //    {
            //        Console.WriteLine($"{student.Name}");
            //    }
            //    Console.WriteLine("-------");
            //}

            #endregion

        }
    }
}
