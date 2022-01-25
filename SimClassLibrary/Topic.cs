using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimClassLibrary
{
    public class Topic
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
            string hr = new string('=', 120)+"\n";
            string hr1 = "\n"+new string('-', 120)+ "\n";
            return $"{hr}" +
                   $"{nameof(Title)}: {Title}" +hr1+
                   $"{nameof(Content)}: {Content}" +hr1+
                   $"{nameof(Comment)}: {Comment}" +hr1+
                   $"{nameof(Author)}: {Author}" +hr1+
                   $"{nameof(DT)}: {DT}"+"\n"+hr;
        }

    }

    public class TopicList
    {
        public string Theme { get; set; } = "Theme";
        public List<Topic> Topics { get; set; } = new List<Topic>();

        public void Add(Topic t)
        {
            Topics.Append(t);
        }
    }
}
