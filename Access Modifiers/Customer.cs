using System;

namespace Access_Modifiers
{
    public class Customer
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders : true);
            if (rating > 5)
                System.Console.WriteLine("Promoted to next level");
            else
                System.Console.WriteLine("U are not promoted");
        }
        protected int CalculateRating(bool excludeOrders)
        {
            return 10;
        }
    }
}
