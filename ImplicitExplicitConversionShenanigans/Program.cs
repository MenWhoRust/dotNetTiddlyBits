using System;
using ImplicitExplicitConversionShenanigans.Models;

namespace ImplicitExplicitConversionShenanigans
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please look at the definitions of the following classes for how
            // to implement implicit/explicit conversions between objects and data types
            
            
            // You can define implicit and explicit conversions
            // between objects
            UserId id = Guid.NewGuid();
            Guid guid = (Guid)id;
            
            // Even though it is possible to do this
            // It is bad practice
            // A Domain Entity should not be responsible for conversions
            // between itself and its DTOs
            Product product = new Product();
            ProductDto productDto = product;

            Console.WriteLine("Hello World!");
        }
    }
}