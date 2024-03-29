﻿using Homeworks;
using Homeworks.FightGame;
using Homeworks.MiniBank;
using Homeworks.MiniBank.Logger;
using Homeworks.MiniBank.MiniBankExceptions;
using System.Collections;
using System.Diagnostics.Tracing;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine();
#region 1 ლექცია

#region საკლასო დავალებები
/*

*********************************************************************************************
   
დავალება 1
•	შექმენით სარეგისტრაციო  კონსოლური აპლიკაცია,სადაც მომხმარებელს სთხოვთ რომ შემოიყვანოს ინფორმაცია საკუთარი თავის შესახებ
(სახელი,გვარი,პირადი ნომერი,ასაკი)
კონსოლიდან შემოყვანილი ინფორმაცია დაიმახსოვრეთ შესაბამის ცვლადში და საბოლოოდ დაბეჭდეთ კონსოლში.


დავალება 2 
   მომხმარებელს კლავიატურის გამოყენებით შეჰყავს რიცხვი 1-100 დიაპაზონში. თუ შეყვანილი რიცხვი
   წარმოადგენს 3-ის ჯერადს (იყოფა 3-ზე ნაშთის გარეშე), თქვენ უნდა გამოიტანოთ სიტყვა Fizz . თუ რიცხვი
   წარმოადგენს 5-ის ჯერადს, უნდა გამოიტანოთ სიტყვა Buzz. თუ შეყვანილი რიცხვი იქნება 3-ისა და 5-ის
   ჯერადი უნდა გამოიტანოთ - Fizz Buzz. ხოლო თუ რიცხვი არც 3-ის და არც 5-ის ჯერადია დააბრუნეთ თვითონ ეს
   რიცხვი. 
   თუ მომხმარებლის მიერ შეყვანილი რიცხვი 1-100 მნიშვნელობებს სცდება აუცილებელია
   მომხმარებელმა შეცდომის (Error) შეტყობინება მიიღოს


Console.Write("Please enter the number: ");
int.TryParse(Console.ReadLine(), out int number);

if (number < 1 || number > 100)
    Console.WriteLine("ERROR");

if (number % 3 == 0)
    Console.WriteLine("Fizz");
else if (number % 5 == 0)
    Console.WriteLine("Fizz Buzz");
else
    Console.WriteLine(number);


if (number < 1 || number > 100)
    Console.WriteLine("ERROR");
else
{
    switch (number)
    {
        case int x when x % 3 == 0:
            Console.WriteLine("Fizz");
            break;
        case int x when x % 5 == 0:
            Console.WriteLine("Fizz Buzz");
            break;
        default:
            Console.WriteLine(number);
            break;
    }
}

*********************************************************************************************

დავალება 3
    მომხმარებელს კლავიატურის გამოყენებით შეჰყავს 4 ციფრი. თქვენ უნდა შექმნათ რიცხვი, რომელიც
    შედგენილია ამ ციფრებისგან. მაგალითად, თუ შეყვანილია ციფრები : 1, 5, 7, 8, თქვენ უნდა შეადგინოთ რიცხვი
    - 1578. 


Console.WriteLine("Please enter the first number: ");
byte firstNumber = byte.Parse(Console.ReadLine());

Console.WriteLine("Please enter the second number: ");
byte secondNumber = byte.Parse(Console.ReadLine());

Console.WriteLine("Please enter the third number: ");
byte thirdNumber = byte.Parse(Console.ReadLine());

Console.WriteLine("Please enter the fourth number: ");
byte fourthNumber = byte.Parse(Console.ReadLine());

string textResult = $"{firstNumber}{secondNumber}{thirdNumber}{fourthNumber}";
int result = int.Parse(textResult);

Console.WriteLine(result);

*********************************************************************************************

დავალება 4
მომხმარებელს კალვიატურის გამოყენებით შეჰყავს თარიღი. აპლიკაციამ, ამ თარიღის მიხედვით
უნდა აჩვენოს სეზონის სახელი და კვირის დღე. მაგალითად, თუ 12/22/2021 არის შეყვანილი, მომხმარებელმა
უნდა მიიღოს - ზამთარი ოთხშაბათი. 


Console.WriteLine("Enter a date (MM/DD/YYYY): ");
if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
{
    string season = GetSeason(date);
    string dayOfWeek = date.DayOfWeek.ToString();

    Console.WriteLine($"{season} {dayOfWeek}");
}
else
{
    Console.WriteLine("Invalid date format!");
}

static string GetSeason(DateTime date)
{
    int month = date.Month;

    switch (month)
    {
        case 12:
        case 1:
        case 2:
            return "Winter";
        case 3:
        case 4:
        case 5:
            return "Spring";
        case 6:
        case 7:
        case 8:
            return "Summer";
        case 9:
        case 10:
        case 11:
            return "Fall";
        default:
            return "Unknown";
    }
}

*********************************************************************************************

დავალება 4.1 - იგივე დავალება ოღნდ გართულებული
მომხმარებელს კალვიატურის გამოყენებით შეჰყავს თარიღი. აპლიკაციამ, ამ თარიღის მიხედვით
უნდა აჩვენოს სეზონის სახელი და კვირის დღე. მაგალითად, თუ 12/22/2021 არის შეყვანილი, მომხმარებელმა
უნდა მიიღოს - ზამთარი ოთხშაბათი. არ ვიყენებთ ჩაშენებულ DateTime - ს.


            Console.WriteLine("Enter a date (MM/DD/YYYY): ");
string userInput = Console.ReadLine();

if (IsValidDateFormat(userInput))
{
    string[] dateParts = userInput.Split('/');
    int month = int.Parse(dateParts[0]);
    int day = int.Parse(dateParts[1]);
    int year = int.Parse(dateParts[2]);

    string season = GetSeason(month);
    string dayOfWeek = GetDayOfWeek(month, day, year);

    Console.WriteLine($"{season} {dayOfWeek}");
}
else
{
    Console.WriteLine("Invalid date format!");
}
}

static bool IsValidDateFormat(string date) => date.Split('/').Length == 3;

static string GetSeason(int month)
{
switch (month)
{
    case 12:
    case 1:
    case 2:
        return "Winter";
    case 3:
    case 4:
    case 5:
        return "Spring";
    case 6:
    case 7:
    case 8:
        return "Summer";
    case 9:
    case 10:
    case 11:
        return "Fall";
    default:
        return "Unknown";
}
}

static string GetDayOfWeek(int month, int day, int year)
{
if (month < 3)
{
    month += 12;
    year--;
}

int century = year / 100;
year %= 100;

int dayOfWeek = (day + ((13 * (month + 1)) / 5) + year + (year / 4) + (century / 4) - (2 * century)) % 7;

string[] daysOfWeek = { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

return daysOfWeek[dayOfWeek];
}

*********************************************************************************************


*/

#endregion

#region საშინაო დავალებები

//დავალება 1
//კონსოლის ფანჯრიდან შემოიყვანეთ ციფრი, და Convert.ToDouble ფუნქციით გადააკონვერტირეთ double-ში
//და შეინახეთ ცვლადში სახელად number1.
//კონსოლის ფანჯრიდან შემოიყვანეთ მეორე ციფრი, ესეც დააკონვერტირეთ double-ში და შეინახეთ
//ცვლადში სახელად number2.
//შექმენით ცვლადი sum და შეინახეთ მასში number1 მიმატებული number2 ანუ მათი ჯამი და დაბეჭდეთ.


//Console.Write("Enter the first number: ");
//double number1 = double.Parse(Console.ReadLine());

//Console.Write("Enter the first number: ");
//double number2 = double.Parse(Console.ReadLine());

//double result = number1 + number2;

//Console.WriteLine(result);



//დავალება 2
//კონსოლის ფანჯრიდან შემოიყვანეთ ციფრი, და გადააკონვერტირეთ int-ში და შეინახეთ ცვლადში
//სახელად number1.
//კონსოლის ფანჯრიდან შემოიყვანეთ მეორე ციფრი, ესეც დააკონვერტირეთ int-ში და შეინახეთ ცვლადში
//სახელად number2.
//შექმენით ცვლადი result და შეინახეთ მასში number1 გამრავლებული number2 ანუ მათი ნამრავლი.
//შეადარეთ result მეტია თუ არა 10 ზე და დაბეჭდეთ. {result} > 10 is { true or false } მსგავსი სახით მეტი იქნება
//თუ ნაკლები შესაბამისად.


//Console.Write("Enter the first number: ");
//int number1 = int.Parse(Console.ReadLine());

//Console.Write("Enter the first number: ");
//int number2 = int.Parse(Console.ReadLine());

//int result = number1 + number2;

//if (result > 10)
//{
//    Console.WriteLine(true);
//}
//else
//{
//    Console.WriteLine(false);
//}





//დავალება 3
//კონსოლის ფანჯრიდან შემოიყვანეთ ციფრი, და Convert.ToDouble ფუნქციით გადააკონვერტირეთ double-ში
//და შეინახეთ ცვლადში სახელად number1.
//კონსოლის ფანჭრიდან შემოიყვანეთ მეორე ციფრი, ესეც დააკონვერტირეთ double-ში და შეინახეთ
//ცვლადში სახელად number2.
//შექმენით ცვლადი sum და შეინახეთ მასში number1 მიმატებული number2 ანუ მათი ჯამი.
//შექმენით ცვლადი isEven, bool ტიპის და შეინახეთ მასში sum არის კენტი თუ ლუწი
//დაბეჭდე კონსოლში Sum და isEven. ანუ ჯამი და არის თუ არა ლუწი.


//Console.Write("Enter the first number: ");
//double number1 = double.Parse(Console.ReadLine());

//Console.Write("Enter the first number: ");
//double number2 = double.Parse(Console.ReadLine());

//double sum = number1 + number2;

//bool isEven = sum % 2 == 0;

//if (isEven)
//{
//    Console.WriteLine("EVEN");
//}
//else
//{
//    Console.WriteLine("ODD");
//}




//დავალება 3.
//ააწყვეთ კონსოლური კალკულატორი სადაც მომხმარებელს სთხოვთ რომ შემოიყვანოს ორი ციფრი და აირჩიოს მისთვის სასურველი ოპერაცია   [+ - * /]
// კალკულატორი ააწყვეთ როგორც IF ELSE ასევე SWITCH CASE - ის გამოყენებით.

//Console.Write("FIRST NUMBER: ");
//int num1 = int.Parse(Console.ReadLine());

//Console.Write("SECOND NUMBER: ");
//int num2 = int.Parse(Console.ReadLine());

//Console.Write("[+ - * /]");
//char operation = char.Parse(Console.ReadLine());

//switch (operation)
//{
//    case '+':
//        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
//        break;
//    case '-':
//        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
//        break;
//    case '*':
//        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
//        break;
//    case '/':
//        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
//        break;
//    default:
//        Console.WriteLine("Incorrect operaion");
//        break;
//}



//დავალება 5
//მოხმარებელს კლავიატურის გამოყენებით შეჰყავს 2 რიცხვი. პრიველი რიცხვი წარმოადგენს რაიმე
//მნიშვნელობას, მეორე რიცხვი წარმოადგენს პროცენტს, რომელიც უნდა გამოვითვალოთ. მაგალითად, თუ ჩვენ
//შევიყვანეთ რიცხვი - 90 და 10, შედეგად უნდა დაგვიბრუდნეს 90-ის 10 პროცენტი (%). პასუხი არის 9. 


//Console.Write("FIRST NUMBER: ");
//int number = int.Parse(Console.ReadLine());

//Console.Write("SECOND NUMBER: ");
//int percentage = int.Parse(Console.ReadLine());

//int result = number * percentage / 100;

//Console.WriteLine($"SECOND NUMBER IS {result} % OF FIRST NUMBER");


//დავალება 6
//მომხმარებელს შეჰყავს 6-ნიშნა რიცხვი. ამის შემდეგ მომხმარებელს შეჰყავს მნიშვნელობები
//ციფრების ადგილების ჩასანაცვლებლად. მაგალითად, თუ მომხმარებელმა შეიჰყვანა 1 და 6, უნდა შეიცვალოს
//პირველი და მეექვსე ციფრების ადგილები. 
//რიცხვი 723895 უნდა იქცეს - 523897 
//თუ მომხმარებლის მიერ შეყვანილი რიცხვი არ იქნება 6-ნიშნა, ამ შემთხვევაში უნდა გამოვიდეს
//შეცდომის (Error) შეტყობინების. 


//Console.Write("FIRST NUMBER: ");
//int number = int.Parse(Console.ReadLine());

//if (number.ToString().Length != 6)
//    Console.WriteLine("ERROR");
//else
//{
//    Console.Write("FIRST REPLACE POSITION: ");
//    int firstReplacePosition = int.Parse(Console.ReadLine());

//    Console.Write("FIRST REPLACE POSITION: ");
//    int secondReplacePosition = int.Parse(Console.ReadLine());

//    if (firstReplacePosition.ToString().Length != 1 || secondReplacePosition.ToString().Length != 1)
//        Console.WriteLine("ERROR");
//    else
//    {
//        //1.არსებული რიცხვი გადაგვყავს ტექსტურ მონაცემთა ტიპში.
//        string numberString = number.ToString();

//        //2.გადაყვანილი ტექსტისგან ვქმნით სიმბოლოების მასივს.
//        char[] numberArray = numberString.ToCharArray();

//        //3.ვპოულობთ გადასანაცვლებელი სიმბოლოების ინდექსებს.
//        int firstReplaceIndex = firstReplacePosition - 1;
//        int secondReplaceIndex = secondReplacePosition - 1;

//        //4.ვანაცვლებთ სიმბოლოებს.
//        char temp = numberArray[firstReplaceIndex];
//        numberArray[firstReplaceIndex] = numberArray[secondReplaceIndex];
//        numberArray[secondReplaceIndex] = temp;

//        //5.გადანაცვლებული სიმბოლოებით ვაწყობთ ახალ ტექსტს
//        numberString = new string(numberArray);

//        //6.საბოლოოდ ვაწყობთ ახალ რიცხვს.
//        int modifiedNumber = int.Parse(numberString);
//        Console.WriteLine($"Modified number: {modifiedNumber}");
//    }
//}




//დავალება 7
//მომხმარებელი შეიყვანს ტემპერატურის მაჩვენებლებს კლავიატურიდან. მომხმარებლის არჩევანის
//მიხედვით, აპლიკაცია გარდაქმნის ტემპერატურას ფარენჰეიტიდან ცელსიუსში ან პირიქით


//Console.Write("press F to convert farenheitt, press c to convert celsius");
//char operation = char.Parse(Console.ReadLine());

//if (operation == 'F' || operation == 'f')
//{
//    Console.Write("FARENHEIT: ");
//    double farenheit = double.Parse(Console.ReadLine());
//    double celsius = (farenheit - 32) * 5 / 9;
//    Console.WriteLine($"{farenheit} FARENHEIT = {celsius} CELSIUS");
//}
//else if (operation == 'C' || operation == 'c')
//{
//    Console.Write("CELSIUS: ");
//    double celsius = double.Parse(Console.ReadLine());
//    double farenheit = (celsius * 9 / 5) * 32;
//    Console.WriteLine($"{celsius} CELSIUS = {farenheit} FARENHEIT");
//}
//else
//{
//    Console.WriteLine("ERROR");
//}






//დავალება 8
//მომხმარებელს კალვიატურის გამოყენებით შეჰყავს თარიღი. აპლიკაციამ, ამ თარიღის მიხედვით
//უნდა აჩვენოს სეზონის სახელი და კვირის დღე. მაგალითად, თუ 12/22/2021 არის შეყვანილი, მომხმარებელმა
//უნდა მიიღოს - ზამთარი ოთხშაბათი. 



//Console.WriteLine("Enter a date (MM/DD/YYYY): ");
//if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
//{
//    string season = GetSeason(date);
//    string dayOfWeek = date.DayOfWeek.ToString();

//    Console.WriteLine($"{season} {dayOfWeek}");
//}
//else
//{
//    Console.WriteLine("Invalid date format!");
//}

//static string GetSeason(DateTime date)
//{
//    int month = date.Month;

//    switch (month)
//    {
//        case 12:
//        case 1:
//        case 2:
//            return "Winter";
//        case 3:
//        case 4:
//        case 5:
//            return "Spring";
//        case 6:
//        case 7:
//        case 8:
//            return "Summer";
//        case 9:
//        case 10:
//        case 11:
//            return "Fall";
//        default:
//            return "Unknown";
//    }
//}






//Console.WriteLine("Enter a date (MM/DD/YYYY): ");
//string userInput = Console.ReadLine();

//if (IsValidDateFormat(userInput))
//{
//    string[] dateParts = userInput.Split('/');
//    int month = int.Parse(dateParts[0]);
//    int day = int.Parse(dateParts[1]);
//    int year = int.Parse(dateParts[2]);

//    string season = GetSeason(month);
//    string dayOfWeek = GetDayOfWeek(month, day, year);

//    Console.WriteLine($"{season} {dayOfWeek}");
//}
//else
//{
//    Console.WriteLine("Invalid date format!");
//}

//static bool IsValidDateFormat(string date) => date.Split('/').Length == 3;

//static string GetSeason(int month)
//{
//    switch (month)
//    {
//        case 12:
//        case 1:
//        case 2:
//            return "Winter";
//        case 3:
//        case 4:
//        case 5:
//            return "Spring";
//        case 6:
//        case 7:
//        case 8:
//            return "Summer";
//        case 9:
//        case 10:
//        case 11:
//            return "Fall";
//        default:
//            return "Unknown";
//    }
//}

//static string GetDayOfWeek(int month, int day, int year)
//{
//    if (month < 3)
//    {
//        month += 12;
//        year--;
//    }

//    int century = year / 100;
//    year %= 100;

//    int dayOfWeek = (day + ((13 * (month + 1)) / 5) + year + (year / 4) + (century / 4) - (2 * century)) % 7;

//    string[] daysOfWeek = { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

//    return daysOfWeek[dayOfWeek];
//}



#endregion

#endregion




#region 2 ლექცია

#region საშინაო დავალებები

//დავალება 1
//დაწერეთ პროგრამა რომელიც კონსოლიდან შემოყვანილი რაიმე n რიცხვისთვის დაითვლის ყველა ციფრის
//ჯამს 1–დან n–მდე. მაგ 7 -ის შემთხვევაში დაითვლის 1+2+3+4+5+6+7 ჯამს.
//შესაყვანი სატესტო მონაცემი: 7
//მოსალოდნელი შედეგი: 
//1 2 3 4 5 6 7
//7–მდე ყველა ნატურალური ციფრის ჯამია: 28



//int maxValue = int.Parse(Console.ReadLine());
//int sum = default;
//for (int i = 1; i <= maxValue; i++)
//{
//    sum += i;
//}
//Console.WriteLine(sum);



//*********************************************************************************************


//დავალება 2
//გააკეთე კონსოლიდან შემოყვანილი რიცხვის გამრავლების ტაბულის ერთი ბლოკი. (ათის ნამრავლის
//ჩათვლით)
//შესაყვანი სატესტო მონაცემი: 13
//მოსალოდნელი შედეგი: 
//13 * 1 = 13
//13 * 2 = 26.........
//13 * 10 = 130


//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.WriteLine($"{i}*{j} = {i * j}");
//    }
//}


//*********************************************************************************************

//დავალება 3
//დაწერეთ პროგრამა რომელიც გამოიტანს კონსოლში ფიფქებით შედგენილ ნახევარპირამიდის ფორმას.
//მაგალითად ციფრი 4–ის შეყვანისას კონსოლში გამოვა შემდეგი სახის ნახევარ პირამიდა:
//*
//**
//***
//****


//int maxValue = int.Parse(Console.ReadLine());
//for (int i = 1; i <= maxValue; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//*********************************************************************************************



//დავალება 4
//გამოთვალეთ კონსოლიდან შემოყვანილი რიცხვის ფაქტორიალი.
//მაგ 5! (ფაქტორიალი) არის 1*2*3*4*5 და უდრის 120
//3! არის 1*2*3 უდრის 6


//int number = int.Parse(Console.ReadLine());
//int factorial = 1;
//for (int i = 1; i <= number; i++)
//{
//    factorial *= i;
//}
//Console.WriteLine(factorial);



//*********************************************************************************************


//დავალება 5
//დაწერეთ პროგრამა რომელიც კონსოლიდან წაკითხული რიცხვის მიხედვით გამოიტანს ციფრებით გამოსახულ
//პირამიდას მაგ: შემოტანილი რიცხვია თუ არის 4, გამოსატან პირამიდას ექნება ასეთი სახე:



//int maxValue = int.Parse(Console.ReadLine());
//for (int i = 1; i <= maxValue; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(i);
//    }
//    Console.WriteLine();
//}


//*********************************************************************************************



//დავალება 6
//მომხმარებელს კლავიატურის გამოყენებით შეჰყავს 2 რიცხვი. ჩვენი ამოცანაა, რომ ვაჩვენოთ ყველა
//ლუწი რიცხვი მითითებულ დიაპაზონში. თუ დიაპზონის საზღვრები არასწორად არის მოცემული, თქვენ უნდა
//ჩაასწოროთ ის. მაგალითად, თუ მომხმარებელმა შეიყვანა 20 და 11, ჩასწორებაა საჭირო, რადგან დიაპაზონის
//დასაწყისი უნდა იყოს - 11, და დასასრული - 20. 


//Console.Write("FIRST NUMBER: ");
//int.TryParse(Console.ReadLine(), out int min);

//Console.Write("SECOND NUMBER: ");
//int.TryParse(Console.ReadLine(), out int max);

//if (min == max)
//    Console.WriteLine("ERROR");
//else if (min > max)
//{
//    int t = min;
//    min = max;
//    max = t;
//}
//else
//{
//    for (int i = min; i <= max; i++)
//    {
//        if (i % 2 == 0)
//            Console.WriteLine(i);
//    }
//}

//*********************************************************************************************


#endregion


#region საკლასო დავალებები

/*
 •	დაწერეთ პროგრამა რომელიც კონსოლში დაბეჭდავს პირველ 10 რიცხვს

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }


 •	დაწერეთ პროგრამა რომელიც კონსოლში დაბეჭდავს ყველა რიცხვის საშუალო არითემტიკულს იქამდე სადამდეც მომხმარებელი იტყვის, ანუ მაქსმიალურ რიცხვს შემოიყვანს მომხმარებელი კონსოლიდან.

    Console.Write("MAX VALUE: ");
    int max = int.Parse(Console.ReadLine());
    int sum = 0;

    for (int i = 0; i < max; i++)
        sum += i;

    double average = sum / max;
    Console.WriteLine($"AVERAGE IS {average}");
    

 •	დაწერეთ პროგრამა რომელიც კონსოლში დაბეჭდავს ტექსტს Hello World იქამდე სანამ შემოყვანილი ტექსტი არ იქნება exit.

    string stopKeyword = string.Empty;
    while (stopKeyword != "exit")
    {
        Console.WriteLine("Hello World");
        Console.WriteLine("ENTER THE STOP KEYWORD");
        stopKeyword = Console.ReadLine();
    }


 */


#endregion

#endregion




#region 3 ლექცია

#region საკლასო დავალებები



/*
 დავალება 1
•	დაბეჭდეთ მასივი უკუღმა

int[] intAr = { 10, 1, 3, 4, 5 };
for (int i = intAr.Length - 1; i >= 0; i--)
{
    Console.WriteLine(intAr[i]);
}


დავალება 2
•	შემთხვევითი რიცხვებით შევსებულ მასივში მოძებნეთ დადებითი რიცხვების რაოდენობა.

Random random = new();
int[] intAr = new int[5];

for (int i = 0; i < intAr.Length; i++)
    intAr[i] = random.Next(-100, 100);

for (int i = 0; i < intAr.Length; i++)
    Console.WriteLine(intAr[i]);

Console.WriteLine("-----------------------");

for (int i = 0; i < intAr.Length; i++)
{
    if (intAr[i] > 0)
    {
        Console.WriteLine(intAr[i]);
    }
}



დავალება 3
•	შეამოწმეთ შემთხვევითი რიცხვებით შევსებული მასივი შეიცავს თუ არა ისეთ 7-ის ჯერად რიცხვს რომელიც მეტია 14 - ზე.


Random random = new();
int[] intAr = new int[5];

for (int i = 0; i < intAr.Length; i++)
    intAr[i] = random.Next(-100, 100);

for (int i = 0; i < intAr.Length; i++)
    Console.WriteLine(intAr[i]);

Console.WriteLine("-----------------------");

for (int i = 0; i < intAr.Length; i++)
{
    if (intAr[i] % 7 == 0 && intAr[i] > 14)
    {
        Console.WriteLine(true);
        break;
    }
}




დავალება 4
•	მოცემულია მასივი სადაც ჩაწერილია მომხმარებლების სახელები მაგალითად:[„ნიკა“,“გიორგი“,“ელენე“,“დავითი“] ამოიკითხეთ მასივიდან n რაოდენობის მონაცემები და დაბეჭდეთ კონსოლში შებრუნებული თანმიმდევრობით. n არის ნებისმიერი მთელი რიცხვი რომელიც არ აღემატება მასივის ზომას.

try
{
    string[] names = { "Nika", "Giorgi", "Elene", "Daviti", "Ana", "Keti" };
    Console.Write("ENTER MAX VALUE: ");
    int max = int.Parse(Console.ReadLine());
    string[] reversed = new string[max];

    if (max > names.Length)
        throw new FormatException();

    for (int i = 0; i < reversed.Length; i++)
        reversed[i] = names[i];

    Console.WriteLine("------------------");

    for (int i = reversed.Length - 1; i >= 0; i--)
        Console.WriteLine(reversed[i]);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

 */


#endregion

#region საშინაო დავალებები

/*
 დავალება 1
•	დაწერეთ პროგრამა რომელიც კონსოლში დაბეჭდავს მასივში შემავალი ყველა ლუწი ელემენტის ჯამს.

int[] collection = { 10, 1, 3, 4, 5, 12, 24 };
int sum = 0;

for (int i = 0; i < collection.Length; i++)
{
    if (collection[i] % 2 == 0)
        sum += collection[i];
}

Console.WriteLine(sum);

დავალება 2
•	დაწერეთ პროგრამა რომელიც ერთ მასივიდან მეორეში გადააკოპირებს ყველა ელემენტს (ჩათვალეთ რომ ორივე მასივის ზომა ერთი და იგივეა).

int[] collection = { 10, 1, 3, 4, 5, 12, 24 };
int[] copyCollection = new int[collection.Length];

for (int i = 0; i < collection.Length; i++)
    copyCollection[i] = collection[i];


დავალება 3
•	დაწერეთ პროგრამა რომელიც კონსოლში დაბეჭდავს მხოლოდ მასივის უნიკალურ ელემენტებს ანუ ისეთ ელემენტებს რომლებიც არსებულ მასივში მხოლოდ ერთხელ გვხვდებიან.


int[] collection = { 1, 1, 2, 1, 3, 12, 13, 3, 4, 5, 5 };

for (int i = 0; i < collection.Length; i++)
{
    bool isUnique = true;

    for (int j = 0; j < collection.Length; j++)
    {
        if (i != j && collection[i] == collection[j])
        {
            isUnique = false;
            break;
        }
    }

    if (isUnique)
        Console.WriteLine(collection[i]);
}


დავალება 4
•	დაწერეთ პროგრამა რომელიც მასივში მოძებნის მაქსიმალურ ელემენტს.


int[] collection = { 1, 1, 2, 1, 3, 12, 13, 3, 4, 5, 5 };
int maxElement = collection[0];

for (int i = 0; i < collection.Length; i++)
{
    if (collection[i] > maxElement)
        maxElement = collection[i];
}

Console.WriteLine("----------------------");
Console.WriteLine(maxElement);

დავალება 5
•	დაწერეთ პროგრამა რომელიც მასივში მოძებნის მაქსიმალური ელემენტის ინდექსს.

int[] collection = { 1, 1, 2, 1, 3, 12, 13, 3, 4, 5, 5 };
int maxElement = 0;

for (int i = 0; i < collection.Length; i++)
{
    if (collection[i] > maxElement)
        maxElement = i;
}

Console.WriteLine("----------------------");
Console.WriteLine(maxElement);



დავალება 6
•	დაალაგეთ მოცემული მასივი ზრდადობის მიხედვით. (არ გამოიყენოთ C#-ში არსებული მზა ფუნქციები მაგალითად OrderBy ან რაიმე მსგავსი სრული ფუნქციონალი დაწერეთ ხელით)


int[] collection = { 1, 1, 2, 1, 3, 12, 13, 3, 4, 5, 5 };

for (int i = 0; i < collection.Length - 1; i++)
{
    for (int j = i + 1; j < collection.Length; j++)
    {
        if (collection[j] < collection[i])
        {
            int temp = collection[j];
            collection[j] = collection[i];
            collection[i] = temp;
        }
    }
}

 */





#endregion

#endregion




#region 4 ლექცია

#region საშინაო დავალებები

//დავალება 1
//მომხმარებელს კლავიატურის გამოყენებით შეჰყავს ტექსტი. აპლიკაციამ თითოეული წინადადების
//პირველი ასო, მაღალი რეგისტრის ასოთი უნდა ჩაანაცვლოს. 
//მაგალითად, თუ მომხმარებელმა შეიყვანა : «today is a good day for walking. i will try to walk near the 
//sea».
//აპლიკაციის შედეგი უნდა იყოს შემდეგი: «Today is a good day for walking. I will try to walk near the sea».


//Console.WriteLine("ENTER THE TEXT");
//string text = Console.ReadLine();
//string[] sentences = text.Split('.');
//for (int i = 0; i < sentences.Length; i++)
//{
//    sentences[i] = sentences[i].Trim();
//    if (sentences[i].Length > 0)
//    {
//        sentences[i] = sentences[i].Substring(0, 1).ToUpper() + sentences[i].Substring(1);
//    }
//}
//text = string.Join(". ", sentences);
//Console.WriteLine($"{text}");


#endregion

#endregion



#region 5 ლექცია


//•	დაწერეთ ფუნქცია რომელიც პარამეტრად აიღებს ტექსტს, ფუნქციამ უნდა დააბრუნოს ამ ტექსტში არსებული იმ სიმბოლოების რაოდენობა რომელსაც მომხმარებელი გადასცემს ამ ფუნქციას.

//Console.WriteLine(CharacterCounter("Hello world", 'o'));
//int CharacterCounter(string arg, char symbol)
//{
//    int counter = 0;
//    for (int i = 0; i < arg.Length; i++)
//    {
//        if (arg[i] == 'o')
//        {
//            counter++;
//        }
//    }

//    return counter;
//}



//•	დაწერეთ ფუნქცია რომელიც გამოითვლის და დააბრუნებს მასივის შემადგენელი ყველა ელემენტის ჯამს.

//int[] collection = { 1, 2, 3 };
//Console.WriteLine(SumArrayElements(collection));
//int SumArrayElements(int[] arrayToSum)
//{
//    int sum = 0;
//    for (int i = 0; i < arrayToSum.Length; i++)
//    {
//        //sum = sum + arrayToSum[i];
//        sum += arrayToSum[i];
//    }

//    return sum;
//}


//•	დაწერეთ ფუნქცია რომელიც გამოითვლის და დააბრუნებს მასივის შემადგენელი ყველა კენტი ელემენტის ჯამს.


//int[] collection = { 1, 2, 3 };
//Console.WriteLine(SumArrayElements(collection));
//int SumArrayElements(int[] arrayToSum)
//{
//    int sum = 0;
//    for (int i = 0; i < arrayToSum.Length; i++)
//    {
//        if (arrayToSum[i] % 2 != 0)
//        {
//            sum += arrayToSum[i];
//        }
//    }

//    return sum;
//}



//•	დაწერეთ ფუნქცია რომელიც დააბრუნებს ორი გადაცემული რცხვის ჯამს

//Console.WriteLine(Sum(10,11));
//int Sum(int first, int second)
//{
//    return first + second;
//}


//•	დაწერეთ ფუნქცია რომელიც მასივში მოძებნის მაქსიმალურ ელემენტს.


//int[] collection = { 1, 2, 3 };
//Console.WriteLine(FindMax(collection));

//int FindMax(int[] array)
//{
//    int max = array[0];
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] > max)
//            max = array[i];
//    }

//    return max;
//}


//•	დაწერეთ ფუნქცია რომელიც მასივში მოძებნის იმ ელემენტს რომელსაც მომხმარებელი გადასცემს.

//string[] names = { "Giorgi", "Davit", "Nika", "Giorgi" };

//var result = FindElement(names, "Nika");
//Console.WriteLine(result);


//string FindElement(string[] collection, string element)
//{
//    string value = string.Empty;
//    for (int i = 0; i < collection.Length; i++)
//    {
//        if (collection[i] == element)
//        {
//            value = collection[i];
//        }
//    }
//    return value;
//}



//•	დაწერეთ ფუნქცია რომელიც დაალაგებს int ების მასივს ზრდადობის მიხედვით.
//(არ გამოიყენოთ C#-ში არსებული მზა ფუნქციები მაგალითად OrderBy ან რაიმე მსგავსი სრული ფუნქციონალი დაწერეთ ხელით)


//int[] collection = { 1, 101, 2, 14, 7, 6, 721 };
//int[] sortedCollection = Sort(collection);

//foreach (var item in sortedCollection)
//{
//    Console.WriteLine(item);
//}

//int[] Sort(int[] collection)
//{
//    for (int i = 0; i < collection.Length - 1; i++)
//    {
//        for (int j = i + 1; j < collection.Length; j++)
//        {
//            if (collection[j] < collection[i])
//            {
//                int t = collection[j];
//                collection[j] = collection[i];
//                collection[i] = t;
//            }
//        }
//    }

//    return collection;
//}



//• დაწერეთ ფუნქცია Any, ფუნქციამ უნდა შეამოწმოს გადაცემული ტექსტი შეიცავს თუ არა კონკრეტულ გადაცემულ სიმბოლოს.


//Console.WriteLine(Any("Hello World", 'o'));

//bool Any(string text, char symbol)
//{
//    for (int i = 0; i < text.Length; i++)
//    {
//        if (text[i] == symbol)
//        {
//            return true;
//        }
//    }

//    return false;
//}


//• დაწერეთ ფუნქცია All, ფუნქციამ უნდა შეამოწმოს გადაცემული ტექსტის ყველა ელემენტი უდრის თუ არა გადაცემულ კონკრეტულ სიმბოლოს.


//Console.WriteLine(All("oooo", 'o'));

//bool All(string text, char symbol)
//{
//    for (int i = 0; i < text.Length; i++)
//    {
//        if (text[i] != symbol)
//        {
//            return false;
//        }
//    }

//    return true;
//}



//•	დაწერეთ ფუნქცია სახელად IsNullOrEmpty ფუნქციამ უნდა შეამოწმოს გადაცემული სტრინგი ცარიელია თუ არა?

//Console.WriteLine(IsNullOrWhiteSpace("    "));
//bool IsNullOrEmpty(string value)
//{
//    return value == null || value.Length == 0;
//}


//•	დაწერეთ ფუნქცია სახელად IsNullOrWhiteSpace ფუნქციამ უნდა შეამოწმოს გადაცემული სტრინგი ცარიელია თუ არა და გადაცემული სტრინგი შედგება თუ არა Space-ებისგან.

//bool IsNullOrWhiteSpace(string value)
//{
//    return value == null || value.Length == 0 || All(value, ' ');
//}



#endregion



#region ლექცია 7 კლასები და ობიექტები



#region საშინაო დავალებები

//•	დავალება 1: შექმენით კლასი რიმლითაც აღწერთ საკუთარ თავს. კლასს უნდა ჰქოონდეს შემდეგი ინფორმაცია თქვენი სახელი, გვარი, ასაკი, პირადი ნომერი, ტელეფონის ნომერი, ელ-ფოსტა.
//კლასი ინფორმაციას უნდა იღებდეს კონსტრუქტორიდან.მოახდინეთ თქვენი კლასის დემონსტრირება კონსოლში.





//•	დავალება 2: დაწერეთ ანგარიშს კლასი, რომელსაც ექნება
//•	ანგარიშის ნომერი (22 ნიშნა)
//•	ვალუტა(სამნიშნა)
//•	ბალანსი(არ უნდა იყოს უარყოფითი)


//•	დაწერეთ კლიენტის კლასი, რომელსაც ექნება
//•	სახელი
//•	გვარი
//•	პირადი ნომერი (11 ნიშნა)
//•	ანგარიში

//მოახდინეთ თქვენს მიერ შექმნილი კლასების დემონსტრირება კონსოლში ობიექტების სახით. ობიექტებს უნდა შეეძლოთ თანხის განაღდება ბალანსის შევსება, ერთმანეთისთვის თნხის გადარიცხვა.







//try
//{
//    Account account1 = new Account()
//    {
//        AccountNumber = "1234567894112345678941",
//        Balance = 100,
//        Currency = "GEL"
//    };

//    Client client1 = new Client()
//    {
//        FirstName = "Tamazi",
//        LastName = "Goderdzishvili",
//        Age = 20,
//        Email = "tamazi@gmail.com",
//        PhoneNumber = "555221177",
//        Pin = "12345678945",
//        Account = account1
//    };

//    Client client2 = new Client()
//    {
//        FirstName = "Mariam",
//        LastName = "Khutishvili",
//        Age = 20,
//        Email = "mariam@gmail.com",
//        PhoneNumber = "555221177",
//        Pin = "12345678945",
//        Account = new Account()
//        {
//            AccountNumber = "2234567894112345678941",
//            Balance = 100,
//            Currency = "GEL"
//        }
//    };

//    Client client3 = new Client()
//    {
//        FirstName = "Giorgi",
//        LastName = "Gujarelidze",
//        Age = 30,
//        Email = "giorgi@gmail.com",
//        PhoneNumber = "555221177",
//        Pin = "12345678945",
//        Account = new Account
//        {
//            AccountNumber = "3234567894112345678941",
//            Balance = 100,
//            Currency = "GEL"
//        }
//    };


//    Console.WriteLine($" {client3.FirstName} {client3.LastName} --- {client3.Account.Balance}");
//    Console.WriteLine($" {client2.FirstName} {client2.LastName} --- {client2.Account.Balance}");

//    client3.Account.Transfer(client2.Account, 150000);
//    Console.WriteLine("---------------------------------");

//    Console.WriteLine($" {client3.FirstName} {client3.LastName} --- {client3.Account.Balance}");
//    Console.WriteLine($" {client2.FirstName} {client2.LastName} --- {client2.Account.Balance}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}




#endregion





//object[] intArray = new object[3] { 10, "Nika", true };


//object x = 12;
//int y = (int)x;


//C# 1.0  boxing unboxing









#endregion



#region ლექცია 8

// ააწყვეთ თამაშის ლოგიკა სადაც გვეყოლება ორი ტიპის პერსონაჟი გმირი (Hero) და ბოროტმოქმედი (Villan).
// პერსონაჟებს უნდა შეეძლოთ ერთანეთთან ბრძოლა და ბრძოლის შედეგად მოწინააღმდეგის სიცოცხლის მაჩვენებლის შემცირება.
// თითოეულ პერსონაჟს უნდა ჰქონდეს განსხვავებული ძალა
// სახელად  LightAbility ან DarkAbility გამომდინარე იქიდან ეს პერსონაჟი გმირია თუ ბოროტმოქმედი
// (ძალა გამოსახეთ int ებში, გმირებს უნდა ჰქონდეთ ნათელი ძალა (LightAbility) ხოლო ბოროტმოქმედებს ბნელი ძალა (DarkAbility))
// რამდენიც არის პერსონაჟის ძალა იმდენით უნდა მცირდებოდეს მოწინააღმდეგის სიცოცხლის მაჩვენებელი შეტევის შემთხვევაში.

//მახასიათებლები რომლებიც პერსონაჟებს უნდა ჰქონდეთ:
//სახელი - Name
//ფული - Money
//სიცოცხლე - Health
//ძალა (LightAbility დადებითი პერსონაჟის შემთხვევაში, DarkAbility უარყოფითი პერსონაჟის შემთხვევაში)

//ყველა პერსონაჟს უნდა შეეძლოს სხვა პერსონაჟზე შეტევის მიტანა
//მხოლოდ გმირებს უნდა შეეძლოთ სხვა გმირების განკურნება საკუთარი სიცოცხლის
//ფასად მაგალითად თუ მოუმატებს სიცოცხლის მაჩვენებელს 20 - ით, თავისი სიცოცხლის მაჩვენებელი უნდა შემცირდეს იმდენითვე ანუ 20-ით.

//P.S. დავალების შესრულებისას აუცილებლად გამოიყენეთ მემკვიდრეობა.

//Hero thor = new()
//{
//    Name = "Thor",
//    Health = 200,
//    LightPower = 20,
//    Money = 0
//};
//Hero ironMan = new()
//{
//    Name = "Tonny Stark",
//    Health = 100,
//    LightPower = 10,
//    Money = 100000
//};

//Villain thanos = new()
//{
//    Name = "Thanos",
//    Health = 500,
//    DarkPower = 60,
//    Money = 0
//};




#endregion



#region ლექცია 9 აბსტრაქცია

//1 დავალება
//წინა გაკვეთლებზე დაწერილ საბანკო აპლიკაციას ჰქონდა გარკვეული ოპერაციების (თანხის განაღდება, გადარიცხვა, შეტანა) ფუნქციონალი რომელიც ავამუშავეთ,
//მაგრამ კონსოლური ფანჯრის გათიშვის შემდეგ გადარიცხვის შესახებ ისტორია იკარგებოდა.
//თქვენი დავალებაა ააწყოთ Logger ანუ განხორციელებული ტრანზაქციების შესახებ ინფორმაციის შემნახავი პროგრამა.
// ინფორმაციის დამახსოვრება შეგვიძლია 2 გზით

//პირვველი: განხორციელებული ტრანზაქციის შესახებ ინფრმაცია დაიბეჭდოს კონსოლში.
//მეორე: განხორციელებული ტანზაქციის შესახებ ინფორამცია ჩაიწეროს და დამახსოვრედს ფაილში.

//როდესაც მომხმარებელი განახორციელებს რომელიმე ოპერაციას მომხმარებელს კონსოლიდან უნდა მიეცეს არჩევანი განხორციელებული ტრანზაქცია ჩაიწეროს ფაილში, თუ დაიბეჭდოს კონსოლში.
//Logger - ის ფუნქციონალის ასაწყობად აუცილებლად გამოიყენეთ
//ინტერფეისი ან აბსტრაქტული კლასი, თქვენი სურვილის მიხედვით.

//თუ მომხმარებელი აირჩევს ფაილს ფაილში უნდა ჩაიწეროს შემდეგი ინფორმაცია, მაგალითად:

//"მომხმარებელმა ნიკა ჩხარტიშვილი გადაურიცხა 500 ლარი მომხმარებელს გიორგი გიორგაძე, გადარიცხვის თარიღი: ----მიმდინარე თარიღი---"
//"მომხმარებელმა ნიკა ჩხარტიშვილი შეიტანა 500 ლარი გადარიცხვის თარიღი: ---მიმდინარე თარიღი---"
//და ა.შ.


//Client giorgi = new()
//{
//    FirstName = "Girogi",
//    LastName = "Giorgadze",
//    Age = 28,
//    Email = "gio@gmail.com",
//    PhoneNumber = "123456789",
//    Pin = "12345678978",
//    Account = new Account
//    {
//        AccountNumber = "1234567897812345678978",
//        Balance = 100,
//        Currency = "GEL"
//    }
//};

//giorgi.Account.Fill(100);

//Console.Write("[F] for file logging [C] for console logging ");
//char logType = char.Parse(Console.ReadLine());

//switch (logType)
//{
//    case 'F':
//        FileLogger.Log($"{giorgi.FirstName} {giorgi.LastName} Filled the balance current balance is {giorgi.Account.Balance} GEL{Environment.NewLine}");
//        break;

//    case 'C':
//        ConsoleLogger.Log($"{giorgi.FirstName} {giorgi.LastName} Filled the balance current balance is {giorgi.Account.Balance} GEL");
//        break;

//    default:
//        Console.WriteLine("INCORRECT LOG TYPE");
//        break;
//}







#endregion




#region ლექცია 10


//CustomDate curentDate = new CustomDate(2024, 1, 19);
//CustomDate newDate = new CustomDate(2024, 1, 20);


//Console.WriteLine(newDate - curentDate);



#endregion




#region ლექცია 13 Generic

//string[] data = File.ReadAllLines(@"../../../vehicles.csv");
//Vehicle[] cars = MyAlgorithms.Select(data);
//var mercedeses = MyAlgorithms.Where(cars, x => x.Make.Contains("Subaru"));

#endregion



#region ლექცია 14 დელეგატები, ანონიმური ფუნქციები

//DELEGATE დელეგატი

//FUNC -- არის დელეგატის ტიპი რომელსაც შეუძლია ისეთ ფუნქციის მიღება რომელსაც დასაბრუნებელ ტიპს ვურჩევთ ჩვენ თვითონ.
//ACTION -- არის დელეგატის ტიპი რომელსაც შეუძლია ისეთი ფუნქციის მიღება რომელიც აბრუნებს void - ს.


//PREDICATE -- არის დელეაგტის ტიპი რომესლაც შეუძლია ისეთი ფუნქციის მიღება რომელიც აბრუნებს კონკრეტულად BOOLEAN მნიშვნელობას.



//public delegate void DisplayInformation(string message);


//int[] numbers = { 100, 2, 31 };
//var result = MyAlgorithms.Sort(numbers, (x, y) => x > y);


#endregion



Console.ReadLine();














