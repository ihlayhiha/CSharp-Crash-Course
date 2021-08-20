using System;
using Abstract_Modifiers.Challenge;

namespace Abstract_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // var shape = new Shape();
            // Cannot create instances from an abstract class

            var circle = new Circle();
            var rectangle = new Rectangle();
            circle.Draw();
            rectangle.Draw();
            circle.Copy();
            rectangle.Copy();
            System.Console.WriteLine();

            // DB connections

            var connection = new DBConnection("Trying out this connection");
            connection.Open();
            connection.Close();
            System.Console.WriteLine(connection.Timeout);

            var oracle = new OracleConnection("Connecting to Oracle servers");
            oracle.Open();
            System.Console.WriteLine(oracle.ConnectionString);
            oracle.Close();
            System.Console.WriteLine(oracle.Timeout);

        }
    }
}
