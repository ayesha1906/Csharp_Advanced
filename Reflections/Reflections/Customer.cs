using System;

namespace Reflections
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;

        }
        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;

        }

        public void PrintId()
        {
            Console.WriteLine("Id : {0} ", Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name: {0}",  Name);
        }
    }
}
