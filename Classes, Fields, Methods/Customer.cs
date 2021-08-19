using System;
using System.Collections.Generic;

namespace Classes__Fields__Methods
{
    public class Customer
    {
        private int _id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();
        public DateTime Birthday { get; private set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - Birthday;
                int years = timeSpan.Days/ 365;
                return years;
            }
        }

        public Customer(int id, DateTime birthday)
        {
            _id = id;
            Birthday = birthday;
        }
        
        public Customer(int id, DateTime birthday, string name)
            :this(id, birthday)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // .. This method will promote the customer to gold customer
            
        }
    }
}
