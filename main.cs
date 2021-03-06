// Created by: Kaitlyn Ip
// Created on: Mar 2022
//
// This program finds your income and government taxes

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int HoursWorked;
        int HourlyRate;

        Console.WriteLine("This program finds the income of the user.");
        Console.WriteLine("");
        Console.Write("Enter number of hours worked: ");
        HoursWorked = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the amount of money earned per hour: ");
        HourlyRate = Convert.ToInt32(Console.ReadLine());
        Double income = HoursWorked * HourlyRate;
        Double taxes = 0.18 * (HoursWorked * HourlyRate);
        Console.WriteLine("");
        Console.Write("Income: " + "$" + income.ToString("0.00"));
        Console.WriteLine("");
        Console.Write("The Government will take: " + "$" + taxes.ToString("0.00"));
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}