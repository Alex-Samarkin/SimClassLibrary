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


            TModel mdl = new TModel();
            
            Console.WriteLine(mdl);
            Console.WriteLine(mdl.ToPrettyString());

            Console.WriteLine(new TSimResult().ToPrettyString());

            Console.WriteLine(mdl.Timer.Result.ToPrettyString());
            mdl.Timer.RunFirst();
            Console.WriteLine(mdl.Timer.Result.ToPrettyString());
            mdl.Timer.Run();
            Console.WriteLine(mdl.Timer.Result.ToPrettyString());
            mdl.Timer.Run(100);
            Console.WriteLine(mdl.Timer.Result.ToPrettyString());

            Console.WriteLine(mdl.Info.ToPrettyString());
            mdl.RunFirst();
            Console.WriteLine(mdl.Result.ToPrettyString());
            mdl.Run();
            Console.WriteLine(mdl.Result.ToPrettyString());
            mdl.RunOnce();
            Console.WriteLine(mdl.Result.ToPrettyString());
            mdl.Run(1000);
            Console.WriteLine(mdl.Result.ToPrettyString());


            Console.ReadKey();


        }
    }
}
