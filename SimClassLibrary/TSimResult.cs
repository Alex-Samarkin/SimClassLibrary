using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimClassLibrary
{
    public class TSimResult : IPrettyString
    {
        public string Title { get; set; } = "Result";
        /// <summary>
        /// потенциальный результат (true - OK, false - Error)
        /// </summary>
        public bool Result { get; set; } = true;

        /// <summary>
        /// потенциальный результат
        /// </summary>
        public double ResultDouble { get; set; } = 0;
        public double ResultInt { get; set; } = 0;

        /// <summary>
        /// сообщение о результате
        /// </summary>
        public string Message { get; set; } = "Ok";

        public override string ToString()
        {
            return $"{nameof(Result)}: {Result}, Result values: {ResultDouble}, {ResultInt}, {nameof(Message)}: {Message}";
        }

        public string ToPrettyString()
        {
            StringsTable st = new StringsTable();
            st.Add(Title,"");
            st.Add("Bool result",Result.ToString());
            st.Add("Numeric result", $"{ResultInt} / {ResultDouble} ");
            st.Add("Text",Message);
            return st.ToPrettyString();
        }
    }
}
