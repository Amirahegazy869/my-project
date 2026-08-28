using GitTest;
using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace first_project_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //static void Main(string[] args)
            // {
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
            // ==================================================================

            // Console.Write("===peersonal info collector ===");
            // Console.Write("enter your name:");
            // var collectedName = Console.ReadLine();
            // Console.Write("enter your age:");
            //   var collectedAge = Console.ReadLine();
            // Console.Write("enter your favorite color:");
            // var collectedColor = Console.ReadLine();
            // Console.Write("are you a student? (yes/no)");
            // var isStudent = Console.ReadLine();
            // Console.WriteLine();
            // Console.WriteLine("=== collected information ===");
            // Console.WriteLine("Name: " + collectedName);
            // Console.WriteLine("Age: " + collectedAge);
            // Console.WriteLine("Favorite Color: " + collectedColor);
            // Console.WriteLine("Is Student: " + isStudent);

            // =====================================================================

            // Console.WriteLine("Receipt Printer......");
            // Console.WriteLine("=== Receipt ===");
            // const decimal ReceiptVatRate = 0.14m;
            // var item1 = 19.99m;
            // var item2 = 45.50m;
            // var item3 = 12.00m;

            // var subtotal = item1 + item2 + item3;
            // var vatAmount = subtotal * ReceiptVatRate;

            // var total = subtotal + vatAmount;

            // Console.WriteLine($"Item 1 : {item1:C}");
            // Console.WriteLine($"Item 2 : {item2:C}");
            // Console.WriteLine($"Item 3 : {item3:C}");
            // Console.WriteLine($"Subtotal : {subtotal:C}");
            // Console.WriteLine($"VAT (14%) : {vatAmount:C}");
            // Console.WriteLine($"Total : {total:C}");
            // Console.WriteLine("\nPress any key to exit...");
            // Console.ReadKey();

            //==================================================
            // operators 

            //  int x = 10;
            //  int y = 3;
            //  int sum = x + y; // addition
            // Console.WriteLine(sum); 
            // int difference = x - y; // subtraction
            // Console.WriteLine(difference);
            // int remainder = x % y; // modulus
            // Console.WriteLine(remainder);
            // int differenceRemainder = remainder % y;
            // Console.WriteLine(differenceRemainder);
            //  int total = sum + difference + remainder + differenceRemainder;
            //  Console.WriteLine(total);
            //  int product = x * y; // multiplication
            //  Console.WriteLine(product);
            //  float z = (float)x / (float)y; // division
            // Console.WriteLine(z);
            // int zint =x / y; // integer division
            //  Console.WriteLine(zint);

            //======================================================================
            //compound operators
            // int score = 15;
            //score += 5; //20
            // score -= 3;//17
            // score *= 3; //20
            //score++; //52
            // score--; //51
            //postfix prefix  
            // int x = score++; //postfix
            //int x =++score;//prefix
            //  Console.WriteLine(x);
            // Console.WriteLine(score);
            //=======================================================================================
            // operators
            //NewMethod();
            //==========================================================================
            // boxing and unboxing

            //int s = 25;
            //object intbox= s;
            //  int unboxedValue = (int)intbox;

            // ArrayList oldschool = new();

            //oldschool.Add(1);//boxing
            //oldschool.Add(2); //boxing
            //oldschool.Add(3); //boxing

            //int firstboxed = (int)oldschool[0];

            //Console.WriteLine(oldschool[0]);//unboxing

            //List<int> modernlist = new() { 1,2,3 };
            //modern.Add(1);//no boxing
            //Console.WriteLine(modernlist);
            //Console.WriteLine(modernlist[2]);


            //static List<wallet> allwallets = new List<wallet>
            //  {
            //    new wallet("amira", 1000)
            //            };
            // public class wallet
            //{
            //  public string ownerid;
            //public decimal balance;
            //public wallet(string ownerId, decimal balance)
            //{
            //  NewMethod1(ownerId);
            //balance = balance;
            //}

            //private void NewMethod1(string ownerId)
            //{
            //  ownerid = ownerId;
            //}

            //static wallet? findwallet(string ownerId)
            //{
            // foreach (var wallet in allwallets)
            //{
            //  if (wallet.ownerid == ownerId)
            //{
            //   return wallet;
            //}
            //}
            //return null;
            //  }
            //oop
            //  private static void NewMethod()
            //{
            //  int x = 30;
            //bool y = (x == 20);
            //Console.WriteLine(y);
            //bool z = (x >= 30);
            //Console.WriteLine(z);
            //if (x < 0 || x > 120)
            //{
            //  Console.WriteLine("invaild age");
            // }
            // else if (x < 30)
            //{
            //  Console.WriteLine("child");
            //}
            //else if (x < 18)
            //{
            //  Console.WriteLine("teen");

            //}
            //else
            //{
            //  Console.WriteLine("aduit");
            //}
            //}

            BankAcount sara = new BankAcount();
            sara.AccountNumber = 1001;
            sara.OwnerName = "sara ibrahim";
            sara.Balance = 1000.00m;


            BankAcount muhamed = new BankAcount();
            muhamed.AccountNumber = 1002;
            muhamed.OwnerName = "muhamed saeed";
            muhamed.Balance = 1500.00m;


            //BankAcount sameacount = sara;
            //sameacount.Balance = 2000.00m;

          Console.WriteLine($" {sara.AccountNumber} | {sara.OwnerName}| {sara.Balance:f2} EGP");
          Console.WriteLine($" {muhamed.AccountNumber} | {muhamed.OwnerName}| {muhamed.Balance:f2} EGP");


        }
    }
}
    

