using System;
using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        private DateTime Entry;
        public DateTime Expiry { get {return Entry.AddYears(2);}}

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
            Entry = DateTime.Now;
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
