using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimClassLibrary
{
    public class TModelTimer : IPrettyString, IRunable
    {
        public double Start { get; set; } = 0;
        public double Stop { get; set; } = 100;

        public bool IsStopped { get; set; } = false;

        public double Step { get; set; } = 0.001;
        public int StepNumber { get; set; } = 0;

        public double CurrentTime => Start + (double)StepNumber * Step;

        public TSimResult Result { get; set; } = new TSimResult()
            { Title = "Timer", Message = "Model time at current step" };

        public double Next(int step = 1)
        {
            if (!IsStopped)
            {
                StepNumber += step;
                if (CurrentTime > Stop) IsStopped = true;
            }
            return CurrentTime;
        }

        public void Reset()
        {
            StepNumber = 0;
            IsStopped = false;
        }

        public void Setup(double newStart = 0, double newStop = 100, double newStep = 0.001)
        {
            Start = newStart;
            Stop = newStop;
            Step = newStep;
            Reset();
        }

        private readonly StringsTable _table = new StringsTable();

        public override string ToString()
        {
            return $"{nameof(Start)}: {Start}, {nameof(Stop)}: {Stop}, {nameof(IsStopped)}: {IsStopped}, {nameof(Step)}: {Step}, {nameof(StepNumber)}: {StepNumber}, {nameof(CurrentTime)}: {CurrentTime}";
        }

        public string ToPrettyString()
        {
            _table.Items.Clear();

            _table.Add("Timer","");
            _table.Add(nameof(Start), Start.ToString());
            _table.Add(nameof(Stop),Stop.ToString());
            _table.Add(nameof(Step), Step.ToString());
            _table.Add(nameof(StepNumber), StepNumber.ToString());
            _table.Add(nameof(CurrentTime), CurrentTime.ToString());

            return _table.ToPrettyString();
        }

        public void Run(int N=1)
        {
            Next(N);
            Result.ResultDouble = CurrentTime;
            Result.ResultInt = StepNumber;
            Result.Result = !IsStopped;
        }

        public void RunOnce()
        {
            Run(1);
        }

        public void RunFirst()
        {
            Reset();
            Run(1);
        }
    }
}
