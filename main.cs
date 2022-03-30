// Created by: Ava Venturino
// Created on: March 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int radius;

        Console.WriteLine("This program finds the circumference of a circle using radius.");
        Console.WriteLine("");
        Console.Write("Enter the radius of the circle (cm): ");
        radius = Convert.ToInt32(Console.ReadLine());

        Double circumference = 2 * (3.1415926 * radius);

        Console.WriteLine("");
        Console.Write("The circumference of the circle = " + circumference.ToString("0.00")); + " cm²");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}