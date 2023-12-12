using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            #region 2 ლექცია IF ELSE

            // + - * / %
            // > < >= <= != == && ||
            // += -= *= /=
            // ++ --


            //Console.WriteLine(10 + 5);
            //Console.WriteLine(10 - 5);
            //Console.WriteLine(10 * 5);
            //Console.WriteLine(10 / 5); გაყოფა
            //Console.WriteLine(10 % 5); ნაშთიანი გაყოფა


            //Console.WriteLine(10 > 5); //true
            //Console.WriteLine(10 < 5); //false
            //Console.WriteLine(10 >= 5); //true
            //Console.WriteLine(10 <= 10); //true
            //Console.WriteLine(10 == 10); //true
            //Console.WriteLine(10 != 10); // false

            //int x = 10;
            //int y = 20;

            //x = x + y;
            //x += y;

            //x = x - y;
            //x -= y;

            //x = x * y;
            //x *= y;

            //x = x / y;
            //x /= y;

            //int x = 10;
            //Console.WriteLine(++x);
            //Console.WriteLine(--x);

            //var x = 12;
            //var y = 25;

            //Console.WriteLine(x > y && x == 10); //და-- false
            //Console.WriteLine(x > y || x == 10);  //ან -- true


            //if (x == 0)
            //{
            //    Console.WriteLine("Number is zero");
            //}
            //else if (x % 2 == 0)
            //{
            //    Console.WriteLine("Number is even");
            //}
            //else
            //{
            //    Console.WriteLine("Number is odd");
            //}

            //int x = int.Parse("123");

            //Console.WriteLine("Enter your age");
            //int age = int.Parse(Console.ReadLine());


            //if (age == 5 || age == 1 || age == 2 || age == 3)
            //    Console.WriteLine("Too young");
            //else if (age == 15)
            //    Console.WriteLine("Teenager");
            //else if (age == 25)
            //    Console.WriteLine("Adult person");
            //else if (age == 75)
            //    Console.WriteLine("Old person");
            //else
            //    Console.WriteLine("Incorrect age");


            //switch (age)
            //{
            //    case 5:
            //        Console.WriteLine("Too young");
            //        break;
            //    case 15:
            //        Console.WriteLine("Teenager");
            //        break;
            //    case 25:
            //        Console.WriteLine("Adult person");
            //        break;
            //    case 75:
            //        Console.WriteLine("Old person");
            //        break;
            //    default:
            //        Console.WriteLine("Incorrect age");
            //        break;
            //}


            //Console.Write("Please enter your first name: ");
            //string firstName = Console.ReadLine();

            //Console.Write("Please enter your last name: ");
            //string lastName = Console.ReadLine();


            //Console.Write("Please enter your pin: ");
            //string pin = Console.ReadLine();


            //Console.Write("Please enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("---------------------------");

            //Console.WriteLine("Hello I am " + firstName + " " + lastName + "my pin number is" + " " + pin + " " + age + " years old");
            //Console.WriteLine($"Hello I am {firstName} {lastName} my pin number is {pin} {age} years old");
            //Console.WriteLine("Hello my name is {0} {1} my pin is {2} {3} years old", firstName, lastName, pin, age);


            //Console.Write("Please enter the number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number < 1 || number > 100)
            //{
            //    Console.WriteLine("ERROR");
            //}
            //else
            //{
            //    switch (number)
            //    {
            //        case int x when x % 3 == 0:
            //            Console.WriteLine("Fizz");
            //            break;
            //        case int x when x % 5 == 0 && x % 3 == 0:
            //            Console.WriteLine("Fizz Buzz");
            //            break;
            //        default:
            //            Console.WriteLine(number);
            //            break;
            //    }
            //}


            //Console.Write("Please enter the number 1: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the number 2: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the number 3: ");
            //int c = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the number 4: ");
            //int d = int.Parse(Console.ReadLine());

            //string resultText = $"{a}{b}{c}{d}";
            //int result = int.Parse(resultText);

            //Console.WriteLine(result);


            #endregion


            #region 3 ლექცია ციკლები და Exception - ები

            //try
            //{
            //    int x = 12;
            //    int y = 0;

            //    int result = x / y;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}


            //bool x = int.TryParse(Console.ReadLine(), out int parsedresult);



            //while

            //int i = 0;
            //while (i < 10)
            //{
            //    i++;
            //    Console.WriteLine("Nika Chkhartishvili");
            //}

            //try
            //{
            //    int keyword = default;
            //    do
            //    {
            //        Console.Write("ENTER THE KEYWORD: ");
            //        keyword = int.Parse(Console.ReadLine());
            //    } while (keyword != 17);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Nika Chkhartishvili");
            //}


            //foreach (var item in collection)
            //{

            //}


            //      დავალება 1
            // •	დაწერეთ პროგრამა რომელიც კონსოლში დაბეჭდავს პირველ 10 რიცხვს


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //int i = 10;
            //while (i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            //for (int i = 10 ; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //      დავალება 2
            // •	დაწერეთ პროგრამა რომელიც კონსოლში დაბეჭდავს ყველა რიცხვის საშუალო არითემტიკულს იქამდე სადამდეც მომხმარებელი იტყვის, ანუ მაქსმიალურ რიცხვს შემოიყვანს მომხმარებელი კონსოლიდან.


            //Console.Write("MAX VALUE: ");
            //double max = double.Parse(Console.ReadLine());
            //double sum = 0;

            //for (int i = 1; i <= max; i++)
            //{
            //    sum += i;
            //}

            //double result = sum/max;
            //Console.WriteLine(result);


            //      დავალება 3
            // •	დაწერეთ პროგრამა რომელიც კონსოლში დაბეჭდავს ტექსტს Hello World იქამდე სანამ შემოყვანილი ტექსტი არ იქნება exit.


            //string text = string.Empty;
            //while (text != "exit")
            //{
            //    Console.WriteLine("Hello world");
            //    text = Console.ReadLine();
            //}



            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"i: {i}");
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine($"j: {j}");
            //    }
            //}



            #endregion
        }
    }
}
