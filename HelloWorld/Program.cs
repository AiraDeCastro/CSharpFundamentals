﻿using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Aira";
            var lastName = "de Castro";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1} ", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Jill"};
            var formattedNames = string.Join(", ", names);

            var text = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
