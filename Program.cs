using System;
using System.Runtime.InteropServices;

class Test
{

    //! Methods
    //* public static void Add(){body} =>  this is how looks like a method
    //* public means we can access this method from anywhere
    //* static means we can call this method without creating an object of this class like Test.Add();
    //* void means this method does not return any value
    //* Main is the entry point of our application

    public static int CalcSquare(int num){
        return num * num;
    }

    public static void Main(string[] args)
    {
        
        // my third day of practicing c#endregion// today i will take some input from users
        // string? studentName;
        // int? studentAge;
        // Console.Write("Write your name ");
        // studentName = Console.ReadLine();
        // Console.Write("Write your age ");
        // studentAge = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"Your name is {studentName} and your age is {studentAge}");


        // now i will practice mathmatical operators
        // there is 3 type of operators
        // 1. unary operator
        // 2. binary operator
        // 3. ternary operator
        // unery operators work only for one variable
        // binary operators work with 2 variables
        // ternary operator is used when we have 3 conditions or more
        //? binary operator are 5 types of operators
        // 1. arrithmatic operator
        // 2. assignment operator
        // 3. comparison operator
        // 4. logical operator
        // 5. bitwise operator


        // int number1 = 10;
        // int number2 = 3;

        // int result;

        // //! addition operator
        // result = number1 + number2;
        // Console.WriteLine($"Addition: {result}");
        // //! subtraction operator
        // result = number1 - number2;
        // Console.WriteLine($"Subtraction: {result}");
        // //! multiplication operator
        // result = number1 * number2;
        // Console.WriteLine($"Multiplication: {result}");
        // //! division operator
        // result = number1 / number2;
        // Console.WriteLine($"Division: {result}");
        // //! modulus operator
        // result = number1 % number2;
        // Console.WriteLine($"Modulus: {result}");
        // //! Task
        // int? number1;
        // int? number2;
        // int? number3;
        // Console.Write("Write first number: ");
        // number1 = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Write second number: ");
        // number2 = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Write third number: ");
        // number3 = Convert.ToInt32(Console.ReadLine());
        // int? result;
        // result = number1 + number2 + number3;
        // Console.WriteLine($"Addition: {result}");
        // int average = Convert.ToInt32(result) / 3;
        // Console.WriteLine($"Average: {average}");

        // //! Triangle Calculation

        // int baseLength, height;
        // Console.Write("Write base length: ");
        // baseLength = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Write height: ");
        // height = Convert.ToInt32(Console.ReadLine());

        // double triangle = 0.5 * baseLength * height;
        // Console.WriteLine($"Triangle area: {triangle}");

        // //! Area of circle calculation
        // double radius;
        // Console.Write("Write radius: ");
        // radius = Convert.ToDouble(Console.ReadLine());
        // double area = 3.1416 * radius * radius; // Math.PI * radius * radius
        // Console.WriteLine($"Circle area: {area}");

        //! Farenheight to celcius
        // double Farenheight;
        // Console.Write("Write temperature in Farenheight: ");
        // Farenheight = Convert.ToDouble(Console.ReadLine());

        // double celcius = (Farenheight - 32) / 1.8;
        // Console.WriteLine($"Temperature in Celcius: {celcius}");

        //! Calcius to Farenheight
        // double celcius;
        // Console.Write("Write temperature in Celcius: ");
        // celcius = Convert.ToDouble(Console.ReadLine());
        // double farenheight = celcius * 1.8 + 32;

        // Console.WriteLine($"Temperature in Farenheight: {farenheight}");

        //! assignment operator
        // int number = 10;
        // number += 5; // number = number + 5;
        // Console.WriteLine(number); // 15
        // number -= 10; // number = number - 10;
        // Console.WriteLine(number); // 5
        // number *= 2; // number = number * 2;
        // Console.WriteLine(number); // 10
        // number /= 3; // number = number / 3;
        // Console.WriteLine(number); // 3
        // number %= 4; // number = number % 4;
        // Console.WriteLine(number);

        // //! Relational or Comparison Operator
        // int number1 = 10;
        // int number2 = 20;
        // Console.WriteLine(number1 > number2); // false
        // Console.WriteLine(number1 < number2); // true
        // Console.WriteLine(number1 == number2); // false
        // Console.WriteLine(number1!= number2); // true
        // Console.WriteLine(number1 >= number2); // false
        // Console.WriteLine(number1 <= number2); // true

        //   //! Logical Operator
        // int number1 = 10;
        // int number2 = 20;
        // int number3 = 14;
        // int number4 = 19;
        // Console.WriteLine(number1 > number2 && number3 < number4); // false
        // Console.WriteLine(number1 < number2 || number1 < number4 || number2 < number3); // true
        // Console.WriteLine(number1 == number2); // false
        // Console.WriteLine(number1 != number2 || number1 == number4); // true
        // Console.WriteLine(number1 >= number2); // false
        // Console.WriteLine(number1 <= number2); // true

        // //! Bitwise operator ( & | ^ >> << ! ) ( bitwise and, bitwise or, bitwise xor, bitwise right shift, bitwise left shift, bitwise not)
        // int result = 12 & 17;
        // Console.WriteLine($"12 & 17 = {result}"); //0
        // result = 15 | 39;
        // Console.WriteLine($"15 | 39 = {result}"); // 47
        // result = 9 ^ 6;
        // Console.WriteLine($"9 ^ 6 = {result}"); // 15
        // result = 18 >> 2;
        // Console.WriteLine($"18 >> 2 = {result}"); //4
        // result = 13 << 3;
        // Console.WriteLine($"13 << 3 = {result}"); // 104

        // //! Unary operator (++ --)
        // int number = 10;
        // Console.WriteLine(number); //10
        // Console.WriteLine(number++); //10
        // Console.WriteLine(++number); //12
        // Console.WriteLine(--number); //11
        // Console.WriteLine(number--); //11
        // Console.WriteLine(number); //10

        // //! Ternary Operator ( ? )  : 
        // int number;
        // Console.Write("Enter a number: ");
        // number = Convert.ToInt32(Console.ReadLine());
        // string result = number > 5 ? "Greater than 5" : "Less than or equal to 5";
        // Console.WriteLine(result);

        // //! COnditional Control statement (if else statements)
        // int num;
        // Console.Write("Enter a number: ");
        // num = Convert.ToInt32(Console.ReadLine());
        // if (num > 0)
        // {
        //     Console.WriteLine("Number is positive");
        // }

        // else if (num < 0)
        // {
        //     Console.WriteLine("Number is negative");
        // }

        // else
        // {
        //     Console.WriteLine("Number is zero");
        // }

        // //! Check Even Odd numbers by if else
        // int number;
        // Console.Write("Enter a number: ");
        // number = Convert.ToInt32(Console.ReadLine());
        // int result = number % 2;
        // if (result == 0)
        // {
        //     Console.WriteLine("Number is even");
        // }
        // else {
        //     Console.WriteLine("Number is odd");
        // }

        // //! Find the large and small number by if else statment
        // int num1;
        // int num2;
        // Console.Write("Enter first number: ");
        // num1 = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter second number: ");
        // num2 = Convert.ToInt32(Console.ReadLine());
        // if (num1 > num2)
        // {
        //     Console.WriteLine($"Largest number is: {num1}");
        //     Console.WriteLine($"Smallest number is: {num2}");
        // }
        // else if (num1 < num2)
        // {
        //     Console.WriteLine($"Largest number is: {num2}");
        //     Console.WriteLine($"Smallest number is: {num1}");
        // }
        // else
        // {
        //     Console.WriteLine("Both numbers are equal");
        // }

        //     //! Find Largest number among 3 numbers
        //     int num1, num2, num3;
        //     Console.Write("Enter the first number: ");
        //     num1 = Convert.ToInt32(Console.ReadLine());
        //     Console.Write("Enter the second number: ");
        //     num2 = Convert.ToInt32(Console.ReadLine());
        //     Console.Write("Enter the third number: ");
        //     num3 = Convert.ToInt32(Console.ReadLine());

        //    if (num1 > num2 && num1 > num3) {
        //      Console.WriteLine($"The Largest number is {num1}");
        //    }else if (num2 > num1 && num2 > num3){
        //      Console.WriteLine($"The Largest number is {num2}");
        //    }else if (num3 > num1 && num3 > num2){
        //      Console.WriteLine($"The Largest number is {num3}");
        //    }
        //     else if (num1 == num2 && num1 == num3){
        //      Console.WriteLine($"All numbers {num1}, {num2}, and {num3} are equal");
        //    }
        //    else if (num1 == num2){
        //      Console.WriteLine($"Both numbers {num1} and {num2} are equal");
        //    }

        //    else if (num1 == num3){
        //      Console.WriteLine($"Both numbers {num1} and {num3} are equal");
        //    }

        //    else if (num2 == num3){
        //      Console.WriteLine($"Both numbers {num2} and {num3} are equal");
        //    }
        //     else {
        //      Console.WriteLine("All numbers are equal");
        //    }

        // //! Grade define (marks between 0 to 100 allowed)
        // double marks;
        // char grade;
        // Console.Write("Enter your marks: ");
        // marks = Convert.ToDouble(Console.ReadLine());
        // if(marks >= 0 && marks <= 100){
        //     if(marks >=90){
        //         grade = 'A';
        //     }else if(marks >= 80){
        //         grade = 'B';
        //     }
        //     else if(marks >= 70){
        //         grade = 'C';
        //     }
        //     else if(marks >= 60){
        //         grade = 'D';
        //     }
        //     else{
        //         grade = 'F';
        //     }
        //     Console.WriteLine($"Your Grade is {grade}");
        // }else{
        //     Console.WriteLine($"{marks} is Invalid Marks");
        // }

        // //! Leap year
        // int year;
        // Console.Write("Enter the year: ");
        // year = Convert.ToInt32(Console.ReadLine());
        // if (year % 400 == 0)
        // {
        //     Console.WriteLine($"{year} is a leap year");
        // }
        // else if  (year % 4 == 0 && year % 100 != 0)
        // {
        //     Console.WriteLine($"{year} is a leap year");
        // }
        // else{
        //     Console.WriteLine($"{year} is not a leap year");
        // }

        // //! Find Capital or Small letter
        // char? letter;
        // Console.Write("Write any letter ");
        // letter = Convert.ToChar(Console.ReadLine());
        // if (letter >= 'A' && letter <= 'Z')
        // {
        //     Console.WriteLine($"The letter {letter} is a Capital letter");
        // }
        // else
        // {
        //     Console.WriteLine($"The letter {letter} is a Small letter");
        // }

        // //! Find Vowel or Consonant letter
        // char letter;
        // Console.Write("Write any letter ");
        // letter = Convert.ToChar(Console.ReadLine());
        // letter = char.ToLower(letter);

        // if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        // {
        //     Console.WriteLine($"{letter} is a Vowel letter");
        // }
        // else
        // {
        //     Console.WriteLine($"{letter} is a Consonent letter");
        // }

        // //! Switch Statements
        // int num;
        // Console.Write("Write a number between 0 and 9: ");
        // num = Convert.ToInt32(Console.ReadLine());

        // switch(num){
        //     case 0:
        //         Console.WriteLine("Zero");
        //         break;
        //     case 1:
        //         Console.WriteLine("One");
        //         break;
        //     case 2:
        //         Console.WriteLine("Two");
        //         break;
        //     case 3:
        //         Console.WriteLine("Three");
        //         break;
        //     case 4:
        //         Console.WriteLine("Four");
        //         break;
        //     case 5:
        //         Console.WriteLine("Five");
        //         break;
        //     case 6:
        //         Console.WriteLine("Six");
        //         break;
        //     case 7:
        //         Console.WriteLine("Seven");
        //         break;
        //     case 8:
        //         Console.WriteLine("Eight");
        //         break;
        //     case 9:
        //         Console.WriteLine("Nine");
        //         break;
        //     default:
        //         Console.WriteLine("Invalid number");
        //         break;
        // }

        // //! vowel consonent by swicth statement
        // char input;
        // Console.Write("Enter a character: ");
        // input = Convert.ToChar(Console.ReadLine());
        // input = char.ToLower(input);

        // switch (input)
        // {
        //     case 'a':
        //     case 'e':
        //     case 'i':
        //     case 'o':
        //     case 'u':
        //         Console.WriteLine("The given character is a vowel");
        //         break;
        //     default:
        //         if(char.IsLetter(input)){
        //             Console.WriteLine("The given character is a consonant");
        //         }else{
        //             Console.WriteLine("The given character is not a letter");
        //         }
        //         break;
        // }

        // //! Finding week day or weekend day by switch statement
        // string day;
        // Console.Write("Write a day: ");
        // day = Console.ReadLine().ToLower();
        // switch(day){
        //     case "saturday":
        //     case "sunday":
        //     case "monday":
        //     case "tuesday":
        //     case "wednesday":
        //     case "thursday":
        //          Console.WriteLine("It is a week day");
        //          break;
        //     case "friday":
        //     Console.WriteLine("It is a weekend day");
        //          break;
        //     default:
        //     Console.WriteLine("Type mysstake or invalid day");
        //     break;
        // }

        // //! Switch shorthand expression

        // Console.Write("Enter a number between 1 - 5: ");
        // int inputs = Convert.ToInt32(Console.ReadLine());

        // string result = inputs switch
        // {
        //     int inp when inp >= 1 && inp <= 5 => inp % 2 == 0 ? "even number" : "odd number",

        //     _ => "Invalid number"
        // };
        // Console.WriteLine($"The number {inputs} is {result}");

        // //! project 1
        // Console.WriteLine("This project is for convert fahrenheit to celsisus and celsisus to fahrenheit");
        // Console.Write("Enter 1 for Fahrenheit to Celsius, or 2 for Celsius to Fahrenheit: ");
        // int choice = Convert.ToInt32(Console.ReadLine());
        // switch(choice){
        //     case 1:
        //         Console.Write("Enter temperature in Fahrenheit: ");
        //         double fahrenheit = Convert.ToDouble(Console.ReadLine());
        //         double celsius = (fahrenheit - 32) / 1.8;
        //         Console.WriteLine($"Temperature in Celsius: {celsius:F2}");
        //         break;
        //     case 2:
        //         Console.Write("Enter temperature in Celsius: ");
        //         double celsius2 = Convert.ToDouble(Console.ReadLine());
        //         double fahrenheit2 = 
        //         celsius2 * 1.8 + 32;
        //         Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit2:F2}");
        //         break;
        //     default:
        //         Console.WriteLine("Invalid choice");
        //         break;
        // }

        // //! Project 2 calculator
        // int num1, num2;
        // char operators;
        // Console.Write("Choose a operation (+,-,*,/): ");
        // operators = Convert.ToChar(Console.ReadLine());

        // if (operators != '+' && operators != '-' && operators != '*' && operators != '/')
        // {
        //     Console.WriteLine("Invalid operator");
        //     return;
        // }

        // Console.Write("Enter first number: ");
        // num1 = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter second number: ");
        // num2 = Convert.ToInt32(Console.ReadLine());

        // switch (operators)
        // {
        //     case '+':
        //         Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        //         break;
        //     case '-':
        //         Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        //         break;
        //     case '*':
        //         Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        //         break;
        //     case '/':
        //         Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        //         break;
        //     default:
        //         Console.WriteLine("Invalid number or operation");
        //         break;
        // }

        // //! loop
        // //? For loop
        // // for (int i = 1; i <= 100; i = i + 2)
        // // {
        // //     Console.Write($"{i} ");
        // // }
        // //? While loop
        // int i = 1;
        // // while(i < 100){
        // //     Console.Write($"{i} ");
        // //     i++;
        // // }

        // //? Do-While loop
        // do{
        //     Console.Write($"{i} ");
        //     i++;
        // } while(i < 100);

        // //? find out sum of the numbers between 1 to 10
        // int sum = 0;
        // for(int i = 1; i <= 10; i++){
        //     sum += i;
        // }
        // Console.WriteLine($"Sum of numbers between 1 to 10: {sum}");

        // //? find out sum of even numbers between 1 to 10
        // int sum = 0;
        // for(int i = 1; i <= 10; i++){
        //     if(i % 2 == 0){
        //         sum += i;
        //     }
        // }
        // Console.WriteLine($"Sum of even numbers between 1 to 10: {sum}");

        // //? find out sum of odd numbers between 1 to 10
        // int sum = 0;
        // for(int i = 1; i <= 10; i++){
        //     if(i % 2 != 0){
        //         sum += i;
        //     }
        // }
        // Console.WriteLine($"Sum of odd numbers between 1 to 10: {sum}");

        // //? find factorial of a number
        // int fact = 1;
        // Console.Write("Enter a number: ");
        // int num = Convert.ToInt32(Console.ReadLine());
        // for(int i = 1; i <= num; i++){
        //         fact *= i;
        // }
        // Console.WriteLine($"Factorial of ({num}): {fact}");

        //! nested loop
        int startNumber, endNumber;
        Console.Write("Enter start number: ");
        startNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter end number: ");
        endNumber = Convert.ToInt32(Console.ReadLine());

        for (int i = startNumber; i <= endNumber; i++)
        {
            Console.WriteLine($"Table of {i}");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} X {j} = {i * j}");
            }
            
        }

        








        Console.Read();
    }
}