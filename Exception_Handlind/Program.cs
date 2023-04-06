using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Exception_Handlind
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exception Handling Practice Problem!");
            ValidateAge validate = new ValidateAge();
            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            string Check = ValidateAge.CheckCategory( age);
            Console.WriteLine($"Agr:{age} \t Category: {Check} ");


        }
    }
    
}
