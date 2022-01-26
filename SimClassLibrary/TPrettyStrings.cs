// SimClassLibrary
// SimClassLibrary
// TPrettyStrings.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 1:46 26 01 2022

using System;

namespace SimClassLibrary
{
    public class TPrettyStrings
    {
        public int Width { get; set; } = 100;
        public string FillSymbols => " .-_=*+><";
        public string hr0 => FillString(0); // "  "
        public string hr1 => FillString(1); // "..."
        public string hr2 => FillString(2); // "---"
        public string hr3 => FillString(3); // "___"
        public string hr4 => FillString(4); // "==="
        public string hr5 => FillString(5); // "***"
        public string hr6 => FillString(6); // "+++"
        public string hr7 => FillString(7); // ">>>"
        public string hr8 => FillString(8); // "<<<"
        public string Nl => Environment.NewLine;
        public string FillString(int i = 5) => new string(FillSymbols[i], Width);

        public string JustifyLeft(string value, int symbolIndex = 3) =>
            value+" "+ new string(FillSymbols[symbolIndex], Width - value.Length-1);

        public string JustifyRight(string value, int symbolIndex = 3) =>
            new string(FillSymbols[symbolIndex], Width - value.Length-1)+" " + value;

        public string JustifyCenter(string value, int symbolIndex = 3)
        {
            int w1 = Width - value.Length;
            int odd = w1 % 2;
            w1 = (int)(w1 / 2);
            string filled = new string(FillSymbols[symbolIndex], w1);
            string filled1 = new string(FillSymbols[symbolIndex], w1-odd);

            return filled + " " + value + " " + filled1;
        }

    }
}