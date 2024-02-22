using System;

namespace Classes
{
    public enum ShippingMethod
    {
        Male = 1,
        Female = 2,
        Express = 3
    }
    public class Person
    {
        public string FirstName;
        public string LastName;
        public void Introduce()
        {
            Console.WriteLine("My Name Is " + FirstName + " " + LastName);
        }
    }
    public class Caluculator
    {
        public int Add(int A, int B)
        {
            return A + B;
        }
    }
}
