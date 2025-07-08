using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Assigment2c_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //// Q1:Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("Pls Enter Number : ");
            //int Num = int.Parse(Console.ReadLine());
            //if (Num % 3 == 0 && Num % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region Q2
            //// Q2: Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("Pls Enter Number : ");
            //int Num = int.Parse(Console.ReadLine());
            //if (Num < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else 
            //    Console.WriteLine("Positive");
            #endregion

            #region Q3 
            ////Q3: Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.WriteLine("Pls Enter Three Numbers : ");
            //int Num1 = int.Parse(Console.ReadLine());
            //int Num2 = int.Parse(Console.ReadLine());
            //int Num3 = int.Parse(Console.ReadLine());
            //int MaxNum = Num1;
            //int MinNum = Num1;

            //if (Num2>MaxNum)
            //{
            //    MaxNum = Num2;
            //}
            //if (Num3 > MaxNum)
            //{
            //    MaxNum = Num3;
            //}

            //if (Num2 < MinNum)
            //{
            //    MinNum = Num2;
            //}

            //if (Num3 < MinNum)
            //{
            //    MinNum = Num3;
            //}

            //Console.WriteLine($"Max Number is : {MaxNum}");
            //Console.WriteLine($"Min Number is : {MinNum}");


            #endregion

            #region Q4
            ////Q4:Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("Pls Enter a Number : ");
            //int Num = int.Parse(Console.ReadLine());
            //if (Num % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");

            //}
            #endregion

            #region Q5
            ////Q5  Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.WriteLine("Pls Enter Char");
            //char C = char.Parse(Console.ReadLine());
            //switch(C)
            //{
            //    case 'a':
            //    case 'A':
            //        Console.WriteLine("vowel"); break;
            //    case 'E':
            //    case 'e':
            //        Console.WriteLine("vowel"); break;
            //    case 'I':
            //    case 'i':
            //        Console.WriteLine("vowel"); break;
            //    case 'o':
            //    case 'O':
            //        Console.WriteLine("vowel"); break;
            //    case 'u':
            //    case 'U':
            //        Console.WriteLine("vowel"); break;
            //    default:
            //        Console.WriteLine("consonant"); break; 
            //}
            #endregion

            #region Q6
            //// Q6 :Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Pls Enter Number");
            //int Num = int.Parse(Console.ReadLine());
            //for (int i=1; i <=Num;i++ )
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q7
            ////Q7 : Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("Pls Enter Number");
            //int Num = int.Parse(Console.ReadLine());
            //for (int i =1; i <=12; i++)
            //{
            //    Console.WriteLine($"{i}*{Num} = {i*Num}");
            //}
            #endregion

            #region Q8
            ////Q8 : Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("Pls Enter Number");
            //int Num = int.Parse(Console.ReadLine());
            //for (int i =1; i<=Num; i++) 
            //{
            //    if (i % 2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region Q9
            //// Q9 : Write a program that takes two integers then prints the power.
            //Console.WriteLine("Pls Enter Number");
            //int Num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Pls Enter Power");
            //int Power = int.Parse(Console.ReadLine());
            //int Result = 1;
            //for (int i = 1; i<= Power; i++)
            //{ 
            //    Result *= Num;
            //}
            //Console.WriteLine($"{Num}^{Power} = {Result}");
            #endregion

            #region Q10
            ////Q10 :Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Console.WriteLine("Pls Enter Marks of Five Subjects");
            //int[] Marks = new int[5];
            //int Total = 0;
            //Console.WriteLine("Enter Your Marks PLS");
            //for (int i = 0; i <5;i++)
            //{
            //    Console.WriteLine($"Pls Enter Marks of Subject {i+1} : ");
            //    Marks[i]=int.Parse(Console.ReadLine());
            //    Total+=Marks[i];
            //}

            //double Average = Total / 5.0;
            //double percentage = (Total / 500.0) * 100;

            //Console.WriteLine($"Total Marks = {Total}");
            //Console.WriteLine($"Average Marks = {Average}");
            //Console.WriteLine($"Percentage = {percentage} %");




            #endregion

            #region Q11
            ////Q11 : 11- Write a program to input the month number and print the number of days in that month.
            //Console.Write("Enter month number (1 to 12): ");
            //int month = int.Parse(Console.ReadLine());

            //int days;

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        days = 31;
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        days = 30;
            //        break;
            //    case 2:
            //        days = 28;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number!");
            //        return;
            //}

            //Console.WriteLine($"Number of days in month {month} = {days}");

            #endregion

            #region Q12
            //// 12- Write a program to create a Simple Calculator.
            //Console.WriteLine("Pls Enter two Num");
            //int Num1 = int.Parse(Console.ReadLine());
            //int Num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the operation");
            //char operation = char.Parse(Console.ReadLine());
            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine($"Result = {Num1 + Num2}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"Result = {Num1 - Num2}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"Result = {Num1 * Num2}");
            //        break;
            //    case '/':
            //        Console.WriteLine($"Result = {Num1 / Num2}");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operation");
            //        break;

            //}

            #endregion

            #region Q13  
            //// Q13: Write a program that takes a string from the user and prints it in reverse order.
            //Console.Write("Please enter a string: ");
            //string input = Console.ReadLine();

            //string reversed = "";

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversed += input[i];
            //}

            //Console.WriteLine($"Reversed string: {reversed}");
            #endregion

            #region Q14
            //// Q14: Write a program that takes a number from the user and prints the reversed number.
            //Console.WriteLine("Pls Enter a Number");
            //int Num = int.Parse(Console.ReadLine());
            //int reversed = 0;
           
            //while (Num > 0)
            //{
            //    int digit = Num % 10;
            //    reversed = reversed * 10 + digit;
            //    Num /= 10;
            //}
            //Console.WriteLine($"Reversed Number is : {reversed}");
            #endregion

        }
    }
}
