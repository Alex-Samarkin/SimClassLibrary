using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimClassLibrary
{
    public static class Doc
    {
        public static TopicList Intro { get; set; } = new TopicList();
        public static TopicList MainList { get; set; } = new TopicList();
        public static TopicList EndList { get; set; } = new TopicList();

        public static void MakeIntro()
        {
            Intro.Theme = "Введение";
            Intro.Add(new Topic()
                {
                    Title = "Цель", 
                    Content = "Создание небольшой библиотеки для симуляции процессов", 
                    Author = "Жаров, Самаркин", 
                    Comment = "", 
                    DT = DateTime.Today
                }
                );
        }


    }
}
