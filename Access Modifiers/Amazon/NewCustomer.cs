using System;

namespace Access_Modifiers.Amazon
{
    public  class NewCustomer
    {
        public int ID { get; set; }        
        public string Name { get; set; }        

        public void Promote()
        {
            var calculator = new RatingCalculator();
            var rating = calculator.Calculate(this);
            System.Console.WriteLine("Promote logic changed");
        }

    }
}
