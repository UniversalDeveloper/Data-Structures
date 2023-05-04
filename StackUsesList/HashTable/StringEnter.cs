using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class StringEnter
    { public string EnterStr { get; set; }
                
        public override string ToString()
        {
            return EnterStr;
        }
        public override int GetHashCode()
        {
            int g = 31;
            int hash = 0;
            for (int i = 0; i < EnterStr.Length; i++)
            {
                int u = (int)EnterStr[i];
                char u1 = EnterStr[i];
                var u2= Char.ConvertToUtf32(EnterStr, i);
                hash = g * hash + Char.ConvertToUtf32(EnterStr, i);
            }
                return hash;
        }
       
    }
}
