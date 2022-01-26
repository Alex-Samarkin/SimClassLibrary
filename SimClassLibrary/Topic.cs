using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimClassLibrary
{
    public class Topic : IPrettyString
    {
        public string Title { get; set; } = "Заголовок раздела";
        public string Content { get; set; } = "Содержание раздела";
        public string Comment { get; set; } = "Комментарий";
        public string Author { get; set; } = "Автор";
        public DateTime DT { get; set; } = DateTime.Today;

        public void Setup(string title, string content, string comment, string author, DateTime dt)
        {
            Title = title;
            Content = content;
            Comment = comment;
            Author = author;
            DT = dt;
        }

        public override string ToString()
        {
            return $"{nameof(Title)}: {Title}, {nameof(Content)}: {Content}, {nameof(Comment)}: {Comment}, {nameof(Author)}: {Author}, {nameof(DT)}: {DT}";
        }
        public string ToPrettyString()
        {
            string nl = Environment.NewLine;
            string hr = new string('=', 120)+nl;
            string hr1 = nl+new string('-', 120)+nl;
            return $"{hr}" +
                   $"{nameof(Title)}: {Title}" +hr1+
                   $"{nameof(Content)}: {Content}" +hr1+
                   $"{nameof(Comment)}: {Comment}" +hr1+
                   $"{nameof(Author)}: {Author}" +hr1+
                   $"{nameof(DT)}: {DT}"+nl+hr;
        }

    }

    public class TopicList : IPrettyString
    {
        public string Theme { get; set; } = "Theme";
        public List<Topic> Topics { get; set; } = new List<Topic>();

        public void Add(Topic t)
        {
            Topics.Add(t);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Theme);
            foreach (Topic topic in Topics)
            {
                sb.AppendLine(topic.ToPrettyString());
            }
            return sb.ToString(); 
        }

        #region Implementation of IPrettyString

        public string ToPrettyString()
        {
            return ToString();
        }

        #endregion
    }
}
