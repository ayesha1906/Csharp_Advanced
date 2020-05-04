using System;
using System.Reflection;

namespace Reflections
{

    class Program
    {

        static void Main(string[] args)
        {
            // Type T = Type.GetType("Reflections.Customer");

            // Type T = typeof(Customer);

            //We can use this or any of the above commented ways

            Customer c1 = new Customer();
            Type T = c1.GetType();


            Console.WriteLine("Full Name : {0}", T.FullName);
            Console.WriteLine("Just the Name : {0}", T.Name);
            Console.WriteLine("Just the Namespace : {0}", T.Namespace);

            Console.WriteLine();
            Console.WriteLine("About Properties in Customers:");
            var properties = T.GetProperties(); //here var is of type PropertyInfo[]
            foreach(var property in properties)
                Console.WriteLine(property.PropertyType.Name+ " "+property.Name);

            Console.WriteLine();
            Console.WriteLine("About Methods in Customers:");
            var methods = T.GetMethods(); //here var is of type MethodInfo[]
            foreach (var method in methods)
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);

            Console.WriteLine();
            Console.WriteLine("About Constructors in Customers:");
            var constructors = T.GetConstructors(); //here var is of type ConstructorInfo[]
            foreach (var constructor in constructors)
            {
                Console.WriteLine(constructor.Name);
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
