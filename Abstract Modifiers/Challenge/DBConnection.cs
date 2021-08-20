using System;

namespace Abstract_Modifiers.Challenge
{
    public class DBConnection
    {
        private string _connectionString;
        private DateTime _open;
        private DateTime _close;
        public string ConnectionString { get{ return _connectionString;} }
        public TimeSpan Timeout 
        { 
            get 
            {   
                if (_open == DateTime.MinValue || _close == DateTime.MinValue)
                {
                    throw new Exception("Timeout cannot be written without establishing and closing a network");
                }
                var timeSpan = _close - _open;
                _open = DateTime.MinValue;
                return timeSpan;
            } 
        }

        public DBConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Invalid parameter value. Connection string cannot be an empty string.");
            _connectionString = connectionString; 
        }

        public virtual void Open()
        {
            if (_open != DateTime.MinValue)
            {
                System.Console.WriteLine("Connection already opened");
                return;
            }
            _open = DateTime.Now;
        }

        public virtual void Close()
        {   
            if (_open == DateTime.MinValue)
            {
                System.Console.WriteLine("Connection hasn't been opened yet");
                return;
            }
            _close = DateTime.Now;
            System.Console.WriteLine("Connection closed to this server.");
        }

    }
}