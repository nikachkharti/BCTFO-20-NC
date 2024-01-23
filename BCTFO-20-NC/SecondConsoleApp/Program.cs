using System.Text;

namespace SecondConsoleApp
{
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
        }
    }
}
