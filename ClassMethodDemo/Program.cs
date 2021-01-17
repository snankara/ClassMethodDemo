using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Sinan";
            customer1.LastName = "KARA";
            customer1.Age = 22;
            customer1.Adress = "Istanbul - Maltepe";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Hande";
            customer2.LastName = "Sayek";
            customer2.Age = 30;
            customer2.Adress = "Istanbul - Kartal";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Mehmet";
            customer3.LastName = "Gencer";
            customer3.Age = 25;
            customer3.Adress = "Antalya - Merkez";

            Customer[] customers = { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.GetList(customers);
            customerManager.Update(customer1, customer1.Id);
            customerManager.Delete(customer2, customer2.Id);
        }
    }
}
