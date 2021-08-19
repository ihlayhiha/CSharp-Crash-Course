using System;
using System.Collections.Generic;

namespace Classes__Fields__Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, new DateTime(1995, 11, 22));

            customer.Name = "Ravi Teja Yella";
            System.Console.WriteLine("Customer {0}'s Age: {1}",customer.Name, customer.Age);

            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            System.Console.WriteLine(customer.Orders.Count);

            // customer.Orders = new List<Order>();    does not work because we defined the field to be readonly
            customer.Promote();
            System.Console.WriteLine(customer.Orders.Count);


            // random check
            var randArray = new int[3]{1,2 ,3};
            var randList = new List<int>(){1,2,3};
            randList.Add(4);
            System.Console.WriteLine(randList.Count);

        }
    }
}
