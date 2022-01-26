using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimClassLibrary;

namespace ClassesTestConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Doc.MakeIntro();
            Console.WriteLine(Doc.Intro.ToString());
            TInfo ti = new TInfo()
            {
                Title = "Title",
                Description = "This is content, main part of",
                Comment = "Additional info",
                Author = "Author of"
            };
            Console.WriteLine(ti.ToString());
            Console.WriteLine(ti.ToPrettyString());

            StringsTable st = new StringsTable();
            st.Add(new StringPair(){Name = "Name1", Value = "Value1"});
            st.Add(new StringPair() { Name = "Name1", Value = "Value1" });
            st.Add(new StringPair() { Name = "Name1", Value = "Value1" });
            st.Add("Name100","Value100");

            Console.WriteLine(st.ToPrettyString());

            TModelTimer t = new TModelTimer();

            Console.WriteLine(t.ToPrettyString());

            for (int i = 0; i < 1500; i++)
            {
                t.Next();
                Console.WriteLine(t.ToPrettyString());
            }

            t.Reset();

            while (!t.IsStopped)
            {
                t.Next(10);
                Console.WriteLine(t.ToPrettyString());
            }


            Console.ReadKey();
        }
    }
}
