using System;

namespace Abstract_Modifiers.Challenge
{
    public class SQLConnection : DBConnection
    {
        // passing the right constructor values to initiate the base class first
        public SQLConnection(string connectionString)
            :base(connectionString)
        {
        }

        public override void Open()
        {
            base.Open();
            System.Console.WriteLine("Connected to SQ servers with connection : " + this.ConnectionString);
        }
    }
}