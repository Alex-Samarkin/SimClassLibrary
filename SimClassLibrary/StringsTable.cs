using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimClassLibrary
{
    public class StringsTable : TPrettyStrings, IPrettyString
    {
        public int Width1 { get; set; } = 1;
        public int Width2 { get; set; } = 1;

        public List<StringPair> Items { get; set; } = new List<StringPair>();

        public void Add(StringPair sp)
        {
            Items.Add(sp);
        }

        public void Add(string name, string value)
        {
            Items.Add(new StringPair() { Name = name, Value = value });
        }

        public string DelimString { get; set; } = " | ";

        public void UpdateW()
        {
            foreach (StringPair item in Items)
            {
                Width1 = (item.Name.Length > Width1) ? item.Name.Length : Width1;
                Width2 = (item.Value.Length > Width2) ? item.Value.Length : Width2;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (StringPair item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            return $"{nameof(Width1)}: {Width1}, {nameof(Width2)}: {Width2}, {nameof(DelimString)}: {DelimString}" +
                   Nl +
                   sb.ToString();

        }

        public virtual string ToPrettyString()
        {
            StringBuilder sb = new StringBuilder();
            UpdateW();
            Width = Width1 + Width2 + 6;
            sb.AppendLine(hr4);

            foreach (StringPair item in Items)
            {
                sb.AppendLine(" "
                              + item.Name + new string(' ', Width1 - item.Name.Length)
                              + DelimString
                              + item.Value
                              + new string(' ', Width2 - item.Value.Length)
                              + $" {DelimString[1]}");
            }

            sb.AppendLine(hr4);

            return sb.ToString();
        }
    }
}
