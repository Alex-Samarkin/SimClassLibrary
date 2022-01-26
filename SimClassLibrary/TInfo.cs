using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimClassLibrary
{
    public class TInfo : IPrettyString
    {
        private readonly TPrettyStrings _prettyStrings = new TPrettyStrings();
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Comment { get; set; } = String.Empty;
        public string Author { get; set; } = String.Empty;
        public DateTime Date { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return $"{nameof(Title)}: {Title} " +
                   $"{nameof(Description)}: {Description} " +
                   $"{nameof(Comment)}: {Comment} " +
                   $"{nameof(Author)}: {Author} " +
                   $"{nameof(Date)}: {Date}";
        }
        public string ToPrettyString()
        {
            return _prettyStrings.hr4+ _prettyStrings.Nl+
                   _prettyStrings.JustifyCenter(Title) +
                   _prettyStrings.Nl + _prettyStrings.hr1 + _prettyStrings.Nl +
                   $"{nameof(Description)}: {Description}, "+ _prettyStrings.Nl + _prettyStrings.hr1 + _prettyStrings.Nl +
                   $"{nameof(Comment)}: {Comment}, "+ _prettyStrings.Nl + _prettyStrings.hr1 + _prettyStrings.Nl + _prettyStrings.JustifyRight(Author) + _prettyStrings.Nl+ _prettyStrings.JustifyRight(Date.ToString())+ _prettyStrings.Nl+ _prettyStrings.Nl+ _prettyStrings.hr4;
        }

    }
}
