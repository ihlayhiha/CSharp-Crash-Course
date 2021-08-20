using System;

namespace Abstract_Modifiers.Challenge
{
    public class OracleConnection : DBConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
        }

        public override void Open()
        {
            base.Open();
            System.Console.WriteLine("Connected to Oracle servers");
        }

    }
}