using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        //Temel Operasyonlar - CRUD Operasyonları
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " - " + customer.Age + " - " + customer.Adress);
            Console.WriteLine("Added!");
        }

        public void Delete(Customer customer, int Id)
        {
            string message = customer.Id == Id ? customer.FirstName + " is deleted!" : "Exception!";
            Console.WriteLine(message);

        }

        public void Update(Customer customer, int Id)
        {
            string message = customer.Id == Id ? customer.FirstName + " is updated!" : "Exception!";
            Console.WriteLine(message);
        }

        public void GetList(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName + " - " + customer.Age + " - " + customer.Adress);
            }

            Console.WriteLine("Listed!");
        }
    }
}
