using System;
using System.Diagnostics.CodeAnalysis;

namespace first_project_csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello, World!");
            // Console.WriteLine("This is a simple C# program.");
            // Console.ReadKey();
            //int age = 23;
            // string name = "amira";
            // bool isStudent = true;
            // char grade = 'A';
            // var height = 'a';

            // double weight = 60.5;
            // int weightint = (int)weight;
            // Console.WriteLine(age);
            // Console.WriteLine(name);
            // Console.WriteLine(isStudent);
            // const double pi = 3.14159;
            // pi++; // This line will cause a compile-time error because pi is a constant and cannot be modified.

            // Console.WriteLine(pi);
            // Console.WriteLine("what is your name ?");
            // var userName = Console.ReadLine();
            //Console.WriteLine("Hello, " + userName + "!");


            Console.Write("===peersonal info collector ===");
            Console.Write("enter your name:");
            var collectedName = Console.ReadLine();
            Console.Write("enter your age:");
            var collectedAge = Console.ReadLine();
            Console.Write("enter your favorite color:");
            var collectedColor = Console.ReadLine();
            Console.Write("are you a student? (yes/no)");
            var isStudent = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("=== collected information ===");
            Console.WriteLine("Name: " + collectedName);
            Console.WriteLine("Age: " + collectedAge);
            Console.WriteLine("Favorite Color: " + collectedColor);
            Console.WriteLine("Is Student: " + isStudent);

            Console.WriteLine("Receipt Printer......");

            Console.WriteLine("=== Receipt ===");
            const decimal ReceiptVatRate = 0.14m;
            var item1 = 19.99m;
            var item2 = 45.50m;
            var item3 = 12.00m;

            var subtotal = item1 + item2 + item3;
            var vatAmount = subtotal * ReceiptVatRate;

            var total = subtotal + vatAmount;

            Console.WriteLine($"Item 1 : {item1:C}");
            Console.WriteLine($"Item 2 : {item2:C}");
            Console.WriteLine($"Item 3 : {item3:C}");
            Console.WriteLine($"Subtotal : {subtotal:C}");
            Console.WriteLine($"VAT (14%) : {vatAmount:C}");
            Console.WriteLine($"Total : {total:C}");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            //=============================================






        }
    }
}

