using System;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            char[] a = str.ToCharArray();
            
            Array.Sort(a);
           
            return new string(a);
        }
    }
}
