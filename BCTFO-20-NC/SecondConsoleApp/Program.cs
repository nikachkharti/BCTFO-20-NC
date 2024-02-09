namespace SecondConsoleApp
{
    enum Subject
    {
        Csharp = 1,
        Javascript = 2,
        SQL = 3,
        React = 4,
        Math = 5,
        Biochemistry = 6
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Subject Subject { get; set; }
        public int FaculityId { get; set; }
    }


    class Faculity
    {
        public int Id { get; set; }
        public string Name { get; set; }
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


            #region 17 ლექცია LINQ

            //Extension Methods     Query

            //SELECTIVE Operators category //Select, SelectMany
            //RESTRICTION Operators category // Where Find FirstOrDefault First Single SingleOrDefault Last LastOrDefault Find FindIndex...
            //AGGREGATE Operators category // Count Sum Average
            //ORDER Operators category // Order OrderBy OrderByDescending
            //GROUPPING Operators category // GroupBy
            //JOIN Operators category // GroupJoin InnerJOin LeftOuterJoin CrossJoin



            //string[] data = File.ReadAllLines(@"C:\Users\User\Desktop\IT STEP\BCTFO-20-NC\BCTFO-20-NC\HomeworksIncludeFunctions\vehicles.csv");

            //1.
            //var bmws = data
            //    .Skip(1)
            //    .Select(Vehicle.Parse)
            //    .Where(x => x.Make.Contains("BMW", StringComparison.OrdinalIgnoreCase));



            //var bmws = from x in data.Skip(1)
            //                let vehicle = Vehicle.Parse(x)
            //                where vehicle.Make.Contains("BMW", StringComparison.OrdinalIgnoreCase)
            //                select vehicle;




            //2.
            //var topTenEconomicCars = data
            //    .Skip(1)
            //    .Select(Vehicle.Parse)
            //    .OrderByDescending(v => v.Combined)
            //    .Take(10);




            //var topTenEconomicCars = (from x in data.Skip(1)
            //                          let vehicle = Vehicle.Parse(x)
            //                          orderby vehicle.Combined descending
            //                          select vehicle).Take(10);







            //GROUPPPING...

            List<Faculity> faculities = new()
            {
                new Faculity{ Id = 1,Name = "Computer Science"},
                new Faculity{ Id = 2,Name = "Mathematics"},
                new Faculity{ Id = 3,Name = "Medical"}
            };

            List<Student> students = new()
            {
                new Student { Id = 1,Name = "Temuri",Subject = Subject.Csharp,FaculityId = 1},
                new Student { Id = 2,Name = "Daviti",Subject = Subject.Javascript, FaculityId = 1},
                new Student { Id = 3,Name = "Giorgi",Subject = Subject.Csharp, FaculityId = 1},
                new Student { Id = 4,Name = "Alex",Subject = Subject.Biochemistry, FaculityId = 3},
                new Student { Id = 5,Name = "Ani",Subject = Subject.Math , FaculityId = 2},
                new Student { Id = 6,Name = "Keti",Subject = Subject.SQL, FaculityId = 1},
                new Student { Id = 7,Name = "Mariami",Subject = Subject.Math , FaculityId = 2}
            };



            //IEnumerable<IGrouping<Subject, Student>> studentGroup = students.GroupBy(x => x.Subject);


            //IEnumerable<IGrouping<Subject, Student>> studentGroup = from student in students
            //                                                        group student by student.Subject;


            //სტუდენტების რაოდენბოა საგნების მიხედვით
            //foreach (var group in studentGroup)
            //    Console.WriteLine($"{group.Key} {group.Count()}");



            //კონკრეტული სტუდენტების ჩამონათვალი საგნების მიხედვით
            //foreach (var group in studentGroup)
            //{
            //    Console.WriteLine($"{group.Key} {group.Count()}");

            //    foreach (var student in group)
            //        Console.WriteLine($"{student.Name}");

            //    Console.WriteLine("---------------");
            //}




            //დაჯგუფებული მონაცემების სორტირება ჯგუფის Key -ს მიხედვით
            //var studentGroup = from student in students
            //                   group student by student.Subject into eGroup
            //                   orderby eGroup.Key
            //                   select new
            //                   {
            //                       Key = eGroup.Key,
            //                       Employees = eGroup
            //                   };



            //დაჯგუფებული მონაცემების სორტირება ჯგუფის Key -ს მიხედვითაც და  თვითონ ჯგუფში არსებული სტუდენტების Id ითაც
            //var studentGroup = from student in students
            //                   group student by student.Subject into eGroup
            //                   orderby eGroup.Key
            //                   select new
            //                   {
            //                       Key = eGroup.Key,
            //                       Employees = eGroup.OrderBy(x => x.Id)
            //                   };






            //JOINING...


            //var result = from f in faculities
            //             join s in students
            //             on f.Id equals s.FaculityId into eGroup
            //             select new
            //             {
            //                 Faculity = f.Name,
            //                 Students = eGroup
            //             };





            #endregion




        }

    }
}
