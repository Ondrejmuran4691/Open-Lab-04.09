using System;
using System.Collections.Generic;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            var done = new List<string> {};
            foreach (string s in strings)
            {
                if (done.Contains(s))
                {
                }
                else
                {
                    done.Add(s);
                }
            }
            return done.ToArray();


        }
    }
}
