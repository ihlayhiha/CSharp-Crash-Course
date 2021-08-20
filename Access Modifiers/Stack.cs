using System;
using System.Collections.Generic;

namespace Access_Modifiers
{
    public class Stack
    {
        private List<object> List;
        public Stack()
        {
            List = new List<object>();
        }

        public void Push(object obj)
        {
            List.Add(obj);
        }

        public object Pop()
        {
            if (List.Count > 0)
            {
                var popObject = List[List.Count - 1];
                List.RemoveAt(List.Count - 1);
                return popObject;
            }
            else
                throw new Exception("This stack is already empty");
        }
        public void Clear()
        {
            List = new List<object>();
        }
    }
}