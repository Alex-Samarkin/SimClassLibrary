// SimClassLibrary
// SimClassLibrary
// StringPair.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 1:44 26 01 2022

using System.Collections.Generic;
using System.Text;

namespace SimClassLibrary
{
    public class StringPair 
    {
        public string Name { get; set; } = "";
        public string Value { get; set; } = "";

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Value)}: {Value}";
        }
    }
}