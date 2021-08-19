using System;

namespace Access_Modifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating > 10)
                System.Console.WriteLine("Offered a brand new voucher for this customer");
        }
    }
}