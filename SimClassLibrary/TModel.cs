using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimClassLibrary
{
    public class TModel : IPrettyString, IRunable
    {
        public TInfo Info { get; set; } = new TInfo()
        {
            Author = "Input author",
            Title = "Name of model",
            Description = "Description. For long text use @string",
            Comment = "Something about"
        };

        public TModelTimer Timer { get; set; } = new TModelTimer();

        public TSimResult Result { get; set; } = new TSimResult()
            { Title = "Model Title", Message = "Model time typically" };

        #region Implementation of IPrettyString

        public override string ToString()
        {
            return $"{nameof(Info)}: {Info}, {nameof(Timer)}: {Timer}";
        }

        public string ToPrettyString()
        {
            return Info.ToPrettyString() + Environment.NewLine + Timer.ToPrettyString();
        }

        public void Run(int N = 1)
        {
            Timer.Run(N);
            /// результат через результат таймера
            Result.Result = Timer.Result.Result;
            Result.ResultDouble = Timer.Result.ResultDouble;
            /// результат через параметр таймера - число шагов
            Result.ResultInt = Timer.StepNumber;
        }

        public void RunOnce()
        {
            Run();
        }

        public void RunFirst()
        {
            Timer.RunFirst();
            /// результат через результат таймера
            Result.Result = Timer.Result.Result;
            Result.ResultDouble = Timer.Result.ResultDouble;
            /// результат через параметр таймера - число шагов
            Result.ResultInt = Timer.StepNumber;
        }

        #endregion
    }
}
