using System;

namespace anotherValue_Ref
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            // number remains the same because the type of the parameter needed for this method is a value type
            // the number we see in this scope  doesn't exist beyond this scope
            // So, when we call the Increment method with this parameter, a copy of this value is created and sent to Increment method.
            // the copy and the original number have the same name but they're in different locations in stack memory because they're value types.
            // One of them is the number with the scope of Main() method, so outside the Main() method, this number does not have a meaning
            // And outside the Main() method, we have another number, coincidentally with the same name, but that's a different place in memory and its -
            // - scope is limited to Increment method
            // So, when this Increment method gets called, a new value is created, increased by 10 and then immediately destroyed
            // Basically, when you're calling the method from some other scope, the method makes copies of the values u provided and runs the method.

            var randNumber = 10;
            Increment(randNumber);

            Console.WriteLine(number);
            Console.WriteLine(randNumber);



            var person = new Person(){Age = 20}; 
            makeOld(person);

            // here, the Age changes because the type of the parameter needed for this method is a reference type
            // When a new copy is created, the copy is basically a  reference to it's hex value
            // So, when u change something  with that reference, the original stored value in the heap memory also changes, because this is a reference type
            // When I call the method makeOld() using 'person', it creates a copy of the hex value of the  person object from Person 'class
            // The copy still points to the original person object from the Person class and so if you call the method, the Age() field value changes

            Console.WriteLine(person.Age);

        }
        // The copy still points to the original person object from the Person class and so if you call the method, the Age() field value changes
        // adding 2 more methods Increment and makeOld in the program class
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void makeOld(Person person)
        {
            person.Age += 10;
        }

    }
}
