using System;

namespace Indexers
{
    public class StopWatch
    {
        public DateTime Begin;
        public DateTime End;

        public void Start()
        {
            Begin = DateTime.Now;
        }
        public TimeSpan Stop()
        {   
            if (Begin == DateTime.MinValue)
                throw new InvalidOperationException("You can't stop the StopWatch before starting it.");
            End = DateTime.Now;
            Begin = DateTime.MinValue;
            return End - Begin;
        }
    }
}
