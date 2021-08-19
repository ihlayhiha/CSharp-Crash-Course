using System.Collections.Generic;

namespace Classes__Fields__Methods
{
    public class CustomerAnotherWay
    {
        public int ID;
        public string Name;
        public List<Order> Orders;

        public CustomerAnotherWay()
        {
            this.Orders = new List<Order>();
        }

        public CustomerAnotherWay(int id)
            :this()
        {
            this.ID = id;
        }
        public CustomerAnotherWay(int id, string name)
            :this(id)
        {
            this.Name = name;
        }




    }
}
