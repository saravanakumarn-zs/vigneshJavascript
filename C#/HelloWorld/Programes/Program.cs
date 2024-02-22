using Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // byte Number = 1; //Can replace by using VAR it wil actomatically consider the numbers
            // int count = 10;
            // float decimel = 20.15f;
            // char totalNumber = 's';
            // string firstName = "Shri";
            // Console.WriteLine(Number);
            // Console.WriteLine(count);
            // Console.WriteLine(decimel);
            // Console.WriteLine(totalNumber);

            //Console.WriteLine("{0} {1}", byte.MinValue,byte.MaxValue);
            // byte b = 1;
            //int C = b;
            //Console.WriteLine(C);
            // try
            // {
            // var number = 1234;
            // byte a = Convert.ToByte(number);
            // int a = 1;
            // Console.WriteLine(a);
            // }
            // catch (Exception)
            // {
            //Console.WriteLine("The number could not be converted");
            // }
            // byte a = 255;
            // byte b =Convert.ToByte(a + 5) ;
            // Console.WriteLine(b);
            //Person Shri = new Person();
            // Shri.FirstName = "Shri";
            // Shri.LastName = "Vignesh";
            //Shri.Introduce();

            //Caluculator Caluculator = new Caluculator();
            //var result = Caluculator.Add(2, 5);
            //Console.WriteLine(result);

            //var FirstName = "Shri";
            //var LastName = "Vignsh";

            //var FullName = FirstName +" "+ LastName;

            //var MyFullName = string.Format("My Name Is {0} {1}",FirstName,LastName);
            //Console.WriteLine(MyFullName);

            //var Names = new string[3] { "Shri", "Vignesh", "S S" };
            //var Formaterd = string.Join(", ",Names);
            //Console.WriteLine(Names[2]);

            // var Text = "Hi Shri\nLook in to the folder\nc:\\Folder1\\Folder";   We Can use like this or use @ for reduce this 
            //Console.WriteLine(Text);

            //var Text = @"Hi Shri                              We can use this for more readeable 
            //Look into this folder
            //c:Folder\Folder1";
            //Console.WriteLine(Text);

            //var Method = ShippingMethod.Male;
            //Console.WriteLine((int)Method); // use int for take the number 

            //var Id = 3;
            //Console.WriteLine((ShippingMethod)Id); // by using this we can have the variable by using the values
            //Console.WriteLine(Method.ToString());  //to convert to string

            //var a = 10;
            //var b = a;
            //b++;
            //Console.WriteLine(string.Format("a: {0}, b: {1}", a,b));

            //int n = 1;
            //    if (n <= 10)
            //  {
            //   Console.WriteLine("Valid Number Entred");
            //}
            //else
            // {
            //    Console.WriteLine("Invalid Number Entred");
            // }

            //string S = (n <= 10) ? "Valide number" : "Invalid Number";    //Terniry Operater
            //Console.WriteLine(S);

            //var datetime = new DateTime(2024, 02, 21);

            //Console.WriteLine(datetime);

            //var now = DateTime.Now;
            //Console.WriteLine(now);
           
            var Number = new List<int> { 1,2,3,4,5,6};
            var Number1 = new Getsmallest(Number,3);
        }
    }
}